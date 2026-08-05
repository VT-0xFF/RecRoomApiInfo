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
	private sealed class IKBEMDECLKM : IEnumerator<object>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x66D7D0", Offset = "0x66C3D0", VA = "0x18066D7D0")]
		[DebuggerHidden]
		public IKBEMDECLKM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4E3B800", Offset = "0x4E3A400", VA = "0x184E3B800", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4E3B690", Offset = "0x4E3A290", VA = "0x184E3B690", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4E3B870", Offset = "0x4E3A470", VA = "0x184E3B870")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4E3B7B0", Offset = "0x4E3A3B0", VA = "0x184E3B7B0", Slot = "8")]
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
	private static HashSet<GameObject> DJLHHMJMGLI;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static HashSet<UnityEngine.Object> EHCLPOPOCLP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B400", Offset = "0x4E3A000", VA = "0x184E3B400")]
	public static void RegisterDontDestroyOnLoad(GameObject NANGEAKDCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B4A0", Offset = "0x4E3A0A0", VA = "0x184E3B4A0")]
	public static void RegisterHideFlagsDontSaveObejct(UnityEngine.Object NJBMHJCLPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B0B0", Offset = "0x4E39CB0", VA = "0x184E3B0B0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B520", Offset = "0x4E3A120", VA = "0x184E3B520")]
	[IteratorStateMachine(typeof(IKBEMDECLKM))]
	private IEnumerator Start()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "6")]
	protected virtual void LOBBMKGKMKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B630", Offset = "0x4E3A230", VA = "0x184E3B630")]
	protected GameRoot()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class MIHIEFEOIHC
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x311B370", Offset = "0x3119F70", VA = "0x18311B370")]
	public static void ENIEIFCKJOM<T>(this T MHMLJIFKLGF) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B930", Offset = "0x4E3A530", VA = "0x184E3B930")]
	public static void ENIEIFCKJOM(this GameObject JNOODOEOLDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class InjectedSingletonMonoBehaviour<TInt, TImpl> : SingletonMonoBehaviour<TImpl> where TInt : class where TImpl : InjectedSingletonMonoBehaviour<TInt, TImpl>, TInt
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x33E0850", Offset = "0x33DF450", VA = "0x1833E0850", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x33E0A90", Offset = "0x33DF690", VA = "0x1833E0A90", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x33E0C30", Offset = "0x33DF830", VA = "0x1833E0C30")]
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
	public GameObject NIMEGOBBGCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xE7F230", Offset = "0xE7DE30", VA = "0x180E7F230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4E3BA10", Offset = "0x4E3A610", VA = "0x184E3BA10")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4E3BC30", Offset = "0x4E3A830", VA = "0x184E3BC30")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xCEA600", Offset = "0xCE9200", VA = "0x180CEA600")]
	public ManagedSingletonObject()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static T GHFDJGDGHGD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T PMDDBIJFNMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xD1B020", Offset = "0xD19C20", VA = "0x180D1B020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool LBIJBKHNALH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2906830", Offset = "0x2905430", VA = "0x182906830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x29062E0", Offset = "0x2904EE0", VA = "0x1829062E0", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2906670", Offset = "0x2905270", VA = "0x182906670", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x28FB780", Offset = "0x28FA380", VA = "0x1828FB780")]
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
