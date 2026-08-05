using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Async;
using RecRoom.Core;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Tweening
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class Easing
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		public enum Functions
		{
			[Cpp2IlInjected.Token(Token = "0x4000002")]
			Linear,
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			QuadraticEaseIn,
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			QuadraticEaseOut,
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			QuadraticEaseInOut,
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			CubicEaseIn,
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			CubicEaseOut,
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			CubicEaseInOut,
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			QuarticEaseIn,
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			QuarticEaseOut,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			QuarticEaseInOut,
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			QuinticEaseIn,
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			QuinticEaseOut,
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			QuinticEaseInOut,
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			SineEaseIn,
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			SineEaseOut,
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			SineEaseInOut,
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			CircularEaseIn,
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			CircularEaseOut,
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			CircularEaseInOut,
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			ExponentialEaseIn,
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			ExponentialEaseOut,
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			ExponentialEaseInOut,
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			ElasticEaseIn,
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			ElasticEaseOut,
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			ElasticEaseInOut,
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			BackEaseIn,
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			BackEaseOut,
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			BackEaseInOut,
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			BounceEaseIn,
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			BounceEaseOut,
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			BounceEaseInOut
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public static class Quadratic
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7E6000", Offset = "0x7E4800", VA = "0x1807E6000")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x33F4F30", Offset = "0x33F3730", VA = "0x1833F4F30")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x33F4EE0", Offset = "0x33F36E0", VA = "0x1833F4EE0")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public static class Cubic
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x33F39D0", Offset = "0x33F21D0", VA = "0x1833F39D0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x33F39E0", Offset = "0x33F21E0", VA = "0x1833F39E0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x33F3980", Offset = "0x33F2180", VA = "0x1833F3980")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class Quartic
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x33F4FB0", Offset = "0x33F37B0", VA = "0x1833F4FB0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x33F4FC0", Offset = "0x33F37C0", VA = "0x1833F4FC0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x33F4F50", Offset = "0x33F3750", VA = "0x1833F4F50")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class Quintic
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x33F5050", Offset = "0x33F3850", VA = "0x1833F5050")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x33F5070", Offset = "0x33F3870", VA = "0x1833F5070")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x33F4FF0", Offset = "0x33F37F0", VA = "0x1833F4FF0")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class Sine
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x33F5120", Offset = "0x33F3920", VA = "0x1833F5120")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x33F51A0", Offset = "0x33F39A0", VA = "0x1833F51A0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x33F50A0", Offset = "0x33F38A0", VA = "0x1833F50A0")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class Exponential
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x33F4D80", Offset = "0x33F3580", VA = "0x1833F4D80")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x33F4E30", Offset = "0x33F3630", VA = "0x1833F4E30")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x33F4C30", Offset = "0x33F3430", VA = "0x1833F4C30")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Circular
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x33F3880", Offset = "0x33F2080", VA = "0x1833F3880")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x33F3900", Offset = "0x33F2100", VA = "0x1833F3900")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x33F37B0", Offset = "0x33F1FB0", VA = "0x1833F37B0")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class Elastic
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x33F49E0", Offset = "0x33F31E0", VA = "0x1833F49E0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x33F4B00", Offset = "0x33F3300", VA = "0x1833F4B00")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x33F48B0", Offset = "0x33F30B0", VA = "0x1833F48B0")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class Back
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static float s;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private static float s2;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x33F33D0", Offset = "0x33F1BD0", VA = "0x1833F33D0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x33F3450", Offset = "0x33F1C50", VA = "0x1833F3450")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x33F32D0", Offset = "0x33F1AD0", VA = "0x1833F32D0")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class Bounce
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x33F3640", Offset = "0x33F1E40", VA = "0x1833F3640")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x33F3710", Offset = "0x33F1F10", VA = "0x1833F3710")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x33F3520", Offset = "0x33F1D20", VA = "0x1833F3520")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x33F3A00", Offset = "0x33F2200", VA = "0x1833F3A00")]
		public static float Ease(float t, Functions function)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3DBF60", Offset = "0x3DA760", VA = "0x1803DBF60")]
		public static float Linear(float t)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface ITweenInstance
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ITweenInstance SetOnComplete(Action callback);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ICancelablePromise AsPromise();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Kill();
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class TweenInstanceColor : TweenInstance<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x33F5220", Offset = "0x33F3A20", VA = "0x1833F5220")]
		public TweenInstanceColor(Func<Color> getter, Action<Color> setter, Color target, float duration, Easing.Functions easeFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x33F5210", Offset = "0x33F3A10", VA = "0x1833F5210", Slot = "7")]
		internal override Color GetTargetValue()
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xE723F0", Offset = "0xE70BF0", VA = "0x180E723F0", Slot = "8")]
		internal override Color Interpolate(Color start, Color end, float time)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class TweenInstanceFloat : TweenInstance<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x33F53A0", Offset = "0x33F3BA0", VA = "0x1833F53A0")]
		public TweenInstanceFloat(Func<float> getter, Action<float> setter, float target, float duration, Easing.Functions easeFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x33F52C0", Offset = "0x33F3AC0", VA = "0x1833F52C0", Slot = "7")]
		internal override float GetTargetValue()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x33F5320", Offset = "0x33F3B20", VA = "0x1833F5320", Slot = "8")]
		internal override float Interpolate(float start, float end, float time)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class TweenInstanceQuaternion : TweenInstance<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x33F5580", Offset = "0x33F3D80", VA = "0x1833F5580")]
		public TweenInstanceQuaternion(Func<Quaternion> getter, Action<Quaternion> setter, Quaternion target, float duration, Easing.Functions easeFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x33F5410", Offset = "0x33F3C10", VA = "0x1833F5410", Slot = "7")]
		internal override Quaternion GetTargetValue()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x33F54E0", Offset = "0x33F3CE0", VA = "0x1833F54E0", Slot = "8")]
		internal override Quaternion Interpolate(Quaternion start, Quaternion end, float time)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class TweenInstanceVector3 : TweenInstance<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x33F57E0", Offset = "0x33F3FE0", VA = "0x1833F57E0")]
		public TweenInstanceVector3(Func<Vector3> getter, Action<Vector3> setter, Vector3 target, float duration, Easing.Functions easeFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x33F5620", Offset = "0x33F3E20", VA = "0x1833F5620", Slot = "7")]
		internal override Vector3 GetTargetValue()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x33F5720", Offset = "0x33F3F20", VA = "0x1833F5720", Slot = "8")]
		internal override Vector3 Interpolate(Vector3 start, Vector3 end, float time)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class Tween
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class <ExecuteTween>d__19<TValue> : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public TweenInstance<TValue> tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TValue <endValue>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TValue <startValue>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private float <elapsed>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x3D3240", Offset = "0x3D1A40", VA = "0x1803D3240", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x3D3240", Offset = "0x3D1A40", VA = "0x1803D3240", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x1B4DD90", Offset = "0x1B4C590", VA = "0x181B4DD90")]
			[DebuggerHidden]
			public <ExecuteTween>d__19(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x3DBF60", Offset = "0x3DA760", VA = "0x1803DBF60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x21E23D0", Offset = "0x21E0BD0", VA = "0x1821E23D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x21E2EE0", Offset = "0x21E16E0", VA = "0x1821E2EE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static readonly HashSet<ITweenInstance> ActiveTweens;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly Dictionary<UnityEngine.Object, HashSet<ITweenInstance>> ActiveTweensByTarget;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static bool _isInitialized;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x33F5BA0", Offset = "0x33F43A0", VA = "0x1833F5BA0")]
		public static ITweenInstance TweenFloat(Func<float> getter, Action<float> setter, float target, float duration, Easing.Functions easeFunction, [Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x33F6330", Offset = "0x33F4B30", VA = "0x1833F6330")]
		public static ITweenInstance TweenVector3(Func<Vector3> getter, Action<Vector3> setter, Vector3 target, float duration, Easing.Functions easeFunction, [Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x33F5AA0", Offset = "0x33F42A0", VA = "0x1833F5AA0")]
		public static ITweenInstance TweenColor(Func<Color> getter, Action<Color> setter, Color target, float duration, Easing.Functions easeFunction, [Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x33F61A0", Offset = "0x33F49A0", VA = "0x1833F61A0")]
		public static ITweenInstance TweenLocalScale(Transform target, Vector3 targetScale, float duration, Easing.Functions easeFunction, [Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x33F6010", Offset = "0x33F4810", VA = "0x1833F6010")]
		public static ITweenInstance TweenLocalRotation(Transform target, Quaternion targetRotation, float duration, Easing.Functions easeFunction, [Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x33F5C90", Offset = "0x33F4490", VA = "0x1833F5C90")]
		public static ITweenInstance TweenLocalPosition(Transform target, Vector3 targetPosition, float duration, Easing.Functions easeFunction, [Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x33F5E20", Offset = "0x33F4620", VA = "0x1833F5E20")]
		public static ITweenInstance TweenLocalPosition(this Behaviour behaviour, Vector3 targetPosition, float duration, Easing.Functions easeFunction)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x33F5880", Offset = "0x33F4080", VA = "0x1833F5880")]
		public static void KillAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x223A4D0", Offset = "0x2238CD0", VA = "0x18223A4D0")]
		private static ITweenInstance Run<TValue>(Behaviour context, TweenInstance<TValue> tween)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1649440", Offset = "0x1647C40", VA = "0x181649440")]
		[IteratorStateMachine(typeof(<ExecuteTween>d__19<>))]
		private static IEnumerator<ISchedule> ExecuteTween<TValue>(TweenInstance<TValue> tween)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1F46EF0", Offset = "0x1F456F0", VA = "0x181F46EF0")]
		private static void AddTween<TValue>(TweenInstance<TValue> tween)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1C0A810", Offset = "0x1C09010", VA = "0x181C0A810")]
		private static void RemoveTween<TValue>(TweenInstance<TValue> tween)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x33F5A50", Offset = "0x33F4250", VA = "0x1833F5A50")]
		private static void OnSceneLoaded(Scene _, LoadSceneMode __)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal abstract class TweenInstance<TValue> : ITweenInstance
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[CompilerGenerated]
		private Action Updated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[CompilerGenerated]
		private Action Completed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		internal readonly Func<TValue> Getter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		internal readonly Action<TValue> Setter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		internal readonly float Duration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		protected readonly TValue TargetValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		protected bool IsRelative;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly List<Action> onCompleteCallbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		internal UnityEngine.Object Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		internal ISchedulerPromise Promise;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal Easing.Functions EaseFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x4F5950", Offset = "0x4F4150", VA = "0x1804F5950")]
			[CompilerGenerated]
			get
			{
				return default(Easing.Functions);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x50F530", Offset = "0x50DD30", VA = "0x18050F530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x21E1AB0", Offset = "0x21E02B0", VA = "0x1821E1AB0")]
		protected TweenInstance(Func<TValue> getter, Action<TValue> setter, TValue targetValue, float duration, Easing.Functions easeFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x21E1740", Offset = "0x21DFF40", VA = "0x1821E1740", Slot = "4")]
		public ITweenInstance SetOnComplete(Action callback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x21E0B60", Offset = "0x21DF360", VA = "0x1821E0B60", Slot = "6")]
		public void Kill()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4AC850", Offset = "0x4AB050", VA = "0x1804AC850", Slot = "5")]
		public ICancelablePromise AsPromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "7")]
		internal abstract TValue GetTargetValue();

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "8")]
		internal abstract TValue Interpolate(TValue start, TValue end, float time);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7446B0", Offset = "0x742EB0", VA = "0x1807446B0")]
		internal void OnUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x21E0EC0", Offset = "0x21DF6C0", VA = "0x1821E0EC0")]
		internal void OnCompleted()
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
