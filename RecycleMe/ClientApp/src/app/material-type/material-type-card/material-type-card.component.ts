import { Component, Input, OnInit } from '@angular/core';
import { MaterialType } from '../../models/material-type';

@Component({
  selector: 'app-material-type-card',
  templateUrl: './material-type-card.component.html',
  styleUrls: ['./material-type-card.component.css']
})
export class MaterialTypeCardComponent implements OnInit {
  @Input()
  materialType: MaterialType;

  constructor() { }

  ngOnInit() {
  }

}
