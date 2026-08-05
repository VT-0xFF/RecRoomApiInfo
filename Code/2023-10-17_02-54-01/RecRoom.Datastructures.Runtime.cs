using System;
using System.Buffers;
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
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class OAMPCCNEFLA : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x772100", Offset = "0x770900", VA = "0x180772100")]
	public OAMPCCNEFLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, KAKFOPNPFFG, BOGNMFOHDBC, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x766130", Offset = "0x764930", VA = "0x180766130", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x766110", Offset = "0x764910", VA = "0x180766110", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7662F0", Offset = "0x764AF0", VA = "0x1807662F0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA223A0", Offset = "0xA20BA0", VA = "0x180A223A0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash JJPJJOLELKC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x848550", Offset = "0x846D50", VA = "0x180848550")]
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
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[SerializeField]
	[CLGMHEMAAJM]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	[HideInInspector]
	[CLGMHEMAAJM]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE7D0", Offset = "0x5CACFD0", VA = "0x185CAE7D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE790", Offset = "0x5CACF90", VA = "0x185CAE790")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE810", Offset = "0x5CAD010", VA = "0x185CAE810")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE9C0", Offset = "0x5CAD1C0", VA = "0x185CAE9C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE930", Offset = "0x5CAD130", VA = "0x185CAE930")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7EE890", Offset = "0x7ED090", VA = "0x1807EE890")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x86FB70", Offset = "0x86E370", VA = "0x18086FB70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE750", Offset = "0x5CACF50", VA = "0x185CAE750")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE8A0", Offset = "0x5CAD0A0", VA = "0x185CAE8A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5CAE1C0", Offset = "0x5CAC9C0", VA = "0x185CAE1C0")]
	public void CopyBounds(SavedExtents IFHFGCDLDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5CAE6A0", Offset = "0x5CACEA0", VA = "0x185CAE6A0")]
	public void SetLocalSpaceBounds(Bounds JOMNGHCFCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8A36E0", Offset = "0x8A1EE0", VA = "0x1808A36E0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5CAE5D0", Offset = "0x5CACDD0", VA = "0x185CAE5D0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5CAE1F0", Offset = "0x5CAC9F0", VA = "0x185CAE1F0")]
	private void ECFDDGHLHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5CAE3B0", Offset = "0x5CACBB0", VA = "0x185CAE3B0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5CADB50", Offset = "0x5CAC350", VA = "0x185CADB50")]
	public static void CalculateLocalBoundsFor(GameObject GOGHJGCCDJI, [Out] Bounds JOMNGHCFCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5CAE5E0", Offset = "0x5CACDE0", VA = "0x185CAE5E0")]
	private static void PPBJJDBEJGK(Bounds DNOEGKBPKDC, Color HCJCBMCLKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5CAE6C0", Offset = "0x5CACEC0", VA = "0x185CAE6C0")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75F980", VA = "0x180761180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x76A250", Offset = "0x768A50", VA = "0x18076A250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xCAB600", Offset = "0xCA9E00", VA = "0x180CAB600")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3FA6650", Offset = "0x3FA4E50", VA = "0x183FA6650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "4")]
	public virtual void EDOMMBPLFLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[OAMPCCNEFLA]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3FA6230", Offset = "0x3FA4A30", VA = "0x183FA6230", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3FA4ED0", Offset = "0x3FA36D0", VA = "0x183FA4ED0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3FA6580", Offset = "0x3FA4D80", VA = "0x183FA6580")]
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
	private sealed class ABLAAONKEGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public ABLAAONKEGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x34875C0", Offset = "0x3485DC0", VA = "0x1834875C0")]
		internal int EIPHFEALNOF(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[OAMPCCNEFLA]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x30B33C0", Offset = "0x30B1BC0", VA = "0x1830B33C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x30B3410", Offset = "0x30B1C10", VA = "0x1830B3410", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x30B32C0", Offset = "0x30B1AC0", VA = "0x1830B32C0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey OHPCNPKOLBJ]
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x30B3360", Offset = "0x30B1B60", VA = "0x1830B3360", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x30B31A0", Offset = "0x30B19A0", VA = "0x1830B31A0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x30B2EC0", Offset = "0x30B16C0", VA = "0x1830B2EC0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x30B2360", Offset = "0x30B0B60", VA = "0x1830B2360", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x30B22D0", Offset = "0x30B0AD0", VA = "0x1830B22D0", Slot = "14")]
	protected virtual string ONDJEENECEK(TKeyVal BPAHKJCOBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x30B21E0", Offset = "0x30B09E0", VA = "0x1830B21E0", Slot = "4")]
	public bool ContainsKey(TKey OHPCNPKOLBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x30B3060", Offset = "0x30B1860", VA = "0x1830B3060", Slot = "5")]
	public bool TryGetValue(TKey OHPCNPKOLBJ, [Out] TVal FKKGMPDEPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x30B2230", Offset = "0x30B0A30", VA = "0x1830B2230", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x30B2230", Offset = "0x30B0A30", VA = "0x1830B2230", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x30B30B0", Offset = "0x30B18B0", VA = "0x1830B30B0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class MMICHGBMGEO<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class ODNKFDABEFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public ODNKFDABEFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3CCC690", Offset = "0x3CCAE90", VA = "0x183CCC690")]
		internal bool DMAHGHMGENN(FBDJHKIIFOH<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float PHJEHOLGFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float OHHCMOKEGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<FBDJHKIIFOH<float, T>> IIOKPPFDLKJ;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int HDAHNAFDJNF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3B45980", Offset = "0x3B44180", VA = "0x183B45980")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3B46440", Offset = "0x3B44C40", VA = "0x183B46440")]
	public MMICHGBMGEO(float NLHEOGGDKOL, float FABHENLPNHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3B461D0", Offset = "0x3B449D0", VA = "0x183B461D0")]
	public bool MDEPEFBMCGO(float EICMLNGBGBA, T FKKGMPDEPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3B45A20", Offset = "0x3B44220", VA = "0x183B45A20")]
	public IEnumerable<T> DOGGGMPDJKK(float EICMLNGBGBA, [Optional] float? DMFPJINEIEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3B459F0", Offset = "0x3B441F0", VA = "0x183B459F0")]
	public void BEIKHFOBAHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3B46360", Offset = "0x3B44B60", VA = "0x183B46360")]
	private void NLLGPKMMEHF(float EICMLNGBGBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class BBOCPCNCBIC<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct DPJDEDGGEML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T PENMJFOMGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float PMPGADNFOPP;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float OFJAECGAJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> JFOOEGBBNIA;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int JBJFEJAAAOL = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private DPJDEDGGEML[] INLAJDDNHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int BICPBGKCMIL;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float GLHGLMOEHHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA86B30", Offset = "0xA85330", VA = "0x180A86B30")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA86B50", Offset = "0xA85350", VA = "0x180A86B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x43E4740", Offset = "0x43E2F40", VA = "0x1843E4740")]
	public BBOCPCNCBIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x43E4760", Offset = "0x43E2F60", VA = "0x1843E4760")]
	public BBOCPCNCBIC(int ALCHALOFNIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x43E3B00", Offset = "0x43E2300", VA = "0x1843E3B00")]
	public void BONJGFNEKBE(float EICMLNGBGBA, T FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x43E3860", Offset = "0x43E2060", VA = "0x1843E3860")]
	public void BEIKHFOBAHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x43E4200", Offset = "0x43E2A00", VA = "0x1843E4200")]
	public bool FLIACBBKAMO(float JGBNMNFPCHG, float FGNMBJCGMCG, [Out] T FKKGMPDEPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x43E3BC0", Offset = "0x43E23C0", VA = "0x1843E3BC0")]
	public bool CAOOJPJBJJA(float JGBNMNFPCHG, float FGNMBJCGMCG, [Out] T FKKGMPDEPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x43E4450", Offset = "0x43E2C50", VA = "0x1843E4450")]
	public void PJBCEGDDLKJ(float JGBNMNFPCHG, float FGNMBJCGMCG, List<T> NEJFCHMJPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x43E3F50", Offset = "0x43E2750", VA = "0x1843E3F50")]
	private int CPBGJCIPANO(int NIHGMKOOIIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x43E4400", Offset = "0x43E2C00", VA = "0x1843E4400")]
	private void NIJGOEOKCIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T IJLMNCEGHEF();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T NBKHJBIAPOE(T FKKGMPDEPMA, float INGJCJMKCCN);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T MCKFFABGCGH(T LOKIPHPAIAD, T CGHEAIJKHIK);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T EJIPIIAAPLG(T LOKIPHPAIAD, T CGHEAIJKHIK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class LJKCOKENHJL : BBOCPCNCBIC<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x772AA0", Offset = "0x7712A0", VA = "0x180772AA0", Slot = "4")]
	protected override Vector3 IJLMNCEGHEF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5CABFB0", Offset = "0x5CAA7B0", VA = "0x185CABFB0", Slot = "5")]
	protected override Vector3 NBKHJBIAPOE(Vector3 FKKGMPDEPMA, float INGJCJMKCCN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5CABF60", Offset = "0x5CAA760", VA = "0x185CABF60", Slot = "6")]
	protected override Vector3 MCKFFABGCGH(Vector3 LOKIPHPAIAD, Vector3 CGHEAIJKHIK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5CABEE0", Offset = "0x5CAA6E0", VA = "0x185CABEE0", Slot = "7")]
	protected override Vector3 EJIPIIAAPLG(Vector3 LOKIPHPAIAD, Vector3 CGHEAIJKHIK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5CABFF0", Offset = "0x5CAA7F0", VA = "0x185CABFF0")]
	public LJKCOKENHJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class IADNGFCFFPO
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x238A430", Offset = "0x2388C30", VA = "0x18238A430")]
	public static FBDJHKIIFOH<T1, T2> KLKFANDJKFE<T1, T2>(T1 FICGDLMPHON, T2 OHJAHNECFII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x238A4B0", Offset = "0x2388CB0", VA = "0x18238A4B0")]
	public static BHEHECOOBDN<T1, T2, T3> KLKFANDJKFE<T1, T2, T3>(T1 FICGDLMPHON, T2 OHJAHNECFII, T3 NEBKIKHNDHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3B80590", Offset = "0x3B7ED90", VA = "0x183B80590")]
	internal static int LGONPMMMHIK(int IMDCPPGJHFM, int MNOFJGLKKED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x51ABAC0", Offset = "0x51AA2C0", VA = "0x1851ABAC0")]
	internal static int LGONPMMMHIK(int IMDCPPGJHFM, int MNOFJGLKKED, int ENCOAECCPCJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FBDJHKIIFOH<T1, T2> : IComparable<FBDJHKIIFOH<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T1 GJGGNKLOPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T2 PNGPPBHJIAD;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x33FC6B0", Offset = "0x33FAEB0", VA = "0x1833FC6B0")]
	public FBDJHKIIFOH(T1 FICGDLMPHON, T2 OHJAHNECFII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x33FA6E0", Offset = "0x33F8EE0", VA = "0x1833FA6E0", Slot = "4")]
	public int CompareTo(FBDJHKIIFOH<T1, T2> IFHFGCDLDEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x33FB340", Offset = "0x33F9B40", VA = "0x1833FB340", Slot = "0")]
	public override bool Equals(object IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x33FB8E0", Offset = "0x33FA0E0", VA = "0x1833FB8E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x33FC010", Offset = "0x33FA810", VA = "0x1833FC010", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BHEHECOOBDN<T1, T2, T3> : IComparable<BHEHECOOBDN<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T1 GJGGNKLOPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T2 PNGPPBHJIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly T3 PAIOCBGEFHE;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x43F4BF0", Offset = "0x43F33F0", VA = "0x1843F4BF0")]
	public BHEHECOOBDN(T1 FICGDLMPHON, T2 OHJAHNECFII, T3 NEBKIKHNDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x43F42B0", Offset = "0x43F2AB0", VA = "0x1843F42B0", Slot = "4")]
	public int CompareTo(BHEHECOOBDN<T1, T2, T3> IFHFGCDLDEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x43F4640", Offset = "0x43F2E40", VA = "0x1843F4640", Slot = "0")]
	public override bool Equals(object IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x43F47F0", Offset = "0x43F2FF0", VA = "0x1843F47F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x43F4920", Offset = "0x43F3120", VA = "0x1843F4920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T PENMJFOMGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1E55DE0", Offset = "0x1E545E0", VA = "0x181E55DE0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1E55EB0", Offset = "0x1E546B0", VA = "0x181E55EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float JMFGEJKLKOO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA35E60", Offset = "0xA34660", VA = "0x180A35E60")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x41AAA80", Offset = "0x41A9280", VA = "0x1841AAA80")]
	public T FKHEBMBMIIM(float INGJCJMKCCN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x41AAD10", Offset = "0x41A9510", VA = "0x1841AAD10")]
	public T KBKIFPABHCL(float INGJCJMKCCN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T DCIAOGEKDKN(T LOKIPHPAIAD, T CGHEAIJKHIK, float INGJCJMKCCN);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA6B0", Offset = "0x5CA8EB0", VA = "0x185CAA6B0", Slot = "4")]
	protected override float DCIAOGEKDKN(float LOKIPHPAIAD, float CGHEAIJKHIK, float INGJCJMKCCN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA6F0", Offset = "0x5CA8EF0", VA = "0x185CAA6F0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xB7DFB0", Offset = "0xB7C7B0", VA = "0x180B7DFB0", Slot = "4")]
	protected override Vector3 DCIAOGEKDKN(Vector3 LOKIPHPAIAD, Vector3 CGHEAIJKHIK, float INGJCJMKCCN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5CAF7E0", Offset = "0x5CADFE0", VA = "0x185CAF7E0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA310", Offset = "0x5CA8B10", VA = "0x185CAA310", Slot = "4")]
	protected override Color DCIAOGEKDKN(Color LOKIPHPAIAD, Color CGHEAIJKHIK, float INGJCJMKCCN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA3D0", Offset = "0x5CA8BD0", VA = "0x185CAA3D0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class DGNJMAPLFNG : IBNLICHHCFB<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA480", Offset = "0x5CA8C80", VA = "0x185CAA480")]
	public DGNJMAPLFNG(int AFOFPPEGLDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA410", Offset = "0x5CA8C10", VA = "0x185CAA410", Slot = "6")]
	protected override uint AEHDDNDKGHP(uint JJPJJOLELKC, string FKKGMPDEPMA)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class COGBBPKJLNN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly IDisposable FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public COGBBPKJLNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct DAENPLHFLAG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> PKCNEOJJFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int DKEGDMGNBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int FFPBKEHHIFB;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3071930", Offset = "0x3070130", VA = "0x183071930")]
	private DAENPLHFLAG(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> KFEEGAGJHOH, int MDMNAFGMNDJ, int DBNIOAJECGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4CDAAA0", Offset = "0x4CD92A0", VA = "0x184CDAAA0")]
	public static DAENPLHFLAG<T> KKMBICLNKPK()
	{
		return default(DAENPLHFLAG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4CDB0E0", Offset = "0x4CD98E0", VA = "0x184CDB0E0")]
	public (int, int, Task<T>) POMLIBMPHON(int MPCNBDJNPDD, [Optional] CancellationToken EHCFBFBFEDH, double HAHNMEKBEPD = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4CDAD40", Offset = "0x4CD9540", VA = "0x184CDAD40")]
	public void PBEICLGNLKM(int MPCNBDJNPDD, int DBNIOAJECGO, [In] T KMHAEDONIKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class APLANNOHMEJ
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA060", Offset = "0x5CA8860", VA = "0x185CAA060")]
	public static DAENPLHFLAG<JGIANJFFIJK> KKMBICLNKPK()
	{
		return default(DAENPLHFLAG<JGIANJFFIJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA0B0", Offset = "0x5CA88B0", VA = "0x185CAA0B0")]
	public static void PBEICLGNLKM([In] this DAENPLHFLAG<JGIANJFFIJK> AFFJMIFONEM, int MPCNBDJNPDD, int DBNIOAJECGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[DefaultMember("Item")]
public class FNHGOJEHHDC<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TKey, TVal> HAKHBAKPGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly Dictionary<TVal, TKey> IDDJILGBMGI;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int HLNPNOBJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2EA0760", Offset = "0x2E9EF60", VA = "0x182EA0760", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool BHLLMPIDEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> POJHELIBEKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x302EE50", Offset = "0x302D650", VA = "0x18302EE50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> PCCFJEBLDMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x342E690", Offset = "0x342CE90", VA = "0x18342E690", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal HBLJIDEPNJF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x342E5E0", Offset = "0x342CDE0", VA = "0x18342E5E0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x342E6F0", Offset = "0x342CEF0", VA = "0x18342E6F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey HBLJIDEPNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x342E2E0", Offset = "0x342CAE0", VA = "0x18342E2E0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x342DB10", Offset = "0x342C310", VA = "0x18342DB10", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x342E460", Offset = "0x342CC60", VA = "0x18342E460", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x342D8E0", Offset = "0x342C0E0", VA = "0x18342D8E0", Slot = "9")]
	public void Add(TKey OHPCNPKOLBJ, TVal FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x342D8B0", Offset = "0x342C0B0", VA = "0x18342D8B0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> BBKHFDEMMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x305D890", Offset = "0x305C090", VA = "0x18305D890", Slot = "8")]
	public bool ContainsKey(TKey OHPCNPKOLBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x342DB70", Offset = "0x342C370", VA = "0x18342DB70", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> BBKHFDEMMEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x342E360", Offset = "0x342CB60", VA = "0x18342E360", Slot = "10")]
	public bool Remove(TKey OHPCNPKOLBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x342E330", Offset = "0x342CB30", VA = "0x18342E330", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> BBKHFDEMMEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x342E4B0", Offset = "0x342CCB0", VA = "0x18342E4B0", Slot = "11")]
	public bool TryGetValue(TKey OHPCNPKOLBJ, [Out] TVal FKKGMPDEPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x342DF00", Offset = "0x342C700", VA = "0x18342DF00", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x342DC00", Offset = "0x342C400", VA = "0x18342DC00", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] INLAJDDNHAO, int ILBHPPPGDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x342E240", Offset = "0x342CA40", VA = "0x18342E240")]
	public bool OCMBKDFPCIC(TVal OHPCNPKOLBJ, [Out] TKey FKKGMPDEPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x342E0C0", Offset = "0x342C8C0", VA = "0x18342E0C0")]
	private void MBGCOENMJBC(TKey OHPCNPKOLBJ, TVal LLMHDPLKODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x342D9E0", Offset = "0x342C1E0", VA = "0x18342D9E0")]
	private void CMGIBHFEHPA(TKey OHPCNPKOLBJ, TVal LLMHDPLKODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x342DE20", Offset = "0x342C620", VA = "0x18342DE20")]
	private bool DKHBNKNJKDC(TKey OHPCNPKOLBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x342E4F0", Offset = "0x342CCF0", VA = "0x18342E4F0")]
	public FNHGOJEHHDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public class LMNJBDAILOG<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private LMNJBDAILOG<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x310E5F0", Offset = "0x310CDF0", VA = "0x18310E5F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x310F3A0", Offset = "0x310DBA0", VA = "0x18310F3A0")]
		public Enumerator(LMNJBDAILOG<T> NEJFCHMJPKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x310ACC0", Offset = "0x31094C0", VA = "0x18310ACC0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x310CC90", Offset = "0x310B490", VA = "0x18310CC90", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x310A210", Offset = "0x3108A10", VA = "0x18310A210")]
		private void DLOKHECCIGO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private T[] MPKCABPHAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int AIINMNHNKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int FJOEONALFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int IFOEKNINMPE;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int HLNPNOBJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3926EC0", Offset = "0x39256C0", VA = "0x183926EC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T HBLJIDEPNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x39277F0", Offset = "0x3925FF0", VA = "0x1839277F0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3927680", Offset = "0x3925E80", VA = "0x183927680")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x39279F0", Offset = "0x39261F0", VA = "0x1839279F0")]
	public LMNJBDAILOG(int AFOFPPEGLDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3926BE0", Offset = "0x39253E0", VA = "0x183926BE0")]
	public void BONJGFNEKBE(T INGJCJMKCCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3926BC0", Offset = "0x39253C0", VA = "0x183926BC0")]
	public void BEIKHFOBAHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3926B10", Offset = "0x3925310", VA = "0x183926B10")]
	public void AKMFHOHADLC(int EHGKBCBKPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3927230", Offset = "0x3925A30", VA = "0x183927230")]
	public void MANNFFKJOPK(T[] INLAJDDNHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3926E80", Offset = "0x3925680", VA = "0x183926E80")]
	public Enumerator EKEEKKCIFJI()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x39278F0", Offset = "0x39260F0", VA = "0x1839278F0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x39278F0", Offset = "0x39260F0", VA = "0x1839278F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3927120", Offset = "0x3925920", VA = "0x183927120")]
	private int IAFAELJFDNL(int LFEFGCGCIAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x39277C0", Offset = "0x3925FC0", VA = "0x1839277C0")]
	private int OCIIFCLDFEB(int LFEFGCGCIAG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class POBNNLAAHAA<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Func<Internal, External> CHDGBHFLAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private IReadOnlyList<Internal> HBKECNHANOP;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public External HBLJIDEPNJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3DD2840", Offset = "0x3DD1040", VA = "0x183DD2840", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int HLNPNOBJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3DD2780", Offset = "0x3DD0F80", VA = "0x183DD2780", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x768BD0", Offset = "0x7673D0", VA = "0x180768BD0")]
	public POBNNLAAHAA(Func<Internal, External> CHDGBHFLAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3DD2730", Offset = "0x3DD0F30", VA = "0x183DD2730")]
	public POBNNLAAHAA(IReadOnlyList<Internal> HBKECNHANOP, Func<Internal, External> CHDGBHFLAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3DD26B0", Offset = "0x3DD0EB0", VA = "0x183DD26B0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3227FA0", Offset = "0x32267A0", VA = "0x183227FA0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class LABGAIKLGEC<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate Task<TResult> DAHNMOADFNH(TRequest LJEEHJLDFLC, CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public enum HJIKKCGDIPA
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class AAEGMIDOEFK
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private const float PBLEANGGKGC = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TimeSpan CJPGEBEOOAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int NIBMAKCEDON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public HJIKKCGDIPA PBBEJFGKLKF;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly AAEGMIDOEFK MHFKJLABGMI;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float HACJILNEDKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x3476770", Offset = "0x3474F70", VA = "0x183476770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan MKLKNKBOHFB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3476850", Offset = "0x3475050", VA = "0x183476850")]
		public AAEGMIDOEFK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private readonly struct KFJLGNGBLIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public readonly TRequest LJEEHJLDFLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public readonly CancellationToken EHCFBFBFEDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly TaskCompletionSource<TResult> PBJEENFPOAA;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x386F590", Offset = "0x386DD90", VA = "0x18386F590")]
		public KFJLGNGBLIC(TRequest LJEEHJLDFLC, TaskCompletionSource<TResult> PBJEENFPOAA, CancellationToken EHCFBFBFEDH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct CJOBJFMLJLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public LABGAIKLGEC<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4B59130", Offset = "0x4B57930", VA = "0x184B59130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x4B59D90", Offset = "0x4B58590", VA = "0x184B59D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct NGKKIDDKNEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public LABGAIKLGEC<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private KFJLGNGBLIC <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3BBC860", Offset = "0x3BBB060", VA = "0x183BBC860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3BBDA30", Offset = "0x3BBC230", VA = "0x183BBDA30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly CancellationTokenSource IOIHLHJHKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<KFJLGNGBLIC> DOPOELDPFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly AAEGMIDOEFK DDMFNGBLGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly DAHNMOADFNH DPKIOAJNPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Task HMFIGDFMMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private int EHOFGELGFAL;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3906920", Offset = "0x3905120", VA = "0x183906920")]
	public LABGAIKLGEC(DAHNMOADFNH DPKIOAJNPAA, [Optional] AAEGMIDOEFK DDMFNGBLGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3906250", Offset = "0x3904A50", VA = "0x183906250")]
	public Task<TResult> LEKCKAMLJKJ(TRequest LJEEHJLDFLC, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3905120", Offset = "0x3903920", VA = "0x183905120")]
	private void AHDLFIPIHLI(KFJLGNGBLIC ILBOKBFJAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3905B20", Offset = "0x3904320", VA = "0x183905B20")]
	[AsyncStateMachine(typeof(LABGAIKLGEC<, >.CJOBJFMLJLN))]
	private Task HDOLNANBIAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3905350", Offset = "0x3903B50", VA = "0x183905350")]
	private KFJLGNGBLIC FIOBDPOLDGO()
	{
		return default(KFJLGNGBLIC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3905E80", Offset = "0x3904680", VA = "0x183905E80")]
	[AsyncStateMachine(typeof(LABGAIKLGEC<, >.NGKKIDDKNEP))]
	private Task HNAAMMOJAOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3906650", Offset = "0x3904E50", VA = "0x183906650")]
	private void PHDKDFBNOKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3905310", Offset = "0x3903B10", VA = "0x183905310", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class PKLCCOJAELF<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly List<T> HBKECNHANOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private HashSet<T> NCJCGHDHDIP;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int HLNPNOBJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2EA0760", Offset = "0x2E9EF60", VA = "0x182EA0760", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool BHLLMPIDEOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T HBLJIDEPNJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3069E70", Offset = "0x3068670", VA = "0x183069E70", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3DBABE0", Offset = "0x3DB93E0", VA = "0x183DBABE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x343F2E0", Offset = "0x343DAE0", VA = "0x18343F2E0", Slot = "11")]
	public void Add(T BBKHFDEMMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3DBA4B0", Offset = "0x3DB8CB0", VA = "0x183DBA4B0")]
	public bool EMGPHAFADIE(T BBKHFDEMMEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3DBA9B0", Offset = "0x3DB91B0", VA = "0x183DBA9B0", Slot = "15")]
	public bool Remove(T BBKHFDEMMEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3DBA570", Offset = "0x3DB8D70", VA = "0x183DBA570", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3380E30", Offset = "0x337F630", VA = "0x183380E30", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3DBA320", Offset = "0x3DB8B20", VA = "0x183DBA320", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3DBA380", Offset = "0x3DB8B80", VA = "0x183DBA380", Slot = "13")]
	public bool Contains(T BBKHFDEMMEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3DBA3C0", Offset = "0x3DB8BC0", VA = "0x183DBA3C0", Slot = "14")]
	public void CopyTo(T[] INLAJDDNHAO, int ILBHPPPGDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x38A8EE0", Offset = "0x38A76E0", VA = "0x1838A8EE0", Slot = "6")]
	public int IndexOf(T BBKHFDEMMEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3DBA6E0", Offset = "0x3DB8EE0", VA = "0x183DBA6E0", Slot = "7")]
	public void Insert(int LFEFGCGCIAG, T BBKHFDEMMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3DBA8C0", Offset = "0x3DB90C0", VA = "0x183DBA8C0", Slot = "8")]
	public void RemoveAt(int LFEFGCGCIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3DBAAF0", Offset = "0x3DB92F0", VA = "0x183DBAAF0")]
	public PKLCCOJAELF()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x1F33D80", Offset = "0x1F32580", VA = "0x181F33D80")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5CAED60", Offset = "0x5CAD560", VA = "0x185CAED60")]
		public SerializedGuid([In] Guid OJPOLEONBAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5CAEA50", Offset = "0x5CAD250", VA = "0x185CAEA50")]
		public static SerializedGuid BBPABFHHELL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5CAEBE0", Offset = "0x5CAD3E0", VA = "0x185CAEBE0")]
		public static SerializedGuid LFHDKPFFCPL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5CAEC50", Offset = "0x5CAD450", VA = "0x185CAEC50")]
		public bool NJJJJBFIMNL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5CAED30", Offset = "0x5CAD530", VA = "0x185CAED30", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5CAECB0", Offset = "0x5CAD4B0", VA = "0x185CAECB0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5CAEB00", Offset = "0x5CAD300", VA = "0x185CAEB00", Slot = "7")]
		public bool Equals(SerializedGuid IFHFGCDLDEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5CAEB40", Offset = "0x5CAD340", VA = "0x185CAEB40", Slot = "0")]
		public override bool Equals(object CBBCDNDPNHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5CAEBD0", Offset = "0x5CAD3D0", VA = "0x185CAEBD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5CAEAD0", Offset = "0x5CAD2D0", VA = "0x185CAEAD0", Slot = "6")]
		public int CompareTo(SerializedGuid IFHFGCDLDEA)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class FIKABPJNPAO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly Type MNLHBDOLOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly string MLFENNOHFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly bool ALJFLDMKDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly bool PFMGGMOBAAG;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA640", Offset = "0x5CA8E40", VA = "0x185CAA640")]
	public FIKABPJNPAO(Type DPOAJIHAFPM, string IPNCLONBMIP, bool AMHFJANIIAB = false, bool CPHDPMCBPBA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class ANHHFLMKBPC<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public readonly struct HDIKFHEPEID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public readonly long OECIMPBJPFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public readonly long GJENEGKDHGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly int EGBGIEEKIED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly int MNEEOJHBIAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly bool MDKILHKLKGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly string EMBDOLFGCOF;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x356E7D0", Offset = "0x356CFD0", VA = "0x18356E7D0")]
		public HDIKFHEPEID(long OECIMPBJPFA, int EGBGIEEKIED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x356E840", Offset = "0x356D040", VA = "0x18356E840")]
		public HDIKFHEPEID(long OECIMPBJPFA, long GJENEGKDHGP, int EGBGIEEKIED, int MNEEOJHBIAN, bool MDKILHKLKGG, string EMBDOLFGCOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x356E780", Offset = "0x356CF80", VA = "0x18356E780")]
		public int NGAJHBGALEF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x356E760", Offset = "0x356CF60", VA = "0x18356E760")]
		public int IONLIKKOCIH(int LBJBCBDCCAG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x356E700", Offset = "0x356CF00", VA = "0x18356E700")]
		public double FMAFFOGNJBC()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x356E660", Offset = "0x356CE60", VA = "0x18356E660")]
		public HDIKFHEPEID EEFMMAIBJIF(long GJENEGKDHGP, int MNEEOJHBIAN)
		{
			return default(HDIKFHEPEID);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class AJPBBELKCKG : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct FAJFHIBFICM<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AJPBBELKCKG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public Func<AJPBBELKCKG, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private AJPBBELKCKG <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x33ECED0", Offset = "0x33EB6D0", VA = "0x1833ECED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x302D840", Offset = "0x302C040", VA = "0x18302D840", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly TKey LKLFDONKJGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly ANHHFLMKBPC<TKey> AOGFPKDBLJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly DGJIKJLGCCH KFIEDGIKACP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private List<AJPBBELKCKG> DMKNOADKKCA;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string GBBKDICHAPP
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x352A980", Offset = "0x3529180", VA = "0x18352A980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<AJPBBELKCKG> JFHGFAJNLCE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x352AD30", Offset = "0x3529530", VA = "0x18352AD30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public HDIKFHEPEID FDAJDFGKHOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x352AD10", Offset = "0x3529510", VA = "0x18352AD10")]
			[CompilerGenerated]
			get
			{
				return default(HDIKFHEPEID);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x352AD70", Offset = "0x3529570", VA = "0x18352AD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x352ADA0", Offset = "0x35295A0", VA = "0x18352ADA0")]
		internal AJPBBELKCKG(ANHHFLMKBPC<TKey> AOGFPKDBLJK, TKey OHPCNPKOLBJ, DGJIKJLGCCH KFIEDGIKACP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x352A9B0", Offset = "0x35291B0", VA = "0x18352A9B0")]
		public AJPBBELKCKG DALOIKLPECN(TKey OHPCNPKOLBJ, [Optional] DGJIKJLGCCH? EIKONHHKGAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2003630", Offset = "0x2001E30", VA = "0x182003630")]
		[AsyncStateMachine(typeof(FAJFHIBFICM<>))]
		public Task<T> FMFEPIJNAFF<T>(TKey OHPCNPKOLBJ, Func<AJPBBELKCKG, Task<T>> KFJLELLEOLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x352AB10", Offset = "0x3529310", VA = "0x18352AB10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class DCMJBLJBAGJ : IEnumerable<(TKey, List<TKey>, HDIKFHEPEID)>, IEnumerable, IEnumerator<(TKey, List<TKey>, HDIKFHEPEID)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private (TKey key, List<TKey> path, HDIKFHEPEID timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public ANHHFLMKBPC<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private IEnumerator<(TKey key, List<TKey> path, HDIKFHEPEID timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, HDIKFHEPEID) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x34CBF70", Offset = "0x34CA770", VA = "0x1834CBF70", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, HDIKFHEPEID));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x4D11C60", Offset = "0x4D10460", VA = "0x184D11C60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x34CC190", Offset = "0x34CA990", VA = "0x1834CC190")]
		[DebuggerHidden]
		public DCMJBLJBAGJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3058DD0", Offset = "0x30575D0", VA = "0x183058DD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4D11700", Offset = "0x4D0FF00", VA = "0x184D11700", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4D11B00", Offset = "0x4D10300", VA = "0x184D11B00")]
		private void NINDIEOCHCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x4D11C10", Offset = "0x4D10410", VA = "0x184D11C10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x4D11B50", Offset = "0x4D10350", VA = "0x184D11B50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, HDIKFHEPEID)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x322BB10", Offset = "0x322A310", VA = "0x18322BB10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class LDKBGNJEENJ : IEnumerable<(TKey, List<TKey>, HDIKFHEPEID)>, IEnumerable, IEnumerator<(TKey, List<TKey>, HDIKFHEPEID)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private (TKey key, List<TKey> path, HDIKFHEPEID timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private AJPBBELKCKG timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AJPBBELKCKG <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public ANHHFLMKBPC<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private IEnumerator<AJPBBELKCKG> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private IEnumerator<(TKey key, List<TKey> path, HDIKFHEPEID timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, HDIKFHEPEID) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x34CBF70", Offset = "0x34CA770", VA = "0x1834CBF70", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, HDIKFHEPEID));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x3919690", Offset = "0x3917E90", VA = "0x183919690", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x34CC190", Offset = "0x34CA990", VA = "0x1834CC190")]
		[DebuggerHidden]
		public LDKBGNJEENJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x39196F0", Offset = "0x3917EF0", VA = "0x1839196F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3918CC0", Offset = "0x39174C0", VA = "0x183918CC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x39194D0", Offset = "0x3917CD0", VA = "0x1839194D0")]
		private void NINDIEOCHCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3919470", Offset = "0x3917C70", VA = "0x183919470")]
		private void NIGDNOCCEEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3919640", Offset = "0x3917E40", VA = "0x183919640", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3919530", Offset = "0x3917D30", VA = "0x183919530", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, HDIKFHEPEID)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3919610", Offset = "0x3917E10", VA = "0x183919610", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly Action<TKey, HDIKFHEPEID, DGJIKJLGCCH> LKLNMKMKFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Action<TKey, HDIKFHEPEID, DGJIKJLGCCH> HOFOCDLAEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly Action<ANHHFLMKBPC<TKey>, DGJIKJLGCCH> NKLKJOEDIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly AJPBBELKCKG KCBJGJBIANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private bool CBPCANBMLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private int FHLAIGICEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Stopwatch KFPDGPILLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly int IPOGGCPMGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private string HGDCNDDNCIB;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public AJPBBELKCKG KHOPIHEPPNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x76B5B0", Offset = "0x769DB0", VA = "0x18076B5B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string GBBKDICHAPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x761C50", Offset = "0x760450", VA = "0x180761C50")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x35333A0", Offset = "0x3531BA0", VA = "0x1835333A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3533670", Offset = "0x3531E70", VA = "0x183533670")]
	public ANHHFLMKBPC(TKey HEILIIGKHPF, DGJIKJLGCCH KFIEDGIKACP, [Optional] int? EGBGIEEKIED, [Optional][CanBeNull] Stopwatch KFPDGPILLEL, [Optional] Action<TKey, HDIKFHEPEID, DGJIKJLGCCH> LKLNMKMKFNP, [Optional] Action<TKey, HDIKFHEPEID, DGJIKJLGCCH> HOFOCDLAEON, [Optional] Action<ANHHFLMKBPC<TKey>, DGJIKJLGCCH> NKLKJOEDIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3533400", Offset = "0x3531C00", VA = "0x183533400", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3533490", Offset = "0x3531C90", VA = "0x183533490")]
	[IteratorStateMachine(typeof(ANHHFLMKBPC<>.DCMJBLJBAGJ))]
	public IEnumerable<(TKey, List<TKey>, HDIKFHEPEID)> GBPCELOKDHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3533520", Offset = "0x3531D20", VA = "0x183533520")]
	[IteratorStateMachine(typeof(ANHHFLMKBPC<>.LDKBGNJEENJ))]
	private IEnumerable<(TKey, List<TKey>, HDIKFHEPEID)> GBPCELOKDHK(List<TKey> EPIKKECCKMG, AJPBBELKCKG ODCJNNEJNDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x35335F0", Offset = "0x3531DF0", VA = "0x1835335F0")]
	private (long, int) HIBLPEDLHDH()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public abstract class FFOJDLNHLBA<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut JMPJBGFFLAN(ANHHFLMKBPC<TKey> AOGFPKDBLJK);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	protected FFOJDLNHLBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public abstract class KMBEANHMPPL<TKey> : FFOJDLNHLBA<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate string INEDKBLILBA(TKey OHPCNPKOLBJ);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x38810F0", Offset = "0x387F8F0", VA = "0x1838810F0")]
	private static string BLMIAEJPNNF(TKey OHPCNPKOLBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3881130", Offset = "0x387F930", VA = "0x183881130", Slot = "4")]
	public override string JMPJBGFFLAN(ANHHFLMKBPC<TKey> AOGFPKDBLJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x38811F0", Offset = "0x387F9F0", VA = "0x1838811F0")]
	public string JMPJBGFFLAN(ANHHFLMKBPC<TKey> AOGFPKDBLJK, [NotNull] INEDKBLILBA CLPGDEOHINM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string BELICDEEKHJ(ANHHFLMKBPC<TKey> AOGFPKDBLJK, [NotNull] INEDKBLILBA CLPGDEOHINM);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3407480", Offset = "0x3405C80", VA = "0x183407480")]
	protected KMBEANHMPPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class EGCOJIGDAEL<TKey> : FFOJDLNHLBA<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate string NAKNEEEKLKO(TKey OHPCNPKOLBJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly string NGGMGOEKKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly double BOLIKPKLELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly bool GPIAHHAJDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly int FCEJBGKHJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly ISet<string> CEMGAOMHLFO;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3068FB0", Offset = "0x30677B0", VA = "0x183068FB0")]
	private static string BLMIAEJPNNF(TKey OHPCNPKOLBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3069B20", Offset = "0x3068320", VA = "0x183069B20")]
	public EGCOJIGDAEL(string NGGMGOEKKMC = "F2", double BOLIKPKLELA = double.MaxValue, bool GPIAHHAJDOJ = false, int FCEJBGKHJGJ = int.MaxValue, [Optional] ISet<string> CEMGAOMHLFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3069310", Offset = "0x3067B10", VA = "0x183069310", Slot = "4")]
	public override Dictionary<string, string> JMPJBGFFLAN(ANHHFLMKBPC<TKey> AOGFPKDBLJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3068FF0", Offset = "0x30677F0", VA = "0x183068FF0")]
	private bool BNJADNACEFO(string ENBAPMHCCIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x30693D0", Offset = "0x3067BD0", VA = "0x1830693D0")]
	public Dictionary<string, string> JMPJBGFFLAN(ANHHFLMKBPC<TKey> AOGFPKDBLJK, NAKNEEEKLKO CLPGDEOHINM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x30690D0", Offset = "0x30678D0", VA = "0x1830690D0")]
	private string IEHJDLAHMHM(StringBuilder DAKCNNDFHAA, List<TKey> NHFJJHKKDDM, NAKNEEEKLKO CLPGDEOHINM, bool JFELOFNFJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x30699C0", Offset = "0x30681C0", VA = "0x1830699C0")]
	private static void OANCJFHEAKJ(StringBuilder LHDBEGNHNFP, string NDNKKBMOBPM, bool IOHOMFOJABE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class ILMPAIPIHHP<TKey> : KMBEANHMPPL<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct BCNPMPEJIIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public INEDKBLILBA keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static ILMPAIPIHHP<TKey> FLMPJFHFLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string[] DMGDJBLOLJN;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3650BE0", Offset = "0x364F3E0", VA = "0x183650BE0")]
	private ILMPAIPIHHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x364FB80", Offset = "0x364E380", VA = "0x18364FB80", Slot = "5")]
	protected override string BELICDEEKHJ(ANHHFLMKBPC<TKey> AOGFPKDBLJK, INEDKBLILBA CLPGDEOHINM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x36509B0", Offset = "0x364F1B0", VA = "0x1836509B0")]
	[CompilerGenerated]
	internal static string JILKKMFKLBE(string DFGFFGGCNPD, TKey OHPCNPKOLBJ, BCNPMPEJIIG P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class IAFAFOINKCJ : ANHHFLMKBPC<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class NFOOGFIFKAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Action<IAFAFOINKCJ, DGJIKJLGCCH> callback;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public NFOOGFIFKAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5CAC580", Offset = "0x5CAAD80", VA = "0x185CAC580")]
		internal void JFANBCPGOGG(ANHHFLMKBPC<string> timer, DGJIKJLGCCH log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5CAB7B0", Offset = "0x5CA9FB0", VA = "0x185CAB7B0")]
	public IAFAFOINKCJ(DGJIKJLGCCH KFIEDGIKACP, [Optional] string NPMLMGEOEPF, [Optional] int? EGBGIEEKIED, [Optional] Stopwatch KFPDGPILLEL, [Optional] Action<string, HDIKFHEPEID, DGJIKJLGCCH> LKLNMKMKFNP, [Optional] Action<string, HDIKFHEPEID, DGJIKJLGCCH> HOFOCDLAEON, [Optional] Action<IAFAFOINKCJ, DGJIKJLGCCH> NKLKJOEDIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5CAB6F0", Offset = "0x5CA9EF0", VA = "0x185CAB6F0")]
	private static Action<ANHHFLMKBPC<string>, DGJIKJLGCCH> DJALPPKHGDE(Action<IAFAFOINKCJ, DGJIKJLGCCH> ABCKGGDLEKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public abstract class EOOMCNPFMCB
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private class KLLAJJGMAOL : EOOMCNPFMCB
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static EOOMCNPFMCB FLMPJFHFLHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x5CABD90", Offset = "0x5CAA590", VA = "0x185CABD90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float IDOGCGMNAFA
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x1C069D0", Offset = "0x1C051D0", VA = "0x181C069D0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5CABE90", Offset = "0x5CAA690", VA = "0x185CABE90")]
		public KLLAJJGMAOL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static EOOMCNPFMCB GJJEPMJLOBE;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static EOOMCNPFMCB MHFKJLABGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5CAA4D0", Offset = "0x5CA8CD0", VA = "0x185CAA4D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float IDOGCGMNAFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	protected EOOMCNPFMCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class PEBFLFLNHMC : PNMOHCDAILC<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5CAD390", Offset = "0x5CABB90", VA = "0x185CAD390")]
	public PEBFLFLNHMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class PNMOHCDAILC<T> : NCPLMHIOGDO<T>, JAEDIAFPMPI, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task<T> DHBOABDCEBN
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public NLPPPLCCBHA<T> LNGCNMCMBDH
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3DD2400", Offset = "0x3DD0C00", VA = "0x183DD2400")]
	public PNMOHCDAILC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class OGIMFCBFFCE<T> : NCPLMHIOGDO<T>, JAEDIAFPMPI, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Task<T> DHBOABDCEBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NLPPPLCCBHA<T> LNGCNMCMBDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3CD6380", Offset = "0x3CD4B80", VA = "0x183CD6380")]
	public OGIMFCBFFCE(Exception KHOFKDAGHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface JAEDIAFPMPI : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface NCPLMHIOGDO<T> : JAEDIAFPMPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	[NotNull]
	Task<T> DHBOABDCEBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[NotNull]
	NLPPPLCCBHA<T> LNGCNMCMBDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public abstract class BMEPHIGHGHD
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	protected static bool ADGBBAAJNKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5CAA130", Offset = "0x5CA8930", VA = "0x185CAA130")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5CAA180", Offset = "0x5CA8980", VA = "0x185CAA180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA1E0", Offset = "0x5CA89E0", VA = "0x185CAA1E0")]
	static BMEPHIGHGHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	protected BMEPHIGHGHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public abstract class PKCEBKMNHHG<TTask, T> : BMEPHIGHGHD, NCPLMHIOGDO<T>, JAEDIAFPMPI, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class IMGAPGMGJOK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public IMGAPGMGJOK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x2E908D0", Offset = "0x2E8F0D0", VA = "0x182E908D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x2E90E40", Offset = "0x2E8F640", VA = "0x182E90E40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public PKCEBKMNHHG<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public IMGAPGMGJOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3656FF0", Offset = "0x36557F0", VA = "0x183656FF0")]
		[AsyncStateMachine(typeof(PKCEBKMNHHG<, >.IMGAPGMGJOK.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> GGAIHFLJFKE(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly Task<T> AKGEHPDFIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	protected readonly CancellationTokenSource PDCJAGPLKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool CBPCANBMLCP;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Task<T> DHBOABDCEBN
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NLPPPLCCBHA<T> LNGCNMCMBDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool AMDAEMPIIPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7FCD80", Offset = "0x7FB580", VA = "0x1807FCD80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3DB9620", Offset = "0x3DB7E20", VA = "0x183DB9620")]
	protected PKCEBKMNHHG(TTask AKGEHPDFIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3DB9590", Offset = "0x3DB7D90", VA = "0x183DB9590", Slot = "1")]
	~PKCEBKMNHHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x3949560", Offset = "0x3947D60", VA = "0x183949560", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x3DB9420", Offset = "0x3DB7C20", VA = "0x183DB9420")]
	private void FILLLFKPAJA(bool GOFOEKAGOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T IDDCIADMEKE(TTask KMPJAJECLFA);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void KHJMKANIPOI();
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class MDALOCENMJP
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5CAC1E0", Offset = "0x5CAA9E0", VA = "0x185CAC1E0")]
	[NotNull]
	public static byte[] NKNCKOBFIPE(this KAKFOPNPFFG CNNKPCEDBBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5CAC170", Offset = "0x5CAA970", VA = "0x185CAC170")]
	[NotNull]
	public static byte[] NKNCKOBFIPE(this KAKFOPNPFFG CNNKPCEDBBM, HashAlgorithmName NNFDKJENPAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5CAC250", Offset = "0x5CAAA50", VA = "0x185CAC250")]
	public static bool PJGFIMBMLHN([CanBeNull] this KAKFOPNPFFG CNNKPCEDBBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5CAC3E0", Offset = "0x5CAABE0", VA = "0x185CAC3E0")]
	public static bool PJGFIMBMLHN([CanBeNull] this KAKFOPNPFFG CNNKPCEDBBM, [Out] string HLPKEEDLIBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5CAC050", Offset = "0x5CAA850", VA = "0x185CAC050")]
	private static bool LPCOKEFGMJE([NotNull] KAKFOPNPFFG CNNKPCEDBBM, [Out][CanBeNull] byte[] FAFHHCMNBOO, [Out][CanBeNull] byte[] KMGCDHPBFEN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class PLEENPGKEGP
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5CAD3D0", Offset = "0x5CABBD0", VA = "0x185CAD3D0")]
	[NotNull]
	public static byte[] NKNCKOBFIPE(this BOGNMFOHDBC JMFFDHCLKBH, HashAlgorithmName NNFDKJENPAF, byte[] MOLGDAJKLMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface BOGNMFOHDBC
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash JJPJJOLELKC);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface KAKFOPNPFFG : BOGNMFOHDBC
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[CanBeNull]
	byte[] MOHGGLAFEJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	[CanBeNull]
	byte[] OPMEEAGMNFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class PBNDBBANMAC
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static readonly ArrayPool<byte> IKHPJPKIOEH;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static bool EJLLFBFHLFE;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5CACFE0", Offset = "0x5CAB7E0", VA = "0x185CACFE0")]
	public static void MBHJNDDJHAP(this IncrementalHash DDCIGNHHJIP, [CanBeNull] GameObject GOGHJGCCDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x24E4920", Offset = "0x24E3120", VA = "0x1824E4920")]
	public static void MBHJNDDJHAP<T>(this IncrementalHash DDCIGNHHJIP, [CanBeNull] T FMGHNFLOPOI) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x24E3D40", Offset = "0x24E2540", VA = "0x1824E3D40")]
	public static void GJCMLILIFGD<T>(this IncrementalHash DDCIGNHHJIP, [CanBeNull] T JMFFDHCLKBH) where T : BOGNMFOHDBC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x24E3DD0", Offset = "0x24E25D0", VA = "0x1824E3DD0")]
	public static void HGCNMMAEFOI<T>(this IncrementalHash DDCIGNHHJIP, [CanBeNull] IList<T> NEMFPCAILCA) where T : BOGNMFOHDBC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5CAD1F0", Offset = "0x5CAB9F0", VA = "0x185CAD1F0")]
	private static bool PHLIPAPAFPL([CanBeNull] BOGNMFOHDBC JMFFDHCLKBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5CAC8F0", Offset = "0x5CAB0F0", VA = "0x185CAC8F0")]
	public static void DFBHPMOKEFD(this IncrementalHash JJPJJOLELKC, [CanBeNull] string OPKNCBOBAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5CAC950", Offset = "0x5CAB150", VA = "0x185CAC950")]
	public static void FKPFPHMNDOL(this IncrementalHash JJPJJOLELKC, long JOMADPANGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5CACB20", Offset = "0x5CAB320", VA = "0x185CACB20")]
	public static void FNIKLGJMEEB(this IncrementalHash JJPJJOLELKC, int IOHPCKAMIKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5CACCF0", Offset = "0x5CAB4F0", VA = "0x185CACCF0")]
	public static void HDPMHFDNHOA(this IncrementalHash JJPJJOLELKC, short LIPEEMOHJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5CAC7E0", Offset = "0x5CAAFE0", VA = "0x185CAC7E0")]
	public static void CMOIHJCLHCM(this IncrementalHash JJPJJOLELKC, byte OGGFBFPKGOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5CAC610", Offset = "0x5CAAE10", VA = "0x185CAC610")]
	public static void BPNNGGKLIPB(this IncrementalHash JJPJJOLELKC, bool MKLGHNCLCJN, bool FHEAKEHDCPG = false, bool BEIAGLCEFOB = false, bool CAOCFBGADKO = false, bool KAIHDHHEHBE = false, bool EPGGHCKFCEH = false, bool PEHFLKNIDAA = false, bool PIHOKDIHEIJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x24E42F0", Offset = "0x24E2AF0", VA = "0x1824E42F0")]
	public static void JLELJDOCHKM<T>(this IncrementalHash JJPJJOLELKC, T OKPFOPOABKC) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5CACF20", Offset = "0x5CAB720", VA = "0x185CACF20")]
	public static void JPGOAJMMCAP(this IncrementalHash JJPJJOLELKC, float JCKODGEGKPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5CACEC0", Offset = "0x5CAB6C0", VA = "0x185CACEC0")]
	public static void JMIEOJBBIBM(this IncrementalHash JJPJJOLELKC, ulong JHFPNAJGAHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5CAC780", Offset = "0x5CAAF80", VA = "0x185CAC780")]
	public static void CCAPJDHHAPG(this IncrementalHash JJPJJOLELKC, uint CHKGNCNNBGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5CACF80", Offset = "0x5CAB780", VA = "0x185CACF80")]
	public static void LMNBMJIFLLJ(this IncrementalHash JJPJJOLELKC, ushort CDKGKENMHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5CAD0C0", Offset = "0x5CAB8C0", VA = "0x185CAD0C0")]
	public static void PFHNCCPOCJF(this IncrementalHash JJPJJOLELKC, Vector3 JKHKBDPHEGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class GMNHBEGFKJB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA730", Offset = "0x5CA8F30", VA = "0x185CAA730")]
	public GMNHBEGFKJB(string BKGEBGGPBLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public abstract class NGLOFOOPEEA<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	internal class GOHGJOFGFNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public TNode AFFJMIFONEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public TNode OBIIIBPBMLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public KPFDNBPKDDI OLCJDOMAAGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public List<KPFDNBPKDDI> IFHEPGFFGDE;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public GOHGJOFGFNF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal struct KPFDNBPKDDI : IComparable<KPFDNBPKDDI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int HHCPPOIJJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public TClaimant JDMJIEDBLJF;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xAA8750", Offset = "0xAA6F50", VA = "0x180AA8750")]
		public KPFDNBPKDDI(int HHCPPOIJJFF, TClaimant JDMJIEDBLJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x388C810", Offset = "0x388B010", VA = "0x18388C810")]
		public bool CEDHJGNENMP([In] KPFDNBPKDDI IFHFGCDLDEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x388C880", Offset = "0x388B080", VA = "0x18388C880")]
		public bool LJBPJJENNBA([In] KPFDNBPKDDI IFHFGCDLDEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x388C870", Offset = "0x388B070", VA = "0x18388C870", Slot = "4")]
		public int CompareTo(KPFDNBPKDDI IFHFGCDLDEA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x388C890", Offset = "0x388B090", VA = "0x18388C890", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum DBGICEBLMAD
	{
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class JJEJNGEMCBN : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public NGLOFOOPEEA<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x86AE20", Offset = "0x869620", VA = "0x18086AE20")]
		[DebuggerHidden]
		public JJEJNGEMCBN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3811780", Offset = "0x380FF80", VA = "0x183811780", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3811940", Offset = "0x3810140", VA = "0x183811940", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3811860", Offset = "0x3810060", VA = "0x183811860", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3224940", Offset = "0x3223140", VA = "0x183224940", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly LFDPCBIOPPA<GOHGJOFGFNF> DFGIEKEALPJ;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly LFDPCBIOPPA<List<KPFDNBPKDDI>> MIAAANGEBBN;

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static int DHIKDPBKFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	internal readonly Dictionary<TClaimant, TNode> FLBCBICBGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	internal readonly Dictionary<TNode, GOHGJOFGFNF> BIKHDGONEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private DBGICEBLMAD FDFIAAFCBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private bool KIMEMKKPGDJ;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode GADDKJOEJFO(TNode GIJABPPCKCI);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void GNFBJAOLNCD(TNode GIJABPPCKCI, TClaimant LKEIABCCOOH, TClaimant BHDILJMMBCF);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x3BBF310", Offset = "0x3BBDB10", VA = "0x183BBF310")]
	public NGLOFOOPEEA(DBGICEBLMAD FDFIAAFCBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3BBEA20", Offset = "0x3BBD220", VA = "0x183BBEA20")]
	public void LBCFOPMHFPG(TNode GIJABPPCKCI, TNode KEDAAEKKLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3BBE5C0", Offset = "0x3BBCDC0", VA = "0x183BBE5C0")]
	public void KDEOIAMEADM(TClaimant JDMJIEDBLJF, TNode EANNLENCNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3BBDEF0", Offset = "0x3BBC6F0", VA = "0x183BBDEF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3BBDE50", Offset = "0x3BBC650", VA = "0x183BBDE50")]
	private void DIICIDCBBFJ(TClaimant JDMJIEDBLJF, TNode AMDHHKOHMNJ, TNode EANNLENCNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3BBEE00", Offset = "0x3BBD600", VA = "0x183BBEE00")]
	private int OBGIHHPFAMF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3BBE6E0", Offset = "0x3BBCEE0", VA = "0x183BBE6E0")]
	private void KJMCPHIHJFC(TClaimant JDMJIEDBLJF, TNode NMAPENPGADI, TNode KNHMPHIEBND, int HPAFNLPIEEN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3BBE1F0", Offset = "0x3BBC9F0", VA = "0x183BBE1F0")]
	private void HFMHFKOIIFC(KPFDNBPKDDI JIIMAIPFDLD, GOHGJOFGFNF PBLOIICNEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3BBEE70", Offset = "0x3BBD670", VA = "0x183BBEE70")]
	private void OMKMLGJBPHI(TClaimant JDMJIEDBLJF, TNode NMAPENPGADI, TNode KNHMPHIEBND, int HPAFNLPIEEN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3BBDBD0", Offset = "0x3BBC3D0", VA = "0x183BBDBD0")]
	private void AJFDJGCEJAC(KPFDNBPKDDI JIIMAIPFDLD, TNode GIJABPPCKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3BBED10", Offset = "0x3BBD510", VA = "0x183BBED10")]
	private void NFLEGAHKBFG(KPFDNBPKDDI JIIMAIPFDLD, GOHGJOFGFNF PBLOIICNEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3BBE0C0", Offset = "0x3BBC8C0", VA = "0x183BBE0C0")]
	private void GLNNBMKFAMJ(GOHGJOFGFNF PBLOIICNEMP, bool OINKHMLGCJB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3BBE280", Offset = "0x3BBCA80", VA = "0x183BBE280")]
	private void JNPECJOPDHG(GOHGJOFGFNF PBLOIICNEMP, TNode KEDAAEKKLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3BBDAF0", Offset = "0x3BBC2F0", VA = "0x183BBDAF0")]
	[IteratorStateMachine(typeof(NGLOFOOPEEA<, >.JJEJNGEMCBN))]
	private IEnumerable<TNode> AGGENJMJFKD(TNode NMAPENPGADI, TNode KNHMPHIEBND, bool HOODDFNHINM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3BBEAB0", Offset = "0x3BBD2B0", VA = "0x183BBEAB0")]
	private GOHGJOFGFNF LPIPNGPDIKM(TNode GIJABPPCKCI, TNode OBIIIBPBMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3BBEBA0", Offset = "0x3BBD3A0", VA = "0x183BBEBA0")]
	private GOHGJOFGFNF MJLHONDBJPL(TNode GIJABPPCKCI, TNode OBIIIBPBMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3BBDCE0", Offset = "0x3BBC4E0", VA = "0x183BBDCE0")]
	private void DGDLGLBMEDA(GOHGJOFGFNF PBLOIICNEMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class IBNLICHHCFB<T> : IEnumerable<IBNLICHHCFB<T>.BANEBHCICPA>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct BANEBHCICPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public T FKKGMPDEPMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public int LFEFGCGCIAG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class ALFJFPMLMBL : IEnumerator<BANEBHCICPA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private IBNLICHHCFB<T> MEMKKNNDEPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private int LFEFGCGCIAG;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x30B3670", Offset = "0x30B1E70", VA = "0x1830B3670", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public BANEBHCICPA NPBPBJCHJJL
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x3531E80", Offset = "0x3530680", VA = "0x183531E80", Slot = "4")]
			get
			{
				return default(BANEBHCICPA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3531E40", Offset = "0x3530640", VA = "0x183531E40")]
		public ALFJFPMLMBL(IBNLICHHCFB<T> MEMKKNNDEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3531D40", Offset = "0x3530540", VA = "0x183531D40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3104AE0", Offset = "0x31032E0", VA = "0x183104AE0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x1A1CB80", Offset = "0x1A1B380", VA = "0x181A1CB80", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private struct CIDOLGMIKEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public bool OLMCEMJDJMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public T FKKGMPDEPMA;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private const int MFLMLEMOEHL = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly Dictionary<T, int> MBKPKCLJBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private CIDOLGMIKEP[] OMDPHLOEMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int FIHJHFDLADM;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int ELOIAHGCBNF
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7A3620", Offset = "0x7A1E20", VA = "0x1807A3620")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7A2CB0", Offset = "0x7A14B0", VA = "0x1807A2CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int HLNPNOBJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2EA0760", Offset = "0x2E9EF60", VA = "0x182EA0760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x3621AA0", Offset = "0x36202A0", VA = "0x183621AA0")]
	public IBNLICHHCFB(int AFOFPPEGLDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3621B80", Offset = "0x3620380", VA = "0x183621B80")]
	public IBNLICHHCFB(BANEBHCICPA[] GADKMGAGGHP, bool EJNOLIAAJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3621990", Offset = "0x3620190", VA = "0x183621990")]
	public int KCNEFNBGNJF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x36217A0", Offset = "0x361FFA0", VA = "0x1836217A0")]
	private int JBBCHDINMIB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3620D70", Offset = "0x361F570", VA = "0x183620D70", Slot = "6")]
	protected virtual uint AEHDDNDKGHP(uint JJPJJOLELKC, T FKKGMPDEPMA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3620E20", Offset = "0x361F620", VA = "0x183620E20")]
	public bool AOPIADDJKDP(T FKKGMPDEPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x3620ED0", Offset = "0x361F6D0", VA = "0x183620ED0")]
	public int BOALFNKBFGJ(T FKKGMPDEPMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x36214F0", Offset = "0x361FCF0", VA = "0x1836214F0")]
	public T HDCIFCDCJJM(int LFEFGCGCIAG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x3620F40", Offset = "0x361F740", VA = "0x183620F40")]
	public bool EMGPHAFADIE(T FKKGMPDEPMA, bool ALNIHAJAOPI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x3620F90", Offset = "0x361F790", VA = "0x183620F90")]
	public bool EMGPHAFADIE(T FKKGMPDEPMA, int LFEFGCGCIAG, bool ALNIHAJAOPI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x36214A0", Offset = "0x361FCA0", VA = "0x1836214A0")]
	private int FNNKGMCDGFN(int AIINMNHNKBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x3621A20", Offset = "0x3620220", VA = "0x183621A20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3621A20", Offset = "0x3620220", VA = "0x183621A20", Slot = "4")]
	private IEnumerator<BANEBHCICPA> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class LFDPCBIOPPA<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Stack<T> KDDKFDKHFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly List<T> ENAEHFMDNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly int EBFLFOFPCBK;

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x391AE60", Offset = "0x3919660", VA = "0x18391AE60")]
	public static LFDPCBIOPPA<T> DOKEHHBBPDJ(int AFOFPPEGLDI = 0, int EBFLFOFPCBK = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x391B770", Offset = "0x3919F70", VA = "0x18391B770")]
	public LFDPCBIOPPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x391B5D0", Offset = "0x3919DD0", VA = "0x18391B5D0")]
	public LFDPCBIOPPA(int AFOFPPEGLDI, int EBFLFOFPCBK = int.MaxValue, bool JOPGFKGLADJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x391B450", Offset = "0x3919C50", VA = "0x18391B450")]
	public T OCMOLFDHFFK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x391B380", Offset = "0x3919B80", VA = "0x18391B380")]
	public void MIPIJDCBCOI(T FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x391B080", Offset = "0x3919880", VA = "0x18391B080")]
	private void ELPOHNOCIEN(T FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x391B160", Offset = "0x3919960", VA = "0x18391B160")]
	private void HCMLMOCILML(T FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x391AF40", Offset = "0x3919740", VA = "0x18391AF40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x391B180", Offset = "0x3919980", VA = "0x18391B180")]
	private void MHOOGINIPBD(IEnumerable<T> OLDAAMHBNMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class IPNKHODJGAO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Dictionary<int, T> ODGKAPIJCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private T EOIFAEJHCPP;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public virtual T LJDBHKCOGGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x766130", Offset = "0x764930", VA = "0x180766130", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x3669FB0", Offset = "0x36687B0", VA = "0x183669FB0")]
	public bool MBJHCBMMMCF(T FKKGMPDEPMA, int HHCPPOIJJFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x347D400", Offset = "0x347BC00", VA = "0x18347D400")]
	public bool JOFGEAIJLMD(int HHCPPOIJJFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x366A2E0", Offset = "0x3668AE0", VA = "0x18366A2E0")]
	public T OJENKKILBGL(int BCHBMBDGJGA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x3669F10", Offset = "0x3668710", VA = "0x183669F10")]
	private bool JGBMEOLLDOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x366A0A0", Offset = "0x36688A0", VA = "0x18366A0A0")]
	public bool OCMBKDFPCIC(int HHCPPOIJJFF, [Out] T FKKGMPDEPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x366A4D0", Offset = "0x3668CD0", VA = "0x18366A4D0")]
	public IPNKHODJGAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class EANCEDFPFFJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	protected struct POBHNGCCJLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public T PENMJFOMGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int ACEJFBMGDLD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	protected readonly List<POBHNGCCJLJ> MPKCABPHAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private T LBIGCBKDLLN;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int HLNPNOBJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2EA0760", Offset = "0x2E9EF60", VA = "0x182EA0760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x3030160", Offset = "0x302E960", VA = "0x183030160")]
	public bool FGLNMIBCGML(T FKKGMPDEPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x302FEE0", Offset = "0x302E6E0", VA = "0x18302FEE0")]
	public void BONJGFNEKBE(T FKKGMPDEPMA, int HHCPPOIJJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x30302E0", Offset = "0x302EAE0", VA = "0x1830302E0")]
	public bool PJFBCFIPABD(T FKKGMPDEPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x302FE80", Offset = "0x302E680", VA = "0x18302FE80")]
	public void BEIKHFOBAHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x30300E0", Offset = "0x302E8E0", VA = "0x1830300E0")]
	public T EJIACBEMGFN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x302FF80", Offset = "0x302E780", VA = "0x18302FF80")]
	private void CMHPPPOMILE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x3030430", Offset = "0x302EC30", VA = "0x183030430")]
	public EANCEDFPFFJ()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		[MPCIHJNAEHG(LFNBNCHIJGL.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x5CAD750", Offset = "0x5CABF50", VA = "0x185CAD750")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x5CADA20", Offset = "0x5CAC220", VA = "0x185CADA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x5CAD930", Offset = "0x5CAC130", VA = "0x185CAD930")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5CAD6A0", Offset = "0x5CABEA0", VA = "0x185CAD6A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x5CAD970", Offset = "0x5CAC170", VA = "0x185CAD970")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x5CAD880", Offset = "0x5CAC080", VA = "0x185CAD880")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5CAD610", Offset = "0x5CABE10", VA = "0x185CAD610")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3F6E340", Offset = "0x3F6CB40", VA = "0x183F6E340", Slot = "4")]
		public virtual T LFIGAANALAI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class HEKBLJBPMFL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly Dictionary<byte, KAJEPNGKBML> DNHOOOIJGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly LFDPCBIOPPA<KAJEPNGKBML> KCFPMJFIDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly bool BDBJJEOGCAN;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public KAJEPNGKBML DMNLCJMBMKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x766300", Offset = "0x764B00", VA = "0x180766300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public Vector2 OLHLPAHNINA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA2C200", Offset = "0xA2AA00", VA = "0x180A2C200")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xD151F0", Offset = "0xD139F0", VA = "0x180D151F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	private Vector2 DDKGJAFENKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xD5FD40", Offset = "0xD5E540", VA = "0x180D5FD40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public Vector2 GGBJBIMANKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5CAA8E0", Offset = "0x5CA90E0", VA = "0x185CAA8E0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x76E4C0", Offset = "0x76CCC0", VA = "0x18076E4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int HJADEEKEDJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x766100", Offset = "0x764900", VA = "0x180766100")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x765F00", Offset = "0x764700", VA = "0x180765F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5CAB260", Offset = "0x5CA9A60", VA = "0x185CAB260")]
	public HEKBLJBPMFL(Bounds HLNLENAKLEM, Vector2[] EIDNMHHDNAE, int BCJBCDIGCKJ, byte AIINMNHNKBO, float EHCMNHCGCEO = 0f, [Optional] LFDPCBIOPPA<KAJEPNGKBML> KCFPMJFIDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA790", Offset = "0x5CA8F90", VA = "0x185CAA790")]
	public KAJEPNGKBML AJNOKGNMCEE(byte LFEFGCGCIAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5CAAB00", Offset = "0x5CA9300", VA = "0x185CAAB00")]
	public void DMGNMFGCEHN(Vector3 MCLBBPPAHAP, float NBILMPJKPFN, float CNPGGDKPPEA, List<byte> DDEFJGJOCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1A15DC0", Offset = "0x1A145C0", VA = "0x181A15DC0")]
	public void CPHHLCOGLKJ(KAJEPNGKBML.HFKMEJAGKDD EFEGBGIINCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA7F0", Offset = "0x5CA8FF0", VA = "0x185CAA7F0")]
	public static int BCMKEDFAFCI(Vector2[] EIDNMHHDNAE, int BCJBCDIGCKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA900", Offset = "0x5CA9100", VA = "0x185CAA900")]
	private KAJEPNGKBML DFCGKPLODOP(byte LFEFGCGCIAG, KAJEPNGKBML.HCFDHIDPOFE CAJCDDBNFPO, KAJEPNGKBML OBIIIBPBMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5CAABD0", Offset = "0x5CA93D0", VA = "0x185CAABD0")]
	private void DOJKOPHLCIK(KAJEPNGKBML OBIIIBPBMLD, Vector2[] EIDNMHHDNAE, int NKOPJNIICAF, int OCHJKNGCDMO, int ODBELLMMLDH, int BJCLNDMDAKO, float EHCMNHCGCEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5CAB040", Offset = "0x5CA9840", VA = "0x185CAB040")]
	private void IICOHJABBMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5CAAF80", Offset = "0x5CA9780", VA = "0x185CAAF80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5CAAFE0", Offset = "0x5CA97E0", VA = "0x185CAAFE0", Slot = "1")]
	~HEKBLJBPMFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class KAJEPNGKBML
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public enum HCFDHIDPOFE
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum HFKMEJAGKDD
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public byte KFOGLCOKPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public Vector3 MMJNAKEJIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public Vector3 JFBFKJBMEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public Vector3 NCHDOMPPENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public Vector3 ADEGPLNJFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public HCFDHIDPOFE PLLPMKPIAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public KAJEPNGKBML MLDLDJMPPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public List<KAJEPNGKBML> JAAAGALPEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public bool KALHMCODMHF;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5CABD70", Offset = "0x5CAA570", VA = "0x185CABD70")]
	public KAJEPNGKBML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5CAB900", Offset = "0x5CAA100", VA = "0x185CAB900")]
	public void CCIOJOCPJBE(KAJEPNGKBML EFKEIDIJBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	public void CPHHLCOGLKJ(int BCOOFNPOBNO, HFKMEJAGKDD EFEGBGIINCJ, int BCLOPCLIOJJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5CABA20", Offset = "0x5CAA220", VA = "0x185CABA20")]
	public void DMGNMFGCEHN(List<byte> DDEFJGJOCJA, Vector3 MCLBBPPAHAP, float NBILMPJKPFN, float CNPGGDKPPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5CABD10", Offset = "0x5CAA510", VA = "0x185CABD10")]
	public bool HPFHBGIEEJC(Vector3 ELJFMFLOMJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5CABD40", Offset = "0x5CAA540", VA = "0x185CABD40")]
	public bool KBFOFNDDHOE(Vector3 ELJFMFLOMJI, float DBGHFFNGEDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5CABC80", Offset = "0x5CAA480", VA = "0x185CABC80")]
	public void GLJEDCMMNGN()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public struct JMCMMNMGEAP<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private readonly List<Component> HBKECNHANOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private readonly bool PKJOGFGOJDA;

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x352B010", Offset = "0x3529810", VA = "0x18352B010")]
			public JMCMMNMGEAP(List<Component> HBKECNHANOP, bool PKJOGFGOJDA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x3820940", Offset = "0x381F140", VA = "0x183820940")]
			public BBALDCBHNJG<T> EKEEKKCIFJI()
			{
				return default(BBALDCBHNJG<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x38209B0", Offset = "0x381F1B0", VA = "0x1838209B0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x38209B0", Offset = "0x381F1B0", VA = "0x1838209B0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public struct BBALDCBHNJG<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private readonly List<Component> HBKECNHANOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private readonly bool PKJOGFGOJDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private int LFEFGCGCIAG;

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public T NPBPBJCHJJL
			{
				[Cpp2IlInjected.Token(Token = "0x60001EB")]
				[Cpp2IlInjected.Address(RVA = "0x43E2C90", Offset = "0x43E1490", VA = "0x1843E2C90", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001EC")]
				[Cpp2IlInjected.Address(RVA = "0x43E2C20", Offset = "0x43E1420", VA = "0x1843E2C20", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x43E2C60", Offset = "0x43E1460", VA = "0x1843E2C60")]
			public BBALDCBHNJG(List<Component> HBKECNHANOP, bool PKJOGFGOJDA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x43E2B60", Offset = "0x43E1360", VA = "0x1843E2B60", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x43E2B70", Offset = "0x43E1370", VA = "0x1843E2B70", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x30712C0", Offset = "0x306FAC0", VA = "0x1830712C0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5CAEFD0", Offset = "0x5CAD7D0", VA = "0x185CAEFD0")]
		private void GLJEDCMMNGN(GameObject JFHKBBJBKEA, bool AKFFELDLHDA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5CAEE10", Offset = "0x5CAD610", VA = "0x185CAEE10")]
		public static void GLJEDCMMNGN(GameObject JFHKBBJBKEA, ToolHierarchyCache FNDFNDILEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x2631880", Offset = "0x2630080", VA = "0x182631880")]
		public void EAMAHGIGINF<T>(Action<T> OONIIOMBHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x2631AA0", Offset = "0x26302A0", VA = "0x182631AA0")]
		public T EKNOICEDOGA<T>(bool PKJOGFGOJDA = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2631B10", Offset = "0x2630310", VA = "0x182631B10")]
		public JMCMMNMGEAP<T> JBEKMGKEFGP<T>(bool PKJOGFGOJDA = false) where T : class
		{
			return default(JMCMMNMGEAP<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5CAF1B0", Offset = "0x5CAD9B0", VA = "0x185CAF1B0")]
		public List<Component> OBBHKKAILNL(Type GFGNPBCFEMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5CAED90", Offset = "0x5CAD590", VA = "0x185CAED90", Slot = "4")]
		public bool Equals(ToolHierarchyCache IILAPOMEGLM, ToolHierarchyCache BNBBAPGFCCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5CAF140", Offset = "0x5CAD940", VA = "0x185CAF140", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache CBBCDNDPNHF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class DLDPKGJGGGP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private int AFOFPPEGLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private int HIDAOGOCPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private List<T> EGHGICGKMKC;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public int HLNPNOBJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x33EBF90", Offset = "0x33EA790", VA = "0x1833EBF90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public T FELPMHHOECD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4D1C3B0", Offset = "0x4D1ABB0", VA = "0x184D1C3B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public T FEAAJPFJLCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4D1C290", Offset = "0x4D1AA90", VA = "0x184D1C290")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public T CILDEFHPCIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x4D1C600", Offset = "0x4D1AE00", VA = "0x184D1C600")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x4D1C690", Offset = "0x4D1AE90", VA = "0x184D1C690")]
	public DLDPKGJGGGP(int AFOFPPEGLDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x4D1C130", Offset = "0x4D1A930", VA = "0x184D1C130")]
	public void BONJGFNEKBE(T NALNFIAADHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x4D1C000", Offset = "0x4D1A800", VA = "0x184D1C000")]
	public void BEIKHFOBAHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x4D1C4D0", Offset = "0x4D1ACD0", VA = "0x184D1C4D0")]
	public void HFJKJNGKOJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x4D1C470", Offset = "0x4D1AC70", VA = "0x184D1C470")]
	public void FHHNIDFMBOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x4D1C680", Offset = "0x4D1AE80", VA = "0x184D1C680")]
	public void KNAOCKAEFKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class BLEEFDHCAOL<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private struct JMNOOPJNJOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int ACEJFBMGDLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public T PENMJFOMGMH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly Dictionary<object, JMNOOPJNJOK> ODGKAPIJCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly EqualityComparer<T> OJGEJOINMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private T EOIFAEJHCPP;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public virtual T LJDBHKCOGGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xD48CA0", Offset = "0xD474A0", VA = "0x180D48CA0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x441C570", Offset = "0x441AD70", VA = "0x18441C570", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool PEGKONONGGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x441ECD0", Offset = "0x441D4D0", VA = "0x18441ECD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public object NPKLKGCGOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x76B5B0", Offset = "0x769DB0", VA = "0x18076B5B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x76BD00", Offset = "0x76A500", VA = "0x18076BD00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x441EE50", Offset = "0x441D650", VA = "0x18441EE50")]
	public bool MBJHCBMMMCF(T FKKGMPDEPMA, object KIAKEGJPMAL, int HHCPPOIJJFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x441EC40", Offset = "0x441D440", VA = "0x18441EC40")]
	public bool JOFGEAIJLMD(object KIAKEGJPMAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x441F7D0", Offset = "0x441DFD0", VA = "0x18441F7D0")]
	public bool OCMBKDFPCIC(object KIAKEGJPMAL, [Out] T FKKGMPDEPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x441C5E0", Offset = "0x441ADE0", VA = "0x18441C5E0")]
	public void BEIKHFOBAHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x441CEF0", Offset = "0x441B6F0", VA = "0x18441CEF0")]
	private bool JGBMEOLLDOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x441FE30", Offset = "0x441E630", VA = "0x18441FE30")]
	public BLEEFDHCAOL()
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
