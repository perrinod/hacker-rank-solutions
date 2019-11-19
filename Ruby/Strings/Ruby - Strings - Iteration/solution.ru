#https://www.hackerrank.com/challenges/ruby-strings-iteration/problem
def count_multibyte_char(string)
    count = 0
    
    string.each_char do |char|
        if char.bytesize > 1
            count += 1
        end
    end
        
    return count
end
