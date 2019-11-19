#https://www.hackerrank.com/challenges/ruby-strings-methods-i/problem
def process_text(strings)
    return strings.map {|s| s.chomp.strip }.join(' ')
end