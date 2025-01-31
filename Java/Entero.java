import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.*;

public class Entero {
    private final int num;

    public Entero(int num) {
        this.num = num;
    }

    // Método secuencial para verificar si un número es primo
    public boolean esPrimo() {
        if (num <= 1) return false;
        for (int i = 2; i <= num; i++) {
            if (num % i == 0) {
                return num == i;
            }
        }
        return false;
    }

    // Método asíncrono usando CompletableFuture
    public CompletableFuture<Boolean> esPrimoAsync() {
        return CompletableFuture.supplyAsync(() -> {
            if (num <= 1) return false;
            for (int i = 2; i <= Math.sqrt(num); i++) {
                if (num % i == 0) {
                    return false;
                }
            }
            return true;
        });
    }

    // Método paralelo utilizando hilos manuales
    public boolean esPrimoThreads(int numThreads) {
        if (num <= 1) return false;
        int limit = (int) Math.sqrt(num);
        Thread[] threads = new Thread[numThreads];
        boolean[] isPrime = {true};

        int range = limit / numThreads;
        for (int i = 0; i < numThreads; i++) {
            final int start = 2 + i * range;
            final int end = (i == numThreads - 1) ? limit : start + range;
            threads[i] = new Thread(() -> {
                for (int j = start; j <= end; j++) {
                    if (num % j == 0) {
                        isPrime[0] = false;
                        break;
                    }
                }
            });
            threads[i].start();
        }

        for (Thread thread : threads) {
            try {
                thread.join();
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
        return isPrime[0];
    }

    // Método paralelo utilizando ExecutorService
    public boolean esPrimoParallel(int numThreads) {
        if (num <= 1) return false;
        int limit = (int) Math.sqrt(num);
        ExecutorService executor = Executors.newFixedThreadPool(numThreads);

        try {
            List<Future<Boolean>> futures = new ArrayList<>();
            for (int i = 2; i <= limit; i++) {
                final int divisor = i;
                futures.add(executor.submit(() -> num % divisor != 0));
            }

            for (Future<Boolean> future : futures) {
                if (!future.get()) {
                    return false;
                }
            }
        } catch (InterruptedException | ExecutionException e) {
            e.printStackTrace();
            return false;
        } finally {
            executor.shutdown();
        }
        return true;
    }

    public static void main(String[] args) {
        int testNum = 104729; // Número primo grande para prueba
        int[] threadCounts = {2, 4, 8};
        Entero checker = new Entero(testNum);

        long start, end;

        // Secuencial
        start = System.nanoTime();
        boolean resultSequential = checker.esPrimo();
        end = System.nanoTime();
        System.out.println("Secuencial: " + resultSequential + " | Tiempo: " + (end - start) / 1e6 + " ms");

        // Asíncrono
        start = System.nanoTime();
        boolean resultAsync = checker.esPrimoAsync().join();
        end = System.nanoTime();
        System.out.println("Asíncrono: " + resultAsync + " | Tiempo: " + (end - start) / 1e6 + " ms");

        // Con hilos manuales
        for (int threads : threadCounts) {
            start = System.nanoTime();
            boolean resultThreads = checker.esPrimoThreads(threads);
            end = System.nanoTime();
            System.out.println("Hilos Manuales (" + threads + " hilos): " + resultThreads + " | Tiempo: " + (end - start) / 1e6 + " ms");
        }

        // Paralelo con ExecutorService
        for (int threads : threadCounts) {
            start = System.nanoTime();
            boolean resultParallel = checker.esPrimoParallel(threads);
            end = System.nanoTime();
            System.out.println("ExecutorService (" + threads + " hilos): " + resultParallel + " | Tiempo: " + (end - start) / 1e6 + " ms");
        }
    }
}
