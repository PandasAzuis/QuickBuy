import { Injectable, Inject, OnInit } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Product } from "../../model/product";

@Injectable({
  providedIn: "root"
})
export class ProductService implements OnInit{

  private baseURL: string;
  public products: Product[];

  get headers(): HttpHeaders {
    return new HttpHeaders().set('content-type', 'application/json');
  }

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl): string {
    this.baseURL = baseUrl;
  }

  ngOnInit(): void {
    this.products = [];
  }

  public add(product: Product): Observable<Product> {
    return this.http.post<Product>(this.baseURL + "api/product/add",
      JSON.stringify(product),
      { headers: this.headers });
  }

  public update(product: Product): Observable<Product> {
    return this.http.post<Product>(this.baseURL + "api/product/update",
      JSON.stringify(product),
      { headers: this.headers });
  }

  public delete(product: Product): Observable<Product> {
    return this.http.post<Product>(this.baseURL + "api/product/delete",
      JSON.stringify(product),
      { headers: this.headers });
  }

  public getAllProduct(): Observable<Product[]> {
    return this.http.get<Product[]>(this.baseURL + "api/product");
  }

  public getProduct(product:Product): Observable<Product> {
    return this.http.get<Product>(this.baseURL + "api/product");
  }
}
