// user-list.component.ts

import { Component, OnInit } from '@angular/core';
import { UserService } from '../../../services/user.service'; // Importing the user service  

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.css']
})
export class UserListComponent implements OnInit {
  users: any[] = []; // Array to store users

  constructor(private userService: UserService) { } // Injecting the UserService

  ngOnInit(): void {
    this.loadUsers(); // Load users when component initializes
  }

  loadUsers(): void {
    this.userService.getUsers() // Call getUsers method from the UserService to fetch users
      .subscribe(users => {
        this.users = users; // Assign fetched users to the users array
      });
  }
}
