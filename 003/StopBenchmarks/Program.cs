// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using StopBenchmarks;

var summary = BenchmarkRunner.Run<UsingDebug>();