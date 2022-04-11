import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { SentenceService } from '../../services/sentence.service';
import { WordGeneratorService } from '../../services/wordgenerator.service';
import { first } from 'rxjs/operators';

@Component({
  selector: 'app-words',
  templateUrl: './words.component.html',
  styleUrls: ['./words.component.css']
})
export class WordsComponent implements OnInit {

  words: any;
  constructor(private formBuilder: FormBuilder,
    private route: ActivatedRoute,
    private router: Router,
    private sentenceService: SentenceService,
    private wordGeneratorService: WordGeneratorService) { }

  ngOnInit(): void { }

  fetchWords(type: string): any {
    this.wordGeneratorService.generateWords(type).pipe(first()).subscribe(words => this.words = words);
  }

}
