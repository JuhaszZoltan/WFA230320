namespace WFA230320
{
    public partial class FrmMain : Form
    {
        #region Hungarian Notation
        //frm -> form
        //mnu -> menu
        //btn -> button
        //cmd -> command / command button
        //chk -> check box / check button
        //lbl -> text label
        //txt -> text edit/input
        //pic -> picture
        //lst -> listbox
        //cbo -> combo box
        //tmr -> timer
        //pd  -> picture box
        //uc  -> user control
        //opt -> radio button
        #endregion

        private static Random rnd = new();

        public FrmMain()
        {
            InitializeComponent();
            tmrUpdate.Tick += OnUpdateTick;
        }

        private void OnUpdateTick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private PictureBox GetRandomTarget()
        {



            return new PictureBox();
        }

    }
}