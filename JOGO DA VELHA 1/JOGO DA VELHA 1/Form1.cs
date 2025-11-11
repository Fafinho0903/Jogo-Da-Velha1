namespace JOGO_DA_VELHA_1
{
    public partial class Form1 : Form
    {
        private string jogador1;
        private string jogador2;
        private string[,] tabuleiro;
        private bool vezJogador1;
        private int jogadas;
        private int vitoriasJogador1 = 0;
        private int vitoriasJogador2 = 0;
        private int empates = 0;
        private bool jogoIniciado = false;

        public Form1()
        {
            InitializeComponent();
            tabuleiro = new string[3, 3];
            vezJogador1 = true;
            jogadas = 0;


            btn1.Click += btnClick_Cell;
            btn2.Click += btnClick_Cell;
            btn3.Click += btnClick_Cell;
            btn4.Click += btnClick_Cell;
            btn5.Click += btnClick_Cell;
            btn6.Click += btnClick_Cell;
            btn7.Click += btnClick_Cell;
            btn8.Click += btnClick_Cell;
            btn9.Click += btnClick_Cell;


            txtPlayer1.TextChanged += TxtPlayer_TextChanged;
            txtPlayer2.TextChanged += TxtPlayer_TextChanged;
        }

        private void TxtPlayer_TextChanged(object sender, EventArgs e)
        {

            string nome1 = string.IsNullOrWhiteSpace(txtPlayer1.Text) ? "Player 1" : txtPlayer1.Text;
            string nome2 = string.IsNullOrWhiteSpace(txtPlayer2.Text) ? "Player 2" : txtPlayer2.Text;

            lblPlayer1.Text = $"{nome1}: {vitoriasJogador1}";
            lblPlayer2.Text = $"{nome2}: {vitoriasJogador2}";
            lblEmpate.Text = $"Empate: {empates}";
        }

        private void BntIniciar_Click(object sender, EventArgs e)
        {
            jogador1 = txtPlayer1.Text;
            jogador2 = txtPlayer2.Text;

            if (string.IsNullOrWhiteSpace(jogador1) || string.IsNullOrWhiteSpace(jogador2))
            {
                MessageBox.Show("Por favor, insira os nomes dos jogadores.");
                return;
            }


            if (!op1.Checked && !op2.Checked)
            {
                MessageBox.Show("Por favor, selecione uma opção (X ou O) para iniciar o jogo.");
                return;
            }


            if (!jogoIniciado)
            {
                vitoriasJogador1 = 0;
                vitoriasJogador2 = 0;
                empates = 0;
            }

            jogoIniciado = true;


            vezJogador1 = true;

            AtualizarPlacar();


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tabuleiro[i, j] = null;
                }
            }

            ReiniciarTabuleiro();


            BntIniciar.Enabled = false;


            txtPlayer1.Enabled = false;
            txtPlayer2.Enabled = false;
            op1.Enabled = false;
            op2.Enabled = false;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tabuleiro[i, j] = null;
                }
            }


            vezJogador1 = true;

            ReiniciarTabuleiro();


            BntIniciar.Enabled = true;


            txtPlayer1.Enabled = true;
            txtPlayer2.Enabled = true;
            op1.Enabled = true;
            op2.Enabled = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Deseja realmente sair do jogo?",
                "Confirmação de Saída",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClick_Cell(object sender, EventArgs e)
        {
            Button btn = (Button)sender;


            int linha = 0, coluna = 0;

            switch (btn.Name)
            {
                case "btn1": linha = 0; coluna = 0; break;
                case "btn2": linha = 0; coluna = 1; break;
                case "btn3": linha = 0; coluna = 2; break;
                case "btn4": linha = 1; coluna = 0; break;
                case "btn5": linha = 1; coluna = 1; break;
                case "btn6": linha = 1; coluna = 2; break;
                case "btn7": linha = 2; coluna = 0; break;
                case "btn8": linha = 2; coluna = 1; break;
                case "btn9": linha = 2; coluna = 2; break;
            }


            if (tabuleiro[linha, coluna] != null)
                return;


            string pecaJogador1 = op1.Checked ? "X" : "O"; 
            string pecaJogador2 = op1.Checked ? "O" : "X"; 


            tabuleiro[linha, coluna] = vezJogador1 ? pecaJogador1 : pecaJogador2;
            btn.Text = tabuleiro[linha, coluna];
            jogadas++;


            if (VerificarVitoria())
            {
                string vencedor = vezJogador1 ? jogador1 : jogador2;
                MessageBox.Show($"{vencedor} venceu!", "Vitória!");

                if (vezJogador1)
                    vitoriasJogador1++;
                else
                    vitoriasJogador2++;

                AtualizarPlacar();
                DesabilitarBotoes();


                BntIniciar.Enabled = true;
                txtPlayer1.Enabled = true;
                txtPlayer2.Enabled = true;
                op1.Enabled = true;
                op2.Enabled = true;
                return;
            }


            if (jogadas == 9)
            {
                MessageBox.Show("Empate!", "Jogo Empatado!");
                empates++;
                AtualizarPlacar();


                BntIniciar.Enabled = true;
                txtPlayer1.Enabled = true;
                txtPlayer2.Enabled = true;
                op1.Enabled = true;
                op2.Enabled = true;
                return;
            }


            vezJogador1 = !vezJogador1;
        }

        private bool VerificarVitoria()
        {

            for (int i = 0; i < 3; i++)
            {

                if (tabuleiro[i, 0] != null &&
                    tabuleiro[i, 0] == tabuleiro[i, 1] &&
                    tabuleiro[i, 1] == tabuleiro[i, 2])
                    return true;


                if (tabuleiro[0, i] != null &&
                    tabuleiro[0, i] == tabuleiro[1, i] &&
                    tabuleiro[1, i] == tabuleiro[2, i])
                    return true;
            }


            if (tabuleiro[0, 0] != null &&
                tabuleiro[0, 0] == tabuleiro[1, 1] &&
                tabuleiro[1, 1] == tabuleiro[2, 2])
                return true;


            if (tabuleiro[0, 2] != null &&
                tabuleiro[0, 2] == tabuleiro[1, 1] &&
                tabuleiro[1, 1] == tabuleiro[2, 0])
                return true;

            return false;
        }

        private void ReiniciarTabuleiro()
        {
            jogadas = 0;

            btn1.Text = btn2.Text = btn3.Text =
            btn4.Text = btn5.Text = btn6.Text =
            btn7.Text = btn8.Text = btn9.Text = "";


            btn1.Enabled = btn2.Enabled = btn3.Enabled =
            btn4.Enabled = btn5.Enabled = btn6.Enabled =
            btn7.Enabled = btn8.Enabled = btn9.Enabled = true;
        }

        private void DesabilitarBotoes()
        {
            btn1.Enabled = btn2.Enabled = btn3.Enabled =
            btn4.Enabled = btn5.Enabled = btn6.Enabled =
            btn7.Enabled = btn8.Enabled = btn9.Enabled = false;
        }

        private void AtualizarPlacar()
        {

            lblPlayer1.Text = $"{jogador1}: {vitoriasJogador1}";
            lblPlayer2.Text = $"{jogador2}: {vitoriasJogador2}";


            lblEmpate.Text = $"Empate: {empates}";
        }


        private void empate_Click(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void op2_Click(object sender, EventArgs e) { }
        private void op1_Click(object sender, EventArgs e) { }
    }
}