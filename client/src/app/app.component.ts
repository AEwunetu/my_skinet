import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { IPagination } from './models/pagination';
import { IProduct } from './models/product';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title: string = 'Skinet';
  products: IProduct[] = [];

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    //TODO: replace any with IPagination interface
    //When replacing any with IPagination interface there an error with a message of "No overload matches this call."
    this.http.get('https://localhost:5001/api/products').subscribe((respose: any) => {
      this.products = respose.data;
    }, error =>{
      console.log(error);
    });
  }
}
