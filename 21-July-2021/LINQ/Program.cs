using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //List of Managers and Branches
            BankManager[] managerList =
            {
                new BankManager() { Age = 45, Id=1, Name="Raj"},
                new BankManager() { Age = 29, Id=2, Name="Kamal"},
                new BankManager() { Age = 35, Id=3, Name="Mohan"},
                new BankManager() { Age = 30, Id=5, Name="Sakthi"},
                new BankManager() { Age = 32, Id=4, Name="Madhan"}
            };

            BankBranch[] branchList =
            {
                new BankBranch(){ BranchId=1, BranchName="Tambaram", ManagerId = 2, MaxPoint = 70 },
                new BankBranch(){ BranchId=3, BranchName="Sholinganallur", ManagerId = 1, MaxPoint = 85 },
                new BankBranch(){ BranchId=2, BranchName="Guindy", ManagerId = 3, MaxPoint = 90 },
                new BankBranch(){ BranchId=5, BranchName="Velacherry", ManagerId = 4, MaxPoint = 65 },
                new BankBranch(){ BranchId=4, BranchName="Vadapalani", ManagerId = 5, MaxPoint = 80 }
            };


            //LINQ Expression for display the list of branches and managers
            Console.WriteLine("\n\n\n\tList of Branches and Managers\n");
            var bankManagers = managerList.Join
                (branchList,
                BankManager => BankManager.Id,
                BankBranch => BankBranch.ManagerId,
                (BankManager, BankBranch) => new
                {
                    BranchName = BankBranch.BranchName,
                    ManagerName = BankManager.Name,
                    ManagerAge = BankManager.Age,
                });


            foreach (var Branch in bankManagers)
            {
                Console.WriteLine($"Branchname: {Branch.BranchName} - Manager: {Branch.ManagerName}");

                if (Branch.ManagerAge > 30)
                {
                    Console.WriteLine($"Manager: {Branch.ManagerName}, Age: {Branch.ManagerAge} Branch: {Branch.BranchName}");
                }
            }


            //LINQ query for display the list of manager, whose age is above 30
            Console.WriteLine("\n\n\n\tList of Managers, whose age is above 30\n");
            var bankManager = from manager in managerList
                              join branch in branchList on manager.Id equals branch.ManagerId
                              where manager.Age > 30
                              select new { manager.Name, manager.Age, branch.BranchName };

            foreach(var manager in bankManager)
            {
                Console.WriteLine($"Name:{manager.Name}, Age: {manager.Age}, Branch: {manager.BranchName}");
            }


            //LINQ query for diaplay the Manager who has maxmimum points
            Console.WriteLine("\n\n\n\tThe Manager who has maxmimum points\n");
            var maxPoint = branchList.Max(point => point.MaxPoint);

            var maxPointManager = from manager in managerList
                           join branch in branchList on manager.Id equals branch.ManagerId
                           where (branch.MaxPoint == maxPoint)
                           select new { manager.Name, manager.Id, manager.Age, branch.BranchName, branch.MaxPoint };

            foreach (var manager in maxPointManager)
            {
                Console.WriteLine($"Name: {manager.Name}, Id: {manager.Id}, Age: {manager.Age}, Branch: {manager.BranchName}, Point: {manager.MaxPoint} ");
            }
        }
    }
}
