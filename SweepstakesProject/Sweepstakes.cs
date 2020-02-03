using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace SweepstakesProject
{
    public class Sweepstakes
    {
        //Member Variables (HAS A)
        // USE DICTIONARY DATA STRUCTURE
        private Dictionary<int, Contestant> contestants;
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }

        //Constructor
        public Sweepstakes(string name)
        {
            this.name = name;
            contestants = new Dictionary<int, Contestant>();
        }

        //Member Methods (CAN DO)
        public void RegisterContestant(Contestant contestant)
        {
            contestant.registrationNum = (contestants.Count) + 1;
            contestants.Add(contestant.registrationNum, contestant);
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"First Name: {contestant.firstName}" +
                $"Last Name: {contestant.lastName}" +
                $"Email: {contestant.email}" +
                $"Registration Number: {contestant.registrationNum}");
        }
        public Contestant PickWinner()
        {
            Random random = new Random();
            Contestant randomWinner;
            // Use Random to select a random number from the length of the dictionary contestants
            int randNum = random.Next(0, (contestants.Count) + 1);
            randomWinner = contestants[randNum];
            return randomWinner;
        }
        public void EmailContestants(Contestant winner,Sweepstakes sweepstakes)
        {
            // take the sweepstakes that was pulled off and notify contestants with a message of win or loss
            foreach (KeyValuePair<int, Contestant> contestant in contestants)
            {
                if (contestant.Value == winner)
                {
                    contestant.Value.Notify($"Congratulations!!! {contestant.Value.firstName} {contestant.Value.lastName} You have won!!!" +
                        $" You will be contacted with additional details in an email.");
                    EmailWinner(winner,sweepstakes);
                }
                else
                {
                    contestant.Value.Notify($"{contestant.Value.firstName} {contestant.Value.lastName} you did not win. Better luck next time!");
                }
            }
        }
        public void EmailWinner(Contestant winner, Sweepstakes sweepstakes)
        {
            var message = new MimeMessage();

            message.From.Add(new MailboxAddress(winner.firstName, winner.email));
            message.To.Add(new MailboxAddress("Andrew", "andrewflamingo@gmail.com"));
            message.Subject = $"Congratulations!!";

            message.Body = new TextPart("plain")
            {
                Text = $@"You have won the {sweepstakes.Name}! Welcome to winnerhood, one of the perks is a new flamingo!
                    We will stay in touch to arrange delivery of your flamingo.
                    Congratulations again!
                    -Andrew"
            };

            try
            {
                var client = new SmtpClient();
                {
                    client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.Auto);
                    client.Authenticate("andrewflamingo@gmail.com", "mypassword");
                    client.Send(message);
                    client.Disconnect(true);
                }
            }
            catch (Exception ex) 
            {
                var e = ex;
                throw;
            }
        }
    }
}
