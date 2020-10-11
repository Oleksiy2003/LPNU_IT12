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
using Newtonsoft.Json;
namespace TelegramBotTranslator
{
    public partial class Form1 : Form
    {
        static Translator tr;
        static ITelegramBotClient botClient;
        public Form1()
        {
          
            InitializeComponent();
            tr = new Translator();
            botClient = new TelegramBotClient("1272015145:AAElDpHDJuAgrK-BqcaXXkAf63Rqsu9fYbA");
            var me = botClient.GetMeAsync().Result;
            botClient.OnMessage += Bot_OnMessage;
            botClient.StartReceiving();
            
        }

        static async void Bot_OnMessage(object sender,MessageEventArgs e)
        {
            if (e.Message!=null)
            {
                await botClient.SendTextMessageAsync(
                    chatId: e.Message.Chat.Id,
                    text: tr.Translate(e.Message.Text, "uk-ru").ToString());


            }
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
