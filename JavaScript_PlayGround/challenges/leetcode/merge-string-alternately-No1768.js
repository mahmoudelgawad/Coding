/**
 * @param {string} word1
 * @param {string} word2
 * @return {string}
 */
var mergeAlternately = function(word1, word2) {
    let merge='';
    const maxLength = Math.max(word1.length,word2.length);
    for(let i = 0; i < maxLength ; i++){
       merge +=i < word1.length ? word1[i] : '';
       merge +=i < word2.length ? word2[i] : '';
    }
    return merge;
};

var output = "apbqcr";
var result = mergeAlternately("abc","pqr");
console.log(result === output, output, result);

output = "apbqrs";
result = mergeAlternately("ab","pqrs");
console.log(result === output, output, result);


result = mergeAlternately("abcd","pq");
output = "apbqcd";
console.log(mergeAlternately("abcd","pq") === output, output,result);