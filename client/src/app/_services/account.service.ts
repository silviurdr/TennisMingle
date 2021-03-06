import { Injectable } from '@angular/core';
import { HttpClient, JsonpClientBackend } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { User } from '../_models/user';
import { BehaviorSubject, ReplaySubject } from 'rxjs';
import { UserForRegister } from '../_models/userForRegister';

@Injectable({
  providedIn: 'root',
})
export class AccountService {
  baseUrl = 'https://localhost:5001/api/';
  private currentUserSource: ReplaySubject<User> = new ReplaySubject<User>(1);
  private newUserSource = new ReplaySubject<UserForRegister>(1);
  currentUser$ = this.currentUserSource.asObservable();

  constructor(private http: HttpClient) {}

  login(model: any) {
    console.log(model);
    return this.http.post<User>(this.baseUrl + 'account/login', model).pipe(
      map((response: User) => {
        const user = response;
        if (user) {
          console.log(user);
          this.setCurrentUser(user);
        } else {
          console.log('nu e userrrrr');
        }
        console.log(user);
      })
    );
  }

  register(model: any) {
    return this.http
      .post<UserForRegister>(this.baseUrl + 'account/register', model)
      .pipe(
        map((user: UserForRegister) => {
          if (user) {
            localStorage.setItem('user', JSON.stringify(user));
            this.newUserSource.next(user);
          }
        })
      );
  }

  setCurrentUser(user: User) {
    user.roles = [];
    const roles = this.getDecodedToken(user.token).role;
    Array.isArray(roles) ? (user.roles = roles) : user.roles.push(roles);
    localStorage.setItem('user', JSON.stringify(user));
    this.currentUserSource.next(user);
    console.log(user);
  }

  logout() {
    localStorage.removeItem('user');
    this.currentUserSource.next(null);
  }

  getDecodedToken(token) {
    return JSON.parse(atob(token.split('.')[1]));
  }
}
