using System;


@startuml
Class Journal {
-_entries: list<Entry>
+Write(): void
+Display(): void
+Save(): void
+Load(): void
}
Class Entry {
-_filename: string
-_prompt: int
-_date: string
-_content: string
+Display(): string
}
Class PromptGenerator {
-_prompts: List<String>
+GeneratePrompt(): int
+Display(int): string
}
Entry --> Journal
Journal --> Entry
Journal ..> PromptGenerator
Entry --> PromptGenerator
@enduml

    
    {
        Console.WriteLine("Hello Develop02 World!");
    }
}




