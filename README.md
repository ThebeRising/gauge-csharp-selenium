# gauge-csharp-selenium
Base Gauge with Selenium Solution

#How to run the project:

default:no rows specified, using IE as browser, and running all specs  
->nant

for specifying the number of rows..
-> nant build -D:rows="--table-rows=1"

for specifying the browser
-> nant build -D:browser="--env=chrome"

for excluding specs
-> nant build -D:spec="\Spec.spec"
