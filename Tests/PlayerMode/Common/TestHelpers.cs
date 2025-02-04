using System;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

public static class TestHelpers {
    public const string UNIFORM = "SquareUniform";
    public const string UN_UNIFORM = "SquareUnUniform";
    public const string ROTATED = "SquareRotated";
    public const string UNIFORM_ROTATION_INVARIANT = "SquareUniformRotationInvariant";
    public const string UNIFORM_DIRECTION_INVARIANT = "SquareUniformDirectionInvariant";
    public const string UNIFORM_ROTATION_INVARIANT_DIRECTION_INVARIANT = "SquareUniformRotationInvariantDirectionInvariant";

    public static List<TestGesturePattern> PopulateAsset(TestGesturePattern pattern, int Length) {
        var patternList = new List<TestGesturePattern>(Length);

        for (int i = 0; i < Length; i++) {
            patternList.Add(pattern);
        }

        return patternList;
    }

    public static NativeArray<float2> PathToNative(ReadOnlySpan<Vector2> path) {
        var buffer = new NativeArray<float2>(path.Length, Allocator.Temp);

        for (int o = 0; o < path.Length; o++) {
            buffer[o] = path[o];
        }

        return buffer;
    }

    public static TestGesturePattern LoadGesture(string path) {
        var pattern = Resources.Load<TestGesturePattern>(path);
        return pattern;
    }
}
