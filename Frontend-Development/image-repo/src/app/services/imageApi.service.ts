import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { user } from '../models/user';
import { image } from '../models/image';

@Injectable({
  providedIn: 'root'
})
export class ImageService {
  baseURL: string = environment.ImageAPI;
  userURL: string = this.baseURL + '/User';
  imageURL: string = this.baseURL + '/Image';

  constructor(private http: HttpClient) { }

  GetUserByEmail(email: string): Promise<user> {
    return this.http.get<user>(`${this.userURL}/${email}`).toPromise();
  }

  AddUser(newUser: user): Promise<user> {
    return this.http.post<user>(this.userURL, newUser).toPromise();
  }

  AddImage(newImage: image): Promise<image> {
    return this.http.post<image>(this.imageURL, newImage).toPromise();
  }

  GetAllVisableImagesByUser(userId: number): Promise<image[]> {
    return this.http.get<image[]>(`${this.imageURL}/${userId}`).toPromise();
  }
}
