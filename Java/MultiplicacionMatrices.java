import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.TimeUnit;

public class MultiplicacionMatrices {
    private static final int[] SIZES = {500, 1000, 2000}; // Tamaños de matrices a probar
    private static final int[] THREAD_COUNTS = {2, 4, 8}; // Cantidad de hilos a probar

    public static void main(String[] args) {
        for (int size : SIZES) {
            double[][] A = generateMatrix(size, size);
            double[][] B = generateMatrix(size, size);
            double[][] result;

            System.out.println("Multiplicación de matrices de tamaño: " + size + "x" + size);

            // Versión secuencial
            long start = System.nanoTime();
            result = multiplySequential(A, B);
            long end = System.nanoTime();
            System.out.println("Tiempo secuencial: " + (end - start) / 1e6 + " ms");

            // Versión con hilos manuales
            for (int threads : THREAD_COUNTS) {
                start = System.nanoTime();
                result = multiplyThreads(A, B, threads);
                end = System.nanoTime();
                System.out.println("Tiempo con " + threads + " hilos manuales: " + (end - start) / 1e6 + " ms");
            }

            // Versión con ExecutorService
            for (int threads : THREAD_COUNTS) {
                start = System.nanoTime();
                result = multiplyParallel(A, B, threads);
                end = System.nanoTime();
                System.out.println("Tiempo con " + threads + " hilos (ExecutorService): " + (end - start) / 1e6 + " ms");
            }
            System.out.println();
        }
    }

    // Multiplicación secuencial
    private static double[][] multiplySequential(double[][] A, double[][] B) {
        int n = A.length;
        double[][] C = new double[n][n];
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                for (int k = 0; k < n; k++) {
                    C[i][j] += A[i][k] * B[k][j];
                }
            }
        }
        return C;
    }

    // Multiplicación paralela con hilos manuales
    private static double[][] multiplyThreads(double[][] A, double[][] B, int numThreads) {
        int n = A.length;
        double[][] C = new double[n][n];
        Thread[] threads = new Thread[numThreads];
        int rowsPerThread = (int) Math.ceil((double) n / numThreads);

        for (int threadId = 0; threadId < numThreads; threadId++) {
            final int startRow = threadId * rowsPerThread;
            final int endRow = Math.min(startRow + rowsPerThread, n);
            threads[threadId] = new Thread(() -> {
                for (int i = startRow; i < endRow; i++) {
                    for (int j = 0; j < n; j++) {
                        for (int k = 0; k < n; k++) {
                            C[i][j] += A[i][k] * B[k][j];
                        }
                    }
                }
            });
            threads[threadId].start();
        }

        for (Thread thread : threads) {
            try {
                thread.join();
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
        return C;
    }

    // Multiplicación paralela usando ExecutorService
    private static double[][] multiplyParallel(double[][] A, double[][] B, int numThreads) {
        int n = A.length;
        double[][] C = new double[n][n];
        ExecutorService executor = Executors.newFixedThreadPool(numThreads);
        int rowsPerThread = (int) Math.ceil((double) n / numThreads);

        for (int threadId = 0; threadId < numThreads; threadId++) {
            final int startRow = threadId * rowsPerThread;
            final int endRow = Math.min(startRow + rowsPerThread, n);
            executor.execute(() -> {
                for (int i = startRow; i < endRow; i++) {
                    for (int j = 0; j < n; j++) {
                        for (int k = 0; k < n; k++) {
                            C[i][j] += A[i][k] * B[k][j];
                        }
                    }
                }
            });
        }

        executor.shutdown();
        try {
            executor.awaitTermination(Long.MAX_VALUE, TimeUnit.NANOSECONDS);
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        return C;
    }

    // Generación de matrices aleatorias
    private static double[][] generateMatrix(int rows, int cols) {
        double[][] matrix = new double[rows][cols];
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                matrix[i][j] = Math.random();
            }
        }
        return matrix;
    }
}
