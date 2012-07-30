﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Neo4jClient;
using DoctorWhoUniverse.Services;
using DoctorWhoUniverse.Relationships;

namespace DoctorWhoUniverse
{
    public class DoctorWhoUniverseGenerator
    {
        private GraphClient db;
        public DoctorWhoUniverseGenerator(GraphClient db)
        {
            this.db = db;
        }

        public void GenerateUniverse()
        {
            AddUsers();
        }
        private void AddUsers()
        {
            var userService = new UserService(db);
            var usersNodeReference = userService.EnsureUsersNodeExists();

            var userNodeReference = userService.CreateUser(
                new User() { Username = "BWoodward" }, 
                (NodeReference<Users>)usersNodeReference);
        }
    }
}
