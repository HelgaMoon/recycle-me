import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MaterialType } from '../../models/material-type';

@Component({
  selector: 'app-material-type',
  templateUrl: './material-type.component.html',
  styleUrls: ['./material-type.component.css']
})
export class MaterialTypeComponent implements OnInit {

  id: number;
  materialType: MaterialType = { id: 2, name: "Металл", image: "" };

  constructor(private route: ActivatedRoute) { }

  ngOnInit() {
    this.id = +this.route.snapshot.paramMap.get('id');
  }

}
