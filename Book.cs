using System;

namespace mycs_project {
    struct Book {
        private string title, actor, description;

        private short pages;

        public void setValues(string title, string actor) {
            this.title = title;
            this.actor = actor;
        }

        public void printValues () {
            Console.WriteLine(this.actor + " - " + this.title);
        }
    }
}