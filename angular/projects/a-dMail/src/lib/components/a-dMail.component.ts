import { Component, OnInit } from '@angular/core';
import { ADMailService } from '../services/a-dMail.service';

@Component({
  selector: 'lib-a-dMail',
  template: ` <p>a-dMail works!</p> `,
  styles: [],
})
export class ADMailComponent implements OnInit {
  constructor(private service: ADMailService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
