import { CommonModule, CurrencyPipe, DatePipe, LowerCasePipe } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-employee',
  standalone: true,
  imports: [CommonModule, LowerCasePipe, CurrencyPipe, DatePipe],
  templateUrl: './employee.component.html',
  styleUrl: './employee.component.css'
})
export class EmployeeComponent {
  a = 10; b = 20
  employee = {
    'Id': 1,
    'Name': 'Daniel',
    'Age': 20,
    'Salary': 5000,
    'Dob': "04/10/1997"
  }

  employeeName = "Smith"
  showDiv=false
  showMsg() {
    this.showDiv = !this.showDiv
  }

  

  countries = ["USA", "UK", "Australia"]
}
