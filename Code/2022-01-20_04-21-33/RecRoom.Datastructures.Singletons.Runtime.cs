using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class GameRoot : SingletonMonoBehaviour<GameRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class NGOGKPPJBKM : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public GameRoot <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5044B0", Offset = "0x502CB0", VA = "0x1805044B0")]
		[DebuggerHidden]
		public NGOGKPPJBKM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x450A550", Offset = "0x4508D50", VA = "0x18450A550", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x450A400", Offset = "0x4508C00", VA = "0x18450A400", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x450A5C0", Offset = "0x4508DC0", VA = "0x18450A5C0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x450A500", Offset = "0x4508D00", VA = "0x18450A500", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[SerializeField]
	private GameObject StartupObject;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static HashSet<GameObject> NDGDACEDMMK;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static HashSet<UnityEngine.Object> HBOHFKDPAMI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4509E90", Offset = "0x4508690", VA = "0x184509E90")]
	public static void RegisterDontDestroyOnLoad(GameObject LGCHCBHLGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4509F30", Offset = "0x4508730", VA = "0x184509F30")]
	public static void RegisterHideFlagsDontSaveObejct(UnityEngine.Object ANEGDOBGOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4509B40", Offset = "0x4508340", VA = "0x184509B40", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4509FB0", Offset = "0x45087B0", VA = "0x184509FB0")]
	[IteratorStateMachine(typeof(NGOGKPPJBKM))]
	private IEnumerator Start()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "6")]
	protected virtual void ALEFGMMHNME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x450A0A0", Offset = "0x45088A0", VA = "0x18450A0A0")]
	protected GameRoot()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class AEGHGJDOEPN
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2018790", Offset = "0x2016F90", VA = "0x182018790")]
	public static void FNKOCINMEBG<T>(this T NHGFCDFBGDF) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4509A60", Offset = "0x4508260", VA = "0x184509A60")]
	public static void FNKOCINMEBG(this GameObject APMEHMIFMMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class InjectedSingletonMonoBehaviour<TInt, TImpl> : SingletonMonoBehaviour<TImpl> where TInt : class where TImpl : InjectedSingletonMonoBehaviour<TInt, TImpl>, TInt
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1786B40", Offset = "0x1785340", VA = "0x181786B40", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1786D80", Offset = "0x1785580", VA = "0x181786D80", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1786F20", Offset = "0x1785720", VA = "0x181786F20")]
	public InjectedSingletonMonoBehaviour()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ManagedSingletonObject : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static Dictionary<string, ManagedSingletonObject> managedObjects;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[SerializeField]
	private string guid;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public GameObject DEDCIPBDCNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x69D700", Offset = "0x69BF00", VA = "0x18069D700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x450A100", Offset = "0x4508900", VA = "0x18450A100")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x450A320", Offset = "0x4508B20", VA = "0x18450A320")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5083B0", Offset = "0x506BB0", VA = "0x1805083B0")]
	public ManagedSingletonObject()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static T HHKOMLIDDED;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T LFFPMMLBFND
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5025E0", Offset = "0x500DE0", VA = "0x1805025E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool JGFHPKNFPJO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2DE5570", Offset = "0x2DE3D70", VA = "0x182DE5570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2DE5030", Offset = "0x2DE3830", VA = "0x182DE5030", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2DE53B0", Offset = "0x2DE3BB0", VA = "0x182DE53B0", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1F74F00", Offset = "0x1F73700", VA = "0x181F74F00")]
	public SingletonMonoBehaviour()
	{
	}
}
namespace Cpp2IlInjected;

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
