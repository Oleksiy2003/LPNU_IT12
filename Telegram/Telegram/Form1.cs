using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace Telegram
{
    public partial class Form1 : Form
    {
       
     
        static ITelegramBotClient botClient;
         Translator tr;
        public Form1()
        {
            InitializeComponent();
            botClient = new TelegramBotClient("1272015145:AAElDpHDJuAgrK-BqcaXXkAf63Rqsu9fYbA");
            var me = botClient.GetMeAsync().Result;
            Console.WriteLine($"Hello World!I am user {me.Id} and my name is {me.FirstName}");
            botClient.OnMessage += Bot_OnMessage;
            botClient.StartReceiving();
            tr=new Translator();
        }
        static async void Bot_OnMessage(object sender,MessageEventArgs e)
        {
            if (e.Message.Text != null)
            {
                Console.WriteLine($"Received message in chat {e.Message.Chat.Id}.");
              await botClient.SendTextMessageAsync(
                    chatId: e.Message.Chat,
                    text:tr.Translate(e.Message.Text,"ru-en").ToString());

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
