import { Component, Input, OnInit } from '@angular/core';
import { MaterialType } from '../models/material-type';

@Component({
  selector: 'app-material-type',
  templateUrl: './material-type.component.html',
  styleUrls: ['./material-type.component.css']
})
export class MaterialTypeComponent implements OnInit {
  @Input()
  materialType: MaterialType;

  constructor() { }

  ngOnInit() {
  }

}
