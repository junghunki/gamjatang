public List<Integer> partitionLabels(String S) {
        int[] lastPos = new int[26];
        for (int i = 0; i < S.length(); i++) {
            lastPos[S.charAt(i) - 'a'] = i;
        }

        List<Integer> res = new ArrayList();
        for (int i = 0, j = 0, start = 0; i < S.length(); i++) {
            j = Math.max(j, lastPos[S.charAt(i) - 'a']);
            if (i == j) {
                res.add(i - start + 1);
                start = i + 1;
            }
        }
        return res;
    }
