using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass_Example.CloudResources
{
    //Public and Internal for Class are not Accecpted
    public class GCPBucket : CloudResource
    {
        public override void Provision()
        {
            Console.WriteLine($"Creating GCP Bucket '{Name}' in {Region}. Relax, it's just storage.");
        }

        public override void Delete()
        {
            Console.WriteLine($"Deleting GCP Bucket '{Name}'. Hope you backed up your backups.");
        }
    }

    public class AzureVM : CloudResource
    {
        public override void Provision()
        {
            Console.WriteLine($"Provisioning Azure VM '{Name}' in {Region} with 99.99% SLA.");
        }

        public override void Delete()
        {
            Console.WriteLine($"Deleting Azure VM '{Name}'. Billing team says thank you.");
        }
    }

    public class AWSLambda : CloudResource
    {
        public override void Provision()
        {
            Console.WriteLine($"Deploying AWS Lambda '{Name}' in {Region}. No servers, no tension.");
        }

        public override void Delete()
        {
            Console.WriteLine($"Deleting AWS Lambda '{Name}'. Goodbye free tier.");
        }
    }
    



}
