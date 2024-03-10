// Import necessary Angular modules and components
import { Component, OnInit } from '@angular/core';
import { OtherService } from '../../services/other.service'; // Import OtherService for fetching other data

@Component({
  selector: 'app-other-list',
  templateUrl: './other-list.component.html',
  styleUrls: ['./other-list.component.css']
})
export class OtherListComponent implements OnInit {
  otherData: any[] = []; // Array to store other data

  // Constructor for injecting OtherService
  constructor(private otherService: OtherService) { }

  // Method called when component initializes
  ngOnInit(): void {
    this.loadOtherData(); // Load other data
  }

  // Method to fetch other data using OtherService
  loadOtherData(): void {
    this.otherService.getOtherData()
      .subscribe((data: any[]) => { // Subscribe to the observable to get other data
        this.otherData = data; // Assign fetched other data to otherData array
      });
  }
}
