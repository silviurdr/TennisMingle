import { ToastrService } from 'ngx-toastr';
import { AccountService } from './../_services/account.service';
import { Injectable } from '@angular/core';
import {
  CanActivate,
  ActivatedRouteSnapshot,
  RouterStateSnapshot,
  UrlTree,
} from '@angular/router';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root',
})
export class AdminGuard implements CanActivate {
  constructor(
    private accountService: AccountService,
    private toastr: ToastrService
  ) {}

  canActivate(): Observable<boolean> {
    console.log(this.accountService.currentUser$);
    return this.accountService.currentUser$.pipe(
      map((user) => {
        if (user.roles.includes('Administrator')) {
          return true;
        }
        this.toastr.error('You cannot enter this area');
      })
    );
  }
}
