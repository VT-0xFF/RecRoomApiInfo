using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class GameRoot : SingletonMonoBehaviour<GameRoot>
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static List<WeakReference<GameObject>> MKPNFDECIEG;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static HashSet<UnityEngine.Object> MKANMFIGDHD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5FCEC00", Offset = "0x5FCDA00", VA = "0x185FCEC00")]
	public static void RegisterDontDestroyOnLoad(GameObject FEGJFGOAMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5FCED60", Offset = "0x5FCDB60", VA = "0x185FCED60")]
	public static void RegisterHideFlagsDontSaveObject(UnityEngine.Object NHLNHJGAONN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5FCE620", Offset = "0x5FCD420", VA = "0x185FCE620", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5FCE6E0", Offset = "0x5FCD4E0", VA = "0x185FCE6E0")]
	private void IHNNCPCPMMH(Scene KMNFMOKGKCG, Scene PIFKLLIIGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5FCE830", Offset = "0x5FCD630", VA = "0x185FCE830", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "6")]
	protected virtual void HGMMKHJKDGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5FCEEE0", Offset = "0x5FCDCE0", VA = "0x185FCEEE0")]
	protected GameRoot()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HEFBPBGHNOB
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2711A50", Offset = "0x2710850", VA = "0x182711A50")]
	public static void MELEDNOOHJE<T>(this T EIFNJBJEIMP) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5FCEF20", Offset = "0x5FCDD20", VA = "0x185FCEF20")]
	public static void MELEDNOOHJE(this GameObject IPHCMOEHILB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class InjectedSingletonMonoBehaviour<TInt, TImpl> : SingletonMonoBehaviour<TImpl> where TInt : class where TImpl : InjectedSingletonMonoBehaviour<TInt, TImpl>, TInt
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3885F60", Offset = "0x3884D60", VA = "0x183885F60", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x38860B0", Offset = "0x3884EB0", VA = "0x1838860B0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3886170", Offset = "0x3884F70", VA = "0x183886170")]
	public InjectedSingletonMonoBehaviour()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ManagedSingletonObject : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static Dictionary<string, ManagedSingletonObject> managedObjects;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	private string guid;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public GameObject MNCNLOJBGMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xB1F1A0", Offset = "0xB1DFA0", VA = "0x180B1F1A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5FCF0B0", Offset = "0x5FCDEB0", VA = "0x185FCF0B0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5FCF2F0", Offset = "0x5FCE0F0", VA = "0x185FCF2F0")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5B0", Offset = "0x7A93B0", VA = "0x1807AA5B0")]
	public ManagedSingletonObject()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static T NNOMIIGCPPJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static T AHFNEPHAKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3780880", Offset = "0x377F680", VA = "0x183780880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static bool LICKKMNBHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4225CF0", Offset = "0x4224AF0", VA = "0x184225CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4225970", Offset = "0x4224770", VA = "0x184225970", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4225C30", Offset = "0x4224A30", VA = "0x184225C30", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5B0", Offset = "0x7A93B0", VA = "0x1807AA5B0")]
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
