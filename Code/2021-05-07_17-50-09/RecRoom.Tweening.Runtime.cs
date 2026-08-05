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
			[Cpp2IlInjected.Address(RVA = "0x1F1AD70", Offset = "0x1F19B70", VA = "0x181F1AD70")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x3508170", Offset = "0x3506F70", VA = "0x183508170")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x3508120", Offset = "0x3506F20", VA = "0x183508120")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public static class Cubic
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x3506C10", Offset = "0x3505A10", VA = "0x183506C10")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x3506C20", Offset = "0x3505A20", VA = "0x183506C20")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x3506BC0", Offset = "0x35059C0", VA = "0x183506BC0")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class Quartic
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x35081F0", Offset = "0x3506FF0", VA = "0x1835081F0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x3508200", Offset = "0x3507000", VA = "0x183508200")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x3508190", Offset = "0x3506F90", VA = "0x183508190")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class Quintic
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x3508290", Offset = "0x3507090", VA = "0x183508290")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x35082B0", Offset = "0x35070B0", VA = "0x1835082B0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x3508230", Offset = "0x3507030", VA = "0x183508230")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class Sine
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x3508360", Offset = "0x3507160", VA = "0x183508360")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x35083E0", Offset = "0x35071E0", VA = "0x1835083E0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x35082E0", Offset = "0x35070E0", VA = "0x1835082E0")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class Exponential
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3507FC0", Offset = "0x3506DC0", VA = "0x183507FC0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3508070", Offset = "0x3506E70", VA = "0x183508070")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x3507E70", Offset = "0x3506C70", VA = "0x183507E70")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Circular
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x35069A0", Offset = "0x35057A0", VA = "0x1835069A0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x3506A20", Offset = "0x3505820", VA = "0x183506A20")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x35068D0", Offset = "0x35056D0", VA = "0x1835068D0")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class Elastic
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x3507C20", Offset = "0x3506A20", VA = "0x183507C20")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3507D40", Offset = "0x3506B40", VA = "0x183507D40")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3507AF0", Offset = "0x35068F0", VA = "0x183507AF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x35064F0", Offset = "0x35052F0", VA = "0x1835064F0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3506570", Offset = "0x3505370", VA = "0x183506570")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x35063F0", Offset = "0x35051F0", VA = "0x1835063F0")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class Bounce
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x3506760", Offset = "0x3505560", VA = "0x183506760")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x3506830", Offset = "0x3505630", VA = "0x183506830")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x3506640", Offset = "0x3505440", VA = "0x183506640")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x3506C40", Offset = "0x3505A40", VA = "0x183506C40")]
		public static float Ease(float t, Functions function)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3D93B0", Offset = "0x3D81B0", VA = "0x1803D93B0")]
		public static float Linear(float t)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface ITweenBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ITweenBase SetOnComplete(Action callback, bool invokeOnCancel = false);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ITweenBase SetOnCancel(Action callback);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IPromise AsPromise();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool Advance(float dt);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Cancel();
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface ITweenInstance : ITweenBase
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface ITweenSequence : ITweenBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ITweenSequence AddTween(ITweenBase tween);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ITweenSequence AddTween(Func<ITweenBase> tweenFactory);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ITweenSequence AddTweens(IEnumerable<ITweenBase> tweens);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ITweenSequence AddTweens(params ITweenBase[] tweens);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ITweenSequence AddDelay(float seconds);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class CompletedTween : TweenInstance
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3506AA0", Offset = "0x35058A0", VA = "0x183506AA0")]
		public CompletedTween()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3FFBA0", Offset = "0x3FE9A0", VA = "0x1803FFBA0", Slot = "9")]
		public override bool Advance(float dt)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class TweenInstanceColor : TweenInstance<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3508C20", Offset = "0x3507A20", VA = "0x183508C20")]
		public TweenInstanceColor(Func<Color> getter, Action<Color> setter, Color target, float duration, Easing.Functions easeFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x63B9F0", Offset = "0x63A7F0", VA = "0x18063B9F0", Slot = "10")]
		protected override Color GetTargetValue()
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3508BD0", Offset = "0x35079D0", VA = "0x183508BD0", Slot = "11")]
		protected override Color Interpolate(Color start, Color end, float time)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class TweenInstanceFloat : TweenInstance<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3508DA0", Offset = "0x3507BA0", VA = "0x183508DA0")]
		public TweenInstanceFloat(Func<float> getter, Action<float> setter, float target, float duration, Easing.Functions easeFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3508CC0", Offset = "0x3507AC0", VA = "0x183508CC0", Slot = "10")]
		protected override float GetTargetValue()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3508D20", Offset = "0x3507B20", VA = "0x183508D20", Slot = "11")]
		protected override float Interpolate(float start, float end, float time)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class TweenInstanceQuaternion : TweenInstance<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3508F80", Offset = "0x3507D80", VA = "0x183508F80")]
		public TweenInstanceQuaternion(Func<Quaternion> getter, Action<Quaternion> setter, Quaternion target, float duration, Easing.Functions easeFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3508E10", Offset = "0x3507C10", VA = "0x183508E10", Slot = "10")]
		protected override Quaternion GetTargetValue()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3508EE0", Offset = "0x3507CE0", VA = "0x183508EE0", Slot = "11")]
		protected override Quaternion Interpolate(Quaternion start, Quaternion end, float time)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class TweenInstanceVector3 : TweenInstance<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x35091E0", Offset = "0x3507FE0", VA = "0x1835091E0")]
		public TweenInstanceVector3(Func<Vector3> getter, Action<Vector3> setter, Vector3 target, float duration, Easing.Functions easeFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3509020", Offset = "0x3507E20", VA = "0x183509020", Slot = "10")]
		protected override Vector3 GetTargetValue()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3509120", Offset = "0x3507F20", VA = "0x183509120", Slot = "11")]
		protected override Vector3 Interpolate(Vector3 start, Vector3 end, float time)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class Tween
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private struct QueuedTween
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public TweenBase Tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public Action RunTweenFunc;
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class <RunQueuedTweens>d__26 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x3D9350", Offset = "0x3D8150", VA = "0x1803D9350", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x3D9350", Offset = "0x3D8150", VA = "0x1803D9350", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x3D93C0", Offset = "0x3D81C0", VA = "0x1803D93C0")]
			[DebuggerHidden]
			public <RunQueuedTweens>d__26(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3D93B0", Offset = "0x3D81B0", VA = "0x1803D93B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x350BC70", Offset = "0x350AA70", VA = "0x18350BC70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x350BEA0", Offset = "0x350ACA0", VA = "0x18350BEA0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class <ExecuteTween>d__28 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public ITweenBase tween;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x3D9350", Offset = "0x3D8150", VA = "0x1803D9350", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x3D9350", Offset = "0x3D8150", VA = "0x1803D9350", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x3D93C0", Offset = "0x3D81C0", VA = "0x1803D93C0")]
			[DebuggerHidden]
			public <ExecuteTween>d__28(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3D93B0", Offset = "0x3D81B0", VA = "0x1803D93B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x350BAA0", Offset = "0x350A8A0", VA = "0x18350BAA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x350BC20", Offset = "0x350AA20", VA = "0x18350BC20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static readonly List<QueuedTween> QueuedTweens;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly HashSet<TweenBase> ActiveTweens;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly Dictionary<UnityEngine.Object, HashSet<TweenBase>> ActiveTweensByTarget;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static bool _isInitialized;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static ISchedulerPromise runQueuedTweensPromise;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static ITweenBase CompletedTween
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x350BA40", Offset = "0x350A840", VA = "0x18350BA40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x350AFC0", Offset = "0x3509DC0", VA = "0x18350AFC0")]
		public static ITweenInstance TweenFloat(Func<float> getter, Action<float> setter, float target, float duration, Easing.Functions easeFunction, [Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x350B750", Offset = "0x350A550", VA = "0x18350B750")]
		public static ITweenInstance TweenVector3(Func<Vector3> getter, Action<Vector3> setter, Vector3 target, float duration, Easing.Functions easeFunction, [Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x350AEC0", Offset = "0x3509CC0", VA = "0x18350AEC0")]
		public static ITweenInstance TweenColor(Func<Color> getter, Action<Color> setter, Color target, float duration, Easing.Functions easeFunction, [Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x350B5C0", Offset = "0x350A3C0", VA = "0x18350B5C0")]
		public static ITweenInstance TweenLocalScale(Transform target, Vector3 targetScale, float duration, Easing.Functions easeFunction, [Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x350B430", Offset = "0x350A230", VA = "0x18350B430")]
		public static ITweenInstance TweenLocalRotation(Transform target, Quaternion targetRotation, float duration, Easing.Functions easeFunction, [Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x350B0B0", Offset = "0x3509EB0", VA = "0x18350B0B0")]
		public static ITweenInstance TweenLocalPosition(Transform target, Vector3 targetPosition, float duration, Easing.Functions easeFunction, [Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x350B240", Offset = "0x350A040", VA = "0x18350B240")]
		public static ITweenInstance TweenLocalPosition(this Behaviour behaviour, Vector3 targetPosition, float duration, Easing.Functions easeFunction)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x350AD20", Offset = "0x3509B20", VA = "0x18350AD20")]
		public static ITweenSequence Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x350A170", Offset = "0x3508F70", VA = "0x18350A170")]
		public static void CancelAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x350A570", Offset = "0x3509370", VA = "0x18350A570")]
		private static void Queue(Behaviour context, TweenBase tween)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x350A940", Offset = "0x3509740", VA = "0x18350A940")]
		[IteratorStateMachine(typeof(<RunQueuedTweens>d__26))]
		private static IEnumerator<ISchedule> RunQueuedTweens()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x350A990", Offset = "0x3509790", VA = "0x18350A990")]
		private static void Run(Behaviour context, TweenBase sequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x350A320", Offset = "0x3509120", VA = "0x18350A320")]
		[IteratorStateMachine(typeof(<ExecuteTween>d__28))]
		private static IEnumerator<ISchedule> ExecuteTween(ITweenBase tween)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3509FC0", Offset = "0x3508DC0", VA = "0x183509FC0")]
		private static void AddTween(TweenBase tween)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x350A800", Offset = "0x3509600", VA = "0x18350A800")]
		private static void RemoveTween(TweenBase tween)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x350A380", Offset = "0x3509180", VA = "0x18350A380")]
		private static void OnSceneLoaded(Scene _, LoadSceneMode __)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal abstract class TweenBase : ITweenBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[CompilerGenerated]
		private Action Updated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[CompilerGenerated]
		private Action Completed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[CompilerGenerated]
		private Action Canceled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		protected readonly List<Action> OnUpdatedCallbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		protected readonly List<Action> OnCompleteCallbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		protected readonly List<Action> OnCancelCallbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		protected CancelablePromise Promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		internal UnityEngine.Object Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		internal bool InSequence;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		internal bool IsCanceled
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x3508A00", Offset = "0x3507800", VA = "0x183508A00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		internal bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x3508A10", Offset = "0x3507810", VA = "0x183508A10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x3FEA40", Offset = "0x3FD840", VA = "0x1803FEA40", Slot = "6")]
		public IPromise AsPromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x35088A0", Offset = "0x35076A0", VA = "0x1835088A0", Slot = "4")]
		public ITweenBase SetOnComplete(Action callback, bool invokeOnCancel = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3508810", Offset = "0x3507610", VA = "0x183508810", Slot = "5")]
		public ITweenBase SetOnCancel(Action callback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract bool Advance(float dt);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3508450", Offset = "0x3507250", VA = "0x183508450", Slot = "8")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3508700", Offset = "0x3507500", VA = "0x183508700")]
		protected void OnUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x35085D0", Offset = "0x35073D0", VA = "0x1835085D0")]
		protected void OnCompleted()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3508950", Offset = "0x3507750", VA = "0x183508950")]
		protected TweenBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal abstract class TweenInstance : TweenBase, ITweenInstance, ITweenBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		protected bool IsRelative;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		protected readonly float Duration;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected Easing.Functions EaseFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x64D780", Offset = "0x64C580", VA = "0x18064D780")]
			[CompilerGenerated]
			get
			{
				return default(Easing.Functions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x35092C0", Offset = "0x35080C0", VA = "0x1835092C0")]
		protected TweenInstance(float duration, Easing.Functions easeFunction)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal abstract class TweenInstance<TValue> : TweenInstance
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		protected readonly Func<TValue> Getter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		protected readonly Action<TValue> Setter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		protected readonly TValue TargetValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private float elapsed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TValue startValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TValue endValue;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x287C390", Offset = "0x287B190", VA = "0x18287C390")]
		protected TweenInstance(Func<TValue> getter, Action<TValue> setter, TValue targetValue, float duration, Easing.Functions easeFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract TValue GetTargetValue();

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract TValue Interpolate(TValue start, TValue end, float time);

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x287C0C0", Offset = "0x287AEC0", VA = "0x18287C0C0", Slot = "9")]
		public override bool Advance(float dt)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class TweenSequence : TweenBase, ITweenSequence, ITweenBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private enum StepTypes
		{
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			Tween,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			Delay,
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			Callback
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		private struct TweenEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private ITweenBase tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private readonly Func<ITweenBase> factory;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x3508B40", Offset = "0x3507940", VA = "0x183508B40")]
			public TweenEntry(ITweenBase tween)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xCB2830", Offset = "0xCB1630", VA = "0x180CB2830")]
			public TweenEntry(Func<ITweenBase> factory)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x3508A20", Offset = "0x3507820", VA = "0x183508A20")]
			public ITweenBase GetTween()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		private struct Step
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public StepTypes StepType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public IEnumerable<TweenEntry> Tweens;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public Action Callback;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public float DelaySeconds;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly List<Step> steps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int currentStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private float delayTimer;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x3509E80", Offset = "0x3508C80", VA = "0x183509E80")]
		public TweenSequence()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3509480", Offset = "0x3508280", VA = "0x183509480", Slot = "10")]
		public ITweenSequence AddTween(ITweenBase tween)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3509650", Offset = "0x3508450", VA = "0x183509650", Slot = "11")]
		public ITweenSequence AddTween(Func<ITweenBase> tweenFactory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3509830", Offset = "0x3508630", VA = "0x183509830", Slot = "12")]
		public ITweenSequence AddTweens(IEnumerable<ITweenBase> tweens)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x35096E0", Offset = "0x35084E0", VA = "0x1835096E0", Slot = "13")]
		public ITweenSequence AddTweens(params ITweenBase[] tweens)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x35093E0", Offset = "0x35081E0", VA = "0x1835093E0", Slot = "14")]
		public ITweenSequence AddDelay(float seconds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x35099D0", Offset = "0x35087D0", VA = "0x1835099D0", Slot = "9")]
		public override bool Advance(float dt)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3509DC0", Offset = "0x3508BC0", VA = "0x183509DC0")]
		private void PrepareNextStep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3509950", Offset = "0x3508750", VA = "0x183509950")]
		private ITweenSequence AddTweens(TweenEntry[] tweens)
		{
			return null;
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
