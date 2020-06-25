import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})

export class HttpHelper {
  private http: HttpClient;
  private baseUrl: string;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.http = http;
    this.baseUrl = baseUrl;
  }

  public Get<T>(url: string) : Promise<T> {
    var promise = this.http.get<T>(this.baseUrl + url).toPromise();
    promise.then(
      answer => { },
      error => {
        console.error(error);
      });
    return promise;
  }

  public Post<T>(url: string, model: object): Promise<T> {
    var promise = this.http.post<T>(this.baseUrl + url, model).toPromise();
    promise.then(
      answer => { },
      error => {
        console.error(error);
      });
    return promise;
  }



}
