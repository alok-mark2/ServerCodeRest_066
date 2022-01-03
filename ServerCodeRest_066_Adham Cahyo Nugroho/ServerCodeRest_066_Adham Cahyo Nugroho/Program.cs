using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ServerCodeRest_066_Adham_Cahyo_Nugroho;
using System.ServiceModel.Web;
using System.ServiceModel.Description;
using System.ServiceModel.Channels;

namespace ServerCodeRest_066_Adham_Cahyo_Nugroho
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostObjek = null;
            Uri address = new Uri("http://localhost:1907/Mahasiswa");
            WebHttpBinding binding = new WebHttpBinding();

            try
            {
                hostObjek = new ServiceHost(typeof(TI_UMY), address);
                hostObjek.AddServiceEndpoint(typeof(ITI_UMY), binding, "");

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                hostObjek.Description.Behaviors.Add(smb);
                Binding mexbind = MetadataExchangeBindings.CreateMexHttpBinding();
                hostObjek.AddServiceEndpoint(typeof(IMetadataExchange), mexbind, "mex");

                WebHttpBehavior whb = new WebHttpBehavior();
                whb.HelpEnabled = true;
                hostObjek.Description.Endpoints[0].EndpointBehaviors.Add(whb);

                hostObjek.Open();
                Console.WriteLine("Server is ready!!!!");
                Console.ReadLine();
                hostObjek.Close();
            }
            catch (Exception ex)
            {
                hostObjek = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }

    internal class WebHttpBinding
    {
    }

    internal class TI_UMY
    {
    }

    internal class ITI_UMY
    {
    }

    internal class ServiceHost
    {
        internal object Description;

        public ServiceHost(Type type, Uri address)
        {
        }

        internal void AddServiceEndpoint(Type type, Binding mexbind, string v)
        {
            throw new NotImplementedException();
        }

        internal void AddServiceEndpoint(Type type, WebHttpBinding binding, string v)
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }

    internal interface IMetadataExchange
    {
    }

    internal class WebHttpBehavior
    {
        internal bool HelpEnabled;
    }

    internal class ServiceMetadataBehavior
    {
        public bool HttpGetEnabled { get; internal set; }
    }

    internal class Binding
    {
    }

    internal class MetadataExchangeBindings
    {
    }
}