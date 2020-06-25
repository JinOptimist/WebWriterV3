import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IBookModel, BookModel } from 'src/app/models/models';

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

  public Get(url: string) {
    var promise = this.http.get<IBookModel>(this.baseUrl + url);
    promise.subscribe(
      answer => { },
      error => {
        console.error(error);
      });
    return promise;
  }

  public Post(url: string, model: object) {
    var promise = this.http.post<IBookModel>(this.baseUrl + url, model);
    promise.subscribe(
      answer => { },
      error => {
        console.error(error);
      });
    return promise;
  }



}
