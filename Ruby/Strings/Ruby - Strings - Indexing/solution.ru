#https://www.hackerrank.com/challenges/ruby-strings-indexing/problem
def serial_average(string)
    return "#{string[0,4]}#{((string[4,5].to_f + string[10,5].to_f) / 2).round(2)}"
end
