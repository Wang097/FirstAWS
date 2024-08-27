import { Component } from '@angular/core';
import { FileUploadService } from './file-upload.service';

@Component({
  selector: 'app-file-upload',
  templateUrl: './file-upload.component.html',
})
export class FileUploadComponent {
  selectedFile: File | null = null;

  constructor(private fileUploadService: FileUploadService) {}

  onFileSelected(event: any) {
    this.selectedFile = event.target.files[0];
  }

  onUpload() {
    if (this.selectedFile) {
      this.fileUploadService.upload(this.selectedFile).subscribe(
        (response) => {
          console.log('Upload successful', response);
        },
        (error) => {
          console.error('Upload failed', error);
        }
      );
    }
  }
}
