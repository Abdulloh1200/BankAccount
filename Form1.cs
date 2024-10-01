using Microsoft.VisualBasic;
using Npgsql;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Security.Principal;
using System.Xml.Linq;

namespace BankAccount
{
    public partial class Form1 : Form
    {
        public string ConnectionString =
        "Host=localhost;Username=postgres;Port=5432;Database=class;Password=1200;";
        private NpgsqlConnection connection;
        private NpgsqlDataAdapter sqlDataAdapter;

        public Form1()
        {
            InitializeComponent();
        }
        private DataTable GetData(string name)
        {
            DataTable dt = new DataTable();
            using (connection = new NpgsqlConnection(ConnectionString))
            {
                sqlDataAdapter = new NpgsqlDataAdapter(name, ConnectionString);
                sqlDataAdapter.Fill(dt);
                return dt;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetData("Select CL.Name,PINFL,C.CardNumber,CT.card_tip as Card_Tip,A.Number,A.Type from Client CL Join Card C on CL.Id = C.clientid JOIN Account A on C.clientid = A.Card_Id JOIN CardType CT on CT.id = C.Card_type where CL.deleted = false order by name");
            dataGridView6.DataSource = GetData("Select CL.Name,PINFL,C.CardNumber,CT.card_tip as Card_Tip,A.Number,A.Type from Client CL Join Card C on CL.Id = C.clientid JOIN Account A on C.clientid = A.Card_Id JOIN CardType CT on CT.id = C.Card_type where CL.deleted = false order by name ");
            dataGridView2.DataSource = GetData("Select CL.Name,A.Number,A.Type,C.CardNumber,CT.card_tip,PINFL from Client CL Join Card C on CL.Id = C.clientid JOIN Account A on C.clientid = A.Card_Id JOIN CardType CT on CT.id = C.Card_type where CL.deleted = false order by name;");
            dataGridView3.DataSource = GetData("select c.id,c.Name,c.PinFl from  client c where c.deleted = false");
            dataGridView4.DataSource = GetData("select C2.id,C2.Name,c.CardNumber from Account a right join Card c on c.clientid = a.Card_Id join Client C2 on c.ClientId = C2.Id where a.number is null and C2.deleted = false order by C2.id;");
            dataGridView7.DataSource = GetData("Select CL.Name,PINFL,C.CardNumber,CT.card_tip as Card_Tip,A.Number,A.Type from Client CL Join Card C on CL.Id = C.clientid JOIN Account A on C.clientid = A.Card_Id JOIN CardType CT on CT.id = C.Card_type where CL.deleted = true");
            dataGridView5.DataSource = GetData("select C.id,C.Name,c.PinFl   from Client C left join Card C2 on C.Id = C2.ClientId left join cardtype cr on C2.Card_type = cr.id where cr.card_tip is null and C.deleted = false order by C.id;");
            AddClient();
            AddClinentCBItem();
            AddCardType();
            AddClientCard();
            DeleteData();
            ReverseData();
        }
        void ReverseData()
        {
            DataTable dataTable = GetData("select c.id,concat(c.name,'-',c.pinfl) as name from client c where c.deleted = true;");
            Reverse.DisplayMember = "name";
            Reverse.ValueMember = "id";
            Reverse.DataSource = dataTable;
            Reverse.SelectedIndex = -1;
        }
        void AddClinentCBItem()
        {
            DataTable UpClient = GetData("Select A.id ,concat(CL.Name,'-',CT.card_tip) as name from Client CL Join Card C on CL.Id = C.clientid JOIN Account A on C.clientid = A.Card_Id JOIN CardType CT on CT.id = C.Card_type where CL.deleted = false order by name");
            CbUpdateName.DisplayMember = "name";
            CbUpdateName.ValueMember = "id";
            CbUpdateName.DataSource = UpClient;
            CbUpdateName.SelectedIndex = -1;
        }
        void AddCardType()
        {
            DataTable CardType = GetData("select c.id,c.card_tip as name from cardtype c");
            idTextboxType.DisplayMember = "name";
            idTextboxType.ValueMember = "id";
            idTextboxType.DataSource = CardType;
            idTextboxType.SelectedIndex = -1;
        }
        void AddClient()
        {
            DataTable Account = GetData("select C2.id,concat(C2.Name,'-',cr.card_tip) as name from Account a right join Card c on c.clientid = a.Card_Id join Client C2 on c.ClientId = C2.Id join cardtype cr on cr.id = c.card_type  where a.number is null and C2.deleted = false order by C2.id;");
            IdAccCr.DisplayMember = "name";
            IdAccCr.ValueMember = "c.id";
            IdAccCr.DataSource = Account;
            IdAccCr.SelectedIndex = -1;
        }
        void AddClientCard()
        {
            DataTable Card = GetData("select C.id,concat(C.Name,'-',c.PinFl) as name   from Client C left join Card C2 on C.Id = C2.ClientId left join cardtype cr on C2.Card_type = cr.id where cr.card_tip is null and C.deleted = false;");
            textBox2.DisplayMember = "name";
            textBox2.ValueMember = "id";
            textBox2.DataSource = Card;
            textBox2.SelectedIndex = -1;

        }
        void DeleteData()
        {
            DataTable Delete1 = GetData("select c.id,concat(c.name,'-',c.pinfl) as name from client c where c.deleted = false order by name;");
            Delete.DisplayMember = "name";
            Delete.ValueMember = "id";
            Delete.DataSource = Delete1;
            Delete.SelectedIndex = -1;

        }
        private void DDelete_Click_1(object sender, EventArgs e)
        {
            if (Delete.SelectedIndex != -1)
            {
                var id = Delete.SelectedValue;
                DialogResult DeleteResult = MessageBox.Show($"Do you want to delete : {Delete.SelectedIndex}", "Close window", MessageBoxButtons.YesNo);
                if (DeleteResult == DialogResult.Yes)
                {
                    GetData($"Update client set deleted = true where id = {Delete.SelectedValue}");
                    Delete.SelectedIndex = -1;
                    dataGridView1.DataSource = GetData("Select CL.Name,PINFL,C.CardNumber,CT.card_tip as Card_Tip,A.Number,A.Type from Client CL Join Card C on CL.Id = C.clientid JOIN Account A on C.clientid = A.Card_Id JOIN CardType CT on CT.id = C.Card_type where CL.deleted = false order by name");
                    dataGridView6.DataSource = GetData("Select CL.Name,PINFL,C.CardNumber,CT.card_tip as Card_Tip,A.Number,A.Type from Client CL Join Card C on CL.Id = C.clientid JOIN Account A on C.clientid = A.Card_Id JOIN CardType CT on CT.id = C.Card_type where CL.deleted = false order by name ");
                    dataGridView2.DataSource = GetData("Select CL.Name,A.Number,A.Type,C.CardNumber,CT.card_tip,PINFL from Client CL Join Card C on CL.Id = C.clientid JOIN Account A on C.clientid = A.Card_Id JOIN CardType CT on CT.id = C.Card_type where CL.deleted = false order by name;");
                    dataGridView3.DataSource = GetData("select c.id,c.Name,c.PinFl from  client c where c.deleted = false");
                    dataGridView4.DataSource = GetData("select C2.id,C2.Name,c.CardNumber from Account a right join Card c on c.clientid = a.Card_Id join Client C2 on c.ClientId = C2.Id where a.number is null and C2.deleted = false order by C2.id;");
                    dataGridView7.DataSource = GetData("Select CL.Name,PINFL,C.CardNumber,CT.card_tip as Card_Tip,A.Number,A.Type from Client CL Join Card C on CL.Id = C.clientid JOIN Account A on C.clientid = A.Card_Id JOIN CardType CT on CT.id = C.Card_type where CL.deleted = true");
                    dataGridView5.DataSource = GetData("select C.id,C.Name,c.PinFl   from Client C left join Card C2 on C.Id = C2.ClientId left join cardtype cr on C2.Card_type = cr.id where cr.card_tip is null and C.deleted = false order by C.id;");
                    AddClient();
                    AddClinentCBItem();
                    AddCardType();
                    AddClientCard();
                    DeleteData();
                    ReverseData();
                    MessageBox.Show("Malumot ochirildi", "Close window", MessageBoxButtons.OK);
                }
                else if (DeleteResult == DialogResult.No)
                {
                    Delete.SelectedIndex = -1;
                    return;
                }

            }
        } 
        private void ReverseSubmit_Click(object sender, EventArgs e)
        {
            if(Reverse.SelectedIndex != -1)
            {
              DialogResult res = MessageBox.Show("Malumotni qaytarmoqchimisiz?", "Close window", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    GetData($"Update client set deleted = false where id = {Reverse.SelectedValue}");
                    Reverse.SelectedIndex = -1;
                dataGridView1.DataSource = GetData("Select CL.Name,PINFL,C.CardNumber,CT.card_tip as Card_Tip,A.Number,A.Type from Client CL Join Card C on CL.Id = C.clientid JOIN Account A on C.clientid = A.Card_Id JOIN CardType CT on CT.id = C.Card_type where CL.deleted = false order by name");
                dataGridView6.DataSource = GetData("Select CL.Name,PINFL,C.CardNumber,CT.card_tip as Card_Tip,A.Number,A.Type from Client CL Join Card C on CL.Id = C.clientid JOIN Account A on C.clientid = A.Card_Id JOIN CardType CT on CT.id = C.Card_type where CL.deleted = false order by name ");
                dataGridView2.DataSource = GetData("Select CL.Name,A.Number,A.Type,C.CardNumber,CT.card_tip,PINFL from Client CL Join Card C on CL.Id = C.clientid JOIN Account A on C.clientid = A.Card_Id JOIN CardType CT on CT.id = C.Card_type where CL.deleted = false order by name;");
                dataGridView3.DataSource = GetData("select c.id,c.Name,c.PinFl from  client c where c.deleted = false");
                dataGridView4.DataSource = GetData("select C2.id,C2.Name,c.CardNumber from Account a right join Card c on c.clientid = a.Card_Id join Client C2 on c.ClientId = C2.Id where a.number is null and C2.deleted = false order by C2.id;");
                dataGridView7.DataSource = GetData("Select CL.Name,PINFL,C.CardNumber,CT.card_tip as Card_Tip,A.Number,A.Type from Client CL Join Card C on CL.Id = C.clientid JOIN Account A on C.clientid = A.Card_Id JOIN CardType CT on CT.id = C.Card_type where CL.deleted = true");
                dataGridView5.DataSource = GetData("select C.id,C.Name,c.PinFl   from Client C left join Card C2 on C.Id = C2.ClientId left join cardtype cr on C2.Card_type = cr.id where cr.card_tip is null and C.deleted = false order by C.id;");
                AddClient();
                AddClinentCBItem();
                AddCardType();
                AddClientCard();
                DeleteData();
                ReverseData();
                MessageBox.Show("Malumotlar qaytarildi" , "Close window" , MessageBoxButtons.OK);
                }
                else if (res == DialogResult.No)
                {
                    Reverse.SelectedIndex = -1;
                    return;
                }
            }    
        }
        private void submit_Click(object sender, EventArgs e)
        {
            if (NameCreate.Text != "" && PinInsert.Text != "")
            {
                if (dataGridView3.Rows.Count == 1)
                {
                    var sql = $"insert into client (name, pinfl,deleted) values ('{NameCreate.Text}', {PinInsert.Text},false)";
                    GetData(sql);
                    MessageBox.Show("Malumotlar qoshiladi!!!", "Close Window", MessageBoxButtons.OK);
                    dataGridView3.DataSource = GetData("select c.Name,c.PinFl from  client c");
                    PinInsert.Text = null;
                    NameCreate.Text = null;
                    dataGridView1.DataSource = GetData("Select CL.Name,PINFL,C.CardNumber,CT.card_tip as Card_Tip,A.Number,A.Type from Client CL Join Card C on CL.Id = C.clientid JOIN Account A on C.clientid = A.Card_Id JOIN CardType CT on CT.id = C.Card_type order by name");
                    dataGridView2.DataSource = GetData("Select CL.Name,A.Number,A.Type,C.CardNumber,CT.card_tip,PINFL from Client CL Join Card C on CL.Id = C.clientid JOIN Account A on C.clientid = A.Card_Id JOIN CardType CT on CT.id = C.Card_type order by name;");
                    dataGridView3.DataSource = GetData("select c.id,c.Name,c.PinFl from  client c");
                    dataGridView4.DataSource = GetData("select C2.id,C2.Name,c.CardNumber from Account a right join Card c on c.clientid = a.Card_Id join Client C2 on c.ClientId = C2.Id where a.number is null order by C2.id;");
                    dataGridView5.DataSource = GetData("select C.id,C.Name,c.PinFl   from Client C left join Card C2 on C.Id = C2.ClientId left join cardtype cr on C2.Card_type = cr.id where cr.card_tip is null order by C.id;");
                    AddClient();
                    AddClinentCBItem();
                    AddCardType();
                    AddClientCard();
                    return;
                }
                else
                {
                    MessageBox.Show("Bunday Pinfl bor iltimos boshqa kiriting yoki ohirgacha kiritmadingiz!!!", "Close window", MessageBoxButtons.OK);
                    PinInsert.Text = null;
                }
            }
            else
            {
                MessageBox.Show("Malumotlarni ohirgacha kiriting!!!", "Close Window", MessageBoxButtons.OK);
                return;
            }
        }
        private void PinInsert_TextChanged(object sender, EventArgs e)
        {
            if (PinInsert.Text != "")
            {
                dataGridView3.DataSource = GetData($"select s.name,s.Pinfl from client s where s.Pinfl like '%{PinInsert.Text}%'");
            }
        }
        private void IdAccCr_TextChanged(object sender, EventArgs e)
        {
            if (IdAccCr.Text != "")
            {
                dataGridView4.DataSource = GetData($"select cl.Name,a.Number,C.CardNumber,cr.card_tip from Account a    join  Card C on a.card_id = C.id   join Client cl on c.clientid = cl.id    join cardtype cr on C.Card_type = cr.id where number = {IdAccCr.Text};");
            }
            if (IdAccCr.Text == "")
            {
                dataGridView4.DataSource = GetData("select cl.Name,a.Number,C.CardNumber,cr.card_tip from Account a    join  Card C on a.card_id = C.id   join Client cl on c.clientid = cl.id    join cardtype cr on C.Card_type = cr.id;");
            }
        }
        private void Accouncr_Click(object sender, EventArgs e)
        {
            if (IdAccCr.SelectedIndex != -1)
            {
                if (IdAccCr.Text != "" && textBox3.Text != "")
                {

                    var sql = $"insert into account (number,card_id,type) values({textBox4.Text},{IdAccCr.SelectedValue},{textBox3.Text})";
                    GetData(sql);
                    MessageBox.Show("Malumotlar muvafaqiyatli qo'shildi!", "Close Window", MessageBoxButtons.OK);
                    IdAccCr.Text = null;
                    textBox3.Text = null;
                    textBox4.Text = null;
                    dataGridView1.DataSource = GetData("Select CL.Name,PINFL,C.CardNumber,CT.card_tip as Card_Tip,A.Number,A.Type from Client CL Join Card C on CL.Id = C.clientid JOIN Account A on C.clientid = A.Card_Id JOIN CardType CT on CT.id = C.Card_type order by name");
                    dataGridView2.DataSource = GetData("Select CL.Name,A.Number,A.Type,C.CardNumber,CT.card_tip,PINFL from Client CL Join Card C on CL.Id = C.clientid JOIN Account A on C.clientid = A.Card_Id JOIN CardType CT on CT.id = C.Card_type order by name;");
                    dataGridView3.DataSource = GetData("select c.id,c.Name,c.PinFl from  client c");
                    dataGridView4.DataSource = GetData("select C2.id,C2.Name,c.CardNumber from Account a right join Card c on c.clientid = a.Card_Id join Client C2 on c.ClientId = C2.Id where a.number is null order by C2.id;");
                    dataGridView5.DataSource = GetData("select C.id,C.Name,c.PinFl   from Client C left join Card C2 on C.Id = C2.ClientId left join cardtype cr on C2.Card_type = cr.id where cr.card_tip is null order by C.id;");
                    AddClient();
                    AddClinentCBItem();
                    AddCardType();
                    AddClientCard();
                }
            }
            else
            {
                MessageBox.Show("Idni kiritmadingiz !!!", "Close window", MessageBoxButtons.OK);
            }

        }
        private void SubmitCard_Click(object sender, EventArgs e)
        {

            var id = textBox2.SelectedValue;
            if (idTextboxType.SelectedIndex != -1)
            {
                var card_number = GetLastCard((int)idTextboxType.SelectedValue);
                string lastFour;
                if (string.IsNullOrEmpty(card_number))
                    lastFour = "0001";
                else
                    lastFour = (int.Parse(card_number.Substring(12, 4)) + 1).ToString("D4");
                string cardNumber;
                if ((int)idTextboxType.SelectedValue == 1)
                    card_number = "986012341234" + lastFour;
                else card_number = "860012341234" + lastFour;
                using (var connect = new NpgsqlConnection(ConnectionString))
                {

                    string sql = "insert into card (cardnumber, card_type, clientid, " +
                        " created) " +
                        "values (@cardNumber, @cardType, @clientId, now());";

                    using (var cmd = new NpgsqlCommand(sql, connect))
                    {
                        connect.Open();
                        cmd.Parameters.AddWithValue("@clientId", id);
                        cmd.Parameters.AddWithValue("@cardType", idTextboxType.SelectedValue);
                        cmd.Parameters.AddWithValue("@cardNumber", card_number);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show($"Sizga karta nomer ochildi : {card_number}", "Close window", MessageBoxButtons.OK);
                    idTextboxType.SelectedIndex = -1;
                    textBox2.SelectedIndex = -1;
                    dataGridView1.DataSource = GetData("Select CL.Name,PINFL,C.CardNumber,CT.card_tip as Card_Tip,A.Number,A.Type from Client CL Join Card C on CL.Id = C.clientid JOIN Account A on C.clientid = A.Card_Id JOIN CardType CT on CT.id = C.Card_type order by name");
                    dataGridView2.DataSource = GetData("Select CL.Name,A.Number,A.Type,C.CardNumber,CT.card_tip,PINFL from Client CL Join Card C on CL.Id = C.clientid JOIN Account A on C.clientid = A.Card_Id JOIN CardType CT on CT.id = C.Card_type order by name;");
                    dataGridView3.DataSource = GetData("select c.id,c.Name,c.PinFl from  client c");
                    dataGridView4.DataSource = GetData("select C2.id,C2.Name,c.CardNumber from Account a right join Card c on c.clientid = a.Card_Id join Client C2 on c.ClientId = C2.Id where a.number is null order by C2.id;");
                    dataGridView5.DataSource = GetData("select C.id,C.Name,c.PinFl   from Client C left join Card C2 on C.Id = C2.ClientId left join cardtype cr on C2.Card_type = cr.id where cr.card_tip is null order by C.id;");
                    AddClient();
                    AddClinentCBItem();
                    AddCardType();
                    AddClientCard();
                }
            }
            else
                MessageBox.Show("Client or card type not selected");

        }
        private string GetLastCard(int id)
        {
            string card;
            if (id == 1)
                card = "9860";
            else
                card = "8600";
            string sql = $"select cardnumber from card where cardnumber like '{card}%' " +
                $"order by created desc limit 1 ";
            var data = GetData(sql);
            if (data.Rows.Count > 0)
            {
                return data.Rows[0].ItemArray[0].ToString();
            }
            return string.Empty;
        }
        private void idTextboxType_TextChanged(object sender, EventArgs e)
        {
            if (idTextboxType.Text != "")
            {
                dataGridView5.DataSource = GetData($"select * from cardtype where id = {idTextboxType.Text};");
            }
            if (idTextboxType.Text == "")
            {
                dataGridView5.DataSource = GetData("select C.id,C.Name,c.PinFl   from Client C left join Card C2 on C.Id = C2.ClientId left join cardtype cr on C2.Card_type = cr.id where cr.card_tip is null;");
            }
        }
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                dataGridView5.DataSource = GetData($"select C.id,C.Name,c.PinFl   from Client C left join Card C2 on C.Id = C2.ClientId left join cardtype cr on C2.Card_type = cr.id where C.id = {textBox2.Text};");
            }
            if (textBox2.Text == "")
            {
                dataGridView5.DataSource = GetData("select C.id,C.Name,c.PinFl   from Client C left join Card C2 on C.Id = C2.ClientId left join cardtype cr on C2.Card_type = cr.id where cr.card_tip is null;");
            }
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

            if (NameUpdate.Text != "")
            {
                dataGridView2.DataSource = GetData($"select s.name,s.Pinfl from client s where s.Pinfl like '%{NameUpdate.Text}%'");
            }
        }
        private void UpdateData_Click(object sender, EventArgs e)
        {
            if (CbUpdateName.SelectedIndex != -1)
            {
                if (NameUpdate.Text != "")
                {
                    GetData($"update Account set number = {NameUpdate.Text} where id = {CbUpdateName.SelectedValue}");
                    NameUpdate.Text = null;
                }
                if (TypeUpdate.Text != "")
                {
                    GetData($"update Account set type = {TypeUpdate.Text} where id = {CbUpdateName.SelectedValue}");
                    TypeUpdate.Text = null;
                }
                MessageBox.Show("Malumotlar Yangilandi", "Close window", MessageBoxButtons.OK);
                dataGridView1.DataSource = GetData("Select CL.Name,PINFL,C.CardNumber,CT.card_tip as Card_Tip,A.Number,A.Type from Client CL Join Card C on CL.Id = C.clientid JOIN Account A on C.clientid = A.Card_Id JOIN CardType CT on CT.id = C.Card_type order by name");
                dataGridView2.DataSource = GetData("Select CL.Name,A.Number,A.Type,C.CardNumber,CT.card_tip,PINFL from Client CL Join Card C on CL.Id = C.clientid JOIN Account A on C.clientid = A.Card_Id JOIN CardType CT on CT.id = C.Card_type order by name;");
                dataGridView3.DataSource = GetData("select c.id,c.Name,c.PinFl from  client c");
                dataGridView4.DataSource = GetData("select C2.id,C2.Name,c.CardNumber from Account a right join Card c on c.clientid = a.Card_Id join Client C2 on c.ClientId = C2.Id where a.number is null order by C2.id;");
                dataGridView5.DataSource = GetData("select C.id,C.Name,c.PinFl   from Client C left join Card C2 on C.Id = C2.ClientId left join cardtype cr on C2.Card_type = cr.id where cr.card_tip is null order by C.id;");
                AddClient();
                AddClinentCBItem();
                AddCardType();
                AddClientCard();
            }
            else
            {
                MessageBox.Show("Kimga kiritmoqchiligingizni kiriting", "Close window", MessageBoxButtons.OK);
            }
        }


        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        private void PinFl_Click(object sender, EventArgs e)
        {

        }
        private void comboBoxCard_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Account_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void PinTextAcc_TextChanged(object sender, EventArgs e)
        {

        }
        private void Card_Click(object sender, EventArgs e)
        {

        }
        private void Nametype_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void ClienItInsert_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        private void label1_Click_2(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void Card_idAccounIdCr_Click(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void AccNumUpdate_TextChanged(object sender, EventArgs e)
        {

        }
        private void AccUpdateId_TextChanged(object sender, EventArgs e)
        {

        }
        private void AccSeUpdate_TextChanged(object sender, EventArgs e)
        {

        }
        private void SubmitAccUpdate_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void SubmitL_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void TypeUpdate_TextChanged(object sender, EventArgs e)
        {

        }
        private void Insert()
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void NameInsert_Click(object sender, EventArgs e)
        {

        }
        private void NameAccCr_TextChanged(object sender, EventArgs e)
        {

        }
        private void Cardnumber_Click(object sender, EventArgs e)
        {

        }
        private void NameCreate_TextChanged(object sender, EventArgs e)
        {


        }
        private void DDelete_Click(object sender, EventArgs e)
        {


        }

       
    }
}