import java.util.Arrays;

public class Xbonacci {

	public double[] tribonacci(double[] s, int n) {
		// hackonacci me
		double[] tri = Arrays.copyOf(s, n);
		for (int i = s.length; i < n; i++) {
			tri[i] = tri[i - 1] + tri[i - 2] + tri[i - 3];
		}
		return tri;
	}
}