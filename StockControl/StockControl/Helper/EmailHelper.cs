using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace StockControl.Helper
{
    public abstract class EmailHelper
    {
        public static void SendEmail()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("levelupcsharp@gmail.com");
            mail.To.Add("tg18roque@gmail.com");
            mail.Subject = "[Testes] - StockControl";
            //mail.Body = "<h2>Cadastro de Categoria realizado!</h2>";

            string bodyMail = @"
                    <table class='m_4082906812234585093container-for-gmail-android' style='font-family:'Oxygen','Helvetica Neue','Arial','sans-serif'!important;min-width:600px;border-collapse:collapse!important' width='100%' cellspacing='0' cellpadding='0' align='center'>
	                    <tbody>
		                    <tr>
			                    <td>
				                    <center>
					                    <img class='m_4082906812234585093force-width-gmail CToWUd' src='https://ci3.googleusercontent.com/proxy/RDP8h8k9Ptd0-aOMCw2IqDUVtxxhL7-slMxaLu9jd0HVzGo36y2gPMuJ6dYugKOzMojL_bDmpxVLaii2uX0Rx29XGgSVlbRetTuN2SJBMMi6-qfxFxbq4BIfzmX1mAlAmA=s0-d-e1-ft#http://s3.amazonaws.com/swu-filepicker/SBb2fQPrQ5ezxmqUTgCr_transparent.png' alt=''>
					                    <table bgcolor='#ffffff'>
						                    <tbody>
							                    <tr>
								                    <td>
									                    <center>
										                    <table class='m_4082906812234585093w320' style='font-family:'Oxygen','Helvetica Neue','Arial','sans-serif'!important;border-collapse:collapse!important' width='600' cellspacing='0' cellpadding='0'>
											                    <tbody>
												                    <tr style='font-family:'Oxygen','Helvetica Neue','Arial','sans-serif'!important'>
													                    <td class='m_4082906812234585093pull-left m_4082906812234585093mobile-header-padding-left' style='vertical-align:middle;font-family:'Oxygen','Helvetica Neue','Arial','sans-serif'!important;font-size:14px;color:#777777;text-align:left;line-height:21px;border-collapse:collapse;width:290px;padding-left:10px'><a style='font-family:'Oxygen','Helvetica Neue','Arial','sans-serif'!important;color:#676767;text-decoration:none!important' href='http://www.levelupacademy.com.br' target='_blank' data-saferedirecturl='https://www.google.com/url?hl=pt-BR&amp;q=http://www.levelupacademy.com.br&amp;source=gmail&amp;ust=1499387911388000&amp;usg=AFQjCNFLHGoq5AKWJ2WuopXC5LMyy5mXUQ'><img style='font-family:'Oxygen','Helvetica Neue','Arial','sans-serif'!important;max-width:600px;outline:none;text-decoration:none;border:none' src='https://ci4.googleusercontent.com/proxy/PMSqorizgUkkTGnhdeE8YPb3A4Jq2NhhSop0K4otDlRcJidIrr-qcOKihOPpKV367Dp6IgokD6oyRWMrzHvKZeUH8MkYUf5gXsLrCu1XxHe0atWCzZR9Yvk=s0-d-e1-ft#http://www.levelupacademy.com.br/TemplateEmail/Images/logoemail.jpg' alt='logo' width='137' height='47' class='CToWUd'></a></td>
													                    <td class='m_4082906812234585093pull-right m_4082906812234585093mobile-header-padding-right' style='color:#4d4d4d;font-family:'Oxygen','Helvetica Neue','Arial','sans-serif'!important;font-size:14px;text-align:right;line-height:21px;border-collapse:collapse;width:290px;padding-left:10px'><a style='font-family:'Oxygen','Helvetica Neue','Arial','sans-serif'!important;color:#676767;text-decoration:none!important' href='http://facebook.com/levelupacademy.com.br' target='_blank' data-saferedirecturl='https://www.google.com/url?hl=pt-BR&amp;q=http://facebook.com/levelupacademy.com.br&amp;source=gmail&amp;ust=1499387911388000&amp;usg=AFQjCNGHJogZFuSEw02764Kk0_OyLaF2KA'><img style='font-family:'Oxygen','Helvetica Neue','Arial','sans-serif'!important;max-width:600px;outline:none;text-decoration:none;border:none' src='https://ci3.googleusercontent.com/proxy/k8wuidOSXnlTZsrrYeZD5q5ZO_BBPQXZigsHcyBgREEmaNzU9k_zBqhNoO280WaDsSOKMybi9IPZ_2jNw3pD5Q2fndsJ5aCBIOZG4JXH0cihWIGkOnbFdqu7bURWBSQ=s0-d-e1-ft#http://s3.amazonaws.com/swu-filepicker/LMPMj7JSRoCWypAvzaN3_social_09.gif' alt='facebook' width='38' height='47' class='CToWUd'></a></td>
												                    </tr>
											                    </tbody>
										                    </table>
									                    </center>
								                    </td>
							                    </tr>
						                    </tbody>
					                    </table>
				                    </center>
			                    </td>
		                    </tr>
		                    <tr style='font-family:'Oxygen','Helvetica Neue','Arial','sans-serif'!important'>
			                    <td class='m_4082906812234585093content-padding' style='background-color:#f7f7f7;font-family:'Oxygen','Helvetica Neue','Arial','sans-serif'!important;font-size:14px;color:#777777;text-align:center;line-height:21px;border-collapse:collapse;padding:20px 0 5px' align='center' valign='top' width='100%'>
				                    <center style='font-family:'Oxygen','Helvetica Neue','Arial','sans-serif'!important'>
					                    <table class='m_4082906812234585093w320' style='font-family:'Oxygen','Helvetica Neue','Arial','sans-serif'!important;border-collapse:collapse!important' width='600' cellspacing='0' cellpadding='0'>
						                    <tbody>
							                    <tr style='font-family:'Oxygen','Helvetica Neue','Arial','sans-serif'!important'>
								                    <td class='m_4082906812234585093header-lg' style='font-family:'Oxygen','Helvetica Neue','Arial','sans-serif'!important;font-size:32px;color:#4d4d4d;text-align:center;line-height:normal;border-collapse:collapse;font-weight:bold;padding:35px 0 0'>Obrigado por participar do nosso workshop!</td>
							                    </tr>
							                    <tr style='font-family:'Oxygen','Helvetica Neue','Arial','sans-serif'!important'>
								                    <td class='m_4082906812234585093free-text' style='font-family:'Oxygen','Helvetica Neue','Arial','sans-serif'!important;font-size:14px;color:#777777;text-align:center;line-height:21px;border-collapse:collapse;padding:10px 60px 0px;width:100%!important'>Como forma de agradecimento, vamos lhe dar um <strong style='font-family:'Oxygen','Helvetica Neue','Arial','sans-serif'!important'>descontão</strong>! <br style='font-family:'Oxygen','Helvetica Neue','Arial','sans-serif'!important'>Veja mais detalhes abaixo neste email.<br style='font-family:'Oxygen','Helvetica Neue','Arial','sans-serif'!important'><br style='font-family:'Oxygen','Helvetica Neue','Arial','sans-serif'!important'> Entre em contato e lhe enviaremos o material dos workshops e um kit inicial totalmente gratuito!</td>
							                    </tr>
							                    <tr style='font-family:'Oxygen','Helvetica Neue','Arial','sans-serif'!important'>
								                    <td class='m_4082906812234585093button' style='font-family:'Oxygen','Helvetica Neue','Arial','sans-serif'!important;font-size:14px;color:#777777;text-align:center;line-height:21px;border-collapse:collapse;padding:30px 0'>
									                    <div style='font-family:'Oxygen','Helvetica Neue','Arial','sans-serif'!important'><a style='background-color:#83ba1d;border-radius:5px;color:#ffffff;display:inline-block;font-family:'Cabin',Helvetica,Arial,sans-serif;font-size:14px;font-weight:regular;line-height:45px;text-align:center;text-decoration:none;width:155px' href='http://levelupacademy.com.br/contato.html' target='_blank' data-saferedirecturl='https://www.google.com/url?hl=pt-BR&amp;q=http://levelupacademy.com.br/contato.html&amp;source=gmail&amp;ust=1499387911388000&amp;usg=AFQjCNHALNtl8qHZp0Qop_5TP6nQtLdkfQ'>Fale com a gente!</a></div>
								                    </td>
							                    </tr>
						                    </tbody>
					                    </table>
				                    </center>
			                    </td>
		                    </tr>
	                    </tbody>
                    </table>";

            mail.Body = bodyMail;
            mail.IsBodyHtml = true;
            //Attachment attachment = new Attachment(filename);
            //mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("levelupcsharp@gmail.com", "LevelUp2017@");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
    }
}
