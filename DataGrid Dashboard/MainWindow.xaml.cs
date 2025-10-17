using System.Windows;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Media;

namespace DataGrid_Dashboard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var converter = new BrushConverter();
            ObservableCollection<Member> members = new ObservableCollection<Member>();
            //Create DateGrid item info 
            members.Add(new Member() { Character = "A", Number = "1", Name = "Alice Johnson", Position = "Manager", Email = "alice.johnson@example.com", Phone = "(555) 123-4567", BgColor = (Brush)converter.ConvertFromString("#3498DB") });
            members.Add(new Member() { Character = "B", Number = "2", Name = "Bob Williams", Position = "Engineer", Email = "bob.williams@example.com", Phone = "(555) 234-5678", BgColor = (Brush)converter.ConvertFromString("#E74C3C") });
            members.Add(new Member() { Character = "C", Number = "3", Name = "Carol Davis", Position = "Analyst", Email = "carol.davis@example.com", Phone = "(555) 345-6789", BgColor = (Brush)converter.ConvertFromString("#2ECC71") });
            members.Add(new Member() { Character = "D", Number = "4", Name = "David Miller", Position = "Developer", Email = "david.miller@example.com", Phone = "(555) 456-7890", BgColor = (Brush)converter.ConvertFromString("#F39C12") });
            members.Add(new Member() { Character = "E", Number = "5", Name = "Emily Wilson", Position = "Consultant", Email = "emily.wilson@example.com", Phone = "(555) 567-8901", BgColor = (Brush)converter.ConvertFromString("#9B59B6") });
            members.Add(new Member() { Character = "F", Number = "6", Name = "Frank Moore", Position = "Technician", Email = "frank.moore@example.com", Phone = "(555) 678-9012", BgColor = (Brush)converter.ConvertFromString("#1ABC9C") });
            members.Add(new Member() { Character = "G", Number = "7", Name = "Grace Taylor", Position = "Specialist", Email = "grace.taylor@example.com", Phone = "(555) 789-0123", BgColor = (Brush)converter.ConvertFromString("#D35400") });
            members.Add(new Member() { Character = "H", Number = "8", Name = "Henry Anderson", Position = "Coordinator", Email = "henry.anderson@example.com", Phone = "(555) 890-1234", BgColor = (Brush)converter.ConvertFromString("#34495E") });
            members.Add(new Member() { Character = "I", Number = "9", Name = "Ivy Thomas", Position = "Supervisor", Email = "ivy.thomas@example.com", Phone = "(555) 901-2345", BgColor = (Brush)converter.ConvertFromString("#E67E22") });
            members.Add(new Member() { Character = "J", Number = "10", Name = "Jack Jackson", Position = "Administrator", Email = "jack.jackson@example.com", Phone = "(555) 012-3456", BgColor = (Brush)converter.ConvertFromString("#C0392B") });
            members.Add(new Member() { Character = "K", Number = "11", Name = "Kelly White", Position = "Team Lead", Email = "kelly.white@example.com", Phone = "(555) 111-2222", BgColor = (Brush)converter.ConvertFromString("#7F8C8D") });
            members.Add(new Member() { Character = "L", Number = "12", Name = "Liam Harris", Position = "Architect", Email = "liam.harris@example.com", Phone = "(555) 333-4444", BgColor = (Brush)converter.ConvertFromString("#27AE60") });
            members.Add(new Member() { Character = "M", Number = "13", Name = "Mia Martin", Position = "Product Owner", Email = "mia.martin@example.com", Phone = "(555) 555-6666", BgColor = (Brush)converter.ConvertFromString("#F1C40F") });
            members.Add(new Member() { Character = "N", Number = "14", Name = "Noah Thompson", Position = "Scrum Master", Email = "noah.thompson@example.com", Phone = "(555) 777-8888", BgColor = (Brush)converter.ConvertFromString("#8E44AD") });
            members.Add(new Member() { Character = "O", Number = "15", Name = "Olivia Garcia", Position = "UX Designer", Email = "olivia.garcia@example.com", Phone = "(555) 999-0000", BgColor = (Brush)converter.ConvertFromString("#A93226") });
            members.Add(new Member() { Character = "P", Number = "16", Name = "Peter Rodriguez", Position = "QA Tester", Email = "peter.rodriguez@example.com", Phone = "(555) 101-2020", BgColor = (Brush)converter.ConvertFromString("#16A085") });
            members.Add(new Member() { Character = "Q", Number = "17", Name = "Quinn Lopez", Position = "Data Scientist", Email = "quinn.lopez@example.com", Phone = "(555) 303-4040", BgColor = (Brush)converter.ConvertFromString("#5D6D7E") });
            members.Add(new Member() { Character = "R", Number = "18", Name = "Ryan Perez", Position = "System Admin", Email = "ryan.perez@example.com", Phone = "(555) 505-6060", BgColor = (Brush)converter.ConvertFromString("#2980B9") });
            members.Add(new Member() { Character = "S", Number = "19", Name = "Sophia Scott", Position = "Marketing Mgr", Email = "sophia.scott@example.com", Phone = "(555) 707-8080", BgColor = (Brush)converter.ConvertFromString("#BA4A00") });
            members.Add(new Member() { Character = "T", Number = "20", Name = "Thomas Green", Position = "Finance Officer", Email = "thomas.green@example.com", Phone = "(555) 909-0000", BgColor = (Brush)converter.ConvertFromString("#21618C") });
            membersDataGrid.ItemsSource = members;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                //Check the button clicked and move the window
                this.DragMove();
            }
        }

        private bool IsMaxmized = false;
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // On double click maximize the window
            if (e.ClickCount == 2)
            {
                if (IsMaxmized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 720;
                    IsMaxmized = false;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;
                    IsMaxmized = true;
                }
            }

        }

        private void membersDataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }

    public class  Member
    {
        public string Character { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Brush BgColor { get; set; }
    }
}