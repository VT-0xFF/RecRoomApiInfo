using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Mono.Math;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class KDFAKNMNOFI : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6EE3E0", Offset = "0x6ED5E0", VA = "0x1806EE3E0")]
	public KDFAKNMNOFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5101B60", Offset = "0x5100D60", VA = "0x185101B60")]
	public byte[] KGIALFINFCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void MCAPMOEJOLH(IncrementalHash AGODCCIEBMA);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xD5FE50", Offset = "0xD5F050", VA = "0x180D5FE50")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[LEJFMHDCMJG]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	[HideInInspector]
	[LEJFMHDCMJG]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x51065D0", Offset = "0x51057D0", VA = "0x1851065D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5106590", Offset = "0x5105790", VA = "0x185106590")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5106610", Offset = "0x5105810", VA = "0x185106610")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5106820", Offset = "0x5105A20", VA = "0x185106820")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5106790", Offset = "0x5105990", VA = "0x185106790")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xF17C60", Offset = "0xF16E60", VA = "0x180F17C60")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xE78590", Offset = "0xE77790", VA = "0x180E78590")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5106550", Offset = "0x5105750", VA = "0x185106550")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5106700", Offset = "0x5105900", VA = "0x185106700")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5105F80", Offset = "0x5105180", VA = "0x185105F80")]
	public void CopyBounds(SavedExtents MKCNOIKIBCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x51064C0", Offset = "0x51056C0", VA = "0x1851064C0")]
	public void SetLocalSpaceBounds(Bounds JPIBIANMPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8A1390", Offset = "0x8A0590", VA = "0x1808A1390")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x51064B0", Offset = "0x51056B0", VA = "0x1851064B0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5105FB0", Offset = "0x51051B0", VA = "0x185105FB0")]
	private void DBAPMBDCKLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5106280", Offset = "0x5105480", VA = "0x185106280")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x51059C0", Offset = "0x5104BC0", VA = "0x1851059C0")]
	public static void CalculateLocalBoundsFor(GameObject BCGNPHHHPEM, out Bounds JPIBIANMPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x51061C0", Offset = "0x51053C0", VA = "0x1851061C0")]
	private static void NDHNFNOMGNG(Bounds DLFOEJDCAKP, Color DIHFAACINDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x51064E0", Offset = "0x51056E0", VA = "0x1851064E0")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x58A1D0", Offset = "0x5893D0", VA = "0x18058A1D0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x58AEE0", Offset = "0x58A0E0", VA = "0x18058AEE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x58A4A0", Offset = "0x5896A0", VA = "0x18058A4A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "4")]
	public virtual void JPNKLDJEJML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[KDFAKNMNOFI]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2A737A0", Offset = "0x2A729A0", VA = "0x182A737A0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2A732E0", Offset = "0x2A724E0", VA = "0x182A732E0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2A73DA0", Offset = "0x2A72FA0", VA = "0x182A73DA0")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class BCGNLEMKNDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
		public BCGNLEMKNDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x273BDF0", Offset = "0x273AFF0", VA = "0x18273BDF0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[KDFAKNMNOFI]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x58A1D0", Offset = "0x5893D0", VA = "0x18058A1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2740410", Offset = "0x273F610", VA = "0x182740410", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2740440", Offset = "0x273F640", VA = "0x182740440", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2740360", Offset = "0x273F560", VA = "0x182740360", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal this[TKey ICIBGJCBOAM]
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2740390", Offset = "0x273F590", VA = "0x182740390", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2740260", Offset = "0x273F460", VA = "0x182740260", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x273FAC0", Offset = "0x273ECC0", VA = "0x18273FAC0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x273F430", Offset = "0x273E630", VA = "0x18273F430", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x273EFD0", Offset = "0x273E1D0", VA = "0x18273EFD0", Slot = "14")]
	protected virtual string BINPIKNJKGH(TKeyVal DBPFPIJDKEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x273F000", Offset = "0x273E200", VA = "0x18273F000", Slot = "4")]
	public bool ContainsKey(TKey ICIBGJCBOAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2740150", Offset = "0x273F350", VA = "0x182740150", Slot = "5")]
	public bool TryGetValue(TKey ICIBGJCBOAM, out TVal LDPMPDNIHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x273F030", Offset = "0x273E230", VA = "0x18273F030", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x273F030", Offset = "0x273E230", VA = "0x18273F030", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2740180", Offset = "0x273F380", VA = "0x182740180")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class ACGGGFBPCLP<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class HLLANHOKKHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
		public HLLANHOKKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2E3F030", Offset = "0x2E3E230", VA = "0x182E3F030")]
		internal bool <GetSamples>b__0(global::PGCPBEHKNOP<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly float JGJMMCIEKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly float ONDKCDDEIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private List<global::PGCPBEHKNOP<float, T>> ALJOCPBJDFL;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int MPFDNAFNFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2E35E20", Offset = "0x2E35020", VA = "0x182E35E20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2E35EA0", Offset = "0x2E350A0", VA = "0x182E35EA0")]
	public ACGGGFBPCLP(float DHDFIPKFGFD, float HCGOGKFHCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2E354D0", Offset = "0x2E346D0", VA = "0x182E354D0")]
	public bool FDLHEBAAKKF(float IELJNLALDNK, T LDPMPDNIHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2E35310", Offset = "0x2E34510", VA = "0x182E35310")]
	public int APFDAIBGNEJ(float IELJNLALDNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2E35630", Offset = "0x2E34830", VA = "0x182E35630")]
	public IEnumerable<T> HCEKPJALBJL(float IELJNLALDNK, [Optional] float? LKHCFBJAJDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2E35D70", Offset = "0x2E34F70", VA = "0x182E35D70")]
	public void OAHGKPPJHGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2E35CB0", Offset = "0x2E34EB0", VA = "0x182E35CB0")]
	private void LOCMOBKICGM(float IELJNLALDNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class LKEGHDEOAMI<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct CEOPMPJCPDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T JDIGBEFEDMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float FDMGHEBFKLF;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static float HCPEICCPPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<T> PFILJCMOKNN;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const int PCABMGMCCFD = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private CEOPMPJCPDE[] BFDPPDNMBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int LMDPNEPCJGL;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float HKNGMGDJBPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x10556C0", Offset = "0x10548C0", VA = "0x1810556C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x10556F0", Offset = "0x10548F0", VA = "0x1810556F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2D87E40", Offset = "0x2D87040", VA = "0x182D87E40")]
	public LKEGHDEOAMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2D87E70", Offset = "0x2D87070", VA = "0x182D87E70")]
	public LKEGHDEOAMI(int FECFCKEKGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2D86EE0", Offset = "0x2D860E0", VA = "0x182D86EE0")]
	public void FKEGKEHNDJG(float IELJNLALDNK, T LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2D87710", Offset = "0x2D86910", VA = "0x182D87710")]
	public void OAHGKPPJHGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2D87860", Offset = "0x2D86A60", VA = "0x182D87860")]
	public bool OBKJIDBFCAI(float POBKADFLILN, float LEBLAFBCBFE, out T LDPMPDNIHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2D86910", Offset = "0x2D85B10", VA = "0x182D86910")]
	public bool CBBDJEABPHN(float POBKADFLILN, float LEBLAFBCBFE, out T LDPMPDNIHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2D87320", Offset = "0x2D86520", VA = "0x182D87320")]
	public void GCNJHBMLNBG(float POBKADFLILN, float LEBLAFBCBFE, List<T> OHNDJLPLBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2D86D90", Offset = "0x2D85F90", VA = "0x182D86D90")]
	private int EPKMKHKFJCK(int KIPOHALONBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2D86DC0", Offset = "0x2D85FC0", VA = "0x182D86DC0")]
	private void FCAGBMNEDMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T MJEAGHEOMBJ();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T MFLHHKLHFHA(T NFJBKPPLFPO, T PDNCJCJLEPL, float INOBBCFLJOF);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T LLLBIABIPJO(T LDPMPDNIHLJ, float INOBBCFLJOF);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T KKHMJNPADBH(T NFJBKPPLFPO, T PDNCJCJLEPL);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T IBGFBLPKOBP(T NFJBKPPLFPO, T PDNCJCJLEPL);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class BELJGFBDHMP : global::LKEGHDEOAMI<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x50FF660", Offset = "0x50FE860", VA = "0x1850FF660", Slot = "4")]
	protected override Vector3 MJEAGHEOMBJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x50FF5A0", Offset = "0x50FE7A0", VA = "0x1850FF5A0", Slot = "5")]
	protected override Vector3 MFLHHKLHFHA(Vector3 NFJBKPPLFPO, Vector3 PDNCJCJLEPL, float INOBBCFLJOF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x50FF500", Offset = "0x50FE700", VA = "0x1850FF500", Slot = "6")]
	protected override Vector3 LLLBIABIPJO(Vector3 LDPMPDNIHLJ, float INOBBCFLJOF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x50FF450", Offset = "0x50FE650", VA = "0x1850FF450", Slot = "7")]
	protected override Vector3 KKHMJNPADBH(Vector3 NFJBKPPLFPO, Vector3 PDNCJCJLEPL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x50FF3E0", Offset = "0x50FE5E0", VA = "0x1850FF3E0", Slot = "8")]
	protected override Vector3 IBGFBLPKOBP(Vector3 NFJBKPPLFPO, Vector3 PDNCJCJLEPL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x50FF6D0", Offset = "0x50FE8D0", VA = "0x1850FF6D0")]
	public BELJGFBDHMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HGFDEAEOGNE : global::LKEGHDEOAMI<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x51018D0", Offset = "0x5100AD0", VA = "0x1851018D0")]
	public HGFDEAEOGNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5101930", Offset = "0x5100B30", VA = "0x185101930")]
	public HGFDEAEOGNE(int FECFCKEKGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1138A10", Offset = "0x1137C10", VA = "0x181138A10", Slot = "4")]
	protected override float MJEAGHEOMBJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5101850", Offset = "0x5100A50", VA = "0x185101850", Slot = "5")]
	protected override float MFLHHKLHFHA(float NFJBKPPLFPO, float PDNCJCJLEPL, float INOBBCFLJOF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x416F580", Offset = "0x416E780", VA = "0x18416F580", Slot = "6")]
	protected override float LLLBIABIPJO(float LDPMPDNIHLJ, float INOBBCFLJOF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2722720", Offset = "0x2721920", VA = "0x182722720", Slot = "7")]
	protected override float KKHMJNPADBH(float NFJBKPPLFPO, float PDNCJCJLEPL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5101840", Offset = "0x5100A40", VA = "0x185101840", Slot = "8")]
	protected override float IBGFBLPKOBP(float NFJBKPPLFPO, float PDNCJCJLEPL)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class EHEHFCKIHNM
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1C98030", Offset = "0x1C97230", VA = "0x181C98030")]
	public static global::DANFHIMJOJL<T1> MFDAKPCHIOJ<T1>(T1 EANACFMJNIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x22E3BA0", Offset = "0x22E2DA0", VA = "0x1822E3BA0")]
	public static global::PGCPBEHKNOP<T1, T2> MFDAKPCHIOJ<T1, T2>(T1 EANACFMJNIL, T2 PMBEOPFMDMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2D14160", Offset = "0x2D13360", VA = "0x182D14160")]
	public static global::AAHEMCAANFM<T1, T2, T3> MFDAKPCHIOJ<T1, T2, T3>(T1 EANACFMJNIL, T2 PMBEOPFMDMA, T3 BLILPEMFGFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x208FA10", Offset = "0x208EC10", VA = "0x18208FA10")]
	public static global::LOPBNLPBALN<T1, T2, T3, T4> MFDAKPCHIOJ<T1, T2, T3, T4>(T1 EANACFMJNIL, T2 PMBEOPFMDMA, T3 BLILPEMFGFI, T4 LGMHILDEJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2D141F0", Offset = "0x2D133F0", VA = "0x182D141F0")]
	public static global::CLCDFGLADLH<T1, T2, T3, T4, T5> MFDAKPCHIOJ<T1, T2, T3, T4, T5>(T1 EANACFMJNIL, T2 PMBEOPFMDMA, T3 BLILPEMFGFI, T4 LGMHILDEJFF, T5 LNGIOKOILFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x208F960", Offset = "0x208EB60", VA = "0x18208F960")]
	public static global::LIGGDNIGPHL<T1, T2, T3, T4, T5, T6> MFDAKPCHIOJ<T1, T2, T3, T4, T5, T6>(T1 EANACFMJNIL, T2 PMBEOPFMDMA, T3 BLILPEMFGFI, T4 LGMHILDEJFF, T5 LNGIOKOILFO, T6 CDMLMNGPGJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1C97F70", Offset = "0x1C97170", VA = "0x181C97F70")]
	public static global::DCAKMDOEOJL<T1, T2, T3, T4, T5, T6, T7> MFDAKPCHIOJ<T1, T2, T3, T4, T5, T6, T7>(T1 EANACFMJNIL, T2 PMBEOPFMDMA, T3 BLILPEMFGFI, T4 LGMHILDEJFF, T5 LNGIOKOILFO, T6 CDMLMNGPGJM, T7 KLPCDMPHHOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x208F890", Offset = "0x208EA90", VA = "0x18208F890")]
	public static global::IBIMIDFOFHO<T1, T2, T3, T4, T5, T6, T7, T8> MFDAKPCHIOJ<T1, T2, T3, T4, T5, T6, T7, T8>(T1 EANACFMJNIL, T2 PMBEOPFMDMA, T3 BLILPEMFGFI, T4 LGMHILDEJFF, T5 LNGIOKOILFO, T6 CDMLMNGPGJM, T7 KLPCDMPHHOC, T8 IHHMAILPJBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1B10140", Offset = "0x1B0F340", VA = "0x181B10140")]
	[IteratorStateMachine(typeof(CENDDKCDMNF))]
	public static IEnumerable<global::PGCPBEHKNOP<T1, T2>> EEKEAHOMKOK<T1, T2>(IEnumerable<T1> KICBFMPMNBH, IEnumerable<T2> DLFOEJDCAKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1B127D0", Offset = "0x1B119D0", VA = "0x181B127D0")]
	[IteratorStateMachine(typeof(BKNGICNEOPL))]
	public static IEnumerable<global::AAHEMCAANFM<T1, T2, T3>> EEKEAHOMKOK<T1, T2, T3>(IEnumerable<T1> KICBFMPMNBH, IEnumerable<T2> DLFOEJDCAKP, IEnumerable<T3> DIHFAACINDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x266D870", Offset = "0x266CA70", VA = "0x18266D870")]
	internal static int ECLLMFDNFPO(int MCJGIJOICDD, int HOBFPAMOBAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3E15260", Offset = "0x3E14460", VA = "0x183E15260")]
	internal static int ECLLMFDNFPO(int MCJGIJOICDD, int HOBFPAMOBAO, int PPHJENNCCCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3E15270", Offset = "0x3E14470", VA = "0x183E15270")]
	internal static int ECLLMFDNFPO(int MCJGIJOICDD, int HOBFPAMOBAO, int PPHJENNCCCD, int IJCJJGINLOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5100FA0", Offset = "0x51001A0", VA = "0x185100FA0")]
	internal static int ECLLMFDNFPO(int MCJGIJOICDD, int HOBFPAMOBAO, int PPHJENNCCCD, int IJCJJGINLOJ, int APKPJHFMIBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5100FF0", Offset = "0x51001F0", VA = "0x185100FF0")]
	internal static int ECLLMFDNFPO(int MCJGIJOICDD, int HOBFPAMOBAO, int PPHJENNCCCD, int IJCJJGINLOJ, int APKPJHFMIBG, int CHACDIBFPAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5100FC0", Offset = "0x51001C0", VA = "0x185100FC0")]
	internal static int ECLLMFDNFPO(int MCJGIJOICDD, int HOBFPAMOBAO, int PPHJENNCCCD, int IJCJJGINLOJ, int APKPJHFMIBG, int CHACDIBFPAF, int DOALMGBOFHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5100F70", Offset = "0x5100170", VA = "0x185100F70")]
	internal static int ECLLMFDNFPO(int MCJGIJOICDD, int HOBFPAMOBAO, int PPHJENNCCCD, int IJCJJGINLOJ, int APKPJHFMIBG, int CHACDIBFPAF, int DOALMGBOFHD, int JINGGNHLDHJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DANFHIMJOJL<T1> : IComparable<global::DANFHIMJOJL<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 KBIJDAAPKHD;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1E5DB50", Offset = "0x1E5CD50", VA = "0x181E5DB50")]
	public DANFHIMJOJL(T1 EANACFMJNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x40884A0", Offset = "0x40876A0", VA = "0x1840884A0", Slot = "4")]
	public int CompareTo(global::DANFHIMJOJL<T1> MKCNOIKIBCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4088510", Offset = "0x4087710", VA = "0x184088510", Slot = "0")]
	public override bool Equals(object MKCNOIKIBCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x893E50", Offset = "0x893050", VA = "0x180893E50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x40885B0", Offset = "0x40877B0", VA = "0x1840885B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PGCPBEHKNOP<T1, T2> : IComparable<global::PGCPBEHKNOP<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T1 KBIJDAAPKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T2 JEGJNECOEEN;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3828200", Offset = "0x3827400", VA = "0x183828200")]
	public PGCPBEHKNOP(T1 EANACFMJNIL, T2 PMBEOPFMDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3826640", Offset = "0x3825840", VA = "0x183826640", Slot = "4")]
	public int CompareTo(global::PGCPBEHKNOP<T1, T2> MKCNOIKIBCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3826A50", Offset = "0x3825C50", VA = "0x183826A50", Slot = "0")]
	public override bool Equals(object MKCNOIKIBCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3827560", Offset = "0x3826760", VA = "0x183827560", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3827810", Offset = "0x3826A10", VA = "0x183827810", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class AAHEMCAANFM<T1, T2, T3> : IComparable<global::AAHEMCAANFM<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 KBIJDAAPKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 JEGJNECOEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T3 KIOFHELJHMH;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4F39110", Offset = "0x4F38310", VA = "0x184F39110")]
	public AAHEMCAANFM(T1 EANACFMJNIL, T2 PMBEOPFMDMA, T3 BLILPEMFGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4F38A30", Offset = "0x4F37C30", VA = "0x184F38A30", Slot = "4")]
	public int CompareTo(global::AAHEMCAANFM<T1, T2, T3> MKCNOIKIBCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4F38C20", Offset = "0x4F37E20", VA = "0x184F38C20", Slot = "0")]
	public override bool Equals(object MKCNOIKIBCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4F38E20", Offset = "0x4F38020", VA = "0x184F38E20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4F38E90", Offset = "0x4F38090", VA = "0x184F38E90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class LOPBNLPBALN<T1, T2, T3, T4> : IComparable<global::LOPBNLPBALN<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T1 KBIJDAAPKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T2 JEGJNECOEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T3 KIOFHELJHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T4 PPDOIMIBHLI;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x240A560", Offset = "0x2409760", VA = "0x18240A560")]
	public LOPBNLPBALN(T1 EANACFMJNIL, T2 PMBEOPFMDMA, T3 BLILPEMFGFI, T4 LGMHILDEJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x240A130", Offset = "0x2409330", VA = "0x18240A130", Slot = "4")]
	public int CompareTo(global::LOPBNLPBALN<T1, T2, T3, T4> MKCNOIKIBCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x240A270", Offset = "0x2409470", VA = "0x18240A270", Slot = "0")]
	public override bool Equals(object MKCNOIKIBCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x240A390", Offset = "0x2409590", VA = "0x18240A390", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x240A450", Offset = "0x2409650", VA = "0x18240A450", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class CLCDFGLADLH<T1, T2, T3, T4, T5> : IComparable<global::CLCDFGLADLH<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T1 KBIJDAAPKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T2 JEGJNECOEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T3 KIOFHELJHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T4 PPDOIMIBHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T5 BBAPLEPIFEO;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5DE0", Offset = "0x2BA4FE0", VA = "0x182BA5DE0")]
	public CLCDFGLADLH(T1 EANACFMJNIL, T2 PMBEOPFMDMA, T3 BLILPEMFGFI, T4 LGMHILDEJFF, T5 LNGIOKOILFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2BA58F0", Offset = "0x2BA4AF0", VA = "0x182BA58F0", Slot = "4")]
	public int CompareTo(global::CLCDFGLADLH<T1, T2, T3, T4, T5> MKCNOIKIBCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5A70", Offset = "0x2BA4C70", VA = "0x182BA5A70", Slot = "0")]
	public override bool Equals(object MKCNOIKIBCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5BB0", Offset = "0x2BA4DB0", VA = "0x182BA5BB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5CB0", Offset = "0x2BA4EB0", VA = "0x182BA5CB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class LIGGDNIGPHL<T1, T2, T3, T4, T5, T6> : IComparable<global::LIGGDNIGPHL<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 KBIJDAAPKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 JEGJNECOEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 KIOFHELJHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 PPDOIMIBHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 BBAPLEPIFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 GPMGANHKEAL;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2D7CE30", Offset = "0x2D7C030", VA = "0x182D7CE30")]
	public LIGGDNIGPHL(T1 EANACFMJNIL, T2 PMBEOPFMDMA, T3 BLILPEMFGFI, T4 LGMHILDEJFF, T5 LNGIOKOILFO, T6 CDMLMNGPGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2D7C890", Offset = "0x2D7BA90", VA = "0x182D7C890", Slot = "4")]
	public int CompareTo(global::LIGGDNIGPHL<T1, T2, T3, T4, T5, T6> MKCNOIKIBCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2D7CA50", Offset = "0x2D7BC50", VA = "0x182D7CA50", Slot = "0")]
	public override bool Equals(object MKCNOIKIBCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2D7CBC0", Offset = "0x2D7BDC0", VA = "0x182D7CBC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2D7CCE0", Offset = "0x2D7BEE0", VA = "0x182D7CCE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class DCAKMDOEOJL<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::DCAKMDOEOJL<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T1 KBIJDAAPKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T2 JEGJNECOEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T3 KIOFHELJHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T4 PPDOIMIBHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T5 BBAPLEPIFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T6 GPMGANHKEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T7 GBPCOOACOBJ;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3893B60", Offset = "0x3892D60", VA = "0x183893B60")]
	public DCAKMDOEOJL(T1 EANACFMJNIL, T2 PMBEOPFMDMA, T3 BLILPEMFGFI, T4 LGMHILDEJFF, T5 LNGIOKOILFO, T6 CDMLMNGPGJM, T7 KLPCDMPHHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3893500", Offset = "0x3892700", VA = "0x183893500", Slot = "4")]
	public int CompareTo(global::DCAKMDOEOJL<T1, T2, T3, T4, T5, T6, T7> MKCNOIKIBCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3893700", Offset = "0x3892900", VA = "0x183893700", Slot = "0")]
	public override bool Equals(object MKCNOIKIBCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x38938A0", Offset = "0x3892AA0", VA = "0x1838938A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x38939F0", Offset = "0x3892BF0", VA = "0x1838939F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class IBIMIDFOFHO<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::IBIMIDFOFHO<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T1 KBIJDAAPKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T2 JEGJNECOEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T3 KIOFHELJHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T4 PPDOIMIBHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T5 BBAPLEPIFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T6 GPMGANHKEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T7 GBPCOOACOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T8 OEHOBKCMDPJ;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x39EFBE0", Offset = "0x39EEDE0", VA = "0x1839EFBE0")]
	public IBIMIDFOFHO(T1 EANACFMJNIL, T2 PMBEOPFMDMA, T3 BLILPEMFGFI, T4 LGMHILDEJFF, T5 LNGIOKOILFO, T6 CDMLMNGPGJM, T7 KLPCDMPHHOC, T8 IHHMAILPJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x39EF4D0", Offset = "0x39EE6D0", VA = "0x1839EF4D0", Slot = "4")]
	public int CompareTo(global::IBIMIDFOFHO<T1, T2, T3, T4, T5, T6, T7, T8> MKCNOIKIBCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x39EF720", Offset = "0x39EE920", VA = "0x1839EF720", Slot = "0")]
	public override bool Equals(object MKCNOIKIBCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x39EF8E0", Offset = "0x39EEAE0", VA = "0x1839EF8E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x39EFA50", Offset = "0x39EEC50", VA = "0x1839EFA50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T JDIGBEFEDMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5B2A30", Offset = "0x5B1C30", VA = "0x1805B2A30")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6C2580", Offset = "0x6C1780", VA = "0x1806C2580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float NMDGLDHNGAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xE136D0", Offset = "0xE128D0", VA = "0x180E136D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x40F6AE0", Offset = "0x40F5CE0", VA = "0x1840F6AE0")]
	public T NLPCEEEOLFJ(float INOBBCFLJOF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x40F69D0", Offset = "0x40F5BD0", VA = "0x1840F69D0")]
	public T BBKEDDIJIFF(float INOBBCFLJOF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T MFLHHKLHFHA(T NFJBKPPLFPO, T PDNCJCJLEPL, float INOBBCFLJOF);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5101630", Offset = "0x5100830", VA = "0x185101630", Slot = "4")]
	protected override float MFLHHKLHFHA(float NFJBKPPLFPO, float PDNCJCJLEPL, float INOBBCFLJOF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x51016B0", Offset = "0x51008B0", VA = "0x1851016B0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5107780", Offset = "0x5106980", VA = "0x185107780", Slot = "4")]
	protected override Vector3 MFLHHKLHFHA(Vector3 NFJBKPPLFPO, Vector3 PDNCJCJLEPL, float INOBBCFLJOF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5107840", Offset = "0x5106A40", VA = "0x185107840")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5100D60", Offset = "0x50FFF60", VA = "0x185100D60", Slot = "4")]
	protected override Color MFLHHKLHFHA(Color NFJBKPPLFPO, Color PDNCJCJLEPL, float INOBBCFLJOF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5100DB0", Offset = "0x50FFFB0", VA = "0x185100DB0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NCIJEJFENOG : global::HGHPFCEOCGK<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5104830", Offset = "0x5103A30", VA = "0x185104830")]
	public NCIJEJFENOG(int FDMAMJMNCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5104880", Offset = "0x5103A80", VA = "0x185104880")]
	public NCIJEJFENOG(CGKDLIHGCNO[] AKBJCAICIGA, bool ECDAIBADBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x51047C0", Offset = "0x51039C0", VA = "0x1851047C0", Slot = "6")]
	protected override uint CEDIOHGLEOD(uint AGODCCIEBMA, string LDPMPDNIHLJ)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class BIFOPGKMGNA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly IDisposable LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public BIFOPGKMGNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DebuggerTypeProxy(typeof(global::FFCKGMJMIEB<>.DMDOPOIHMHJ))]
[DefaultMember("Item")]
public sealed class FFCKGMJMIEB<T> : IDisposable, global::BELKBDCAPOC<T>, IDHHDMCOBIE, global::EKDGLFNDAOE<T, global::FFCKGMJMIEB<T>.EHPPBPKNBCA>, global::LMHHMLFLAMF<T>, global::FABBLLDBPKA<T, global::FFCKGMJMIEB<T>.EHPPBPKNBCA>, global::JKIAJBAFJIL<T>, global::FGLOCALHNHK<T, global::FFCKGMJMIEB<T>.EHPPBPKNBCA>, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct EHPPBPKNBCA : IDHHDMCOBIE, global::OLHECNNJKGE<T>, global::HKIJFLLGBCF<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly global::FFCKGMJMIEB<T> OKDMEHFLNAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private int ILPKBKOCJBC;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int HKOLKDAEOPE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1F8CA30", Offset = "0x1F8BC30", VA = "0x181F8CA30", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T NDCKGIGIEHE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x34F0AC0", Offset = "0x34EFCC0", VA = "0x1834F0AC0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private T BJNAOIOHHBB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x34F03B0", Offset = "0x34EF5B0", VA = "0x1834F03B0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x34F06C0", Offset = "0x34EF8C0", VA = "0x1834F06C0", Slot = "7")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x34F0860", Offset = "0x34EFA60", VA = "0x1834F0860", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x34F0AA0", Offset = "0x34EFCA0", VA = "0x1834F0AA0")]
		private EHPPBPKNBCA(global::FFCKGMJMIEB<T> EAHKFBMKAPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2401F30", Offset = "0x2401130", VA = "0x182401F30")]
		public static EHPPBPKNBCA NPLCOEOMBMO(global::FFCKGMJMIEB<T> EAHKFBMKAPP)
		{
			return default(EHPPBPKNBCA);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x34F04D0", Offset = "0x34EF6D0", VA = "0x1834F04D0", Slot = "9")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2401F90", Offset = "0x2401190", VA = "0x182401F90", Slot = "11")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "8")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class DMDOPOIHMHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly global::FFCKGMJMIEB<T> OKDMEHFLNAP;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int HKOLKDAEOPE
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1E5DB20", Offset = "0x1E5CD20", VA = "0x181E5DB20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T[] MLHALAINLPB
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x34F0230", Offset = "0x34EF430", VA = "0x1834F0230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool BJJJLOGDMGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x34F0170", Offset = "0x34EF370", VA = "0x1834F0170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x1E5DB50", Offset = "0x1E5CD50", VA = "0x181E5DB50")]
		public DMDOPOIHMHJ(global::FFCKGMJMIEB<T> EAHKFBMKAPP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly GKKBGNKIPKN CHGIHMGIIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private T[] HHCGNJDEJBJ;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int HKOLKDAEOPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x58ACD0", Offset = "0x589ED0", VA = "0x18058ACD0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x60BA10", Offset = "0x60AC10", VA = "0x18060BA10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Span<T> MLHALAINLPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x34F6140", Offset = "0x34F5340", VA = "0x1834F6140")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public T APAEDMJBEDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x34F4C40", Offset = "0x34F3E40", VA = "0x1834F4C40")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public T BLLCJCENOPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x34F4C40", Offset = "0x34F3E40", VA = "0x1834F4C40")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public T NDDGGEMNAMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x34F52B0", Offset = "0x34F44B0", VA = "0x1834F52B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x34F5E40", Offset = "0x34F5040", VA = "0x1834F5E40")]
	public static global::FFCKGMJMIEB<T> NPLCOEOMBMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x34F5B80", Offset = "0x34F4D80", VA = "0x1834F5B80")]
	public static global::FFCKGMJMIEB<T> LMCOCHJEGEF(int FDMAMJMNCKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x34F7080", Offset = "0x34F6280", VA = "0x1834F7080")]
	internal FFCKGMJMIEB(T[] FPDLKCEGBJF, int NAOLJMJHENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2888010", Offset = "0x2887210", VA = "0x182888010", Slot = "5")]
	public T EBONCEPCBHO(int PJEHDDODHBJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x34F4BC0", Offset = "0x34F3DC0", VA = "0x1834F4BC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x34F4F90", Offset = "0x34F4190", VA = "0x1834F4F90")]
	public void FKEGKEHNDJG(in T LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x34F5490", Offset = "0x34F4690", VA = "0x1834F5490")]
	public void IKIKGKBAOFP(int OHJLAHMBLMG, in T LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x34F53F0", Offset = "0x34F45F0", VA = "0x1834F53F0")]
	public void IDLCJKOPAFG(int OHJLAHMBLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x34F3660", Offset = "0x34F2860", VA = "0x1834F3660")]
	public void BNNPNLBLAFJ(int FECFCKEKGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x34F5CC0", Offset = "0x34F4EC0", VA = "0x1834F5CC0")]
	private void MCOJLDDDGFI(int FDMAMJMNCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x34F5F80", Offset = "0x34F5180", VA = "0x1834F5F80")]
	public void OAHGKPPJHGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x34F4440", Offset = "0x34F3640", VA = "0x1834F4440")]
	public global::FFCKGMJMIEB<T> CCMJLFMPMPI(global::APFBIMKOGCI<T, T> APLIHDGAFKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x34F5270", Offset = "0x34F4470", VA = "0x1834F5270", Slot = "11")]
	public EHPPBPKNBCA GetEnumerator()
	{
		return default(EHPPBPKNBCA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x34F4B40", Offset = "0x34F3D40", VA = "0x1834F4B40", Slot = "8")]
	private global::OLHECNNJKGE<T> ILIPCIHODDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x34F4B40", Offset = "0x34F3D40", VA = "0x1834F4B40", Slot = "10")]
	private global::HKIJFLLGBCF<T> DLBMGHHOAEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x34F4B40", Offset = "0x34F3D40", VA = "0x1834F4B40", Slot = "12")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x34F4B40", Offset = "0x34F3D40", VA = "0x1834F4B40", Slot = "13")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class KIFMAFGDOIH
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2790C00", Offset = "0x278FE00", VA = "0x182790C00")]
	public static bool PDHGAFAPJNI<T>(this global::FFCKGMJMIEB<T> EAHKFBMKAPP, in T LDPMPDNIHLJ) where T : global::JKOLFBFAHAI<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct IBJPKIOFKLM
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class KMFDPMMPAHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public TaskCompletionSource<ONAHGIBPGPN> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public KMFDPMMPAHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5103720", Offset = "0x5102920", VA = "0x185103720")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<ONAHGIBPGPN>> DOPCMELKKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private int AFGPKCIEAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int KJANGIDLILP;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x9976E0", Offset = "0x9968E0", VA = "0x1809976E0")]
	private IBJPKIOFKLM(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<ONAHGIBPGPN>> KIFOLIFJLPJ, int FAKPKCAFNDB, int CIIOFMJICNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5102040", Offset = "0x5101240", VA = "0x185102040")]
	public static IBJPKIOFKLM NPLCOEOMBMO()
	{
		return default(IBJPKIOFKLM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5101C40", Offset = "0x5100E40", VA = "0x185101C40")]
	public (int, int, Task) EJLKJELPGIP(int DDELCAECMNG, [Optional] CancellationToken IHCDPGIEMEN)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5101F90", Offset = "0x5101190", VA = "0x185101F90")]
	public void GMCCJBBKEFF(int DDELCAECMNG, int CIIOFMJICNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class IONDDCNGMNC<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Dictionary<TKey, TVal> MMAGPCILMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly Dictionary<TVal, TKey> DCNIAOCOJPA;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int HKOLKDAEOPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x1E5DB20", Offset = "0x1E5CD20", VA = "0x181E5DB20", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool NPIKHPBKLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x58AEC0", Offset = "0x58A0C0", VA = "0x18058AEC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public ICollection<TKey> ICJDAAGJBDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2A61D30", Offset = "0x2A60F30", VA = "0x182A61D30", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public ICollection<TVal> NFBBLGKEDIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1E4FC00", Offset = "0x1E4EE00", VA = "0x181E4FC00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public TVal NDDGGEMNAMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x240A880", Offset = "0x2409A80", VA = "0x18240A880", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2D79560", Offset = "0x2D78760", VA = "0x182D79560", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public TKey NDDGGEMNAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3A24BA0", Offset = "0x3A23DA0", VA = "0x183A24BA0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3A24800", Offset = "0x3A23A00", VA = "0x183A24800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3A248B0", Offset = "0x3A23AB0", VA = "0x183A248B0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3A252B0", Offset = "0x3A244B0", VA = "0x183A252B0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2BA1260", Offset = "0x2BA0460", VA = "0x182BA1260", Slot = "9")]
	public void Add(TKey ICIBGJCBOAM, TVal LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3A247D0", Offset = "0x3A239D0", VA = "0x183A247D0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> GKPGLMINDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2A00430", Offset = "0x29FF630", VA = "0x182A00430", Slot = "8")]
	public bool ContainsKey(TKey ICIBGJCBOAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1E50890", Offset = "0x1E4FA90", VA = "0x181E50890", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> GKPGLMINDLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3A25200", Offset = "0x3A24400", VA = "0x183A25200", Slot = "10")]
	public bool Remove(TKey ICIBGJCBOAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3A25200", Offset = "0x3A24400", VA = "0x183A25200", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> GKPGLMINDLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x321C980", Offset = "0x321BB80", VA = "0x18321C980", Slot = "11")]
	public bool TryGetValue(TKey ICIBGJCBOAM, out TVal LDPMPDNIHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3A24B20", Offset = "0x3A23D20", VA = "0x183A24B20", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3A24940", Offset = "0x3A23B40", VA = "0x183A24940", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] BFDPPDNMBIM, int DPCKJFODMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3A24A00", Offset = "0x3A23C00", VA = "0x183A24A00")]
	public void FKEGKEHNDJG(TVal KGBAJDIJIJD, TKey ICIBGJCBOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3A24A80", Offset = "0x3A23C80", VA = "0x183A24A80")]
	public void FKEGKEHNDJG(KeyValuePair<TVal, TKey> GKPGLMINDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3A24AF0", Offset = "0x3A23CF0", VA = "0x183A24AF0")]
	public bool GJHAJBFNDCI(TVal ICIBGJCBOAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x29674A0", Offset = "0x29666A0", VA = "0x1829674A0")]
	public bool EFLIOKIPEDI(KeyValuePair<TVal, TKey> GKPGLMINDLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2FD0", Offset = "0x2BA21D0", VA = "0x182BA2FD0")]
	public bool CDCPBPNLMGM(TVal ICIBGJCBOAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2FD0", Offset = "0x2BA21D0", VA = "0x182BA2FD0")]
	public bool CDCPBPNLMGM(KeyValuePair<TVal, TKey> GKPGLMINDLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3A249D0", Offset = "0x3A23BD0", VA = "0x183A249D0")]
	public bool FINJNPJEIIJ(TVal ICIBGJCBOAM, out TKey LDPMPDNIHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3A24BD0", Offset = "0x3A23DD0", VA = "0x183A24BD0")]
	public IEnumerator<KeyValuePair<TVal, TKey>> IPOIAEHKOPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3A25180", Offset = "0x3A24380", VA = "0x183A25180")]
	private void NOJILEGBOEO(TKey ICIBGJCBOAM, TVal KGBAJDIJIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3A24FE0", Offset = "0x3A241E0", VA = "0x183A24FE0")]
	private void NAHGLLJMMKP(TKey ICIBGJCBOAM, TVal KGBAJDIJIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3A24F20", Offset = "0x3A24120", VA = "0x183A24F20")]
	private bool JOBIJOKPIEO(TKey ICIBGJCBOAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3A24E60", Offset = "0x3A24060", VA = "0x183A24E60")]
	private bool JOBIJOKPIEO(TVal KGBAJDIJIJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3A25300", Offset = "0x3A24500", VA = "0x183A25300")]
	public IONDDCNGMNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class HFNPACGJLKH<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private global::HFNPACGJLKH<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x10556C0", Offset = "0x10548C0", VA = "0x1810556C0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x38C0100", Offset = "0x38BF300", VA = "0x1838C0100", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x38C04B0", Offset = "0x38BF6B0", VA = "0x1838C04B0")]
		public Enumerator(global::HFNPACGJLKH<T> OHNDJLPLBEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x38BF8C0", Offset = "0x38BEAC0", VA = "0x1838BF8C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x38BFF00", Offset = "0x38BF100", VA = "0x1838BFF00", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x38BFDE0", Offset = "0x38BEFE0", VA = "0x1838BFDE0")]
		private void PAOJCAHCAJH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private T[] APFPBOJHHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private int BLNMCHHANPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private int IACIBFMBFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private int BGPOJNMOBBK;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int HKOLKDAEOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x38C85D0", Offset = "0x38C77D0", VA = "0x1838C85D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public T NDDGGEMNAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x38C8D70", Offset = "0x38C7F70", VA = "0x1838C8D70")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x38C8270", Offset = "0x38C7470", VA = "0x1838C8270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x38CA270", Offset = "0x38C9470", VA = "0x1838CA270")]
	public HFNPACGJLKH(int FDMAMJMNCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x38C8A80", Offset = "0x38C7C80", VA = "0x1838C8A80")]
	public void FKEGKEHNDJG(T INOBBCFLJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x38C9380", Offset = "0x38C8580", VA = "0x1838C9380")]
	public void IHKOMOBOGGB(IEnumerable<T> FAFOBDEDNLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x38C9FD0", Offset = "0x38C91D0", VA = "0x1838C9FD0")]
	public void OAHGKPPJHGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x38C83E0", Offset = "0x38C75E0", VA = "0x1838C83E0")]
	public void DDLOLBBMHNH(int NAOLJMJHENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x38C9FF0", Offset = "0x38C91F0", VA = "0x1838C9FF0")]
	public void PAKLELFJJDP(int NAOLJMJHENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x38C8F90", Offset = "0x38C8190", VA = "0x1838C8F90")]
	public void ICHOGCAINDD(T[] BFDPPDNMBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x38C8560", Offset = "0x38C7760", VA = "0x1838C8560")]
	public Enumerator ECCFOEBFBJP()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x38CA1D0", Offset = "0x38C93D0", VA = "0x1838CA1D0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x38CA1D0", Offset = "0x38C93D0", VA = "0x1838CA1D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x38C87F0", Offset = "0x38C79F0", VA = "0x1838C87F0")]
	private int FCEPMFBLEGP(int OHJLAHMBLMG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x38C9FA0", Offset = "0x38C91A0", VA = "0x1838C9FA0")]
	private int NIOMGMMCMGJ(int OHJLAHMBLMG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct LCHINJPIPBF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly IDisposable[] HHCGNJDEJBJ;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6CB170", Offset = "0x6CA370", VA = "0x1806CB170")]
	public LCHINJPIPBF(params IDisposable[] FPDLKCEGBJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0xDBC010", Offset = "0xDBB210", VA = "0x180DBC010")]
	public static LCHINJPIPBF NPLCOEOMBMO(params IDisposable[] FPDLKCEGBJF)
	{
		return default(LCHINJPIPBF);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5103770", Offset = "0x5102970", VA = "0x185103770", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct FBECOFJGPMF<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly IDisposable KELDLBJOHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public T JDIGBEFEDMD;

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x38D0920", Offset = "0x38CFB20", VA = "0x1838D0920")]
	public FBECOFJGPMF(IDisposable AKFPLPAIEMF, in T LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x1C98470", Offset = "0x1C97670", VA = "0x181C98470")]
	public static global::FBECOFJGPMF<U> CGNGLECIJLH<U>(in global::FBECOFJGPMF<T> AKFPLPAIEMF, in U LDPMPDNIHLJ)
	{
		return default(global::FBECOFJGPMF<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1C955A0", Offset = "0x1C947A0", VA = "0x181C955A0")]
	public global::FBECOFJGPMF<U> EFLGBJOJODA<U>(in U LDPMPDNIHLJ)
	{
		return default(global::FBECOFJGPMF<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x1C984B0", Offset = "0x1C976B0", VA = "0x181C984B0")]
	public static global::FBECOFJGPMF<(T, U)> HGOBPLKIDIB<U>(in global::FBECOFJGPMF<T> KICBFMPMNBH, in global::FBECOFJGPMF<U> DLFOEJDCAKP)
	{
		return default(global::FBECOFJGPMF<(T, U)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3B2BA60", Offset = "0x3B2AC60", VA = "0x183B2BA60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class BEGIPGNKFJL
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x1C95650", Offset = "0x1C94850", VA = "0x181C95650")]
	public static global::FBECOFJGPMF<T> NPLCOEOMBMO<T>(IDisposable AKFPLPAIEMF, in T LDPMPDNIHLJ)
	{
		return default(global::FBECOFJGPMF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x1C955A0", Offset = "0x1C947A0", VA = "0x181C955A0")]
	public static global::FBECOFJGPMF<U> CGNGLECIJLH<U, T>(in global::FBECOFJGPMF<T> GLGLDNGOKHC, in U LDPMPDNIHLJ)
	{
		return default(global::FBECOFJGPMF<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x1C955D0", Offset = "0x1C947D0", VA = "0x181C955D0")]
	public static global::FBECOFJGPMF<(T, U)> HGOBPLKIDIB<T, U>(in global::FBECOFJGPMF<T> KICBFMPMNBH, in global::FBECOFJGPMF<U> DLFOEJDCAKP)
	{
		return default(global::FBECOFJGPMF<(T, U)>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct GKKBGNKIPKN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x58AEC0", Offset = "0x58A0C0", VA = "0x18058AEC0")]
	public static GKKBGNKIPKN JIOMMKDDBOD<T>([Optional] string DHLJCJCOEPD, [Optional] string KAMLNEEDHGJ, bool KDBCBLFAEJB = false)
	{
		return default(GKKBGNKIPKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[DefaultMember("Item")]
public readonly struct LNJMNEBOLAG<T> : global::FABBLLDBPKA<T, global::LNJMNEBOLAG<T>.DDCHPIMDBAP>, global::JKIAJBAFJIL<T>, global::FGLOCALHNHK<T, global::LNJMNEBOLAG<T>.DDCHPIMDBAP>, IEnumerable<T>, IEnumerable, global::BELKBDCAPOC<T>, IDHHDMCOBIE
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct DDCHPIMDBAP : IDHHDMCOBIE, global::HKIJFLLGBCF<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly T[] OKDMEHFLNAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int ILPKBKOCJBC;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int HKOLKDAEOPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x2401EE0", Offset = "0x24010E0", VA = "0x182401EE0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public T NDCKGIGIEHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x2401FF0", Offset = "0x24011F0", VA = "0x182401FF0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x2401FA0", Offset = "0x24011A0", VA = "0x182401FA0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x2401FA0", Offset = "0x24011A0", VA = "0x182401FA0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9CB790", Offset = "0x9CA990", VA = "0x1809CB790")]
		private DDCHPIMDBAP(T[] EAHKFBMKAPP, int OHJLAHMBLMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2401F30", Offset = "0x2401130", VA = "0x182401F30")]
		public static DDCHPIMDBAP NPLCOEOMBMO(T[] EAHKFBMKAPP)
		{
			return default(DDCHPIMDBAP);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x2401F00", Offset = "0x2401100", VA = "0x182401F00", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x2401F90", Offset = "0x2401190", VA = "0x182401F90", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly T[] DPNEFFLPPEB;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int IKCNHOEKMBC
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2401EE0", Offset = "0x24010E0", VA = "0x182401EE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int HKOLKDAEOPE
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x240A010", Offset = "0x2409210", VA = "0x18240A010", Slot = "10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T NDDGGEMNAMN
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x240A0F0", Offset = "0x24092F0", VA = "0x18240A0F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6CB170", Offset = "0x6CA370", VA = "0x1806CB170")]
	internal LNJMNEBOLAG(T[] BFDPPDNMBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2409DF0", Offset = "0x2408FF0", VA = "0x182409DF0")]
	public static global::LNJMNEBOLAG<T> AGHBDCJKPJC()
	{
		return default(global::LNJMNEBOLAG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2409FB0", Offset = "0x24091B0", VA = "0x182409FB0", Slot = "9")]
	public T EBONCEPCBHO(int OHJLAHMBLMG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x240A050", Offset = "0x2409250", VA = "0x18240A050", Slot = "6")]
	public DDCHPIMDBAP GetEnumerator()
	{
		return default(DDCHPIMDBAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2409EB0", Offset = "0x24090B0", VA = "0x182409EB0", Slot = "5")]
	private global::HKIJFLLGBCF<T> DLBMGHHOAEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2409EB0", Offset = "0x24090B0", VA = "0x182409EB0", Slot = "7")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x2409EB0", Offset = "0x24090B0", VA = "0x182409EB0", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class MECCKGMGNPH
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x1C94BA0", Offset = "0x1C93DA0", VA = "0x181C94BA0")]
	public static global::LNJMNEBOLAG<T> NPLCOEOMBMO<T>(T[] BFDPPDNMBIM)
	{
		return default(global::LNJMNEBOLAG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x1AEA110", Offset = "0x1AE9310", VA = "0x181AEA110")]
	public static global::LNJMNEBOLAG<T> CKNIKAINJCA<T>(this T[] EAHKFBMKAPP)
	{
		return default(global::LNJMNEBOLAG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x1C94B70", Offset = "0x1C93D70", VA = "0x181C94B70")]
	public static global::LNJMNEBOLAG<T>.DDCHPIMDBAP JPKGEJCDGOM<T>(this T[] EAHKFBMKAPP)
	{
		return default(global::LNJMNEBOLAG<T>.DDCHPIMDBAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x1AEA110", Offset = "0x1AE9310", VA = "0x181AEA110")]
	public static global::LNJMNEBOLAG<T> BBFGGKPEBGK<T>(this T[] EAHKFBMKAPP)
	{
		return default(global::LNJMNEBOLAG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct DNFBJIPHHJC<T, U> : global::FABBLLDBPKA<T, U>, global::JKIAJBAFJIL<T>, global::FGLOCALHNHK<T, U>, IEnumerable<T>, IEnumerable where U : global::HKIJFLLGBCF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly U AEDCMINJIBD;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x269B7E0", Offset = "0x269A9E0", VA = "0x18269B7E0")]
	internal DNFBJIPHHJC(in U ECMLENMKENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7600E0", Offset = "0x75F2E0", VA = "0x1807600E0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2E4F680", Offset = "0x2E4E880", VA = "0x182E4F680", Slot = "5")]
	private global::HKIJFLLGBCF<T> DLBMGHHOAEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x2E4F680", Offset = "0x2E4E880", VA = "0x182E4F680", Slot = "7")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x2E4F680", Offset = "0x2E4E880", VA = "0x182E4F680", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class COFNOBNOPAK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x1C96B40", Offset = "0x1C95D40", VA = "0x181C96B40")]
	public static global::DNFBJIPHHJC<T, U> NPLCOEOMBMO<U>(in U ECMLENMKENJ) where U : global::HKIJFLLGBCF<T>
	{
		return default(global::DNFBJIPHHJC<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class KBGBKIBLBPE<TResult, TResultEnumerator> where TResultEnumerator : global::HKIJFLLGBCF<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x1C9A080", Offset = "0x1C99280", VA = "0x181C9A080")]
	public static global::EBBKDPFMLMK<TSourceEnumerator, TResultEnumerator, TResult> MEIKJKNMIPK<TSourceEnumerator>(in TSourceEnumerator EAHKFBMKAPP) where TSourceEnumerator : IEnumerator<TResultEnumerator>
	{
		return default(global::EBBKDPFMLMK<TSourceEnumerator, TResultEnumerator, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct EBBKDPFMLMK<TSourceEnumerator, TResultEnumerator, TResult> : global::HKIJFLLGBCF<TResult>, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : IEnumerator<TResultEnumerator> where TResultEnumerator : global::HKIJFLLGBCF<TResult>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private TSourceEnumerator OKDMEHFLNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private TResultEnumerator BIHDEIFBEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool KPPNKJIHKEM;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public TResult NDCKGIGIEHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2BA61A0", Offset = "0x2BA53A0", VA = "0x182BA61A0", Slot = "4")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	TResult IEnumerator<TResult>.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x2BA60B0", Offset = "0x2BA52B0", VA = "0x182BA60B0", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA60B0", Offset = "0x2BA52B0", VA = "0x182BA60B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x365CBF0", Offset = "0x365BDF0", VA = "0x18365CBF0")]
	internal EBBKDPFMLMK(in TSourceEnumerator EAHKFBMKAPP, in TResultEnumerator ALCHBPNPDML, bool GPAJBKHHMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x365CA70", Offset = "0x365BC70", VA = "0x18365CA70", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x365CBA0", Offset = "0x365BDA0", VA = "0x18365CBA0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x365CA20", Offset = "0x365BC20", VA = "0x18365CA20", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct EEDJFALACKF<TSourceEnumerator, TSource, TResult> : IDHHDMCOBIE, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : IDHHDMCOBIE, global::HKIJFLLGBCF<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private TSourceEnumerator OKDMEHFLNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly global::APFBIMKOGCI<TSource, TResult> COIFDHEFMCB;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int HKOLKDAEOPE
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x365EF90", Offset = "0x365E190", VA = "0x18365EF90", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public TResult NDCKGIGIEHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x365F690", Offset = "0x365E890", VA = "0x18365F690", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x365F5D0", Offset = "0x365E7D0", VA = "0x18365F5D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x24331E0", Offset = "0x24323E0", VA = "0x1824331E0")]
	internal EEDJFALACKF(in TSourceEnumerator EAHKFBMKAPP, global::APFBIMKOGCI<TSource, TResult> PGIJDGPOKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x365F130", Offset = "0x365E330", VA = "0x18365F130", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x365F3B0", Offset = "0x365E5B0", VA = "0x18365F3B0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x365EC70", Offset = "0x365DE70", VA = "0x18365EC70", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct CLDCKKHLHLD<TSourceEnumerator, TSource, TResultEnumerator, TResult> : global::HKIJFLLGBCF<TResult>, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : global::HKIJFLLGBCF<TSource> where TResultEnumerator : global::HKIJFLLGBCF<TResult>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private TSourceEnumerator OKDMEHFLNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private TResultEnumerator BIHDEIFBEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly global::APFBIMKOGCI<TSource, TResultEnumerator> COIFDHEFMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private bool KPPNKJIHKEM;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public TResult NDCKGIGIEHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2BA61A0", Offset = "0x2BA53A0", VA = "0x182BA61A0", Slot = "4")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	TResult IEnumerator<TResult>.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2BA60B0", Offset = "0x2BA52B0", VA = "0x182BA60B0", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2BA60B0", Offset = "0x2BA52B0", VA = "0x182BA60B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6140", Offset = "0x2BA5340", VA = "0x182BA6140")]
	internal CLDCKKHLHLD(in TSourceEnumerator EAHKFBMKAPP, in TResultEnumerator ALCHBPNPDML, global::APFBIMKOGCI<TSource, TResultEnumerator> PGIJDGPOKPP, bool GPAJBKHHMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5ED0", Offset = "0x2BA50D0", VA = "0x182BA5ED0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6060", Offset = "0x2BA5260", VA = "0x182BA6060", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5E80", Offset = "0x2BA5080", VA = "0x182BA5E80", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct FEOMCCBNBDC<TSource1Enumerator, TSource1, TSource2Enumerator, TSource2> : IDHHDMCOBIE, IEnumerator<(TSource1, TSource2)>, IEnumerator, IDisposable where TSource1Enumerator : IDHHDMCOBIE, global::HKIJFLLGBCF<TSource1> where TSource2Enumerator : IDHHDMCOBIE, global::HKIJFLLGBCF<TSource2>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private TSource1Enumerator FLFCMCLCDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private TSource2Enumerator EKKEOKNPLPN;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int HKOLKDAEOPE
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x34F32D0", Offset = "0x34F24D0", VA = "0x1834F32D0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public (TSource1, TSource2) NDCKGIGIEHE
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x34F3530", Offset = "0x34F2730", VA = "0x1834F3530", Slot = "5")]
		get
		{
			return default((TSource1, TSource2));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x34F3450", Offset = "0x34F2650", VA = "0x1834F3450", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x34F34F0", Offset = "0x34F26F0", VA = "0x1834F34F0")]
	internal FEOMCCBNBDC(in TSource1Enumerator BDGBDEHGNFO, in TSource2Enumerator DHGACIHGJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x34F3370", Offset = "0x34F2570", VA = "0x1834F3370", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x34F33E0", Offset = "0x34F25E0", VA = "0x1834F33E0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x34F3270", Offset = "0x34F2470", VA = "0x1834F3270", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct NEMEDMLPIOP<T, U> : global::FGLOCALHNHK<T, U>, IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly U AEDCMINJIBD;

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3491610", Offset = "0x3490810", VA = "0x183491610")]
	internal NEMEDMLPIOP(in U ECMLENMKENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x2433D40", Offset = "0x2432F40", VA = "0x182433D40", Slot = "4")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x43E6AE0", Offset = "0x43E5CE0", VA = "0x1843E6AE0", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x43E6AE0", Offset = "0x43E5CE0", VA = "0x1843E6AE0", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class EIBKKEPOMPB<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x22E3C60", Offset = "0x22E2E60", VA = "0x1822E3C60")]
	public static global::NEMEDMLPIOP<T, U> NPLCOEOMBMO<U>(in U ECMLENMKENJ) where U : IEnumerator<T>
	{
		return default(global::NEMEDMLPIOP<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct AINDKAENPBL<TSourceEnumerator, TSource, TResult> : IDHHDMCOBIE, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : IDHHDMCOBIE, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private TSourceEnumerator OKDMEHFLNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly Func<TSource, TResult> COIFDHEFMCB;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int HKOLKDAEOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x1F0C8E0", Offset = "0x1F0BAE0", VA = "0x181F0C8E0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public TResult NDCKGIGIEHE
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x1F0CA50", Offset = "0x1F0BC50", VA = "0x181F0CA50", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x1F0C9D0", Offset = "0x1F0BBD0", VA = "0x181F0C9D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x1F0CA10", Offset = "0x1F0BC10", VA = "0x181F0CA10")]
	internal AINDKAENPBL(in TSourceEnumerator EAHKFBMKAPP, Func<TSource, TResult> PGIJDGPOKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x1F0C930", Offset = "0x1F0BB30", VA = "0x181F0C930", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x1F0C980", Offset = "0x1F0BB80", VA = "0x181F0C980", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x1F0C890", Offset = "0x1F0BA90", VA = "0x181F0C890", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class HBEAINDEBCI
{
	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x278F7E0", Offset = "0x278E9E0", VA = "0x18278F7E0")]
	public static bool HAFEMMMFCII<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator EAHKFBMKAPP, in TArgs JCLMGKKJJJG, in global::BKEEFILGHBI<TArgs, TSource, bool> IOCNICJKMOB) where TSourceEnumerator : global::HKIJFLLGBCF<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2074160", Offset = "0x2073360", VA = "0x182074160")]
	public static int ADIAGLAPLIF<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator EAHKFBMKAPP, in TArgs JCLMGKKJJJG, global::BKEEFILGHBI<TArgs, TSource, bool> IOCNICJKMOB) where TSourceEnumerator : global::HKIJFLLGBCF<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x278F700", Offset = "0x278E900", VA = "0x18278F700")]
	public static bool DFGOBONIDKO<TSourceEnumerator, TSource>(this TSourceEnumerator EAHKFBMKAPP, in TSource GKPGLMINDLM) where TSourceEnumerator : global::HKIJFLLGBCF<TSource> where TSource : global::JKOLFBFAHAI<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2074450", Offset = "0x2073650", VA = "0x182074450")]
	public static int ONKPHBICBEN<TSourceEnumerator, TSource>(this TSourceEnumerator EAHKFBMKAPP, in TSource LDPMPDNIHLJ) where TSourceEnumerator : global::HKIJFLLGBCF<TSource> where TSource : global::JKOLFBFAHAI<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x1C98A90", Offset = "0x1C97C90", VA = "0x181C98A90")]
	public static global::EEDJFALACKF<TSourceEnumerator, TSource, TResult> GPFBNNFOEBM<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator EAHKFBMKAPP, global::APFBIMKOGCI<TSource, TResult> PGIJDGPOKPP) where TSourceEnumerator : IDHHDMCOBIE, global::HKIJFLLGBCF<TSource>
	{
		return default(global::EEDJFALACKF<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x1C98AE0", Offset = "0x1C97CE0", VA = "0x181C98AE0")]
	public static global::AINDKAENPBL<TSourceEnumerator, TSource, TResult> FDABAPJPCLP<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator EAHKFBMKAPP, Func<TSource, TResult> PGIJDGPOKPP) where TSourceEnumerator : IDHHDMCOBIE, IEnumerator<TSource>
	{
		return default(global::AINDKAENPBL<TSourceEnumerator, TSource, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class OOKADOAPDBI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x23E3EC0", Offset = "0x23E30C0", VA = "0x1823E3EC0")]
	public static bool HMAAHKBKIGL<TSourceEnumerator>(TSourceEnumerator EAHKFBMKAPP) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x1AF11B0", Offset = "0x1AF03B0", VA = "0x181AF11B0")]
	public static T JMPPIGIHKIB<TSourceEnumerator>(TSourceEnumerator EAHKFBMKAPP) where TSourceEnumerator : global::HKIJFLLGBCF<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2D14D00", Offset = "0x2D13F00", VA = "0x182D14D00")]
	public static global::CLDCKKHLHLD<TSourceEnumerator, TSource, TResultEnumerator, T> KOIKOCLFLKH<TSourceEnumerator, TSource, TResultEnumerator>(in TSourceEnumerator EAHKFBMKAPP, global::APFBIMKOGCI<TSource, TResultEnumerator> PGIJDGPOKPP) where TSourceEnumerator : global::HKIJFLLGBCF<TSource> where TResultEnumerator : global::HKIJFLLGBCF<T>
	{
		return default(global::CLDCKKHLHLD<TSourceEnumerator, TSource, TResultEnumerator, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x37505D0", Offset = "0x374F7D0", VA = "0x1837505D0")]
	public static string JIOAGCBDKIF<TSourceEnumerator>(TSourceEnumerator EAHKFBMKAPP) where TSourceEnumerator : IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2B538A0", Offset = "0x2B52AA0", VA = "0x182B538A0")]
	public static T[] AIMIHAKFONK<TSourceEnumerator>(TSourceEnumerator EAHKFBMKAPP) where TSourceEnumerator : IDHHDMCOBIE, IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x1F06F40", Offset = "0x1F06140", VA = "0x181F06F40")]
	public static T HKEHDPNFBEH<TSourceEnumerator>(TSourceEnumerator EAHKFBMKAPP) where TSourceEnumerator : IEnumerator<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x23E3FF0", Offset = "0x23E31F0", VA = "0x1823E3FF0")]
	public static bool MCLKKMNMOIB<TSourceEnumerator>(TSourceEnumerator EAHKFBMKAPP) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class HIFJGBHFBLF<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x1C98D00", Offset = "0x1C97F00", VA = "0x181C98D00")]
	public static global::FEOMCCBNBDC<TSource1Enumerator, T, TSource2Enumerator, U> EJICELGGADJ<TSource1Enumerator, TSource2Enumerator>(in TSource1Enumerator BDGBDEHGNFO, in TSource2Enumerator DHGACIHGJFO) where TSource1Enumerator : IDHHDMCOBIE, global::HKIJFLLGBCF<T> where TSource2Enumerator : IDHHDMCOBIE, global::HKIJFLLGBCF<U>
	{
		return default(global::FEOMCCBNBDC<TSource1Enumerator, T, TSource2Enumerator, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface JKIAJBAFJIL<T>
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::HKIJFLLGBCF<T> GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface FABBLLDBPKA<T, TEnumerator> : global::JKIAJBAFJIL<T>, global::FGLOCALHNHK<T, TEnumerator>, IEnumerable<T>, IEnumerable where TEnumerator : global::HKIJFLLGBCF<T>
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface HKIJFLLGBCF<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	T NDCKGIGIEHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface BELKBDCAPOC<T> : IDHHDMCOBIE
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T EBONCEPCBHO(int PJEHDDODHBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface FGLOCALHNHK<T, TEnumerator> : IEnumerable<T>, IEnumerable where TEnumerator : IEnumerator<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface IDHHDMCOBIE
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	int HKOLKDAEOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface JKOLFBFAHAI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LOBNKDPNGEC(in T MKCNOIKIBCA);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface LMHHMLFLAMF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::OLHECNNJKGE<T> GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface EKDGLFNDAOE<T, TEnumerator> : global::LMHHMLFLAMF<T>, global::FABBLLDBPKA<T, TEnumerator>, global::JKIAJBAFJIL<T>, global::FGLOCALHNHK<T, TEnumerator>, IEnumerable<T>, IEnumerable where TEnumerator : global::OLHECNNJKGE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface OLHECNNJKGE<T> : global::HKIJFLLGBCF<T>, IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	new T NDCKGIGIEHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public delegate void IBMPPFGCMLB<T>(in T FAAMNDLBHDG);
[Cpp2IlInjected.Token(Token = "0x200004A")]
public delegate void AAOEGCAELMA<T1, T2>(in T1 GPBNIIDBJBD, in T2 HJICALJOLMD);
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class BOIMPIIENMP
{
	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x27828D0", Offset = "0x2781AD0", VA = "0x1827828D0")]
	public static bool HPLFFMFLEBL<T, U>(this T EAHKFBMKAPP, in U ANFJLMLDELH) where T : global::JKOLFBFAHAI<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public delegate TResult APFBIMKOGCI<T, out TResult>(in T FAAMNDLBHDG);
[Cpp2IlInjected.Token(Token = "0x200004D")]
public delegate TResult BKEEFILGHBI<T1, T2, out TResult>(in T1 GPBNIIDBJBD, in T2 HJICALJOLMD);
[Cpp2IlInjected.Token(Token = "0x200004E")]
public delegate TResult ECIAMFCPEJC<T1, T2, T3, out TResult>(in T1 GPBNIIDBJBD, in T2 HJICALJOLMD, in T3 MMIADNEJKHJ);
[Cpp2IlInjected.Token(Token = "0x200004F")]
public delegate TResult JBMINHBKIAE<T1, T2, T3, T4, out TResult>(in T1 GPBNIIDBJBD, in T2 HJICALJOLMD, in T3 MMIADNEJKHJ, in T4 HDIMPIBEOJA);
[Cpp2IlInjected.Token(Token = "0x2000050")]
public delegate TResult IFPELLNGAGN<T1, T2, T3, T4, T5, out TResult>(in T1 GPBNIIDBJBD, in T2 HJICALJOLMD, in T3 MMIADNEJKHJ, in T4 HDIMPIBEOJA, in T5 GOFIIPMIBPB);
[Cpp2IlInjected.Token(Token = "0x2000051")]
public delegate TResult ANOMGOFAENP<T, TResult>(in T FAAMNDLBHDG);
[Cpp2IlInjected.Token(Token = "0x2000052")]
public delegate TResult PHPCCNBFNBE<T1, T2, TResult>(in T1 GPBNIIDBJBD, in T2 HJICALJOLMD);
[Cpp2IlInjected.Token(Token = "0x2000053")]
public delegate TResult JHJKHNNHGCO<T1, T2, T3, TResult>(in T1 GPBNIIDBJBD, in T2 HJICALJOLMD, in T3 MMIADNEJKHJ);
[Cpp2IlInjected.Token(Token = "0x2000054")]
[DefaultMember("Item")]
public struct CONHFIAMIJI<T> : global::EKDGLFNDAOE<T, global::CONHFIAMIJI<T>.OKFOJLLDAHJ>, global::LMHHMLFLAMF<T>, global::FABBLLDBPKA<T, global::CONHFIAMIJI<T>.OKFOJLLDAHJ>, global::JKIAJBAFJIL<T>, global::FGLOCALHNHK<T, global::CONHFIAMIJI<T>.OKFOJLLDAHJ>, IEnumerable<T>, IEnumerable, global::BELKBDCAPOC<T>, IDHHDMCOBIE
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct OKFOJLLDAHJ : IDHHDMCOBIE, global::OLHECNNJKGE<T>, global::HKIJFLLGBCF<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private T[] OKDMEHFLNAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int ILPKBKOCJBC;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public int HKOLKDAEOPE
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x2401EE0", Offset = "0x24010E0", VA = "0x182401EE0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public T NDCKGIGIEHE
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x2401FF0", Offset = "0x24011F0", VA = "0x182401FF0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		private T BJNAOIOHHBB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x408E930", Offset = "0x408DB30", VA = "0x18408E930", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x2401FA0", Offset = "0x24011A0", VA = "0x182401FA0", Slot = "7")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x2401FA0", Offset = "0x24011A0", VA = "0x182401FA0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x9CB790", Offset = "0x9CA990", VA = "0x1809CB790")]
		private OKFOJLLDAHJ(T[] EAHKFBMKAPP, int OHJLAHMBLMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2401F30", Offset = "0x2401130", VA = "0x182401F30")]
		public static OKFOJLLDAHJ NPLCOEOMBMO(T[] EAHKFBMKAPP)
		{
			return default(OKFOJLLDAHJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x2401F00", Offset = "0x2401100", VA = "0x182401F00", Slot = "9")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x2401F90", Offset = "0x2401190", VA = "0x182401F90", Slot = "11")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "8")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private T[] DPNEFFLPPEB;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int IKCNHOEKMBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2401EE0", Offset = "0x24010E0", VA = "0x182401EE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public int HKOLKDAEOPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x240A010", Offset = "0x2409210", VA = "0x18240A010", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public T NDDGGEMNAMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x240A0F0", Offset = "0x24092F0", VA = "0x18240A0F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6CB170", Offset = "0x6CA370", VA = "0x1806CB170")]
	internal CONHFIAMIJI(T[] BFDPPDNMBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x2409DF0", Offset = "0x2408FF0", VA = "0x182409DF0")]
	public static global::CONHFIAMIJI<T> AGHBDCJKPJC()
	{
		return default(global::CONHFIAMIJI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x2409FB0", Offset = "0x24091B0", VA = "0x182409FB0", Slot = "11")]
	public T EBONCEPCBHO(int OHJLAHMBLMG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x4087D30", Offset = "0x4086F30", VA = "0x184087D30")]
	public global::LNJMNEBOLAG<T> GDNKBFPKKGO()
	{
		return default(global::LNJMNEBOLAG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x4087DB0", Offset = "0x4086FB0", VA = "0x184087DB0", Slot = "8")]
	public OKFOJLLDAHJ GetEnumerator()
	{
		return default(OKFOJLLDAHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x4087C30", Offset = "0x4086E30", VA = "0x184087C30", Slot = "5")]
	private global::OLHECNNJKGE<T> ILIPCIHODDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x4087C30", Offset = "0x4086E30", VA = "0x184087C30", Slot = "7")]
	private global::HKIJFLLGBCF<T> DLBMGHHOAEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x4087C30", Offset = "0x4086E30", VA = "0x184087C30", Slot = "9")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x4087C30", Offset = "0x4086E30", VA = "0x184087C30", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class AELHLDFCHED
{
	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x1C94BA0", Offset = "0x1C93DA0", VA = "0x181C94BA0")]
	public static global::CONHFIAMIJI<T> NPLCOEOMBMO<T>(T[] BFDPPDNMBIM)
	{
		return default(global::CONHFIAMIJI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x1AEA110", Offset = "0x1AE9310", VA = "0x181AEA110")]
	public static global::CONHFIAMIJI<T> KCFLLKJCBKE<T>(this T[] EAHKFBMKAPP)
	{
		return default(global::CONHFIAMIJI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x1C94B70", Offset = "0x1C93D70", VA = "0x181C94B70")]
	public static global::CONHFIAMIJI<T>.OKFOJLLDAHJ ABFLBLOPAEG<T>(this T[] EAHKFBMKAPP)
	{
		return default(global::CONHFIAMIJI<T>.OKFOJLLDAHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x1AEA110", Offset = "0x1AE9310", VA = "0x181AEA110")]
	public static global::CONHFIAMIJI<T> IMOPBKNHMHM<T>(this T[] EAHKFBMKAPP)
	{
		return default(global::CONHFIAMIJI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct KOPPIJICGLJ<T, U> : global::EKDGLFNDAOE<T, U>, global::LMHHMLFLAMF<T>, global::FABBLLDBPKA<T, U>, global::JKIAJBAFJIL<T>, global::FGLOCALHNHK<T, U>, IEnumerable<T>, IEnumerable where U : global::OLHECNNJKGE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly U AEDCMINJIBD;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x269B7E0", Offset = "0x269A9E0", VA = "0x18269B7E0")]
	internal KOPPIJICGLJ(in U ECMLENMKENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7600E0", Offset = "0x75F2E0", VA = "0x1807600E0", Slot = "8")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2E4F680", Offset = "0x2E4E880", VA = "0x182E4F680", Slot = "5")]
	private global::OLHECNNJKGE<T> ILIPCIHODDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x2E4F680", Offset = "0x2E4E880", VA = "0x182E4F680", Slot = "7")]
	private global::HKIJFLLGBCF<T> DLBMGHHOAEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x2E4F680", Offset = "0x2E4E880", VA = "0x182E4F680", Slot = "9")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x2E4F680", Offset = "0x2E4E880", VA = "0x182E4F680", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class EPKEOBEOLBK<T>
{
	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x1C96B40", Offset = "0x1C95D40", VA = "0x181C96B40")]
	public static global::KOPPIJICGLJ<T, U> NPLCOEOMBMO<U>(in U ECMLENMKENJ) where U : global::OLHECNNJKGE<T>
	{
		return default(global::KOPPIJICGLJ<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[DefaultMember("Item")]
public class IJCLEEMOMND<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly Func<Internal, External> LPAKFHPINIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Func<External, Internal> OHBMOKMEILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private IList<Internal> JDGJMEHHHMC;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public IList<Internal> JKFEHANAJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x58CDF0", Offset = "0x58BFF0", VA = "0x18058CDF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5B4D70", Offset = "0x5B3F70", VA = "0x1805B4D70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool NPIKHPBKLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x60B990", Offset = "0x60AB90", VA = "0x18060B990", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x9D8E80", Offset = "0x9D8080", VA = "0x1809D8E80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public External NDDGGEMNAMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x269B6A0", Offset = "0x269A8A0", VA = "0x18269B6A0", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x269B740", Offset = "0x269A940", VA = "0x18269B740", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public int HKOLKDAEOPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x269B640", Offset = "0x269A840", VA = "0x18269B640", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x269B5B0", Offset = "0x269A7B0", VA = "0x18269B5B0")]
	public IJCLEEMOMND(Func<Internal, External> LPAKFHPINIB, Func<External, Internal> OHBMOKMEILC, bool BONAINDCLDA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x269B2C0", Offset = "0x269A4C0", VA = "0x18269B2C0", Slot = "6")]
	public int IndexOf(External GKPGLMINDLM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x269AEE0", Offset = "0x269A0E0", VA = "0x18269AEE0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x269AF40", Offset = "0x269A140", VA = "0x18269AF40", Slot = "13")]
	public bool Contains(External GKPGLMINDLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x269AFD0", Offset = "0x269A1D0", VA = "0x18269AFD0", Slot = "14")]
	public void CopyTo(External[] BFDPPDNMBIM, int DPCKJFODMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x269AE50", Offset = "0x269A050", VA = "0x18269AE50", Slot = "11")]
	public void Add(External GKPGLMINDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x269B3B0", Offset = "0x269A5B0", VA = "0x18269B3B0", Slot = "7")]
	public void Insert(int OHJLAHMBLMG, External GKPGLMINDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x269B520", Offset = "0x269A720", VA = "0x18269B520", Slot = "15")]
	public bool Remove(External GKPGLMINDLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x269B450", Offset = "0x269A650", VA = "0x18269B450", Slot = "8")]
	public void RemoveAt(int OHJLAHMBLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x269B1F0", Offset = "0x269A3F0", VA = "0x18269B1F0", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x1D76340", Offset = "0x1D75540", VA = "0x181D76340", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[DefaultMember("Item")]
public class NFNMNLGAHNN<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Func<Internal, External> LPAKFHPINIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyList<Internal> JDGJMEHHHMC;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public IReadOnlyList<Internal> JKFEHANAJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x58A4A0", Offset = "0x5896A0", VA = "0x18058A4A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool NPIKHPBKLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x58AFE0", Offset = "0x58A1E0", VA = "0x18058AFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public External NDDGGEMNAMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x4047810", Offset = "0x4046A10", VA = "0x184047810", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public int HKOLKDAEOPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x40477B0", Offset = "0x40469B0", VA = "0x1840477B0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x1E5DB50", Offset = "0x1E5CD50", VA = "0x181E5DB50")]
	public NFNMNLGAHNN(Func<Internal, External> LPAKFHPINIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x4047760", Offset = "0x4046960", VA = "0x184047760")]
	public NFNMNLGAHNN(IReadOnlyList<Internal> JDGJMEHHHMC, Func<Internal, External> LPAKFHPINIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x4047540", Offset = "0x4046740", VA = "0x184047540")]
	public void ICHOGCAINDD(External[] BFDPPDNMBIM, int DPCKJFODMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x4047470", Offset = "0x4046670", VA = "0x184047470", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x1D7DE50", Offset = "0x1D7D050", VA = "0x181D7DE50", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[DefaultMember("Item")]
public class JGGHHHJOEHA<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private IReadOnlyList<Internal> JDGJMEHHHMC;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public IReadOnlyList<Internal> JKFEHANAJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x58A1D0", Offset = "0x5893D0", VA = "0x18058A1D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x58A490", Offset = "0x589690", VA = "0x18058A490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public bool NPIKHPBKLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x58AFE0", Offset = "0x58A1E0", VA = "0x18058AFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public External NDDGGEMNAMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3A27EF0", Offset = "0x3A270F0", VA = "0x183A27EF0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int HKOLKDAEOPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3A27E90", Offset = "0x3A27090", VA = "0x183A27E90", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x1E5DB50", Offset = "0x1E5CD50", VA = "0x181E5DB50")]
	public JGGHHHJOEHA(IReadOnlyList<Internal> JDGJMEHHHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x3A27B50", Offset = "0x3A26D50", VA = "0x183A27B50")]
	public bool EFLIOKIPEDI(External GKPGLMINDLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3A27C60", Offset = "0x3A26E60", VA = "0x183A27C60")]
	public void ICHOGCAINDD(External[] BFDPPDNMBIM, int DPCKJFODMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x3A27BF0", Offset = "0x3A26DF0", VA = "0x183A27BF0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x1D76340", Offset = "0x1D75540", VA = "0x181D76340", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public abstract class EHNFJHLMGDB
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void PLOIKJIDAKI(object[] JCLMGKKJJJG);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	protected EHNFJHLMGDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class FCKODOHDPII<T> : EHNFJHLMGDB
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	protected struct HODPIPEIDEK
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public enum NAGALDIOELG
		{
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public NAGALDIOELG ALJEFDPBPKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public T GIFFKCDDBCP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int HAAPDJAJDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly bool FAENIJNDPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	protected readonly bool FGADLOJDDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	protected List<T> IMJAJMLHNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private List<HODPIPEIDEK> OADAEJAIMEB;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool GLGJMIENMEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3B2C800", Offset = "0x3B2BA00", VA = "0x183B2C800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x3B2C970", Offset = "0x3B2BB70", VA = "0x183B2C970")]
	protected FCKODOHDPII(bool FGADLOJDDKP, bool FAENIJNDPNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x3B2C5B0", Offset = "0x3B2B7B0", VA = "0x183B2C5B0")]
	protected bool JFNKCEMBDLB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x3B2C350", Offset = "0x3B2B550", VA = "0x183B2C350")]
	protected void DNECGIBNKMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x3B2C650", Offset = "0x3B2B850", VA = "0x183B2C650")]
	protected void LNFJPDPBDAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x36E38A0", Offset = "0x36E2AA0", VA = "0x1836E38A0")]
	private static void OEJCPLKHACH<U>(ref List<U> JDGJMEHHHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x3B2C430", Offset = "0x3B2B630", VA = "0x183B2C430", Slot = "5")]
	public void FKEGKEHNDJG(T GIFFKCDDBCP, bool FLBDMPBIPPO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x3B2C1F0", Offset = "0x3B2B3F0", VA = "0x183B2C1F0", Slot = "6")]
	public void CDCPBPNLMGM(T GIFFKCDDBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3B2C840", Offset = "0x3B2BA40", VA = "0x183B2C840")]
	public void OAHGKPPJHGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface BEODMGKCKNG
{
	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FKEGKEHNDJG(Action GIFFKCDDBCP, bool FLBDMPBIPPO = false);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CDCPBPNLMGM(Action GIFFKCDDBCP);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public sealed class COKNLFJLEMD : global::FCKODOHDPII<Action>, BEODMGKCKNG
{
	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x51008B0", Offset = "0x50FFAB0", VA = "0x1851008B0")]
	public COKNLFJLEMD(bool FGADLOJDDKP = false, bool FAENIJNDPNH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x5100610", Offset = "0x50FF810", VA = "0x185100610")]
	public void MAKGKKCPFOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x5100830", Offset = "0x50FFA30", VA = "0x185100830", Slot = "4")]
	public override void PLOIKJIDAKI(object[] JCLMGKKJJJG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x51005B0", Offset = "0x50FF7B0", VA = "0x1851005B0")]
	public static COKNLFJLEMD HHCFMGIIAPI(COKNLFJLEMD IAIOPAIDAJF, Action GIFFKCDDBCP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x51007D0", Offset = "0x50FF9D0", VA = "0x1851007D0")]
	public static COKNLFJLEMD PLIDCHNJEHM(COKNLFJLEMD IAIOPAIDAJF, Action GIFFKCDDBCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface DPPFFFHJPJI<T>
{
	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FKEGKEHNDJG(Action<T> GIFFKCDDBCP, bool FLBDMPBIPPO = false);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CDCPBPNLMGM(Action<T> GIFFKCDDBCP);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public sealed class DLPMHIELPJI<T> : global::FCKODOHDPII<Action<T>>, global::DPPFFFHJPJI<T>
{
	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x269A2B0", Offset = "0x26994B0", VA = "0x18269A2B0")]
	public DLPMHIELPJI(bool FGADLOJDDKP = false, bool FAENIJNDPNH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x3A7DCE0", Offset = "0x3A7CEE0", VA = "0x183A7DCE0")]
	public void MAKGKKCPFOE(T INOBBCFLJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x3A814A0", Offset = "0x3A806A0", VA = "0x183A814A0", Slot = "4")]
	public override void PLOIKJIDAKI(object[] JCLMGKKJJJG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x3A7DA00", Offset = "0x3A7CC00", VA = "0x183A7DA00")]
	public static global::DLPMHIELPJI<T> HHCFMGIIAPI(global::DLPMHIELPJI<T> IAIOPAIDAJF, Action<T> GIFFKCDDBCP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x3A81060", Offset = "0x3A80260", VA = "0x183A81060")]
	public static global::DLPMHIELPJI<T> PLIDCHNJEHM(global::DLPMHIELPJI<T> IAIOPAIDAJF, Action<T> GIFFKCDDBCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface KJHLJMEFBIF<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FKEGKEHNDJG(Action<T, U> GIFFKCDDBCP, bool FLBDMPBIPPO = false);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CDCPBPNLMGM(Action<T, U> GIFFKCDDBCP);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public sealed class IMENFOMAFOL<T, U> : global::FCKODOHDPII<Action<T, U>>, global::KJHLJMEFBIF<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x269A2B0", Offset = "0x26994B0", VA = "0x18269A2B0")]
	public IMENFOMAFOL(bool FGADLOJDDKP = false, bool FAENIJNDPNH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x26A2AA0", Offset = "0x26A1CA0", VA = "0x1826A2AA0")]
	public void MAKGKKCPFOE(T INOBBCFLJOF, U GJEFKCMNNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x26A6300", Offset = "0x26A5500", VA = "0x1826A6300", Slot = "4")]
	public override void PLOIKJIDAKI(object[] JCLMGKKJJJG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x26A2550", Offset = "0x26A1750", VA = "0x1826A2550")]
	public static global::IMENFOMAFOL<T, U> HHCFMGIIAPI(global::IMENFOMAFOL<T, U> IAIOPAIDAJF, Action<T, U> GIFFKCDDBCP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x26A5080", Offset = "0x26A4280", VA = "0x1826A5080")]
	public static global::IMENFOMAFOL<T, U> PLIDCHNJEHM(global::IMENFOMAFOL<T, U> IAIOPAIDAJF, Action<T, U> GIFFKCDDBCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface APKMIBKDPMO<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FKEGKEHNDJG(Action<T, U, V> GIFFKCDDBCP, bool FLBDMPBIPPO = false);

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CDCPBPNLMGM(Action<T, U, V> GIFFKCDDBCP);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public sealed class IHKENFDCFFF<T, U, V> : global::FCKODOHDPII<Action<T, U, V>>, global::APKMIBKDPMO<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x269A2B0", Offset = "0x26994B0", VA = "0x18269A2B0")]
	public IHKENFDCFFF(bool FGADLOJDDKP = false, bool FAENIJNDPNH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x2696830", Offset = "0x2695A30", VA = "0x182696830")]
	public void MAKGKKCPFOE(T INOBBCFLJOF, U GJEFKCMNNON, V DKNLKMNLNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x2698810", Offset = "0x2697A10", VA = "0x182698810", Slot = "4")]
	public override void PLOIKJIDAKI(object[] JCLMGKKJJJG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2696510", Offset = "0x2695710", VA = "0x182696510")]
	public static global::IHKENFDCFFF<T, U, V> HHCFMGIIAPI(global::IHKENFDCFFF<T, U, V> IAIOPAIDAJF, Action<T, U, V> GIFFKCDDBCP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2698770", Offset = "0x2697970", VA = "0x182698770")]
	public static global::IHKENFDCFFF<T, U, V> PLIDCHNJEHM(global::IHKENFDCFFF<T, U, V> IAIOPAIDAJF, Action<T, U, V> GIFFKCDDBCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface IPFJLHPBCAC<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FKEGKEHNDJG(Action<T, U, V, W> GIFFKCDDBCP, bool FLBDMPBIPPO = false);

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CDCPBPNLMGM(Action<T, U, V, W> GIFFKCDDBCP);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public sealed class PBDBEGEENOE<T, U, V, W> : global::FCKODOHDPII<Action<T, U, V, W>>, global::IPFJLHPBCAC<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x269A2B0", Offset = "0x26994B0", VA = "0x18269A2B0")]
	public PBDBEGEENOE(bool FGADLOJDDKP = false, bool FAENIJNDPNH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x31F5DF0", Offset = "0x31F4FF0", VA = "0x1831F5DF0")]
	public void MAKGKKCPFOE(T INOBBCFLJOF, U GJEFKCMNNON, V DKNLKMNLNPI, W OPOOFMFPPJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x31F8740", Offset = "0x31F7940", VA = "0x1831F8740", Slot = "4")]
	public override void PLOIKJIDAKI(object[] JCLMGKKJJJG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x31F5A20", Offset = "0x31F4C20", VA = "0x1831F5A20")]
	public static global::PBDBEGEENOE<T, U, V, W> HHCFMGIIAPI(global::PBDBEGEENOE<T, U, V, W> IAIOPAIDAJF, Action<T, U, V, W> GIFFKCDDBCP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x31F72F0", Offset = "0x31F64F0", VA = "0x1831F72F0")]
	public static global::PBDBEGEENOE<T, U, V, W> PLIDCHNJEHM(global::PBDBEGEENOE<T, U, V, W> IAIOPAIDAJF, Action<T, U, V, W> GIFFKCDDBCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface DAMPFJNLGHN<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FKEGKEHNDJG(Action<T, U, V, W, X> GIFFKCDDBCP, bool FLBDMPBIPPO = false);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CDCPBPNLMGM(Action<T, U, V, W, X> GIFFKCDDBCP);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public sealed class PFCHHMDKADP<T, U, V, W, X> : global::FCKODOHDPII<Action<T, U, V, W, X>>, global::DAMPFJNLGHN<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x269A2B0", Offset = "0x26994B0", VA = "0x18269A2B0")]
	public PFCHHMDKADP(bool FGADLOJDDKP = false, bool FAENIJNDPNH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x381FC80", Offset = "0x381EE80", VA = "0x18381FC80")]
	public void MAKGKKCPFOE(T INOBBCFLJOF, U GJEFKCMNNON, V DKNLKMNLNPI, W OPOOFMFPPJH, X CNMHAFPCMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x38202E0", Offset = "0x381F4E0", VA = "0x1838202E0", Slot = "4")]
	public override void PLOIKJIDAKI(object[] JCLMGKKJJJG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x381F8D0", Offset = "0x381EAD0", VA = "0x18381F8D0")]
	public static global::PFCHHMDKADP<T, U, V, W, X> HHCFMGIIAPI(global::PFCHHMDKADP<T, U, V, W, X> IAIOPAIDAJF, Action<T, U, V, W, X> GIFFKCDDBCP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x381FF20", Offset = "0x381F120", VA = "0x18381FF20")]
	public static global::PFCHHMDKADP<T, U, V, W, X> PLIDCHNJEHM(global::PFCHHMDKADP<T, U, V, W, X> IAIOPAIDAJF, Action<T, U, V, W, X> GIFFKCDDBCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface KCBDCMHEEAD<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FKEGKEHNDJG(Action<T, U, V, W, X, Y> GIFFKCDDBCP, bool FLBDMPBIPPO = false);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CDCPBPNLMGM(Action<T, U, V, W, X, Y> GIFFKCDDBCP);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public sealed class JKPBDPIAGHO<T, U, V, W, X, Y> : global::FCKODOHDPII<Action<T, U, V, W, X, Y>>, global::KCBDCMHEEAD<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x269A2B0", Offset = "0x26994B0", VA = "0x18269A2B0")]
	public JKPBDPIAGHO(bool FGADLOJDDKP = false, bool FAENIJNDPNH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x321B4D0", Offset = "0x321A6D0", VA = "0x18321B4D0")]
	public void MAKGKKCPFOE(T INOBBCFLJOF, U GJEFKCMNNON, V DKNLKMNLNPI, W OPOOFMFPPJH, X CNMHAFPCMJK, Y HNFKJOACHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x321BE00", Offset = "0x321B000", VA = "0x18321BE00", Slot = "4")]
	public override void PLOIKJIDAKI(object[] JCLMGKKJJJG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x321B430", Offset = "0x321A630", VA = "0x18321B430")]
	public static global::JKPBDPIAGHO<T, U, V, W, X, Y> HHCFMGIIAPI(global::JKPBDPIAGHO<T, U, V, W, X, Y> IAIOPAIDAJF, Action<T, U, V, W, X, Y> GIFFKCDDBCP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x321BD60", Offset = "0x321AF60", VA = "0x18321BD60")]
	public static global::JKPBDPIAGHO<T, U, V, W, X, Y> PLIDCHNJEHM(global::JKPBDPIAGHO<T, U, V, W, X, Y> IAIOPAIDAJF, Action<T, U, V, W, X, Y> GIFFKCDDBCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public sealed class KMDFBNLCDCB<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public readonly struct NNDFJHNOFMP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly global::KMDFBNLCDCB<T> ANIJHKECFFB;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public T JDIGBEFEDMD
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x2E55750", Offset = "0x2E54950", VA = "0x182E55750")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x2E55770", Offset = "0x2E54970", VA = "0x182E55770", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6CB170", Offset = "0x6CA370", VA = "0x1806CB170")]
		public NNDFJHNOFMP(global::KMDFBNLCDCB<T> ANIJHKECFFB)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct JEPPMPAFBDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder<NNDFJHNOFMP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public global::KMDFBNLCDCB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x2E47480", Offset = "0x2E46680", VA = "0x182E47480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x2E46FC0", Offset = "0x2E461C0", VA = "0x182E46FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct HOOOFIGGABP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder<NNDFJHNOFMP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public global::KMDFBNLCDCB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x2E46C20", Offset = "0x2E45E20", VA = "0x182E46C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x2E46FC0", Offset = "0x2E461C0", VA = "0x182E46FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly SemaphoreSlim EMFBPHBKECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private T EKGIJPBHKEA;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int AHKJMGPPMPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x2E4E260", Offset = "0x2E4D460", VA = "0x182E4E260")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x2E4E320", Offset = "0x2E4D520", VA = "0x182E4E320")]
	public KMDFBNLCDCB(in T EKGIJPBHKEA, int MNPJDCAKHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2E4E3C0", Offset = "0x2E4D5C0", VA = "0x182E4E3C0")]
	public KMDFBNLCDCB(in T EKGIJPBHKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2E4E1E0", Offset = "0x2E4D3E0", VA = "0x182E4E1E0")]
	public NNDFJHNOFMP EKCGGLKACLK()
	{
		return default(NNDFJHNOFMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2E4E220", Offset = "0x2E4D420", VA = "0x182E4E220")]
	public NNDFJHNOFMP EKCGGLKACLK(CancellationToken IHCDPGIEMEN)
	{
		return default(NNDFJHNOFMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x2E4DF00", Offset = "0x2E4D100", VA = "0x182E4DF00")]
	[AsyncStateMachine(typeof(global::KMDFBNLCDCB<>.JEPPMPAFBDK))]
	public Task<NNDFJHNOFMP> CFLBNKFOKGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x2E4DD80", Offset = "0x2E4CF80", VA = "0x182E4DD80")]
	[AsyncStateMachine(typeof(global::KMDFBNLCDCB<>.HOOOFIGGABP))]
	public Task<NNDFJHNOFMP> CFLBNKFOKGA(CancellationToken IHCDPGIEMEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class PFHPNNABAJA
{
	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x5104F90", Offset = "0x5104190", VA = "0x185104F90")]
	public static global::KMDFBNLCDCB<ONAHGIBPGPN> NPLCOEOMBMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x5104FF0", Offset = "0x51041F0", VA = "0x185104FF0")]
	public static global::KMDFBNLCDCB<ONAHGIBPGPN> NPLCOEOMBMO(int MNPJDCAKHEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x1C98030", Offset = "0x1C97230", VA = "0x181C98030")]
	public static global::KMDFBNLCDCB<T> NPLCOEOMBMO<T>(in T EKGIJPBHKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x2091810", Offset = "0x2090A10", VA = "0x182091810")]
	public static global::KMDFBNLCDCB<T> NPLCOEOMBMO<T>(in T EKGIJPBHKEA, int MNPJDCAKHEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class IGJPHJDNDCC<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public delegate bool FEFECACILBP(global::IGJPHJDNDCC<T> HGDPCCBPGAD);

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class AFEBLCPJOAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public global::IGJPHJDNDCC<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
		public AFEBLCPJOAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x39E9FC0", Offset = "0x39E91C0", VA = "0x1839E9FC0")]
		internal bool <FindNode>b__0(global::IGJPHJDNDCC<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public T KJPJBAMIJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public LinkedList<global::IGJPHJDNDCC<T>> CEJLNIHKMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public global::IGJPHJDNDCC<T> BALGPFHLKGA;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public global::IGJPHJDNDCC<T> MKIKBMOICDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x5DD130", Offset = "0x5DC330", VA = "0x1805DD130")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x39F4FC0", Offset = "0x39F41C0", VA = "0x1839F4FC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool JKNFKMCPGLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x39F4750", Offset = "0x39F3950", VA = "0x1839F4750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool BPLBELCNGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x39F4900", Offset = "0x39F3B00", VA = "0x1839F4900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public global::IGJPHJDNDCC<T> FKEBKHEAMCO
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x39F6850", Offset = "0x39F5A50", VA = "0x1839F6850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x39F6970", Offset = "0x39F5B70", VA = "0x1839F6970")]
	public IGJPHJDNDCC(T MJOMLFAJDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x39F5D00", Offset = "0x39F4F00", VA = "0x1839F5D00")]
	public global::IGJPHJDNDCC<T> GMBLMGAPPHN(T DCCHBDGNEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x39F6680", Offset = "0x39F5880", VA = "0x1839F6680")]
	public global::IGJPHJDNDCC<T> OHDFPDOCLGH(T KDJLNPNEGGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x39F4780", Offset = "0x39F3980", VA = "0x1839F4780")]
	public global::IGJPHJDNDCC<T> CDCPBPNLMGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x39F6260", Offset = "0x39F5460", VA = "0x1839F6260")]
	public void OAHGKPPJHGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x39F5E20", Offset = "0x39F5020", VA = "0x1839F5E20")]
	public global::IGJPHJDNDCC<T> KFANODFGGCG(T AGCGKNDGLDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x39F4940", Offset = "0x39F3B40", VA = "0x1839F4940")]
	public static void DJCNHMPFHFM(global::IGJPHJDNDCC<T> BHBEEPEGNMH, FEFECACILBP CBAONAHOLAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x36EB040", Offset = "0x36EA240", VA = "0x1836EB040")]
	public static void DJCNHMPFHFM<A>(global::IGJPHJDNDCC<T> BHBEEPEGNMH, Func<global::IGJPHJDNDCC<T>, A, bool> CBAONAHOLAG, A FAAMNDLBHDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x39F56D0", Offset = "0x39F48D0", VA = "0x1839F56D0")]
	public static string EOMOJBBHIIH(global::IGJPHJDNDCC<T> BHBEEPEGNMH, int MJDCBDAMEKF = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x39F4530", Offset = "0x39F3730", VA = "0x1839F4530")]
	public static global::IGJPHJDNDCC<T> AEGEOELHHLE(global::IGJPHJDNDCC<T> BHBEEPEGNMH, T OKDCIMGOHLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class MDJPDDGIJFC<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public delegate Task<TResult> APCCICKOMOD(TRequest JBJBLKDALON, CancellationToken IHCDPGIEMEN);

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public enum BBJBAIIOPAC
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class MIMGPAOHECF
	{
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private const float JALGPJBFEKB = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TimeSpan EICHOHDFGPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int GHJBEMODCDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public BBJBAIIOPAC FILKNFNJNEF;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public static readonly MIMGPAOHECF GCMDIACLNPO;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public float GLBEILELOEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x2415990", Offset = "0x2414B90", VA = "0x182415990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public TimeSpan BJACJIAJJDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x58A1D0", Offset = "0x5893D0", VA = "0x18058A1D0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x2415BC0", Offset = "0x2414DC0", VA = "0x182415BC0")]
		public MIMGPAOHECF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private readonly struct AMPHJDPEELB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public readonly TRequest JBJBLKDALON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public readonly CancellationToken IHCDPGIEMEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public readonly TaskCompletionSource<TResult> LJKDPAOIJGC;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x24007E0", Offset = "0x23FF9E0", VA = "0x1824007E0")]
		public AMPHJDPEELB(TRequest JBJBLKDALON, TaskCompletionSource<TResult> LJKDPAOIJGC, CancellationToken IHCDPGIEMEN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class IBLDMJDGEBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
		public IBLDMJDGEBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x1E5DB20", Offset = "0x1E5CD20", VA = "0x181E5DB20")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct JBECHELFBEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public global::MDJPDDGIJFC<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x2405BD0", Offset = "0x2404DD0", VA = "0x182405BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7EBFE0", Offset = "0x7EB1E0", VA = "0x1807EBFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class IHLBEGKPLOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public AMPHJDPEELB req;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public global::MDJPDDGIJFC<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
		public IHLBEGKPLOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x2405510", Offset = "0x2404710", VA = "0x182405510")]
		internal void <ProcessQueue>b__0(Task<TResult> task)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly CancellationTokenSource HMOFFKJNCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly List<AMPHJDPEELB> NCPLHMNIMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly MIMGPAOHECF NGPOCCKCLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly APCCICKOMOD PLKJLAKDPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private Task HOCOCPMNODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int ADMCBKBOAJC;

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x240DA80", Offset = "0x240CC80", VA = "0x18240DA80")]
	public MDJPDDGIJFC(APCCICKOMOD PLKJLAKDPHF, [Optional] MIMGPAOHECF NGPOCCKCLIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x240D050", Offset = "0x240C250", VA = "0x18240D050")]
	public Task<TResult> DAJMKPLCIPK(TRequest JBJBLKDALON, CancellationToken IHCDPGIEMEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x240D2F0", Offset = "0x240C4F0", VA = "0x18240D2F0")]
	private void KEJKKJGJINO(AMPHJDPEELB KPBGFCPOFPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x240CA80", Offset = "0x240BC80", VA = "0x18240CA80")]
	[AsyncStateMachine(typeof(global::MDJPDDGIJFC<, >.JBECHELFBEI))]
	private Task COGDNKEIGCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x240C3B0", Offset = "0x240B5B0", VA = "0x18240C3B0")]
	private AMPHJDPEELB BOGBPEGAGNI()
	{
		return default(AMPHJDPEELB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x240D690", Offset = "0x240C890", VA = "0x18240D690")]
	private void PJOAPLGDGEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x240D2B0", Offset = "0x240C4B0", VA = "0x18240D2B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class FOOCEMJNEHP<TKey, TVal> : global::FLANAIHPCKF<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int ONGNHLDEIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	internal Dictionary<TKey, (TVal value, int size)> MFHMFHFNOEJ;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	internal override int NEKAFFFHDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x3C957F0", Offset = "0x3C949F0", VA = "0x183C957F0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	internal int JHAJNKJJMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x3C95250", Offset = "0x3C94450", VA = "0x183C95250")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public override int HKOLKDAEOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x3C955D0", Offset = "0x3C947D0", VA = "0x183C955D0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x3C95930", Offset = "0x3C94B30", VA = "0x183C95930")]
	public FOOCEMJNEHP(int FDMAMJMNCKL, [Optional] ANHBNJDCOMD BJOMKFEHCCP, [Optional] IEqualityComparer<TKey> ICAGKMPOJAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x3C95280", Offset = "0x3C94480", VA = "0x183C95280")]
	public void AGJJIJBNPJN(TKey ICIBGJCBOAM, TVal LDPMPDNIHLJ, bool LGLEOCACOEC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x3C95320", Offset = "0x3C94520", VA = "0x183C95320")]
	public bool BBDIMFFIBGH(TKey ICIBGJCBOAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x3C95630", Offset = "0x3C94830", VA = "0x183C95630", Slot = "6")]
	public override bool FINJNPJEIIJ(TKey JPKOBNDDOPL, out TVal LDPMPDNIHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x3C953A0", Offset = "0x3C945A0", VA = "0x183C953A0")]
	public bool DNLHDFGDLMJ(TKey ICIBGJCBOAM, TVal LDPMPDNIHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x3C956E0", Offset = "0x3C948E0", VA = "0x183C956E0")]
	public bool LGLEICGCMON(TKey ICIBGJCBOAM, TVal LDPMPDNIHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x3C958C0", Offset = "0x3C94AC0", VA = "0x183C958C0", Slot = "7")]
	public override void OAHGKPPJHGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x3C95820", Offset = "0x3C94A20", VA = "0x183C95820")]
	private bool NKJBMHLHJDH(TKey ICIBGJCBOAM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DefaultMember("Item")]
public class FLANAIHPCKF<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public delegate int ANHBNJDCOMD(TKey ICIBGJCBOAM, TVal LDPMPDNIHLJ);

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private class APFNBMGOLAL
	{
		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public TKey CHPMOLLJLMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x58A1D0", Offset = "0x5893D0", VA = "0x18058A1D0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public TVal JDIGBEFEDMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x6B8C80", Offset = "0x6B7E80", VA = "0x1806B8C80")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x75E9D0", Offset = "0x75DBD0", VA = "0x18075E9D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public int FNLLLKNNJJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x6DC5D0", Offset = "0x6DB7D0", VA = "0x1806DC5D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x6DC600", Offset = "0x6DB800", VA = "0x1806DC600")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public DateTime FKGMEBBEAPI
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x58CDF0", Offset = "0x58BFF0", VA = "0x18058CDF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x10B28D0", Offset = "0x10B1AD0", VA = "0x1810B28D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x3C8C940", Offset = "0x3C8BB40", VA = "0x183C8C940")]
		public APFNBMGOLAL(TKey ICIBGJCBOAM, TVal KGBAJDIJIJD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const int GDPFKFANBAF = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<TKey, LinkedListNode<APFNBMGOLAL>> HLPAOBPMGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly LinkedList<APFNBMGOLAL> ABCNBLECKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	protected readonly ANHBNJDCOMD BJOMKFEHCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly TimeSpan GNMJGHEOJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly KKEIPDPAOHB ODPCHGAOEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int FMDDGIGBHPA;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int IONMEHKOHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6E59D0", Offset = "0x6E4BD0", VA = "0x1806E59D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	private bool MDEEOKPFDIA
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x3C8FB80", Offset = "0x3C8ED80", VA = "0x183C8FB80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	internal virtual int NEKAFFFHDGG
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6E59E0", Offset = "0x6E4BE0", VA = "0x1806E59E0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	private int NAOLJMJHENM
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x20CDF00", Offset = "0x20CD100", VA = "0x1820CDF00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public virtual int HKOLKDAEOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x1D763F0", Offset = "0x1D755F0", VA = "0x181D763F0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public IEnumerable<TKey> ICJDAAGJBDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x3C8E8B0", Offset = "0x3C8DAB0", VA = "0x183C8E8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public TVal NDDGGEMNAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x27996C0", Offset = "0x27988C0", VA = "0x1827996C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x2D79340", Offset = "0x2D78540", VA = "0x182D79340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x3C901C0", Offset = "0x3C8F3C0", VA = "0x183C901C0")]
	public FLANAIHPCKF(int FDMAMJMNCKL, [Optional] ANHBNJDCOMD BJOMKFEHCCP, [Optional] IEqualityComparer<TKey> ICAGKMPOJAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x3C90170", Offset = "0x3C8F370", VA = "0x183C90170")]
	public FLANAIHPCKF(TimeSpan GNMJGHEOJHB, [Optional] IEqualityComparer<TKey> ICAGKMPOJAK, [Optional] KKEIPDPAOHB ODPCHGAOEJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x3C90120", Offset = "0x3C8F320", VA = "0x183C90120")]
	public FLANAIHPCKF(int FDMAMJMNCKL, TimeSpan GNMJGHEOJHB, [Optional] IEqualityComparer<TKey> ICAGKMPOJAK, [Optional] KKEIPDPAOHB ODPCHGAOEJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x3C8FED0", Offset = "0x3C8F0D0", VA = "0x183C8FED0")]
	public FLANAIHPCKF(int FDMAMJMNCKL, ANHBNJDCOMD BJOMKFEHCCP, TimeSpan GNMJGHEOJHB, [Optional] IEqualityComparer<TKey> ICAGKMPOJAK, [Optional] KKEIPDPAOHB ODPCHGAOEJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x3C8F220", Offset = "0x3C8E420", VA = "0x183C8F220")]
	public void GCDMEPPKFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x3C8E510", Offset = "0x3C8D710", VA = "0x183C8E510")]
	public void AMBCHILDJAC(TKey ICIBGJCBOAM, TVal LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x3C8E750", Offset = "0x3C8D950", VA = "0x183C8E750")]
	public bool CDCPBPNLMGM(TKey ICIBGJCBOAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x3C8F0C0", Offset = "0x3C8E2C0", VA = "0x183C8F0C0")]
	private TVal FMKAFPOODOK(TKey JPKOBNDDOPL)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x3C8EC30", Offset = "0x3C8DE30", VA = "0x183C8EC30", Slot = "6")]
	public virtual bool FINJNPJEIIJ(TKey JPKOBNDDOPL, out TVal LDPMPDNIHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x3C8FC10", Offset = "0x3C8EE10", VA = "0x183C8FC10", Slot = "7")]
	public virtual void OAHGKPPJHGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x3C8E5D0", Offset = "0x3C8D7D0", VA = "0x183C8E5D0")]
	private bool BEMNIJNIJMO(APFNBMGOLAL OKNHECADDHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x3C8F5B0", Offset = "0x3C8E7B0", VA = "0x183C8F5B0")]
	private void GNKFIJGKJGH(LinkedListNode<APFNBMGOLAL> PEFANDHDHBP, TVal FBOPOEBKKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x3C8F7E0", Offset = "0x3C8E9E0", VA = "0x183C8F7E0")]
	private void IAAHDADOJIB(TKey ICIBGJCBOAM, TVal LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x3C8EF20", Offset = "0x3C8E120", VA = "0x183C8EF20")]
	private void FKCIDMLKHDE(APFNBMGOLAL OKNHECADDHE, TVal FBOPOEBKKLB, int EKHBMEJDNBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DefaultMember("Item")]
public class KEJFJILDBAN<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly List<T> JDGJMEHHHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private HashSet<T> CILOHBOBLFO;

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public int HKOLKDAEOPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x1E5DB20", Offset = "0x1E5CD20", VA = "0x181E5DB20", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public bool NPIKHPBKLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x58AEC0", Offset = "0x58A0C0", VA = "0x18058AEC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public T NDDGGEMNAMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x2A770A0", Offset = "0x2A762A0", VA = "0x182A770A0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x4413190", Offset = "0x4412390", VA = "0x184413190", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x3A24170", Offset = "0x3A23370", VA = "0x183A24170", Slot = "11")]
	public void Add(T GKPGLMINDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x4412980", Offset = "0x4411B80", VA = "0x184412980")]
	public bool HOLPEDBHFBN(T GKPGLMINDLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x4413030", Offset = "0x4412230", VA = "0x184413030", Slot = "15")]
	public bool Remove(T GKPGLMINDLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x321C890", Offset = "0x321BA90", VA = "0x18321C890", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x1D6FE50", Offset = "0x1D6F050", VA = "0x181D6FE50", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x44128F0", Offset = "0x4411AF0", VA = "0x1844128F0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x322C590", Offset = "0x322B790", VA = "0x18322C590", Slot = "13")]
	public bool Contains(T GKPGLMINDLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x3799A80", Offset = "0x3798C80", VA = "0x183799A80", Slot = "14")]
	public void CopyTo(T[] BFDPPDNMBIM, int DPCKJFODMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x240A880", Offset = "0x2409A80", VA = "0x18240A880", Slot = "6")]
	public int IndexOf(T GKPGLMINDLM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x4412BA0", Offset = "0x4411DA0", VA = "0x184412BA0", Slot = "7")]
	public void Insert(int OHJLAHMBLMG, T GKPGLMINDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x4412ED0", Offset = "0x44120D0", VA = "0x184412ED0", Slot = "8")]
	public void RemoveAt(int OHJLAHMBLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x4412D30", Offset = "0x4411F30", VA = "0x184412D30")]
	public void JAJDCGJIKMC(Predicate<T> BLAOOANMOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x4412950", Offset = "0x4411B50", VA = "0x184412950")]
	public void FLBOMADMHKP(Comparison<T> CGOHNEMPGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x44130B0", Offset = "0x44122B0", VA = "0x1844130B0")]
	public KEJFJILDBAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public static class FKNOODKCNHD
{
	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5101260", Offset = "0x5100460", VA = "0x185101260")]
	public static Vector3 CDFLPMLKMOK(this GameObject BCGNPHHHPEM, float IBCICOMFCJL)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x228DF60", Offset = "0x228D160", VA = "0x18228DF60")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x5106D60", Offset = "0x5105F60", VA = "0x185106D60")]
		public SerializedGuid(in Guid AAGNCBDBNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x5106B80", Offset = "0x5105D80", VA = "0x185106B80")]
		public static SerializedGuid NBLGEELBMNA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x5106A60", Offset = "0x5105C60", VA = "0x185106A60")]
		public static SerializedGuid FOFJPPABKEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x5106C00", Offset = "0x5105E00", VA = "0x185106C00")]
		public bool OEHKNHFKDPO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x5106D30", Offset = "0x5105F30", VA = "0x185106D30", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x5106C90", Offset = "0x5105E90", VA = "0x185106C90", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x5106AF0", Offset = "0x5105CF0", VA = "0x185106AF0")]
		public bool ICHDBJIAOKL(in Guid AAGNCBDBNJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x51068E0", Offset = "0x5105AE0", VA = "0x1851068E0", Slot = "7")]
		public bool Equals(SerializedGuid MKCNOIKIBCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x5106980", Offset = "0x5105B80", VA = "0x185106980", Slot = "0")]
		public override bool Equals(object ANFJLMLDELH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x5106AE0", Offset = "0x5105CE0", VA = "0x185106AE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x51068B0", Offset = "0x5105AB0", VA = "0x1851068B0", Slot = "6")]
		public int CompareTo(SerializedGuid MKCNOIKIBCA)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class LODABMJBIEI : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public readonly Type EOFNMCOFFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public readonly string NBBPJDDIHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public readonly bool PMBKDIIMFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public readonly bool IOIGCLDKEBO;

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x51046A0", Offset = "0x51038A0", VA = "0x1851046A0")]
	public LODABMJBIEI(Type OLFGGFECEGJ, string EOPEIBGKEHI, bool GFDPACIBABL = false, bool LLMKLFPGJAH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public interface MCGCDIGIEAB
{
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public interface DEIMAOMKEAO<T> : MCGCDIGIEAB
{
	[Cpp2IlInjected.Token(Token = "0x17000079")]
	T JDIGBEFEDMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	bool IOJPGPLDHJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	string MIFLCMNLKBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::DEIMAOMKEAO<T> KAAJNCDADGC(Action<T> FGDHKJHKAEC);

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::DEIMAOMKEAO<T> LICFEMCKHOG(Action<T> FGDHKJHKAEC);

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::DEIMAOMKEAO<T> HFMEOGDIOFP(Action<T, T> JAPBMBBJDAD);

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::DEIMAOMKEAO<T> PIMHABEMHPD(Action<T, T> JAPBMBBJDAD);

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::DEIMAOMKEAO<T> IJPBGIIAPDK(Action<string> AECECLABPDC);

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::DEIMAOMKEAO<T> OOGEGHPONFK(Action<string> AECECLABPDC);
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class EBDCHFCKJID<T> : global::DEIMAOMKEAO<T>, MCGCDIGIEAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private global::IMENFOMAFOL<T, T> EMIIEMIKMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private global::DLPMHIELPJI<T> NGKJPNBLOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private global::DLPMHIELPJI<string> AODKNAPMOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private string GKOBJIGADIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private T KCKMKGJDDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private bool CPOACGCAAJC;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public T JDIGBEFEDMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x5B2A30", Offset = "0x5B1C30", VA = "0x1805B2A30", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x27A2D20", Offset = "0x27A1F20", VA = "0x1827A2D20", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public bool IOJPGPLDHJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x60C8B0", Offset = "0x60BAB0", VA = "0x18060C8B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public string MIFLCMNLKBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x5B30C0", Offset = "0x5B22C0", VA = "0x1805B30C0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x29D3000", Offset = "0x29D2200", VA = "0x1829D3000", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x365CD30", Offset = "0x365BF30", VA = "0x18365CD30")]
	private void IFHIFCHCLLO(T LCFAIGDEKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x365CC90", Offset = "0x365BE90", VA = "0x18365CC90")]
	private void HOAAALHBIIG(string NJKILBPPEMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x365CE60", Offset = "0x365C060", VA = "0x18365CE60")]
	public void JNOECIFKPLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x365CC40", Offset = "0x365BE40", VA = "0x18365CC40", Slot = "6")]
	public global::DEIMAOMKEAO<T> HFMEOGDIOFP(Action<T, T> JAPBMBBJDAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x365D060", Offset = "0x365C260", VA = "0x18365D060", Slot = "7")]
	public global::DEIMAOMKEAO<T> PIMHABEMHPD(Action<T, T> JAPBMBBJDAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x365CF10", Offset = "0x365C110", VA = "0x18365CF10", Slot = "4")]
	public global::DEIMAOMKEAO<T> KAAJNCDADGC(Action<T> JAPBMBBJDAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x365CFA0", Offset = "0x365C1A0", VA = "0x18365CFA0", Slot = "5")]
	public global::DEIMAOMKEAO<T> LICFEMCKHOG(Action<T> FGDHKJHKAEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x365CDD0", Offset = "0x365BFD0", VA = "0x18365CDD0", Slot = "8")]
	public global::DEIMAOMKEAO<T> IJPBGIIAPDK(Action<string> AECECLABPDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x365CFF0", Offset = "0x365C1F0", VA = "0x18365CFF0", Slot = "9")]
	public global::DEIMAOMKEAO<T> OOGEGHPONFK(Action<string> AECECLABPDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x365D0B0", Offset = "0x365C2B0", VA = "0x18365D0B0")]
	public EBDCHFCKJID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public static class AKJNBNNKGAB
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class HPNKLGGBEAM<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public global::DEIMAOMKEAO<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::EJFMGPECAAO<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
		public HPNKLGGBEAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x2C7B110", Offset = "0x2C7A310", VA = "0x182C7B110")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x1C94CB0", Offset = "0x1C93EB0", VA = "0x181C94CB0")]
	public static global::FJLAHCBCPIJ<T> BGIIDPHCDHJ<T>(this global::DEIMAOMKEAO<T> JOBGHGFIOAC, Action<T> JNJKIKIBHIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public class DCKHMOOINHA<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public readonly struct IGLOILALIKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public readonly long EMDPMIEKKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public readonly long LNANGJEFFCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public readonly int FBIAGHDMLGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public readonly int BPKLKNJKCLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public readonly bool GAEIKFDGFDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private readonly string ACOHFBJIACF;

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x38A2BB0", Offset = "0x38A1DB0", VA = "0x1838A2BB0")]
		public IGLOILALIKP(long EMDPMIEKKMP, int FBIAGHDMLGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x38A2B80", Offset = "0x38A1D80", VA = "0x1838A2B80")]
		public IGLOILALIKP(long EMDPMIEKKMP, long LNANGJEFFCI, int FBIAGHDMLGJ, int BPKLKNJKCLI, bool GAEIKFDGFDN, string ACOHFBJIACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x38A2970", Offset = "0x38A1B70", VA = "0x1838A2970")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void BEGKELNEBCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x38A29E0", Offset = "0x38A1BE0", VA = "0x1838A29E0")]
		public int IMFMBJOAICI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x38A2B60", Offset = "0x38A1D60", VA = "0x1838A2B60")]
		public int OIKIBIBAEGE(int CELNJAGHCFL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x38A2AF0", Offset = "0x38A1CF0", VA = "0x1838A2AF0")]
		public double ODPNJMLIBIN()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x38A2A30", Offset = "0x38A1C30", VA = "0x1838A2A30")]
		public IGLOILALIKP JHLJLJPGLIG(long LNANGJEFFCI, int BPKLKNJKCLI)
		{
			return default(IGLOILALIKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public class JEOAIEOFIKM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public readonly TKey CHPMOLLJLMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private readonly global::DCKHMOOINHA<TKey> MFCFDDLDEMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private List<JEOAIEOFIKM> IIFMCEINABL;

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public string PBGCIAADOBN
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x1F8C8A0", Offset = "0x1F8BAA0", VA = "0x181F8C8A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x2964320", Offset = "0x2963520", VA = "0x182964320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public IEnumerable<JEOAIEOFIKM> CEJLNIHKMMD
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x38A2D60", Offset = "0x38A1F60", VA = "0x1838A2D60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public IGLOILALIKP MKMPEKHIGMP
		{
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x1089130", Offset = "0x1088330", VA = "0x181089130")]
			[CompilerGenerated]
			get
			{
				return default(IGLOILALIKP);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x38A2C20", Offset = "0x38A1E20", VA = "0x1838A2C20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x38A3040", Offset = "0x38A2240", VA = "0x1838A3040")]
		internal JEOAIEOFIKM(global::DCKHMOOINHA<TKey> MFCFDDLDEMB, TKey ICIBGJCBOAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x38A2C50", Offset = "0x38A1E50", VA = "0x1838A2C50")]
		public JEOAIEOFIKM BEEOHDNHJHP(TKey ICIBGJCBOAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x38A2F40", Offset = "0x38A2140", VA = "0x1838A2F40")]
		public void PBCNFENBLMM(TKey ICIBGJCBOAM, Action<JEOAIEOFIKM> GIFFKCDDBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x2441F90", Offset = "0x2441190", VA = "0x182441F90")]
		public T PBCNFENBLMM<T>(TKey ICIBGJCBOAM, Func<JEOAIEOFIKM, T> LIGNCFOLDGO)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x22FEA90", Offset = "0x22FDC90", VA = "0x1822FEA90")]
		[AsyncStateMachine(typeof(MOKBELLHHLH))]
		public Task<T> CGINLMEGKIB<T>(TKey ICIBGJCBOAM, Func<JEOAIEOFIKM, Task<T>> LIGNCFOLDGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x38A2D80", Offset = "0x38A1F80", VA = "0x1838A2D80", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class CKHDCEIDNEE : IEnumerable<(TKey, List<TKey>, IGLOILALIKP)>, IEnumerable, IEnumerator<(TKey, List<TKey>, IGLOILALIKP)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private (TKey key, List<TKey> path, IGLOILALIKP timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public global::DCKHMOOINHA<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private IEnumerator<(TKey key, List<TKey> path, IGLOILALIKP timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private (TKey, List<TKey>, IGLOILALIKP) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x2E41300", Offset = "0x2E40500", VA = "0x182E41300", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, IGLOILALIKP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x3891060", Offset = "0x3890260", VA = "0x183891060", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x2E417D0", Offset = "0x2E409D0", VA = "0x182E417D0")]
		[DebuggerHidden]
		public CKHDCEIDNEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x38910C0", Offset = "0x38902C0", VA = "0x1838910C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x3890CE0", Offset = "0x388FEE0", VA = "0x183890CE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x3891140", Offset = "0x3890340", VA = "0x183891140")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x3891010", Offset = "0x3890210", VA = "0x183891010", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x3890F50", Offset = "0x3890150", VA = "0x183890F50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, IGLOILALIKP)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x1D7B290", Offset = "0x1D7A490", VA = "0x181D7B290", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class NLPIALICHIM : IEnumerable<(TKey, List<TKey>, IGLOILALIKP)>, IEnumerable, IEnumerator<(TKey, List<TKey>, IGLOILALIKP)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private (TKey key, List<TKey> path, IGLOILALIKP timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private JEOAIEOFIKM timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public JEOAIEOFIKM <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public global::DCKHMOOINHA<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private IEnumerator<JEOAIEOFIKM> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private IEnumerator<(TKey key, List<TKey> path, IGLOILALIKP timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		private (TKey, List<TKey>, IGLOILALIKP) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x2E41300", Offset = "0x2E40500", VA = "0x182E41300", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, IGLOILALIKP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x38A44F0", Offset = "0x38A36F0", VA = "0x1838A44F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x2E417D0", Offset = "0x2E409D0", VA = "0x182E417D0")]
		[DebuggerHidden]
		public NLPIALICHIM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x38A4550", Offset = "0x38A3750", VA = "0x1838A4550", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x38A3E90", Offset = "0x38A3090", VA = "0x1838A3E90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x38A4620", Offset = "0x38A3820", VA = "0x1838A4620")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x38A4670", Offset = "0x38A3870", VA = "0x1838A4670")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x38A44A0", Offset = "0x38A36A0", VA = "0x1838A44A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x38A43D0", Offset = "0x38A35D0", VA = "0x1838A43D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, IGLOILALIKP)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x240B570", Offset = "0x240A770", VA = "0x18240B570", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly Action<TKey, IGLOILALIKP> FFJAHHCMMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly Action<TKey, IGLOILALIKP> HJPCGFHCFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Action<global::DCKHMOOINHA<TKey>> PMICMPLBOIA;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private const string PCPDLFDDLHN = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly JEOAIEOFIKM DHHDDGDBKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private bool HNFBEGJGFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private int ACKFBGPBJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly Stopwatch JEGEGDKCNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public readonly int FCGJOOKDPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private string LNMKKDKOPPC;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public JEOAIEOFIKM CPJLBFJHNJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x5B30C0", Offset = "0x5B22C0", VA = "0x1805B30C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	[NotNull]
	public string PBGCIAADOBN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x5DD130", Offset = "0x5DC330", VA = "0x1805DD130")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x3894680", Offset = "0x3893880", VA = "0x183894680")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public long PJFDCCPKOPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x3894660", Offset = "0x3893860", VA = "0x183894660")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public int HPMEMDNKINM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x3894580", Offset = "0x3893780", VA = "0x183894580")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x38948D0", Offset = "0x3893AD0", VA = "0x1838948D0")]
	public DCKHMOOINHA(TKey MALHDDBIHLH, [Optional] int? FBIAGHDMLGJ, [Optional][CanBeNull] Stopwatch JEGEGDKCNAH, [Optional] Action<TKey, IGLOILALIKP> FFJAHHCMMCK, [Optional] Action<TKey, IGLOILALIKP> HJPCGFHCFDO, [Optional] Action<global::DCKHMOOINHA<TKey>> PMICMPLBOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x38945B0", Offset = "0x38937B0", VA = "0x1838945B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x3894640", Offset = "0x3893840", VA = "0x183894640")]
	public void EPFGIGMLGND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x3894560", Offset = "0x3893760", VA = "0x183894560")]
	public void BEICBFPBBEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x38947B0", Offset = "0x38939B0", VA = "0x1838947B0")]
	[IteratorStateMachine(typeof(global::DCKHMOOINHA<>.CKHDCEIDNEE))]
	public IEnumerable<(TKey, List<TKey>, IGLOILALIKP)> KGGLEANKJJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x38946E0", Offset = "0x38938E0", VA = "0x1838946E0")]
	[IteratorStateMachine(typeof(global::DCKHMOOINHA<>.NLPIALICHIM))]
	private IEnumerable<(TKey, List<TKey>, IGLOILALIKP)> KGGLEANKJJO(List<TKey> ACCIHAJODLB, JEOAIEOFIKM KHLDFIMDCFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x3894840", Offset = "0x3893A40", VA = "0x183894840")]
	private (long, int) MLALNCGNKNO()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public abstract class NFLDGDCINLP<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut KFGJPJDKOIL(global::DCKHMOOINHA<TKey> MFCFDDLDEMB);

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
	protected NFLDGDCINLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public abstract class GDFELHBEPEP<TKey> : global::NFLDGDCINLP<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public delegate string IIEKMDNHNJN(TKey ICIBGJCBOAM);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F960", Offset = "0x1E4EB60", VA = "0x181E4F960")]
	protected string ECONCKEIKCN(double JEPMOHFIJAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F910", Offset = "0x1E4EB10", VA = "0x181E4F910")]
	protected string DGBPNMGEOHJ(int NCBJIODFECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x1E4FB90", Offset = "0x1E4ED90", VA = "0x181E4FB90")]
	private static string MNBICJANKOD(TKey ICIBGJCBOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x1E4FAE0", Offset = "0x1E4ECE0", VA = "0x181E4FAE0", Slot = "4")]
	public override string KFGJPJDKOIL(global::DCKHMOOINHA<TKey> MFCFDDLDEMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F9C0", Offset = "0x1E4EBC0", VA = "0x181E4F9C0")]
	public string KFGJPJDKOIL(global::DCKHMOOINHA<TKey> MFCFDDLDEMB, [NotNull] IIEKMDNHNJN FJLOHDHLGHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string AOOPAJOEEOO(global::DCKHMOOINHA<TKey> MFCFDDLDEMB, [NotNull] IIEKMDNHNJN FJLOHDHLGHA);

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x1D76340", Offset = "0x1D75540", VA = "0x181D76340")]
	protected GDFELHBEPEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class JKJHFEBDDOD<TKey> : global::NFLDGDCINLP<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public delegate string FOFAGJBIGIM(TKey ICIBGJCBOAM);

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int CJIGONLKAEF = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly string NKGJANHMJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly double HAKBPFNCEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly bool OMLEMJBJHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly int OPJHNJAPDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly ISet<string> LFGFEJPJFNK;

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x321B280", Offset = "0x321A480", VA = "0x18321B280")]
	private static string MNBICJANKOD(TKey ICIBGJCBOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x321B3A0", Offset = "0x321A5A0", VA = "0x18321B3A0")]
	public JKJHFEBDDOD(string NKGJANHMJPO = "F2", double HAKBPFNCEJN = double.MaxValue, bool OMLEMJBJHOA = false, int OPJHNJAPDGO = int.MaxValue, [Optional] ISet<string> LFGFEJPJFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x321B1D0", Offset = "0x321A3D0", VA = "0x18321B1D0", Slot = "4")]
	public override Dictionary<string, string> KFGJPJDKOIL(global::DCKHMOOINHA<TKey> MFCFDDLDEMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x321B2C0", Offset = "0x321A4C0", VA = "0x18321B2C0")]
	private bool NEAEBMIHLHJ(string FJPBLBFEJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x321AD30", Offset = "0x3219F30", VA = "0x18321AD30")]
	public Dictionary<string, string> KFGJPJDKOIL(global::DCKHMOOINHA<TKey> MFCFDDLDEMB, FOFAGJBIGIM FJLOHDHLGHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x321AB80", Offset = "0x3219D80", VA = "0x18321AB80")]
	private string HOBBOBBOLGP(StringBuilder OAHHBIJDLAO, List<TKey> NHAAHDFJMBF, FOFAGJBIGIM FJLOHDHLGHA, bool JJIBBOBMIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x321AA20", Offset = "0x3219C20", VA = "0x18321AA20")]
	private static void ABJKIOOBAEH(StringBuilder EFKNBBBOAOJ, string JEOJLJBKIGF, bool JCBKBPPEHDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public class PEBONCEEGFB<TKey> : global::GDFELHBEPEP<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct CBMBJCNONNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public IIEKMDNHNJN keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static global::PEBONCEEGFB<TKey> LHIDCGAAEOA;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private const int LDKDONFLION = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly string[] FHLIBEHIKFB;

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x381F710", Offset = "0x381E910", VA = "0x18381F710")]
	private PEBONCEEGFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x381E710", Offset = "0x381D910", VA = "0x18381E710", Slot = "5")]
	protected override string AOOPAJOEEOO(global::DCKHMOOINHA<TKey> MFCFDDLDEMB, IIEKMDNHNJN FJLOHDHLGHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x381F530", Offset = "0x381E730", VA = "0x18381F530")]
	[CompilerGenerated]
	internal static string HEFCAHKJPKO(string FFDFHKHNKMD, TKey ICIBGJCBOAM, ref CBMBJCNONNE P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public class ODFKHCEEFAL<TKey> : global::GDFELHBEPEP<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class FDKGNFHPFHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public IIEKMDNHNJN keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
		public FDKGNFHPFHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x2E3F150", Offset = "0x2E3E350", VA = "0x182E3F150")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x4320E10", Offset = "0x4320010", VA = "0x184320E10", Slot = "5")]
	protected override string AOOPAJOEEOO(global::DCKHMOOINHA<TKey> MFCFDDLDEMB, IIEKMDNHNJN FJLOHDHLGHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x321CAD0", Offset = "0x321BCD0", VA = "0x18321CAD0")]
	public ODFKHCEEFAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public sealed class IFAOELFNCJI : global::DCKHMOOINHA<string>
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class PPGEHDPDPNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public Action<IFAOELFNCJI> callback;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public PPGEHDPDPNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x5105060", Offset = "0x5104260", VA = "0x185105060")]
		internal void <Wrap>b__0(global::DCKHMOOINHA<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x5102180", Offset = "0x5101380", VA = "0x185102180")]
	public IFAOELFNCJI([Optional] string KEAOMAIBCJG, [Optional] int? FBIAGHDMLGJ, [Optional] Stopwatch JEGEGDKCNAH, [Optional] Action<string, IGLOILALIKP> FFJAHHCMMCK, [Optional] Action<string, IGLOILALIKP> HJPCGFHCFDO, [Optional] Action<IFAOELFNCJI> PMICMPLBOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x51020C0", Offset = "0x51012C0", VA = "0x1851020C0")]
	private static Action<global::DCKHMOOINHA<string>> PBCNFENBLMM(Action<IFAOELFNCJI> JNJKIKIBHIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public abstract class KKEIPDPAOHB
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	private class HHPJHCNNCMA : KKEIPDPAOHB
	{
		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public static KKEIPDPAOHB LHIDCGAAEOA
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x5101A00", Offset = "0x5100C00", VA = "0x185101A00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public override DateTime IGCCKMNMOPP
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x51019A0", Offset = "0x5100BA0", VA = "0x1851019A0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public override float HAGHEGIEMPA
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x51019F0", Offset = "0x5100BF0", VA = "0x1851019F0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x5101B00", Offset = "0x5100D00", VA = "0x185101B00")]
		public HHPJHCNNCMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static KKEIPDPAOHB GILBFFENHIF;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public static KKEIPDPAOHB GCMDIACLNPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x51035A0", Offset = "0x51027A0", VA = "0x1851035A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public abstract DateTime IGCCKMNMOPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public abstract float HAGHEGIEMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	protected KKEIPDPAOHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class EKOKBLHDCKO : global::MHLELEJGIKP<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x5101010", Offset = "0x5100210", VA = "0x185101010")]
	public EKOKBLHDCKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class MHLELEJGIKP<T> : global::CECHLNGIBOA<T>, OMHNEOBKAFB, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Task<T> JCKNPCEAPEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x58A1D0", Offset = "0x5893D0", VA = "0x18058A1D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Task BOMOHLJKJGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x1D70480", Offset = "0x1D6F680", VA = "0x181D70480", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public global::FJLAHCBCPIJ<T> KDMFILHKNEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private KJNBDKOEMOC EOKHEAHONDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x1D75470", Offset = "0x1D74670", VA = "0x181D75470", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x3799D20", Offset = "0x3798F20", VA = "0x183799D20")]
	public MHLELEJGIKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public class KHDBDHJKBAO : global::IMGPOINJIOJ<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x5103550", Offset = "0x5102750", VA = "0x185103550")]
	public KHDBDHJKBAO(Exception NBMFBMPPBLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public class IMGPOINJIOJ<T> : global::CECHLNGIBOA<T>, OMHNEOBKAFB, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Task<T> JCKNPCEAPEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x58A1D0", Offset = "0x5893D0", VA = "0x18058A1D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private Task BOMOHLJKJGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x1D70480", Offset = "0x1D6F680", VA = "0x181D70480", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public global::FJLAHCBCPIJ<T> KDMFILHKNEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private KJNBDKOEMOC EOKHEAHONDN
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x1D75470", Offset = "0x1D74670", VA = "0x181D75470", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x3A24070", Offset = "0x3A23270", VA = "0x183A24070")]
	public IMGPOINJIOJ(Exception NBMFBMPPBLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public interface OMHNEOBKAFB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000098")]
	[NotNull]
	Task JCKNPCEAPEM
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	[NotNull]
	KJNBDKOEMOC KDMFILHKNEB
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public interface CECHLNGIBOA<T> : OMHNEOBKAFB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	[NotNull]
	new Task<T> JCKNPCEAPEM
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	[NotNull]
	new global::FJLAHCBCPIJ<T> KDMFILHKNEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public abstract class BFGBCJOAKEP<TTask, T> : global::CECHLNGIBOA<T>, OMHNEOBKAFB, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class OEKCFBFCIDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public global::BFGBCJOAKEP<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
		public OEKCFBFCIDE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static bool EOOOEPPKDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly Task<T> MEIGONNEKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	protected readonly CancellationTokenSource DPKOKAKGNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private bool HNFBEGJGFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private SynchronizationContext CCBGCJNKPAF;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Task<T> JCKNPCEAPEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x58A1D0", Offset = "0x5893D0", VA = "0x18058A1D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Task BOMOHLJKJGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x58A1D0", Offset = "0x5893D0", VA = "0x18058A1D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public global::FJLAHCBCPIJ<T> KDMFILHKNEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private KJNBDKOEMOC EOKHEAHONDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x2314460", Offset = "0x2313660", VA = "0x182314460", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool BJJJLOGDMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x60B990", Offset = "0x60AB90", VA = "0x18060B990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x390ACB0", Offset = "0x3909EB0", VA = "0x18390ACB0")]
	static BFGBCJOAKEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x390AE20", Offset = "0x390A020", VA = "0x18390AE20")]
	protected BFGBCJOAKEP(TTask MEIGONNEKEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x390A6D0", Offset = "0x39098D0", VA = "0x18390A6D0", Slot = "1")]
	~BFGBCJOAKEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x390A6A0", Offset = "0x39098A0", VA = "0x18390A6A0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x390A810", Offset = "0x3909A10", VA = "0x18390A810")]
	private void HDNJGCNGFLG(bool MAIMBOGJJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T BGBJEFFEBHB(TTask KFDHEPJJKED);

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void NDLDGLBHEPD();

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x390AAF0", Offset = "0x3909CF0", VA = "0x18390AAF0")]
	[CompilerGenerated]
	private void MDBGHMBBIBK(object DDBPFEGDPNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public interface MJOFFDGGHLP
{
	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	float HKHGGNGKKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event OHBDHPIDOMM PBPIMHFDMAJ;
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public class JKDKBHMCEIL : MJOFFDGGHLP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public readonly struct IKBFMPBFCJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public readonly float NHGAHBMEICL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public readonly float DOCCFFKKACL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		internal readonly bool BHHDDHBMDKJ;

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public float FNLLLKNNJJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x51022A0", Offset = "0x51014A0", VA = "0x1851022A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x5102410", Offset = "0x5101610", VA = "0x185102410")]
		public IKBFMPBFCJA(float NDIGKIEANGO, float EGKHKAOEMCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x51022B0", Offset = "0x51014B0", VA = "0x1851022B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class KAFHFLMCFNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public JKDKBHMCEIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public KAFHFLMCFNL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private readonly int FDMAMJMNCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private int OBPLHPADIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly MJOFFDGGHLP[] KMKJGAMLELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly OHBDHPIDOMM[] KJIJKIGPLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly IKBFMPBFCJA[] MEHEOAOOHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private IKBFMPBFCJA BKDJBOEIJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly EPPFOLCFBIO JBAHAKFNODM;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public IKBFMPBFCJA NEGBGADIHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x33A52B0", Offset = "0x33A44B0", VA = "0x1833A52B0")]
		get
		{
			return default(IKBFMPBFCJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float HKHGGNGKKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x5102C70", Offset = "0x5101E70", VA = "0x185102C70", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event OHBDHPIDOMM PBPIMHFDMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x5102B30", Offset = "0x5101D30", VA = "0x185102B30", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x51032A0", Offset = "0x51024A0", VA = "0x1851032A0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x5103360", Offset = "0x5102560", VA = "0x185103360")]
	public JKDKBHMCEIL(int FDMAMJMNCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x5102BF0", Offset = "0x5101DF0", VA = "0x185102BF0")]
	public EPPFOLCFBIO CDFLGILKBGG(IKBFMPBFCJA FAFOBDEDNLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x5102E70", Offset = "0x5102070", VA = "0x185102E70")]
	public void MBGIKBIICJL(MJOFFDGGHLP GBOKFIGFJBI, [Optional] IKBFMPBFCJA JOABHOELKMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x5102E20", Offset = "0x5102020", VA = "0x185102E20")]
	internal int IGGHBJHDLHJ(MJOFFDGGHLP BMNLCKAKLGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x5103250", Offset = "0x5102450", VA = "0x185103250")]
	internal IKBFMPBFCJA NFNHLHBNFNK(int OHJLAHMBLMG)
	{
		return default(IKBFMPBFCJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x5102C90", Offset = "0x5101E90", VA = "0x185102C90", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public delegate void OHBDHPIDOMM(float BLNLAIPAPOD);
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class CHHIGLPAGII
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	internal const float BCEKAHNPGNE = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class FMFDAFMPHCC
{
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	private class EDCAENJDLPJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly MJOFFDGGHLP BMNLCKAKLGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private readonly OHBDHPIDOMM JNJKIKIBHIN;

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x5100EE0", Offset = "0x51000E0", VA = "0x185100EE0")]
		public EDCAENJDLPJ(MJOFFDGGHLP BMNLCKAKLGH, OHBDHPIDOMM JNJKIKIBHIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x5100E90", Offset = "0x5100090", VA = "0x185100E90", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x51014F0", Offset = "0x51006F0", VA = "0x1851014F0")]
	internal static bool CLAMOIFGHEI(float KICBFMPMNBH, float DLFOEJDCAKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x3D2BDD0", Offset = "0x3D2AFD0", VA = "0x183D2BDD0")]
	internal static float MFOLPIGKPBK(float KICBFMPMNBH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x5101570", Offset = "0x5100770", VA = "0x185101570")]
	public static IDisposable PBENABANNDF(this MJOFFDGGHLP BMNLCKAKLGH, OHBDHPIDOMM JNJKIKIBHIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public class EPPFOLCFBIO : MJOFFDGGHLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private float BLNLAIPAPOD;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public float HKHGGNGKKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xF17C60", Offset = "0xF16E60", VA = "0x180F17C60", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x51010F0", Offset = "0x51002F0", VA = "0x1851010F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event OHBDHPIDOMM PBPIMHFDMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x5101050", Offset = "0x5100250", VA = "0x185101050", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x51011C0", Offset = "0x51003C0", VA = "0x1851011C0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public EPPFOLCFBIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public class GIFKBLIJFGO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public readonly Type EOFNMCOFFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public readonly string NBBPJDDIHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public readonly bool PMBKDIIMFKA;

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x51016F0", Offset = "0x51008F0", VA = "0x1851016F0")]
	public GIFKBLIJFGO(Type OLFGGFECEGJ, string EOPEIBGKEHI, bool GFDPACIBABL = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class HBFIBFJNOJF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x5101750", Offset = "0x5100950", VA = "0x185101750")]
	public HBFIBFJNOJF(string NJKILBPPEMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x51017C0", Offset = "0x51009C0", VA = "0x1851017C0")]
	public HBFIBFJNOJF(string NJKILBPPEMD, Exception DAABKFILMIE)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x58AED0", Offset = "0x58A0D0", VA = "0x18058AED0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x5AE710", Offset = "0x5AD910", VA = "0x1805AE710")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public T this[int PJEHDDODHBJ, int HEBMFKBNFAI]
		{
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x1F85820", Offset = "0x1F84A20", VA = "0x181F85820")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x1F858C0", Offset = "0x1F84AC0", VA = "0x181F858C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x1F85790", Offset = "0x1F84990", VA = "0x181F85790")]
		public Array2D(uint HDKAONFKHGH, uint IPFKOEAAMDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x1F85710", Offset = "0x1F84910", VA = "0x181F85710")]
		public void OAHGKPPJHGI()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x50FF380", Offset = "0x50FE580", VA = "0x1850FF380")]
		public Array2DVector3(uint HDKAONFKHGH, uint IPFKOEAAMDI)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal static class GJNLGJPAEOI
{
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public const int PGMEEANPNNG = -1;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public const int DFAPFMEJBCF = 0;
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[DefaultMember("Item")]
public class CIOGIJMFBGJ<THandle, TValue> : IDisposable where THandle : struct, ABPBGICCMKA where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly List<THandle> IFLKPMNPFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly List<TValue> ADFGPDABJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly Func<TValue> OIMNJHJAAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly Action<TValue> BCGEIJJLJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private int JELJBEAFGGO;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public TValue NDDGGEMNAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2FD0", Offset = "0x2BA21D0", VA = "0x182BA2FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x2BA35F0", Offset = "0x2BA27F0", VA = "0x182BA35F0")]
	public CIOGIJMFBGJ(Action<TValue> BCGEIJJLJPG, [Optional] Func<TValue> OIMNJHJAAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2E50", Offset = "0x2BA2050", VA = "0x182BA2E50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x2BA34A0", Offset = "0x2BA26A0", VA = "0x182BA34A0")]
	public THandle MFDAKPCHIOJ()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2ED0", Offset = "0x2BA20D0", VA = "0x182BA2ED0")]
	public THandle FKEGKEHNDJG(TValue LDPMPDNIHLJ)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2BC0", Offset = "0x2BA1DC0", VA = "0x182BA2BC0")]
	public bool CDCPBPNLMGM(THandle DFDBDIGAGLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3280", Offset = "0x2BA2480", VA = "0x182BA3280")]
	public bool LMNCOHNCPBE(THandle DFDBDIGAGLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3040", Offset = "0x2BA2240", VA = "0x182BA3040")]
	public bool IHNEFFJOGBK(THandle DFDBDIGAGLK, out TValue LDPMPDNIHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2F40", Offset = "0x2BA2140", VA = "0x182BA2F40")]
	public TValue FMKAFPOODOK(THandle DFDBDIGAGLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2A20", Offset = "0x2BA1C20", VA = "0x182BA2A20")]
	public bool BDOEAIKIIHP(THandle DFDBDIGAGLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2FA0", Offset = "0x2BA21A0", VA = "0x182BA2FA0")]
	private THandle GNBGFICINOI(int OHJLAHMBLMG)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2B90", Offset = "0x2BA1D90", VA = "0x182BA2B90")]
	private TValue BGIIDPHCDHJ(int OHJLAHMBLMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x2BA35B0", Offset = "0x2BA27B0", VA = "0x182BA35B0")]
	private void PJFDEOAALDJ(int OHJLAHMBLMG, in THandle DFDBDIGAGLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3000", Offset = "0x2BA2200", VA = "0x182BA3000")]
	private void IFHIFCHCLLO(int OHJLAHMBLMG, in TValue LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2D40", Offset = "0x2BA1F40", VA = "0x182BA2D40")]
	private THandle CMCOENHIKKI()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2AD0", Offset = "0x2BA1CD0", VA = "0x182BA2AD0")]
	private void BFJKDAKLKPF(THandle DFDBDIGAGLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2F90", Offset = "0x2BA2190", VA = "0x182BA2F90")]
	private int GCMDPOGHHMM(int BGPOJNMOBBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x2BA35A0", Offset = "0x2BA27A0", VA = "0x182BA35A0")]
	private bool OEDMCAHFANF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9A0", Offset = "0x5DABA0", VA = "0x1805DB9A0")]
	private void JFLDHAOBOJD(THandle DFDBDIGAGLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x2BA30E0", Offset = "0x2BA22E0", VA = "0x182BA30E0")]
	private bool IMKJLNHNMHJ(out THandle DFDBDIGAGLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2C70", Offset = "0x2BA1E70", VA = "0x182BA2C70")]
	private bool CDIJPADLAHC(out THandle DFDBDIGAGLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3540", Offset = "0x2BA2740", VA = "0x182BA3540")]
	private void MGJOPDFKCLB(THandle DFDBDIGAGLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3160", Offset = "0x2BA2360", VA = "0x182BA3160")]
	private void JMAMBKBOGCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public interface ABPBGICCMKA
{
	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	int AJKNHICCIOI
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	int DEHBMHFAMKN
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public interface EMFMIACAOHB<T> : ABPBGICCMKA, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public static class JJKFEIJBNCB
{
	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x2790710", Offset = "0x278F910", VA = "0x182790710")]
	public static bool BHHDDHBMDKJ<T>(this T DFDBDIGAGLK) where T : struct, ABPBGICCMKA
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public class LCIDKHNIENE
{
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	private enum DKMANMGCHHF : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private int AGODCCIEBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private bool OFLLDMLPEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private DKMANMGCHHF DHICEDFONNC;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool AGHBDCJKPJC
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x5103960", Offset = "0x5102B60", VA = "0x185103960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool IDOHLJGDIEP
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x5104650", Offset = "0x5103850", VA = "0x185104650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x5104670", Offset = "0x5103870", VA = "0x185104670")]
	public LCIDKHNIENE(bool OFLLDMLPEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x5103C60", Offset = "0x5102E60", VA = "0x185103C60")]
	public void MHNPJNAOJGI(object ANFJLMLDELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5103BB0", Offset = "0x5102DB0", VA = "0x185103BB0")]
	public void LEGPACGJEEH(int LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x5104660", Offset = "0x5103860", VA = "0x185104660")]
	public void PMEEIEMBJCM(uint HEPDKMCAJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x5103890", Offset = "0x5102A90", VA = "0x185103890")]
	public void DBDEJKCEEPD(bool CAMCOMLDHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x51038B0", Offset = "0x5102AB0", VA = "0x1851038B0")]
	public void EEBDFCOKEPI(long BEHGKOKBGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5103B70", Offset = "0x5102D70", VA = "0x185103B70")]
	public void KENBMEEGKHF(ulong LOAMIPMNHJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5103B00", Offset = "0x5102D00", VA = "0x185103B00")]
	public void JJNKMMHHBHH(string IDFBJHKLGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5104180", Offset = "0x5103380", VA = "0x185104180")]
	public void NBINOGECMPG(Enum NBMFBMPPBLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5103970", Offset = "0x5102B70", VA = "0x185103970")]
	public void FDKACICGPIL(IList JDGJMEHHHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x25FD230", Offset = "0x25FC430", VA = "0x1825FD230")]
	public void HMGBOEGGLBN<T, U>(Dictionary<T, U> FOLPEMJHAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x5104210", Offset = "0x5103410", VA = "0x185104210")]
	private void NKEAMELJDCC(IDictionary FOLPEMJHAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x51045E0", Offset = "0x51037E0", VA = "0x1851045E0")]
	public int OKKAOPMJFHA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x51038F0", Offset = "0x5102AF0", VA = "0x1851038F0")]
	public short EHEHPNHEPJG()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x51045D0", Offset = "0x51037D0", VA = "0x1851045D0")]
	public void OAHGKPPJHGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x5103A90", Offset = "0x5102C90", VA = "0x185103A90")]
	private void IDCKJMFKBDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public abstract class GCPBFIHHEHH<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	internal class KNOBGIBNHJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public TNode EAHKFBMKAPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public TNode DBICPFPGAAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public AHFJIJIMFJH AKFPLPAIEMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public List<AHFJIJIMFJH> LKKFKNNKOHC;

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
		public KNOBGIBNHJC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	internal struct AHFJIJIMFJH : IComparable<AHFJIJIMFJH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public int LIMIFDNPGNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public TClaimant DBFENPIOHGA;

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x592CF0", Offset = "0x591EF0", VA = "0x180592CF0")]
		public AHFJIJIMFJH(int LIMIFDNPGNA, TClaimant DBFENPIOHGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x1E45870", Offset = "0x1E44A70", VA = "0x181E45870")]
		public bool GKIADFPBPGN(in AHFJIJIMFJH MKCNOIKIBCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x1E45860", Offset = "0x1E44A60", VA = "0x181E45860")]
		public bool DAPGFOGJNJC(in AHFJIJIMFJH MKCNOIKIBCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x1E45850", Offset = "0x1E44A50", VA = "0x181E45850", Slot = "4")]
		public int CompareTo(AHFJIJIMFJH MKCNOIKIBCA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x1E458D0", Offset = "0x1E44AD0", VA = "0x181E458D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public enum FCEGOKHKCFP
	{
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private sealed class ACHIAIEONJF : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public global::GCPBFIHHEHH<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x1E45630", Offset = "0x1E44830", VA = "0x181E45630")]
		[DebuggerHidden]
		public ACHIAIEONJF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x1E45420", Offset = "0x1E44620", VA = "0x181E45420", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x1E455E0", Offset = "0x1E447E0", VA = "0x181E455E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x1E45500", Offset = "0x1E44700", VA = "0x181E45500", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x1D76D60", Offset = "0x1D75F60", VA = "0x181D76D60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private static readonly global::EANBDABOCPC<KNOBGIBNHJC> LMGILHIGFKJ;

	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private static readonly global::EANBDABOCPC<List<AHFJIJIMFJH>> NBDKFFJJFIH;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private static int JGOAPCGHHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	internal readonly Dictionary<TClaimant, TNode> NHFBEMFHABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	internal readonly Dictionary<TNode, KNOBGIBNHJC> GDPJINGMHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private FCEGOKHKCFP POGDHLEGDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private bool KKMPIABJNOM;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode LGKCHFAELKA(TNode HGDPCCBPGAD);

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void DGHIFODNFKL(TNode HGDPCCBPGAD, TClaimant DKONFNBGDFK, TClaimant MADIHOMBMHF);

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F750", Offset = "0x1E4E950", VA = "0x181E4F750")]
	public GCPBFIHHEHH(FCEGOKHKCFP POGDHLEGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x1E4E950", Offset = "0x1E4DB50", VA = "0x181E4E950")]
	public void HILLPOOPEKK(TNode HGDPCCBPGAD, TNode AGCGKNDGLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x1E4EC40", Offset = "0x1E4DE40", VA = "0x181E4EC40")]
	public void KJBOCOBMBOD(TClaimant DBFENPIOHGA, TNode BOBDHKDBDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x1E4E220", Offset = "0x1E4D420", VA = "0x181E4E220", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x1E4DF80", Offset = "0x1E4D180", VA = "0x181E4DF80")]
	private void DBINHCHLBEB(TClaimant DBFENPIOHGA, TNode FMHIBNAPGNK, TNode BOBDHKDBDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x1E4E1B0", Offset = "0x1E4D3B0", VA = "0x181E4E1B0")]
	private int DFOPFCPGDDD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F340", Offset = "0x1E4E540", VA = "0x181E4F340")]
	private void PALKCNIKEAL(TClaimant DBFENPIOHGA, TNode BNLEBAAPIPL, TNode FHKOFNJIDPO, int FDKMEGBNIIH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x1E4DEF0", Offset = "0x1E4D0F0", VA = "0x181E4DEF0")]
	private void ACNNKLCDIDH(AHFJIJIMFJH NIFOFDAFDMB, KNOBGIBNHJC DHLLMBGKDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x1E4E9D0", Offset = "0x1E4DBD0", VA = "0x181E4E9D0")]
	private void JKECAJOPNKE(TClaimant DBFENPIOHGA, TNode BNLEBAAPIPL, TNode FHKOFNJIDPO, int FDKMEGBNIIH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x1E4EE00", Offset = "0x1E4E000", VA = "0x181E4EE00")]
	private void MJDIGAGMBKJ(AHFJIJIMFJH NIFOFDAFDMB, TNode HGDPCCBPGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x1E4E710", Offset = "0x1E4D910", VA = "0x181E4E710")]
	private void GLGCPGJFFKL(AHFJIJIMFJH NIFOFDAFDMB, KNOBGIBNHJC DHLLMBGKDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x1E4E810", Offset = "0x1E4DA10", VA = "0x181E4E810")]
	private void HFDJPNJJMGM(KNOBGIBNHJC DHLLMBGKDKP, bool OPINAGAOHOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x1E4EF00", Offset = "0x1E4E100", VA = "0x181E4EF00")]
	private void OFKKOGOONME(KNOBGIBNHJC DHLLMBGKDKP, TNode AGCGKNDGLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x1E4E640", Offset = "0x1E4D840", VA = "0x181E4E640")]
	[IteratorStateMachine(typeof(global::GCPBFIHHEHH<, >.ACHIAIEONJF))]
	private IEnumerable<TNode> ELEFBBEDGAE(TNode BNLEBAAPIPL, TNode FHKOFNJIDPO, bool FKECLHKDKMD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x1E4ED40", Offset = "0x1E4DF40", VA = "0x181E4ED40")]
	private KNOBGIBNHJC LHAODBKDBAG(TNode HGDPCCBPGAD, TNode DBICPFPGAAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x1E4E020", Offset = "0x1E4D220", VA = "0x181E4E020")]
	private KNOBGIBNHJC DBKCJMEFCHC(TNode HGDPCCBPGAD, TNode DBICPFPGAAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x1E4E480", Offset = "0x1E4D680", VA = "0x181E4E480")]
	private void ECGIJOCOBJG(KNOBGIBNHJC DHLLMBGKDKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public class HGHPFCEOCGK<T> : IEnumerable<global::HGHPFCEOCGK<T>.CGKDLIHGCNO>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public struct CGKDLIHGCNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public T LDPMPDNIHLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public int OHJLAHMBLMG;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public class PKNKEDAMLAN : IEnumerator<CGKDLIHGCNO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private global::HGHPFCEOCGK<T> KDFHGONDKDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private int OHJLAHMBLMG;

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x28036B0", Offset = "0x28028B0", VA = "0x1828036B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public CGKDLIHGCNO NDCKGIGIEHE
		{
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x38D26F0", Offset = "0x38D18F0", VA = "0x1838D26F0", Slot = "4")]
			get
			{
				return default(CGKDLIHGCNO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x8B8030", Offset = "0x8B7230", VA = "0x1808B8030")]
		public PKNKEDAMLAN(global::HGHPFCEOCGK<T> KDFHGONDKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x38D2660", Offset = "0x38D1860", VA = "0x1838D2660", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x81B480", Offset = "0x81A680", VA = "0x18081B480", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x84FF80", Offset = "0x84F180", VA = "0x18084FF80", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	private struct FIHGLKMIKJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public bool HDCOBADPNJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public T LDPMPDNIHLJ;
	}

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private const int DFCDGIHDLEN = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly Dictionary<T, int> CDOJKHEHPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private FIHGLKMIKJJ[] JCIGHFAGFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private int BOIIDGMBGMA;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int AOBANEAGDNP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x58ACC0", Offset = "0x589EC0", VA = "0x18058ACC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x6E4EB0", Offset = "0x6E40B0", VA = "0x1806E4EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public int HKOLKDAEOPE
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x1E5DB20", Offset = "0x1E5CD20", VA = "0x181E5DB20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x38CD630", Offset = "0x38CC830", VA = "0x1838CD630")]
	public HGHPFCEOCGK(int FDMAMJMNCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x38CD240", Offset = "0x38CC440", VA = "0x1838CD240")]
	public HGHPFCEOCGK(CGKDLIHGCNO[] AKBJCAICIGA, bool ECDAIBADBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x38CCD60", Offset = "0x38CBF60", VA = "0x1838CCD60")]
	public int OLPHMNDKIJN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x38CBC30", Offset = "0x38CAE30", VA = "0x1838CBC30")]
	private int FOKPHOIBNFH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x38CB9F0", Offset = "0x38CABF0", VA = "0x1838CB9F0", Slot = "6")]
	protected virtual uint CEDIOHGLEOD(uint AGODCCIEBMA, T LDPMPDNIHLJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x38CBA70", Offset = "0x38CAC70", VA = "0x1838CBA70")]
	public bool EFBNHOALLNF(T LDPMPDNIHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x38CC6B0", Offset = "0x38CB8B0", VA = "0x1838CC6B0")]
	public bool HPNFHEGCGDE(int OHJLAHMBLMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x38CBAB0", Offset = "0x38CACB0", VA = "0x1838CBAB0")]
	public bool EFLIOKIPEDI(Func<T, bool> NLAOGPIGINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x38CC130", Offset = "0x38CB330", VA = "0x1838CC130")]
	public int GKFGIODPIMC(T LDPMPDNIHLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x38CB860", Offset = "0x38CAA60", VA = "0x1838CB860")]
	public T BGIIDPHCDHJ(int OHJLAHMBLMG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x38CCCE0", Offset = "0x38CBEE0", VA = "0x1838CCCE0")]
	public void OAHGKPPJHGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x38CC670", Offset = "0x38CB870", VA = "0x1838CC670")]
	public bool HOLPEDBHFBN(T LDPMPDNIHLJ, bool DFKGOPFHNHL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x38CC420", Offset = "0x38CB620", VA = "0x1838CC420")]
	public bool HOLPEDBHFBN(T LDPMPDNIHLJ, int OHJLAHMBLMG, bool DFKGOPFHNHL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x38CB960", Offset = "0x38CAB60", VA = "0x1838CB960")]
	public bool CDCPBPNLMGM(T LDPMPDNIHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x38CC770", Offset = "0x38CB970", VA = "0x1838CC770")]
	public bool IDLCJKOPAFG(int OHJLAHMBLMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x38CC8A0", Offset = "0x38CBAA0", VA = "0x1838CC8A0")]
	private void JOBIJOKPIEO(int OHJLAHMBLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x38CCA30", Offset = "0x38CBC30", VA = "0x1838CCA30")]
	public CGKDLIHGCNO[] NJJCPOKIIFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x38CC990", Offset = "0x38CBB90", VA = "0x1838CC990")]
	private int KILMBAHJHGE(int BLNMCHHANPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x38CCDD0", Offset = "0x38CBFD0", VA = "0x1838CCDD0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x38CCDD0", Offset = "0x38CBFD0", VA = "0x1838CCDD0", Slot = "4")]
	private IEnumerator<CGKDLIHGCNO> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public class EANBDABOCPC<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly Stack<T> EDEHLMOBDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly List<T> OKGAGLBFLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly int NMPOLHGICBF;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int EFINFIHDOOF
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x1F8C8A0", Offset = "0x1F8BAA0", VA = "0x181F8C8A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public int AKEBKBCFCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x1F89A60", Offset = "0x1F88C60", VA = "0x181F89A60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x365C3C0", Offset = "0x365B5C0", VA = "0x18365C3C0")]
	public static global::EANBDABOCPC<T> EHPGDNHNIPM(int FDMAMJMNCKL = 0, int NMPOLHGICBF = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x365C490", Offset = "0x365B690", VA = "0x18365C490")]
	public static global::EANBDABOCPC<T> GFACOHBKIIC(int FDMAMJMNCKL = 0, int NMPOLHGICBF = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x365C850", Offset = "0x365BA50", VA = "0x18365C850")]
	public EANBDABOCPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x365C890", Offset = "0x365BA90", VA = "0x18365C890")]
	public EANBDABOCPC(int FDMAMJMNCKL, int NMPOLHGICBF = int.MaxValue, bool JNGAOEFHGFI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x365BFC0", Offset = "0x365B1C0", VA = "0x18365BFC0")]
	public T BOJMFGCMAEA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x365C560", Offset = "0x365B760", VA = "0x18365C560")]
	public void GGCIONGPJEH(T LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x365C790", Offset = "0x365B990", VA = "0x18365C790")]
	private void NHGAAMNIIBC(T LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x365C770", Offset = "0x365B970", VA = "0x18365C770")]
	private void LFBOKLPOMAP(T LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x365C620", Offset = "0x365B820", VA = "0x18365C620")]
	[Conditional("DEBUG_BUILD")]
	private void HCCGLOPKMID(T PFGEDGOCGAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x365C6C0", Offset = "0x365B8C0", VA = "0x18365C6C0")]
	[Conditional("DEBUG_BUILD")]
	private void JMBPNJHDIED(T PFGEDGOCGAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x365C2B0", Offset = "0x365B4B0", VA = "0x18365C2B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x365C0F0", Offset = "0x365B2F0", VA = "0x18365C0F0")]
	private void DBPJJJKOHJM(IEnumerable<T> ADFGPDABJHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public class OIBKPMAPFJB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private Dictionary<int, T> BOIBHALAJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private T KOIEMBGDMGB;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public virtual T GNKNLNOJIJB
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x58A4A0", Offset = "0x5896A0", VA = "0x18058A4A0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool HJFHKNJJAPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x36798A0", Offset = "0x3678AA0", VA = "0x1836798A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x3679580", Offset = "0x3678780", VA = "0x183679580")]
	public bool IAAHDADOJIB(T LDPMPDNIHLJ, int LIMIFDNPGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x36797E0", Offset = "0x36789E0", VA = "0x1836797E0")]
	public bool NCJLBJNOBLM(int LIMIFDNPGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x36792F0", Offset = "0x36784F0", VA = "0x1836792F0")]
	public T AMLBDPMAFAA(int MMPPMDAEDBD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x3679840", Offset = "0x3678A40", VA = "0x183679840")]
	public void OAHGKPPJHGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x3679640", Offset = "0x3678840", VA = "0x183679640")]
	private bool MCINOMCNJMN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x3679550", Offset = "0x3678750", VA = "0x183679550")]
	public bool FINJNPJEIIJ(int LIMIFDNPGNA, out T LDPMPDNIHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x34F31E0", Offset = "0x34F23E0", VA = "0x1834F31E0")]
	public OIBKPMAPFJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public class PPJKCKMOPEC<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	protected struct HJLEEMJNCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public T JDIGBEFEDMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public int HBJEMGBEAIJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	protected readonly List<HJLEEMJNCCM> APFPBOJHHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private T PNAOOMEGJNO;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public int HKOLKDAEOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x1E5DB20", Offset = "0x1E5CD20", VA = "0x181E5DB20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x33DA230", Offset = "0x33D9430", VA = "0x1833DA230")]
	public bool EFLIOKIPEDI(T LDPMPDNIHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x33DA480", Offset = "0x33D9680", VA = "0x1833DA480")]
	public void FKEGKEHNDJG(T LDPMPDNIHLJ, int LIMIFDNPGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x33D9F00", Offset = "0x33D9100", VA = "0x1833D9F00")]
	public bool CDCPBPNLMGM(T LDPMPDNIHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x33DA520", Offset = "0x33D9720", VA = "0x1833DA520")]
	public void OAHGKPPJHGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x33D9E00", Offset = "0x33D9000", VA = "0x1833D9E00")]
	public T BJEHICAIGGL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x33D9E90", Offset = "0x33D9090", VA = "0x1833D9E90")]
	public T BOGBPEGAGNI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x33DA020", Offset = "0x33D9220", VA = "0x1833DA020")]
	private void DMONIAIHIPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x33DA580", Offset = "0x33D9780", VA = "0x1833DA580")]
	public PPJKCKMOPEC()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[SerializeField]
		[PLCNAFAOAOP(BAKNHFGGKOC.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0x51052C0", Offset = "0x51044C0", VA = "0x1851052C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x5105790", Offset = "0x5104990", VA = "0x185105790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x51055B0", Offset = "0x51047B0", VA = "0x1851055B0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x5105930", Offset = "0x5104B30", VA = "0x185105930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x5105180", Offset = "0x5104380", VA = "0x185105180")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x5105650", Offset = "0x5104850", VA = "0x185105650")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x5105470", Offset = "0x5104670", VA = "0x185105470")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x51050E0", Offset = "0x51042E0", VA = "0x1851050E0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public interface EBIGEBGDMIN
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public abstract class ResourcePrefabReference<T> : EBIGEBGDMIN where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x1F9A4B0", Offset = "0x1F996B0", VA = "0x181F9A4B0", Slot = "4")]
		public virtual T LOIBMNCJNAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public class BILAMNHEHLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly Dictionary<byte, CPNNDGAGLHH> PHBEOOBNJBO;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public CPNNDGAGLHH IKMJCOMAFFD
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x58A1D0", Offset = "0x5893D0", VA = "0x18058A1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x58A490", Offset = "0x589690", VA = "0x18058A490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector2 PGFBKMKKNGL
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x11E0510", Offset = "0x11DF710", VA = "0x1811E0510")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x36772B0", Offset = "0x36764B0", VA = "0x1836772B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public Vector2 AKDOBBHHLNK
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x159F580", Offset = "0x159E780", VA = "0x18159F580")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x159F610", Offset = "0x159E810", VA = "0x18159F610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public Vector2 HDDIDKDJEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x50FFE40", Offset = "0x50FF040", VA = "0x1850FFE40")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x50FF790", Offset = "0x50FE990", VA = "0x1850FF790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public int PHLBJEKPPEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x5B57E0", Offset = "0x5B49E0", VA = "0x1805B57E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x5DB9A0", Offset = "0x5DABA0", VA = "0x1805DB9A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x50FFF90", Offset = "0x50FF190", VA = "0x1850FFF90")]
	public BILAMNHEHLH(Bounds CKGDDJMAOIE, Vector2[] PDCJEFBBOHO, int FILJPNMEOAE, byte BLNMCHHANPG, float NPMGLKLDDBH = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x50FFCD0", Offset = "0x50FEED0", VA = "0x1850FFCD0")]
	public CPNNDGAGLHH JDOEHLMPJKE(byte OHJLAHMBLMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x50FFD30", Offset = "0x50FEF30", VA = "0x1850FFD30")]
	public void LJONOHMBKFN(Vector3 PNBJGABNCHL, float FLEIEPOIDEK, float JJDJFLAOOON, ref List<byte> CLOMFIDGCDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x50FFE20", Offset = "0x50FF020", VA = "0x1850FFE20")]
	public void NINKHIEFBBN(CPNNDGAGLHH.DKPFJOJOLPN LGLEAKADBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x50FFE60", Offset = "0x50FF060", VA = "0x1850FFE60")]
	private CPNNDGAGLHH OKCAOFOPOPD(byte OHJLAHMBLMG, CPNNDGAGLHH.HKKFPAEACKK ICAPACJNOKI, CPNNDGAGLHH DBICPFPGAAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x50FF7B0", Offset = "0x50FE9B0", VA = "0x1850FF7B0")]
	private void INNMDFPEJAD(CPNNDGAGLHH DBICPFPGAAP, Vector2[] PDCJEFBBOHO, int COHEJHMEEMG, int FMFPKKEAILD, int JOMMKBDOAGP, int MMKPDFEGEHM, float NPMGLKLDDBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class CPNNDGAGLHH
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public enum HKKFPAEACKK
	{
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public enum DKPFJOJOLPN
	{
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public byte EHOJOPDMDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public Vector3 EHOJDPLAOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public Vector3 FNLLLKNNJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public Vector3 GKGECJGMDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public Vector3 DAJEADBJCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public HKKFPAEACKK EGOOLFFFEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public CPNNDGAGLHH MKIKBMOICDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public List<CPNNDGAGLHH> MOINIDJDFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public bool JJPBAJMEGIE;

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x5100CE0", Offset = "0x50FFEE0", VA = "0x185100CE0")]
	public CPNNDGAGLHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x5100D00", Offset = "0x50FFF00", VA = "0x185100D00")]
	public CPNNDGAGLHH(byte AHIADCPIPAH, HKKFPAEACKK ICAPACJNOKI, CPNNDGAGLHH DBICPFPGAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x5100970", Offset = "0x50FFB70", VA = "0x185100970")]
	public void GMBLMGAPPHN(CPNNDGAGLHH EINIIIHBEDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80")]
	public void NINKHIEFBBN(int GLEKGOMKKOF, DKPFJOJOLPN LGLEAKADBHB, int LJBAKCMKBCN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x5100A10", Offset = "0x50FFC10", VA = "0x185100A10")]
	public void LJONOHMBKFN(List<byte> CLOMFIDGCDI, Vector3 PNBJGABNCHL, float FLEIEPOIDEK, float JJDJFLAOOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x5100910", Offset = "0x50FFB10", VA = "0x185100910")]
	public bool EEJPODHBPCK(Vector3 FHCGDMNCODD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x5100CA0", Offset = "0x50FFEA0", VA = "0x185100CA0")]
	public bool PODNGJFHIMM(Vector3 FHCGDMNCODD, float LCILGBLBOOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class DAHNFOEKGCJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly Dictionary<T, object> INMCHCNNKCB;

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x2E3F150", Offset = "0x2E3E350", VA = "0x182E3F150")]
	public bool EMLOHGDANEB(T PLJJHIFPCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x4088380", Offset = "0x4087580", VA = "0x184088380")]
	public bool EMLOHGDANEB(T PLJJHIFPCJK, object OLHNGKKAKIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x40883C0", Offset = "0x40875C0", VA = "0x1840883C0")]
	public bool EMLOHGDANEB(T PLJJHIFPCJK, object OLHNGKKAKIK, out object PAHLNALLECG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x4088210", Offset = "0x4087410", VA = "0x184088210")]
	public bool CGEBIPCJPLM(T PLJJHIFPCJK, object OLHNGKKAKIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x40881D0", Offset = "0x40873D0", VA = "0x1840881D0")]
	public bool CCJEGGGDDOJ(T PLJJHIFPCJK, object OLHNGKKAKIK, out object PAHLNALLECG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x4088250", Offset = "0x4087450", VA = "0x184088250")]
	public bool CGEBIPCJPLM(T PLJJHIFPCJK, object OLHNGKKAKIK, out object PAHLNALLECG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x3799CF0", Offset = "0x3798EF0", VA = "0x183799CF0")]
	public void OHFINPJFFAE(T PLJJHIFPCJK, object OLHNGKKAKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x40882E0", Offset = "0x40874E0", VA = "0x1840882E0")]
	public void EEELBKFBPLA(T PLJJHIFPCJK, object OLHNGKKAKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x4088420", Offset = "0x4087620", VA = "0x184088420")]
	public DAHNFOEKGCJ()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		public struct CDKIBKOKIHF<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			private readonly List<Component> JDGJMEHHHMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			private readonly bool KAIHOJONLCB;

			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x7CA060", Offset = "0x7C9260", VA = "0x1807CA060")]
			public CDKIBKOKIHF(List<Component> JDGJMEHHHMC, bool KAIHOJONLCB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0x1F88A00", Offset = "0x1F87C00", VA = "0x181F88A00")]
			public OFCIFJKILPK<T> ECCFOEBFBJP()
			{
				return default(OFCIFJKILPK<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0x1F88A70", Offset = "0x1F87C70", VA = "0x181F88A70", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0x1F88A70", Offset = "0x1F87C70", VA = "0x181F88A70", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		public struct OFCIFJKILPK<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			private readonly List<Component> JDGJMEHHHMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			private readonly bool KAIHOJONLCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			private int OHJLAHMBLMG;

			[Cpp2IlInjected.Token(Token = "0x170000C4")]
			public T NDCKGIGIEHE
			{
				[Cpp2IlInjected.Token(Token = "0x600045F")]
				[Cpp2IlInjected.Address(RVA = "0x1F93CA0", Offset = "0x1F92EA0", VA = "0x181F93CA0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C5")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000460")]
				[Cpp2IlInjected.Address(RVA = "0x1F93C30", Offset = "0x1F92E30", VA = "0x181F93C30", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0x1F93C70", Offset = "0x1F92E70", VA = "0x181F93C70")]
			public OFCIFJKILPK(List<Component> JDGJMEHHHMC, bool KAIHOJONLCB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0x1F93B60", Offset = "0x1F92D60", VA = "0x181F93B60", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0x1F93B70", Offset = "0x1F92D70", VA = "0x181F93B70", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0x1F93C20", Offset = "0x1F92E20", VA = "0x181F93C20", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0x51075F0", Offset = "0x51067F0", VA = "0x1851075F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x51075B0", Offset = "0x51067B0", VA = "0x1851075B0")]
		public ToolHierarchyCache(GameObject OFENFDMDHAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x5107020", Offset = "0x5106220", VA = "0x185107020")]
		private void INKIGOFOFOG(GameObject OFENFDMDHAD, bool HBFPIFLJBKH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x5107140", Offset = "0x5106340", VA = "0x185107140")]
		public static void INKIGOFOFOG(GameObject OFENFDMDHAD, ref ToolHierarchyCache PHICLPBHDPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x5107480", Offset = "0x5106680", VA = "0x185107480")]
		public void LFPDNDJBEKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x5106FD0", Offset = "0x51061D0", VA = "0x185106FD0")]
		public void HIHICAIPOGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x1CF30B0", Offset = "0x1CF22B0", VA = "0x181CF30B0")]
		public void ALGBOEEMJEJ<T>(Action<T> GIFFKCDDBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x5106E20", Offset = "0x5106020", VA = "0x185106E20")]
		public Component EKAOFHHFJFG(Type ALJEFDPBPKG, bool KAIHOJONLCB = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x1F09A40", Offset = "0x1F08C40", VA = "0x181F09A40")]
		public T EKAOFHHFJFG<T>(bool KAIHOJONLCB = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x5106D90", Offset = "0x5105F90", VA = "0x185106D90")]
		public CDKIBKOKIHF<Component> DABDEJMLAGN(Type ALJEFDPBPKG, bool KAIHOJONLCB = false)
		{
			return default(CDKIBKOKIHF<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x22EDE70", Offset = "0x22ED070", VA = "0x1822EDE70")]
		public CDKIBKOKIHF<T> DABDEJMLAGN<T>(bool KAIHOJONLCB = false) where T : class
		{
			return default(CDKIBKOKIHF<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x51071D0", Offset = "0x51063D0", VA = "0x1851071D0")]
		public List<Component> KLDBDCMDELM(Type ALJEFDPBPKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x5106EE0", Offset = "0x51060E0", VA = "0x185106EE0", Slot = "4")]
		public bool Equals(ToolHierarchyCache CNMHAFPCMJK, ToolHierarchyCache HNFKJOACHLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x5106F60", Offset = "0x5106160", VA = "0x185106F60", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache ANFJLMLDELH)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public class CFLPAGFIOAB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private int FDMAMJMNCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private int JGAMJPEDLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private List<T> BAJKBGIAPJC;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public int HKOLKDAEOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x1F8C8A0", Offset = "0x1F8BAA0", VA = "0x181F8C8A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public T CHLDIPCPHDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1770", Offset = "0x2BA0970", VA = "0x182BA1770")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public T ANPDKFACMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1A60", Offset = "0x2BA0C60", VA = "0x182BA1A60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public T HCOIBCOFKFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1570", Offset = "0x2BA0770", VA = "0x182BA1570")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x2BA1AF0", Offset = "0x2BA0CF0", VA = "0x182BA1AF0")]
	public CFLPAGFIOAB(int FDMAMJMNCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x2BA17F0", Offset = "0x2BA09F0", VA = "0x182BA17F0")]
	public void FKEGKEHNDJG(T APCIJGDECOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x2BA1AB0", Offset = "0x2BA0CB0", VA = "0x182BA1AB0")]
	public void OAHGKPPJHGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x2BA1630", Offset = "0x2BA0830", VA = "0x182BA1630")]
	public void DGEJIOIBOFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x2BA19A0", Offset = "0x2BA0BA0", VA = "0x182BA19A0")]
	public void GGGOKDDNLGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x2BA1AA0", Offset = "0x2BA0CA0", VA = "0x182BA1AA0")]
	public void JKGBILMIKIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public class DIMMHNFHDGI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private bool ENBEADCKPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private Action GIFFKCDDBCP;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public static DIMMHNFHDGI KIFNBOEFNIA
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x5100DF0", Offset = "0x50FFFF0", VA = "0x185100DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public bool NBGHDFPIFAL
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x5B57B0", Offset = "0x5B49B0", VA = "0x1805B57B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x8A1950", Offset = "0x8A0B50", VA = "0x1808A1950")]
	public DIMMHNFHDGI(Action GIFFKCDDBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x5100E70", Offset = "0x5100070", VA = "0x185100E70")]
	public void NEIHCBLCFCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x5100E70", Offset = "0x5100070", VA = "0x185100E70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public static class GHOPBGDKBFB
{
	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80")]
	public static void GKMJNNCOBFJ(OCIGDKIGDHE HFDNCPLJJIM, string OLMBPGCAAHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public class FELKADCHHAE<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	private struct JIPDOJMFJBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public int HBJEMGBEAIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public T JDIGBEFEDMD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private readonly Dictionary<object, JIPDOJMFJBD> BOIBHALAJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private T KOIEMBGDMGB;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public virtual T GNKNLNOJIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x11E0510", Offset = "0x11DF710", VA = "0x1811E0510", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x36772B0", Offset = "0x36764B0", VA = "0x1836772B0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool HJFHKNJJAPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x34F31B0", Offset = "0x34F23B0", VA = "0x1834F31B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public object FIMCIDNPKJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x58CDF0", Offset = "0x58BFF0", VA = "0x18058CDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x5B4D70", Offset = "0x5B3F70", VA = "0x1805B4D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x34F12A0", Offset = "0x34F04A0", VA = "0x1834F12A0")]
	public bool IAAHDADOJIB(T LDPMPDNIHLJ, object OLHNGKKAKIK, int LIMIFDNPGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x34F3140", Offset = "0x34F2340", VA = "0x1834F3140")]
	public bool NCJLBJNOBLM(object OLHNGKKAKIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x4396EC0", Offset = "0x43960C0", VA = "0x184396EC0")]
	public bool FINJNPJEIIJ(object OLHNGKKAKIK, out T LDPMPDNIHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x2D7E9F0", Offset = "0x2D7DBF0", VA = "0x182D7E9F0")]
	public void OAHGKPPJHGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x4397DF0", Offset = "0x4396FF0", VA = "0x184397DF0")]
	private bool MCINOMCNJMN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x34F31E0", Offset = "0x34F23E0", VA = "0x1834F31E0")]
	public FELKADCHHAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public class OALMELCFGNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private Dictionary<object, float> BOIBHALAJIB;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public float HGPFCIHCOAC
	{
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0xF17C60", Offset = "0xF16E60", VA = "0x180F17C60")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0xDBB350", Offset = "0xDBA550", VA = "0x180DBB350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x5104A00", Offset = "0x5103C00", VA = "0x185104A00")]
	public void IAAHDADOJIB(float LDPMPDNIHLJ, object OLHNGKKAKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x5104A70", Offset = "0x5103C70", VA = "0x185104A70")]
	public void NCJLBJNOBLM(object OLHNGKKAKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x51048E0", Offset = "0x5103AE0", VA = "0x1851048E0")]
	private void EAEJDIIBOAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x5104AE0", Offset = "0x5103CE0", VA = "0x185104AE0")]
	public OALMELCFGNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public class BJHHFJNHKGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public readonly string DNPHMFHBAGI;

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x6BF360", Offset = "0x6BE560", VA = "0x1806BF360")]
	public BJHHFJNHKGM(string LJLCJKFMMBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x5100500", Offset = "0x50FF700", VA = "0x185100500")]
	public BJHHFJNHKGM(UnityEngine.Object OAJGLHIIGCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x51004B0", Offset = "0x50FF6B0", VA = "0x1851004B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class OCIGDKIGDHE
{
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private sealed class MMAHLCHFFAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public MMAHLCHFFAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x5104710", Offset = "0x5103910", VA = "0x185104710")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private readonly HashSet<object> ILLEAABLHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private int KKAPCHPLLLE;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public IReadOnlyCollection<object> JMJAFOAJNCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x58A1D0", Offset = "0x5893D0", VA = "0x18058A1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public bool OBMHLBFLKDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x5104CC0", Offset = "0x5103EC0", VA = "0x185104CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public int HKOLKDAEOPE
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x616670", Offset = "0x615870", VA = "0x180616670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x5104C40", Offset = "0x5103E40", VA = "0x185104C40")]
	public bool FKEGKEHNDJG(object OLHNGKKAKIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x5104B60", Offset = "0x5103D60", VA = "0x185104B60")]
	public bool CDCPBPNLMGM(object OLHNGKKAKIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x5104BE0", Offset = "0x5103DE0", VA = "0x185104BE0")]
	public bool EFLIOKIPEDI(object OLHNGKKAKIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x5104CD0", Offset = "0x5103ED0", VA = "0x185104CD0")]
	public void NKBBACICPBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x5104D30", Offset = "0x5103F30", VA = "0x185104D30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x5104EA0", Offset = "0x51040A0", VA = "0x185104EA0")]
	public OCIGDKIGDHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public class OFOLKCMMEMJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private struct ODDBEFNFFMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public float FDMGHEBFKLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public T JDIGBEFEDMD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private Dictionary<object, ODDBEFNFFMG> BOIBHALAJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private T FDDIJAMEGLK;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public virtual T LFAMPJFMNHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x1853BD0", Offset = "0x1852DD0", VA = "0x181853BD0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x1852920", Offset = "0x1851B20", VA = "0x181852920", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public object MJNNODNLJFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x5B2A30", Offset = "0x5B1C30", VA = "0x1805B2A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x6C2580", Offset = "0x6C1780", VA = "0x1806C2580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool HJFHKNJJAPF
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x3677270", Offset = "0x3676470", VA = "0x183677270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x36757D0", Offset = "0x36749D0", VA = "0x1836757D0")]
	public bool IAAHDADOJIB(T LDPMPDNIHLJ, object OLHNGKKAKIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x3677210", Offset = "0x3676410", VA = "0x183677210")]
	public bool NCJLBJNOBLM(object OLHNGKKAKIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x2D7E9F0", Offset = "0x2D7DBF0", VA = "0x182D7E9F0")]
	public void OAHGKPPJHGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x3675160", Offset = "0x3674360", VA = "0x183675160")]
	public bool FINJNPJEIIJ(object OLHNGKKAKIK, out T LDPMPDNIHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x3675CA0", Offset = "0x3674EA0", VA = "0x183675CA0")]
	private bool MCINOMCNJMN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x36772D0", Offset = "0x36764D0", VA = "0x1836772D0")]
	public OFOLKCMMEMJ()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public class JABMDOENCKP
{
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private static byte[] CDGDAHNLLDM;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static int FDPMPGKGLAJ;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static int LAEDHJMCKNO;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static BigInteger CJEJEKHBKEN;

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public JABMDOENCKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x5102870", Offset = "0x5101A70", VA = "0x185102870")]
	private static string DMHFLPDODAP(byte[] DLFOEJDCAKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x5102540", Offset = "0x5101740", VA = "0x185102540")]
	public static string AJIDJKNPAKB(byte[] NGIBJOEMFPL, bool MFLHBEHGGNL)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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
