import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MaterialSubType } from '../../models/material-subtype';

@Component({
  selector: 'app-material-subtype',
  templateUrl: './material-subtype.component.html',
  styleUrls: ['./material-subtype.component.css']
})
export class MaterialSubTypeComponent implements OnInit {

  id: number;
  materialSubType: MaterialSubType = { id: 1, name: "PET", materialTypeId: 1, materialTypeName:"Пластик", image: "", description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. " };

  constructor(private route: ActivatedRoute) { }

  ngOnInit() {
    this.id = +this.route.snapshot.paramMap.get('id');
  }

}
