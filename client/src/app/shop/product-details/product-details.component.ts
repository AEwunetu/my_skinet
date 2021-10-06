import { Component, OnInit } from '@angular/core';
import { IProduct } from 'src/app/shared/models/product';
import { ShopService } from '../shop.service';
import { ActivatedRoute } from "@angular/router";
import { BreadcrumbService } from 'xng-breadcrumb';

@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.scss']
})
export class ProductDetailsComponent implements OnInit {
  product: IProduct | null = null;
  
  constructor(
    private shopService: ShopService,
    private activatedRoute: ActivatedRoute,
    private bcService: BreadcrumbService
  ) {
    this.bcService.set("@productDetails", " ");
  }

  ngOnInit(): void {
    this.loadProduct();
  }

  loadProduct() {
    let productId: unknown = this.activatedRoute.snapshot.paramMap.get("id");
    this.shopService.getProduct(productId as number).subscribe(respose => {
      this.product = respose;
      this.bcService.set("@productDetails", this.product.name);
    }, error => {
      console.log(error);
    });
  }

}
