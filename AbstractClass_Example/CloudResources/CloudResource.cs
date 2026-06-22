using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass_Example.CloudResources
{
    // Every cloud resource must implement provisioning and deletion.
    // CloudResource is like your architecture review board: strict, abstract, and full of rules.
    public abstract class CloudResource
    {
        public string? Name { get; set; }
        public required string Region { get; set; }

        public abstract void Provision();
        public abstract void Delete();

        public void TagResource()
        {
            Console.WriteLine($"Tagging resource {Name} with 'Owner=CloudTeam'");
        }
    }

}
