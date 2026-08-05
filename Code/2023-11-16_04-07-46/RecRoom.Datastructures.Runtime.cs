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
public class BHKHAPJIAEI : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x780100", Offset = "0x77F100", VA = "0x180780100")]
	public BHKHAPJIAEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, GKCNABJFLDD, EHIBLOPHBLE, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x76F1A0", Offset = "0x76E1A0", VA = "0x18076F1A0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x76F1F0", Offset = "0x76E1F0", VA = "0x18076F1F0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x76F1E0", Offset = "0x76E1E0", VA = "0x18076F1E0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x814FF0", Offset = "0x813FF0", VA = "0x180814FF0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash PBHLHLBGOBP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x802230", Offset = "0x801230", VA = "0x180802230")]
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
	[DGFDINLLCHO]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	[HideInInspector]
	[DGFDINLLCHO]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7190", Offset = "0x5DC6190", VA = "0x185DC7190")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7150", Offset = "0x5DC6150", VA = "0x185DC7150")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5DC71D0", Offset = "0x5DC61D0", VA = "0x185DC71D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7380", Offset = "0x5DC6380", VA = "0x185DC7380")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5DC72F0", Offset = "0x5DC62F0", VA = "0x185DC72F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x83CEA0", Offset = "0x83BEA0", VA = "0x18083CEA0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8E0080", Offset = "0x8DF080", VA = "0x1808E0080")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7110", Offset = "0x5DC6110", VA = "0x185DC7110")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7260", Offset = "0x5DC6260", VA = "0x185DC7260")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5DC6B80", Offset = "0x5DC5B80", VA = "0x185DC6B80")]
	public void CopyBounds(SavedExtents EJEDDDCGMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5DC7060", Offset = "0x5DC6060", VA = "0x185DC7060")]
	public void SetLocalSpaceBounds(Bounds OKIOONKPAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x93FDB0", Offset = "0x93EDB0", VA = "0x18093FDB0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5DC7050", Offset = "0x5DC6050", VA = "0x185DC7050")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5DC6BB0", Offset = "0x5DC5BB0", VA = "0x185DC6BB0")]
	private void EMNCIPHECHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5DC6E30", Offset = "0x5DC5E30", VA = "0x185DC6E30")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5DC6510", Offset = "0x5DC5510", VA = "0x185DC6510")]
	public static void CalculateLocalBoundsFor(GameObject GFBHJHHLEFD, [Out] Bounds OKIOONKPAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5DC6D70", Offset = "0x5DC5D70", VA = "0x185DC6D70")]
	private static void OEFFLGJPIIC(Bounds NDOJJCKFJID, Color APEENPEFHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5DC7080", Offset = "0x5DC6080", VA = "0x185DC7080")]
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
		[Cpp2IlInjected.Address(RVA = "0x76F180", Offset = "0x76E180", VA = "0x18076F180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x77AFF0", Offset = "0x779FF0", VA = "0x18077AFF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xD0AB70", Offset = "0xD09B70", VA = "0x180D0AB70")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x40F2040", Offset = "0x40F1040", VA = "0x1840F2040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "4")]
	public virtual void ELOIKCHFGLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
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
	[BHKHAPJIAEI]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x40F1C20", Offset = "0x40F0C20", VA = "0x1840F1C20", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x40F08C0", Offset = "0x40EF8C0", VA = "0x1840F08C0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x40F1F70", Offset = "0x40F0F70", VA = "0x1840F1F70")]
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
	private sealed class BBICCBBCEBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public BBICCBBCEBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x452AE10", Offset = "0x4529E10", VA = "0x18452AE10")]
		internal int KAGGPFADGLN(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[BHKHAPJIAEI]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3126460", Offset = "0x3125460", VA = "0x183126460", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x31264B0", Offset = "0x31254B0", VA = "0x1831264B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3126360", Offset = "0x3125360", VA = "0x183126360", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey BGNGIHJEFLM]
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3126400", Offset = "0x3125400", VA = "0x183126400", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3126240", Offset = "0x3125240", VA = "0x183126240", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3125F60", Offset = "0x3124F60", VA = "0x183125F60", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3125400", Offset = "0x3124400", VA = "0x183125400", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x31253A0", Offset = "0x31243A0", VA = "0x1831253A0", Slot = "14")]
	protected virtual string OPPAOECACEM(TKeyVal DODPKDGIDLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3125280", Offset = "0x3124280", VA = "0x183125280", Slot = "4")]
	public bool ContainsKey(TKey BGNGIHJEFLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3126100", Offset = "0x3125100", VA = "0x183126100", Slot = "5")]
	public bool TryGetValue(TKey BGNGIHJEFLM, [Out] TVal APPJEOKOGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x31252D0", Offset = "0x31242D0", VA = "0x1831252D0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x31252D0", Offset = "0x31242D0", VA = "0x1831252D0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3126150", Offset = "0x3125150", VA = "0x183126150")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class JNBAJAKCPAB<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class KKMJJGLMBML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public KKMJJGLMBML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x39D1410", Offset = "0x39D0410", VA = "0x1839D1410")]
		internal bool HDFMLFPDCDD(OOMKCHDLDPO<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float LIPOANAMLMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float JBAADNNIILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<OOMKCHDLDPO<float, T>> MNCCKEICKBC;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int JNKKCIDNIFH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x38F9440", Offset = "0x38F8440", VA = "0x1838F9440")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x38F9550", Offset = "0x38F8550", VA = "0x1838F9550")]
	public JNBAJAKCPAB(float BFEJLKOEEMH, float NNMKEPIJADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x38F91D0", Offset = "0x38F81D0", VA = "0x1838F91D0")]
	public bool JEADJHANPIO(float ICEIPOOCKJL, T APPJEOKOGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x38F8A20", Offset = "0x38F7A20", VA = "0x1838F8A20")]
	public IEnumerable<T> CBHKGMDOCDA(float ICEIPOOCKJL, [Optional] float? PMOIALPEFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x38F9520", Offset = "0x38F8520", VA = "0x1838F9520")]
	public void PMEKKAMOFIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x38F9360", Offset = "0x38F8360", VA = "0x1838F9360")]
	private void KJPBODPNGCP(float ICEIPOOCKJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class NMCOGEFBDJI<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct CJABDGGJPEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T INAJMIAKCCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float AFLEHMKALJB;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float IJOEJHGPBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> HLDGHODGKFE;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int LBDFLPJCJHO = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private CJABDGGJPEM[] FHOLKIOOKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int CPDLHAPENMC;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float ABFJPKFHNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xAEF5D0", Offset = "0xAEE5D0", VA = "0x180AEF5D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xAEF5F0", Offset = "0xAEE5F0", VA = "0x180AEF5F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3D31A10", Offset = "0x3D30A10", VA = "0x183D31A10")]
	public NMCOGEFBDJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3D31A30", Offset = "0x3D30A30", VA = "0x183D31A30")]
	public NMCOGEFBDJI(int LHAIIFMNPNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3D313C0", Offset = "0x3D303C0", VA = "0x183D313C0")]
	public void GPDFOMDKBKK(float ICEIPOOCKJL, T APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3D317D0", Offset = "0x3D307D0", VA = "0x183D317D0")]
	public void PMEKKAMOFIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3D30EC0", Offset = "0x3D2FEC0", VA = "0x183D30EC0")]
	public bool AOBKBIONHGO(float IHDHAPFINBI, float HBEKABMALBO, [Out] T APPJEOKOGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3D30D20", Offset = "0x3D2FD20", VA = "0x183D30D20")]
	public bool AHONPHNIEOH(float IHDHAPFINBI, float HBEKABMALBO, [Out] T APPJEOKOGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3D31540", Offset = "0x3D30540", VA = "0x183D31540")]
	public void HEGLLCIMFFD(float IHDHAPFINBI, float HBEKABMALBO, List<T> DOAIHCCMJDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3D31340", Offset = "0x3D30340", VA = "0x183D31340")]
	private int BHCNJKPJJGE(int FLKLODMFDLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3D31370", Offset = "0x3D30370", VA = "0x183D31370")]
	private void CFCMIFLIOAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T LDMECDCLAEB();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T MBJOJLHPKHP(T APPJEOKOGAK, float CDBKGKHLPJH);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T OEFJBHIFOHJ(T LJNLOLDLJAJ, T AHGDCNHHAHG);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T AIKCKHKMAIM(T LJNLOLDLJAJ, T AHGDCNHHAHG);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PIMOFFGDOAP : NMCOGEFBDJI<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x780990", Offset = "0x77F990", VA = "0x180780990", Slot = "4")]
	protected override Vector3 LDMECDCLAEB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5EE0", Offset = "0x5DC4EE0", VA = "0x185DC5EE0", Slot = "5")]
	protected override Vector3 MBJOJLHPKHP(Vector3 APPJEOKOGAK, float CDBKGKHLPJH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5F20", Offset = "0x5DC4F20", VA = "0x185DC5F20", Slot = "6")]
	protected override Vector3 OEFJBHIFOHJ(Vector3 LJNLOLDLJAJ, Vector3 AHGDCNHHAHG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5E60", Offset = "0x5DC4E60", VA = "0x185DC5E60", Slot = "7")]
	protected override Vector3 AIKCKHKMAIM(Vector3 LJNLOLDLJAJ, Vector3 AHGDCNHHAHG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5F70", Offset = "0x5DC4F70", VA = "0x185DC5F70")]
	public PIMOFFGDOAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class FANBOOEMBIP
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x24CFFF0", Offset = "0x24CEFF0", VA = "0x1824CFFF0")]
	public static OOMKCHDLDPO<T1, T2> BJANKEDJCNP<T1, T2>(T1 ANIMENCHFNI, T2 AGOIDIEOMJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x24D0070", Offset = "0x24CF070", VA = "0x1824D0070")]
	public static DFLELLBFFBA<T1, T2, T3> BJANKEDJCNP<T1, T2, T3>(T1 ANIMENCHFNI, T2 AGOIDIEOMJK, T3 PEPFKAKNFJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3CF22B0", Offset = "0x3CF12B0", VA = "0x183CF22B0")]
	internal static int EHODMEAPHDH(int MCBEHCBEJPM, int CKOBEFLCGHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x529AF70", Offset = "0x5299F70", VA = "0x18529AF70")]
	internal static int EHODMEAPHDH(int MCBEHCBEJPM, int CKOBEFLCGHH, int EJBAIGOMLEJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class OOMKCHDLDPO<T1, T2> : IComparable<OOMKCHDLDPO<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T1 OHMKCDPAOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T2 JIFNDAACIMJ;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3E11740", Offset = "0x3E10740", VA = "0x183E11740")]
	public OOMKCHDLDPO(T1 ANIMENCHFNI, T2 AGOIDIEOMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3E0F620", Offset = "0x3E0E620", VA = "0x183E0F620", Slot = "4")]
	public int CompareTo(OOMKCHDLDPO<T1, T2> EJEDDDCGMMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3E10320", Offset = "0x3E0F320", VA = "0x183E10320", Slot = "0")]
	public override bool Equals(object EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3E10980", Offset = "0x3E0F980", VA = "0x183E10980", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3E11500", Offset = "0x3E10500", VA = "0x183E11500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DFLELLBFFBA<T1, T2, T3> : IComparable<DFLELLBFFBA<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T1 OHMKCDPAOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T2 JIFNDAACIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly T3 PFDBGLAACKA;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4DA7830", Offset = "0x4DA6830", VA = "0x184DA7830")]
	public DFLELLBFFBA(T1 ANIMENCHFNI, T2 AGOIDIEOMJK, T3 PEPFKAKNFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4DA6EF0", Offset = "0x4DA5EF0", VA = "0x184DA6EF0", Slot = "4")]
	public int CompareTo(DFLELLBFFBA<T1, T2, T3> EJEDDDCGMMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4DA7280", Offset = "0x4DA6280", VA = "0x184DA7280", Slot = "0")]
	public override bool Equals(object EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4DA7430", Offset = "0x4DA6430", VA = "0x184DA7430", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4DA7560", Offset = "0x4DA6560", VA = "0x184DA7560", Slot = "3")]
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
	public T INAJMIAKCCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1F12C70", Offset = "0x1F11C70", VA = "0x181F12C70")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1F12DE0", Offset = "0x1F11DE0", VA = "0x181F12DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float FKNPJFEPBBB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xAB3440", Offset = "0xAB2440", VA = "0x180AB3440")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x42FE1C0", Offset = "0x42FD1C0", VA = "0x1842FE1C0")]
	public T HPCOGCEDBCE(float CDBKGKHLPJH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x42FDF20", Offset = "0x42FCF20", VA = "0x1842FDF20")]
	public T CBLOJEOIKAN(float CDBKGKHLPJH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T OPOIBGONJCG(T LJNLOLDLJAJ, T AHGDCNHHAHG, float CDBKGKHLPJH);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5DC2C50", Offset = "0x5DC1C50", VA = "0x185DC2C50", Slot = "4")]
	protected override float OPOIBGONJCG(float LJNLOLDLJAJ, float AHGDCNHHAHG, float CDBKGKHLPJH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5DC2C90", Offset = "0x5DC1C90", VA = "0x185DC2C90")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xBFAE00", Offset = "0xBF9E00", VA = "0x180BFAE00", Slot = "4")]
	protected override Vector3 OPOIBGONJCG(Vector3 LJNLOLDLJAJ, Vector3 AHGDCNHHAHG, float CDBKGKHLPJH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5DC81A0", Offset = "0x5DC71A0", VA = "0x185DC81A0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5DC2AE0", Offset = "0x5DC1AE0", VA = "0x185DC2AE0", Slot = "4")]
	protected override Color OPOIBGONJCG(Color LJNLOLDLJAJ, Color AHGDCNHHAHG, float CDBKGKHLPJH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5DC2BA0", Offset = "0x5DC1BA0", VA = "0x185DC2BA0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class OPKKPNIDCPJ : FAIAFJEFEKO<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5E10", Offset = "0x5DC4E10", VA = "0x185DC5E10")]
	public OPKKPNIDCPJ(int IKHECAIEEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5DA0", Offset = "0x5DC4DA0", VA = "0x185DC5DA0", Slot = "6")]
	protected override uint NOBCCKOHCJI(uint PBHLHLBGOBP, string APPJEOKOGAK)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class AFJMHHMCJEN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly IDisposable NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public AFJMHHMCJEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct CICHMBIKPIH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> HAAFKHDNCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int OLHNKGHADCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int ECJIHMGFIHL;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3CF4A40", Offset = "0x3CF3A40", VA = "0x183CF4A40")]
	private CICHMBIKPIH(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> NBHOJEEDBML, int HBKNKLKBNDH, int PPPHBEILEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x47FA480", Offset = "0x47F9480", VA = "0x1847FA480")]
	public static CICHMBIKPIH<T> ANBAJJBGINK()
	{
		return default(CICHMBIKPIH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x47FAAC0", Offset = "0x47F9AC0", VA = "0x1847FAAC0")]
	public (int, int, Task<T>) PPMBHHBGHLO(int PBHILIKAOFG, [Optional] CancellationToken JEBPNJAPHEL, double JPCFJENKEPD = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x47FA580", Offset = "0x47F9580", VA = "0x1847FA580")]
	public void JICGFOFMADF(int PBHILIKAOFG, int PPPHBEILEFD, [In] T BBMBCGDLBEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class NAPDNAOKDFB
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5A00", Offset = "0x5DC4A00", VA = "0x185DC5A00")]
	public static CICHMBIKPIH<DBKAPBMMCGK> ANBAJJBGINK()
	{
		return default(CICHMBIKPIH<DBKAPBMMCGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5A50", Offset = "0x5DC4A50", VA = "0x185DC5A50")]
	public static void JICGFOFMADF([In] this CICHMBIKPIH<DBKAPBMMCGK> IEOMMHOPOKN, int PBHILIKAOFG, int PPPHBEILEFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[DefaultMember("Item")]
public class GKCOMMCOGDC<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TKey, TVal> NFINIGBLHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly Dictionary<TVal, TKey> ENEIJIEPALI;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int PLKFCNLILAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2F73550", Offset = "0x2F72550", VA = "0x182F73550", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool HFHPEHMAAKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> JIILBNBNBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x346E1C0", Offset = "0x346D1C0", VA = "0x18346E1C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> BOPHLAOAHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3585030", Offset = "0x3584030", VA = "0x183585030", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal KHIKFGEKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3584F80", Offset = "0x3583F80", VA = "0x183584F80", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3585090", Offset = "0x3584090", VA = "0x183585090", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey KHIKFGEKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3584BE0", Offset = "0x3583BE0", VA = "0x183584BE0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x35842B0", Offset = "0x35832B0", VA = "0x1835842B0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3584DB0", Offset = "0x3583DB0", VA = "0x183584DB0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3584260", Offset = "0x3583260", VA = "0x183584260", Slot = "9")]
	public void Add(TKey BGNGIHJEFLM, TVal APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3584230", Offset = "0x3583230", VA = "0x183584230", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> NIFCHCHHAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3584310", Offset = "0x3583310", VA = "0x183584310", Slot = "8")]
	public bool ContainsKey(TKey BGNGIHJEFLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x35843B0", Offset = "0x35833B0", VA = "0x1835843B0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> NIFCHCHHAAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3584D30", Offset = "0x3583D30", VA = "0x183584D30", Slot = "10")]
	public bool Remove(TKey BGNGIHJEFLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3584CD0", Offset = "0x3583CD0", VA = "0x183584CD0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> NIFCHCHHAAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3584E50", Offset = "0x3583E50", VA = "0x183584E50", Slot = "11")]
	public bool TryGetValue(TKey BGNGIHJEFLM, [Out] TVal APPJEOKOGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3584A60", Offset = "0x3583A60", VA = "0x183584A60", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x35843E0", Offset = "0x35833E0", VA = "0x1835843E0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] FHOLKIOOKFG, int FKKKLBOABKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3584C80", Offset = "0x3583C80", VA = "0x183584C80")]
	public bool KMJKDBDGJFH(TVal BGNGIHJEFLM, [Out] TKey APPJEOKOGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3584620", Offset = "0x3583620", VA = "0x183584620")]
	private void DPCPOHLDHJA(TKey BGNGIHJEFLM, TVal DKCKOABFNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3584580", Offset = "0x3583580", VA = "0x183584580")]
	private void DOHJDBDEMCF(TKey BGNGIHJEFLM, TVal DKCKOABFNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3584980", Offset = "0x3583980", VA = "0x183584980")]
	private bool FNAMGGKCNLD(TKey BGNGIHJEFLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3584E90", Offset = "0x3583E90", VA = "0x183584E90")]
	public GKCOMMCOGDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public class HEHIMENBEEH<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private HEHIMENBEEH<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x3181210", Offset = "0x3180210", VA = "0x183181210", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3181E80", Offset = "0x3180E80", VA = "0x183181E80")]
		public Enumerator(HEHIMENBEEH<T> DOAIHCCMJDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x317ED20", Offset = "0x317DD20", VA = "0x18317ED20", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x317FFF0", Offset = "0x317EFF0", VA = "0x18317FFF0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x317DDB0", Offset = "0x317CDB0", VA = "0x18317DDB0")]
		private void IFAIAHLGPAE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private T[] DJBMCFBLDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int HOLHNBPNHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int IDKPJCOPKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int CEJKGGNMCNG;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int PLKFCNLILAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3609DD0", Offset = "0x3608DD0", VA = "0x183609DD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T KHIKFGEKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x3609D50", Offset = "0x3608D50", VA = "0x183609D50")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3609820", Offset = "0x3608820", VA = "0x183609820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x360A620", Offset = "0x3609620", VA = "0x18360A620")]
	public HEHIMENBEEH(int IKHECAIEEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3609B50", Offset = "0x3608B50", VA = "0x183609B50")]
	public void GPDFOMDKBKK(T CDBKGKHLPJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3609EC0", Offset = "0x3608EC0", VA = "0x183609EC0")]
	public void PMEKKAMOFIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3609250", Offset = "0x3608250", VA = "0x183609250")]
	public void CAPALPENGJO(int AGLAJIDEGHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3609EE0", Offset = "0x3608EE0", VA = "0x183609EE0")]
	public void POABEONPCCI(T[] FHOLKIOOKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3609E10", Offset = "0x3608E10", VA = "0x183609E10")]
	public Enumerator PKEKCLMIDEH()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x360A520", Offset = "0x3609520", VA = "0x18360A520", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x360A520", Offset = "0x3609520", VA = "0x18360A520", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3609520", Offset = "0x3608520", VA = "0x183609520")]
	private int DIIODLIBGDB(int NFJIPMHILEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3609DA0", Offset = "0x3608DA0", VA = "0x183609DA0")]
	private int IOGBLHACACJ(int NFJIPMHILEL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class JNOPFAMMAHB<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Func<Internal, External> BKKPLACEKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private IReadOnlyList<Internal> LOKHPAFMLOJ;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public External KHIKFGEKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x39080F0", Offset = "0x39070F0", VA = "0x1839080F0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int PLKFCNLILAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x39080A0", Offset = "0x39070A0", VA = "0x1839080A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x77EBC0", Offset = "0x77DBC0", VA = "0x18077EBC0")]
	public JNOPFAMMAHB(Func<Internal, External> BKKPLACEKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3908050", Offset = "0x3907050", VA = "0x183908050")]
	public JNOPFAMMAHB(IReadOnlyList<Internal> LOKHPAFMLOJ, Func<Internal, External> BKKPLACEKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3907F70", Offset = "0x3906F70", VA = "0x183907F70", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x33C6680", Offset = "0x33C5680", VA = "0x1833C6680", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class MBBCDDLAPMP<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate Task<TResult> LCFIFKNCMOI(TRequest ICLPGCHCHFB, CancellationToken JEBPNJAPHEL);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public enum JCMJIPGMDBM
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class NEBEHCEGJAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private const float DFLICLPIGAM = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TimeSpan IPKGIHDNLHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int LFAMCFBMCEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public JCMJIPGMDBM FNOBDMDLBFE;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly NEBEHCEGJAO ENPBEGLBBIN;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float LFEHEPOIJHK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x3D11E60", Offset = "0x3D10E60", VA = "0x183D11E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan DIFLAPNAPOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3D12020", Offset = "0x3D11020", VA = "0x183D12020")]
		public NEBEHCEGJAO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private readonly struct KBLIEJJHJCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public readonly TRequest ICLPGCHCHFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public readonly CancellationToken JEBPNJAPHEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly TaskCompletionSource<TResult> FKPIILDBMBC;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x394AC30", Offset = "0x3949C30", VA = "0x18394AC30")]
		public KBLIEJJHJCM(TRequest ICLPGCHCHFB, TaskCompletionSource<TResult> FKPIILDBMBC, CancellationToken JEBPNJAPHEL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct BHFPFOLAIMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public MBBCDDLAPMP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x455CD00", Offset = "0x455BD00", VA = "0x18455CD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x455D580", Offset = "0x455C580", VA = "0x18455D580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct NIDEDANMHCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public MBBCDDLAPMP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private KBLIEJJHJCM <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3D20170", Offset = "0x3D1F170", VA = "0x183D20170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3D20770", Offset = "0x3D1F770", VA = "0x183D20770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly CancellationTokenSource JOELAAEPJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<KBLIEJJHJCM> FBOCCFALIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly NEBEHCEGJAO GGMMLIAEHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly LCFIFKNCMOI PBIMFHEDFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Task PFEANCBJPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private int OFAFLNLHNEE;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3C57070", Offset = "0x3C56070", VA = "0x183C57070")]
	public MBBCDDLAPMP(LCFIFKNCMOI PBIMFHEDFCF, [Optional] NEBEHCEGJAO GGMMLIAEHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3C56D00", Offset = "0x3C55D00", VA = "0x183C56D00")]
	public Task<TResult> PAEEJHBEKLD(TRequest ICLPGCHCHFB, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3C56100", Offset = "0x3C55100", VA = "0x183C56100")]
	private void EOMPLOCINNK(KBLIEJJHJCM KKGJIEMEBPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3C55F80", Offset = "0x3C54F80", VA = "0x183C55F80")]
	[AsyncStateMachine(typeof(MBBCDDLAPMP<, >.BHFPFOLAIMI))]
	private Task EIIMEIKAGHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3C56450", Offset = "0x3C55450", VA = "0x183C56450")]
	private KBLIEJJHJCM MLEKJGNGKON()
	{
		return default(KBLIEJJHJCM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3C566E0", Offset = "0x3C556E0", VA = "0x183C566E0")]
	[AsyncStateMachine(typeof(MBBCDDLAPMP<, >.NIDEDANMHCP))]
	private Task NOKCIGNINIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3C568D0", Offset = "0x3C558D0", VA = "0x183C568D0")]
	private void ODMJOEGDFBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3C55E70", Offset = "0x3C54E70", VA = "0x183C55E70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class DGHLKPDDMKE<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly List<T> LOKHPAFMLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private HashSet<T> NDHEEHMICMN;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int PLKFCNLILAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2F73550", Offset = "0x2F72550", VA = "0x182F73550", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool HFHPEHMAAKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T KHIKFGEKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x372B970", Offset = "0x372A970", VA = "0x18372B970", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x4DAA180", Offset = "0x4DA9180", VA = "0x184DAA180", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3487A90", Offset = "0x3486A90", VA = "0x183487A90", Slot = "11")]
	public void Add(T NIFCHCHHAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4DA9BE0", Offset = "0x4DA8BE0", VA = "0x184DA9BE0")]
	public bool KBPGNNBKMBB(T NIFCHCHHAAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4DA9F50", Offset = "0x4DA8F50", VA = "0x184DA9F50", Slot = "15")]
	public bool Remove(T NIFCHCHHAAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x31084B0", Offset = "0x31074B0", VA = "0x1831084B0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x34ACE80", Offset = "0x34ABE80", VA = "0x1834ACE80", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4DA9950", Offset = "0x4DA8950", VA = "0x184DA9950", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4DA99B0", Offset = "0x4DA89B0", VA = "0x184DA99B0", Slot = "13")]
	public bool Contains(T NIFCHCHHAAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4DA99F0", Offset = "0x4DA89F0", VA = "0x184DA99F0", Slot = "14")]
	public void CopyTo(T[] FHOLKIOOKFG, int FKKKLBOABKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x39F7220", Offset = "0x39F6220", VA = "0x1839F7220", Slot = "6")]
	public int IndexOf(T NIFCHCHHAAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4DA9B00", Offset = "0x4DA8B00", VA = "0x184DA9B00", Slot = "7")]
	public void Insert(int NFJIPMHILEL, T NIFCHCHHAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4DA9D60", Offset = "0x4DA8D60", VA = "0x184DA9D60", Slot = "8")]
	public void RemoveAt(int NFJIPMHILEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4DAA090", Offset = "0x4DA9090", VA = "0x184DAA090")]
	public DGHLKPDDMKE()
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
			[Cpp2IlInjected.Address(RVA = "0x2043D70", Offset = "0x2042D70", VA = "0x182043D70")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7720", Offset = "0x5DC6720", VA = "0x185DC7720")]
		public SerializedGuid([In] Guid BCPPFHNPEMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7410", Offset = "0x5DC6410", VA = "0x185DC7410")]
		public static SerializedGuid BBHBBGLKBOG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5DC74C0", Offset = "0x5DC64C0", VA = "0x185DC74C0")]
		public static SerializedGuid EMHGDIJLFBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7610", Offset = "0x5DC6610", VA = "0x185DC7610")]
		public bool MHPEFMEANPC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5DC76F0", Offset = "0x5DC66F0", VA = "0x185DC76F0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7670", Offset = "0x5DC6670", VA = "0x185DC7670", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7530", Offset = "0x5DC6530", VA = "0x185DC7530", Slot = "7")]
		public bool Equals(SerializedGuid EJEDDDCGMMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7570", Offset = "0x5DC6570", VA = "0x185DC7570", Slot = "0")]
		public override bool Equals(object GPCHHCACPPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7600", Offset = "0x5DC6600", VA = "0x185DC7600", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7490", Offset = "0x5DC6490", VA = "0x185DC7490", Slot = "6")]
		public int CompareTo(SerializedGuid EJEDDDCGMMB)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class EAKOMEHCFAM : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly Type PKINEHHKGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly string CAFDFGDNEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly bool EKKIHEMNKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly bool OBFLJFAGNEK;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5DC2BE0", Offset = "0x5DC1BE0", VA = "0x185DC2BE0")]
	public EAKOMEHCFAM(Type EOCGFKDDOMG, string PEKPICMIKAB, bool LLGBJLOHBIM = false, bool JKNCADDNKLN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class PFLLCKOMFGL<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public readonly struct JGOIKPDPLFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public readonly long DMABEAPGEIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public readonly long KPCBPIJLHDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly int KDPENDBMHPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly int NODCGCGDMOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly bool HELFLHOFJDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly string ODKKECDGOHF;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x38DD440", Offset = "0x38DC440", VA = "0x1838DD440")]
		public JGOIKPDPLFA(long DMABEAPGEIL, int KDPENDBMHPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x38DD4B0", Offset = "0x38DC4B0", VA = "0x1838DD4B0")]
		public JGOIKPDPLFA(long DMABEAPGEIL, long KPCBPIJLHDN, int KDPENDBMHPB, int NODCGCGDMOP, bool HELFLHOFJDM, string ODKKECDGOHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x38DD2D0", Offset = "0x38DC2D0", VA = "0x1838DD2D0")]
		public int APKDKPIIHEO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x38DD320", Offset = "0x38DC320", VA = "0x1838DD320")]
		public int CKOILNNLKAI(int HJADLCHPDAA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x38DD3E0", Offset = "0x38DC3E0", VA = "0x1838DD3E0")]
		public double JBALIKCBOOB()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x38DD340", Offset = "0x38DC340", VA = "0x1838DD340")]
		public JGOIKPDPLFA CPIIMLBOOLG(long KPCBPIJLHDN, int NODCGCGDMOP)
		{
			return default(JGOIKPDPLFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class FEFFPGFLENA : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct JBDMGDCABJF<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public FEFFPGFLENA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public Func<FEFFPGFLENA, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private FEFFPGFLENA <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x38C95B0", Offset = "0x38C85B0", VA = "0x1838C95B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x345D0E0", Offset = "0x345C0E0", VA = "0x18345D0E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly TKey NNFEBNLDCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly PFLLCKOMFGL<TKey> HCMHKMALPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly IMFBLHALHMN DJHKLFMABMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private List<FEFFPGFLENA> LBDGIOHLENM;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string EBIAGHDJGIC
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x3453EC0", Offset = "0x3452EC0", VA = "0x183453EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<FEFFPGFLENA> FACLIONGBII
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x3453F10", Offset = "0x3452F10", VA = "0x183453F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public JGOIKPDPLFA IMMDEJOBKAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x3453EF0", Offset = "0x3452EF0", VA = "0x183453EF0")]
			[CompilerGenerated]
			get
			{
				return default(JGOIKPDPLFA);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x3453F50", Offset = "0x3452F50", VA = "0x183453F50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3453F80", Offset = "0x3452F80", VA = "0x183453F80")]
		internal FEFFPGFLENA(PFLLCKOMFGL<TKey> HCMHKMALPLB, TKey BGNGIHJEFLM, IMFBLHALHMN DJHKLFMABMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3453D60", Offset = "0x3452D60", VA = "0x183453D60")]
		public FEFFPGFLENA HPNLBCGEKBC(TKey BGNGIHJEFLM, [Optional] IMFBLHALHMN? JNBILIJIPDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2E0F9D0", Offset = "0x2E0E9D0", VA = "0x182E0F9D0")]
		[AsyncStateMachine(typeof(JBDMGDCABJF<>))]
		public Task<T> CJJILJNHCPF<T>(TKey BGNGIHJEFLM, Func<FEFFPGFLENA, Task<T>> CMDBLPFLCHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3453B60", Offset = "0x3452B60", VA = "0x183453B60", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class FDJLLFCPHBD : IEnumerable<(TKey, List<TKey>, JGOIKPDPLFA)>, IEnumerable, IEnumerator<(TKey, List<TKey>, JGOIKPDPLFA)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private (TKey key, List<TKey> path, JGOIKPDPLFA timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public PFLLCKOMFGL<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private IEnumerator<(TKey key, List<TKey> path, JGOIKPDPLFA timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, JGOIKPDPLFA) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x203E920", Offset = "0x203D920", VA = "0x18203E920", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, JGOIKPDPLFA));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x344C110", Offset = "0x344B110", VA = "0x18344C110", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x203EA10", Offset = "0x203DA10", VA = "0x18203EA10")]
		[DebuggerHidden]
		public FDJLLFCPHBD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x33C1200", Offset = "0x33C0200", VA = "0x1833C1200", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x344BC60", Offset = "0x344AC60", VA = "0x18344BC60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x344BC10", Offset = "0x344AC10", VA = "0x18344BC10")]
		private void GDOLLNLODDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x344C0C0", Offset = "0x344B0C0", VA = "0x18344C0C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x344C000", Offset = "0x344B000", VA = "0x18344C000", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, JGOIKPDPLFA)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x33C9270", Offset = "0x33C8270", VA = "0x1833C9270", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class LLEGMOHPDCL : IEnumerable<(TKey, List<TKey>, JGOIKPDPLFA)>, IEnumerable, IEnumerator<(TKey, List<TKey>, JGOIKPDPLFA)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private (TKey key, List<TKey> path, JGOIKPDPLFA timerEntry) <>2__current;

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
		private FEFFPGFLENA timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public FEFFPGFLENA <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public PFLLCKOMFGL<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private IEnumerator<FEFFPGFLENA> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private IEnumerator<(TKey key, List<TKey> path, JGOIKPDPLFA timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, JGOIKPDPLFA) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x203E920", Offset = "0x203D920", VA = "0x18203E920", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, JGOIKPDPLFA));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x3A918E0", Offset = "0x3A908E0", VA = "0x183A918E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x203EA10", Offset = "0x203DA10", VA = "0x18203EA10")]
		[DebuggerHidden]
		public LLEGMOHPDCL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3A91940", Offset = "0x3A90940", VA = "0x183A91940", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3A90FD0", Offset = "0x3A8FFD0", VA = "0x183A90FD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3A90F70", Offset = "0x3A8FF70", VA = "0x183A90F70")]
		private void GDOLLNLODDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3A90F10", Offset = "0x3A8FF10", VA = "0x183A90F10")]
		private void CPPLOHGLGKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3A91890", Offset = "0x3A90890", VA = "0x183A91890", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3A91780", Offset = "0x3A90780", VA = "0x183A91780", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, JGOIKPDPLFA)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3A91860", Offset = "0x3A90860", VA = "0x183A91860", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly Action<TKey, JGOIKPDPLFA, IMFBLHALHMN> JFGGGJNDNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Action<TKey, JGOIKPDPLFA, IMFBLHALHMN> EJMFJOPIIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly Action<PFLLCKOMFGL<TKey>, IMFBLHALHMN> JBBBIEPBJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly IMFBLHALHMN DJHKLFMABMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly FEFFPGFLENA AKGDBOHIIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private bool EDDFAKMICOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private int LGBFDPDIIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Stopwatch NMFBCPLCIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly int JNGPOACMPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private string IECGFDPKFIN;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public FEFFPGFLENA AELPGCELAPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x76F1D0", Offset = "0x76E1D0", VA = "0x18076F1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string EBIAGHDJGIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7738C0", Offset = "0x7728C0", VA = "0x1807738C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3EAEBB0", Offset = "0x3EADBB0", VA = "0x183EAEBB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3EAEC10", Offset = "0x3EADC10", VA = "0x183EAEC10")]
	public PFLLCKOMFGL(TKey EBFHLKGKPDP, IMFBLHALHMN DJHKLFMABMI, [Optional] int? KDPENDBMHPB, [Optional][CanBeNull] Stopwatch NMFBCPLCIPI, [Optional] Action<TKey, JGOIKPDPLFA, IMFBLHALHMN> JFGGGJNDNFC, [Optional] Action<TKey, JGOIKPDPLFA, IMFBLHALHMN> EJMFJOPIIFJ, [Optional] Action<PFLLCKOMFGL<TKey>, IMFBLHALHMN> JBBBIEPBJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE9C0", Offset = "0x3EAD9C0", VA = "0x183EAE9C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3EAEB20", Offset = "0x3EADB20", VA = "0x183EAEB20")]
	[IteratorStateMachine(typeof(PFLLCKOMFGL<>.FDJLLFCPHBD))]
	public IEnumerable<(TKey, List<TKey>, JGOIKPDPLFA)> FDMAIIKNNEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3EAEA50", Offset = "0x3EADA50", VA = "0x183EAEA50")]
	[IteratorStateMachine(typeof(PFLLCKOMFGL<>.LLEGMOHPDCL))]
	private IEnumerable<(TKey, List<TKey>, JGOIKPDPLFA)> FDMAIIKNNEO(List<TKey> JDDFHOGGEKO, FEFFPGFLENA BNGAJLKFMGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE940", Offset = "0x3EAD940", VA = "0x183EAE940")]
	private (long, int) COEIBLOOOLM()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public abstract class BIIIFHDFGMA<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut CBBFNKBPNKO(PFLLCKOMFGL<TKey> HCMHKMALPLB);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	protected BIIIFHDFGMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public abstract class KAKNAANNBOL<TKey> : BIIIFHDFGMA<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate string IBAOKOAHBFD(TKey BGNGIHJEFLM);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x394A9D0", Offset = "0x39499D0", VA = "0x18394A9D0")]
	private static string KBIGHAJJIBA(TKey BGNGIHJEFLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x394A7C0", Offset = "0x39497C0", VA = "0x18394A7C0", Slot = "4")]
	public override string CBBFNKBPNKO(PFLLCKOMFGL<TKey> HCMHKMALPLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x394A880", Offset = "0x3949880", VA = "0x18394A880")]
	public string CBBFNKBPNKO(PFLLCKOMFGL<TKey> HCMHKMALPLB, [NotNull] IBAOKOAHBFD IDDKIMGPAKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string FAGEKOFGHHC(PFLLCKOMFGL<TKey> HCMHKMALPLB, [NotNull] IBAOKOAHBFD IDDKIMGPAKH);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x375A710", Offset = "0x3759710", VA = "0x18375A710")]
	protected KAKNAANNBOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class MDCALECDKNE<TKey> : BIIIFHDFGMA<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate string KDNIJDGPCGI(TKey BGNGIHJEFLM);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly string KGOMGEPFLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly double MFDGCMJBBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly bool NDNNKJJKLOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly int DPOJHKMJIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly ISet<string> DDIFPMILGJF;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3C61F00", Offset = "0x3C60F00", VA = "0x183C61F00")]
	private static string KBIGHAJJIBA(TKey BGNGIHJEFLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3C61F40", Offset = "0x3C60F40", VA = "0x183C61F40")]
	public MDCALECDKNE(string KGOMGEPFLJB = "F2", double MFDGCMJBBDG = double.MaxValue, bool NDNNKJJKLOO = false, int DPOJHKMJIEC = int.MaxValue, [Optional] ISet<string> DDIFPMILGJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3C613D0", Offset = "0x3C603D0", VA = "0x183C613D0", Slot = "4")]
	public override Dictionary<string, string> CBBFNKBPNKO(PFLLCKOMFGL<TKey> HCMHKMALPLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3C61BE0", Offset = "0x3C60BE0", VA = "0x183C61BE0")]
	private bool DMOAPDCNPOC(string HCJMDIHFODO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3C61490", Offset = "0x3C60490", VA = "0x183C61490")]
	public Dictionary<string, string> CBBFNKBPNKO(PFLLCKOMFGL<TKey> HCMHKMALPLB, KDNIJDGPCGI IDDKIMGPAKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3C61CC0", Offset = "0x3C60CC0", VA = "0x183C61CC0")]
	private string GMNBBGOJBMM(StringBuilder DGBNHOIHNLI, List<TKey> FGMGIFIDCIM, KDNIJDGPCGI IDDKIMGPAKH, bool EJJNABNLMIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3C61A80", Offset = "0x3C60A80", VA = "0x183C61A80")]
	private static void DJNOBKOAMKA(StringBuilder GLPKGGIAPMG, string IPDLJMNFNBE, bool MEFFHBDGGLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class GMHJMBEJGEL<TKey> : KAKNAANNBOL<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct NFGILEFGKFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public IBAOKOAHBFD keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static GMHJMBEJGEL<TKey> NKFKDADGOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string[] FHNIIDKKGAD;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x35962C0", Offset = "0x35952C0", VA = "0x1835962C0")]
	private GMHJMBEJGEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x35951A0", Offset = "0x35941A0", VA = "0x1835951A0", Slot = "5")]
	protected override string FAGEKOFGHHC(PFLLCKOMFGL<TKey> HCMHKMALPLB, IBAOKOAHBFD IDDKIMGPAKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3596090", Offset = "0x3595090", VA = "0x183596090")]
	[CompilerGenerated]
	internal static string GOKCKNJKAEM(string APBDKPBNOBD, TKey BGNGIHJEFLM, NFGILEFGKFA P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class MJDBMFMIHBM : PFLLCKOMFGL<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class OIFEFCNOGIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Action<MJDBMFMIHBM, IMFBLHALHMN> callback;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public OIFEFCNOGIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5DC5D10", Offset = "0x5DC4D10", VA = "0x185DC5D10")]
		internal void LEPLMGALGFL(PFLLCKOMFGL<string> timer, IMFBLHALHMN log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5DC58B0", Offset = "0x5DC48B0", VA = "0x185DC58B0")]
	public MJDBMFMIHBM(IMFBLHALHMN DJHKLFMABMI, [Optional] string HGFEKPAIJJA, [Optional] int? KDPENDBMHPB, [Optional] Stopwatch NMFBCPLCIPI, [Optional] Action<string, JGOIKPDPLFA, IMFBLHALHMN> JFGGGJNDNFC, [Optional] Action<string, JGOIKPDPLFA, IMFBLHALHMN> EJMFJOPIIFJ, [Optional] Action<MJDBMFMIHBM, IMFBLHALHMN> JBBBIEPBJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5DC57F0", Offset = "0x5DC47F0", VA = "0x185DC57F0")]
	private static Action<PFLLCKOMFGL<string>, IMFBLHALHMN> BCJPOCKDMMJ(Action<MJDBMFMIHBM, IMFBLHALHMN> CAEGDBPOJIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public abstract class IPPCMKMBGAK
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private class MANMOABNDBH : IPPCMKMBGAK
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static IPPCMKMBGAK NKFKDADGOPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x5DC4920", Offset = "0x5DC3920", VA = "0x185DC4920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float BCEKFKDDLDC
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x1C8D810", Offset = "0x1C8C810", VA = "0x181C8D810", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5DC4A20", Offset = "0x5DC3A20", VA = "0x185DC4A20")]
		public MANMOABNDBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static IPPCMKMBGAK KMKPMBPNKCF;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static IPPCMKMBGAK ENPBEGLBBIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5DC3200", Offset = "0x5DC2200", VA = "0x185DC3200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float BCEKFKDDLDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	protected IPPCMKMBGAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class BEAGHOBCMNK : MOGBNDNCOBN<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5DC2AA0", Offset = "0x5DC1AA0", VA = "0x185DC2AA0")]
	public BEAGHOBCMNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class MOGBNDNCOBN<T> : JFNGNMHHJFA<T>, BCEPPIOGDMP, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task<T> AOAGMFCPOKC
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public FFKFAKMNOMC<T> CCIMJCDPLMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3CBC200", Offset = "0x3CBB200", VA = "0x183CBC200")]
	public MOGBNDNCOBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class IDIOIOGAKIH<T> : JFNGNMHHJFA<T>, BCEPPIOGDMP, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Task<T> AOAGMFCPOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public FFKFAKMNOMC<T> CCIMJCDPLMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x372B850", Offset = "0x372A850", VA = "0x18372B850")]
	public IDIOIOGAKIH(Exception BALOPCFMODO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface BCEPPIOGDMP : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface JFNGNMHHJFA<T> : BCEPPIOGDMP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	[NotNull]
	Task<T> AOAGMFCPOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[NotNull]
	FFKFAKMNOMC<T> CCIMJCDPLMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public abstract class KBCIHPKCEBM
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	protected static bool HHNJCCJMJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5DC3430", Offset = "0x5DC2430", VA = "0x185DC3430")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5DC33D0", Offset = "0x5DC23D0", VA = "0x185DC33D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3480", Offset = "0x5DC2480", VA = "0x185DC3480")]
	static KBCIHPKCEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	protected KBCIHPKCEBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public abstract class AFMDHCPMIHO<TTask, T> : KBCIHPKCEBM, JFNGNMHHJFA<T>, BCEPPIOGDMP, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class GGOBJJDNFCE
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
			public GGOBJJDNFCE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x2F641A0", Offset = "0x2F631A0", VA = "0x182F641A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x2F64710", Offset = "0x2F63710", VA = "0x182F64710", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AFMDHCPMIHO<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public GGOBJJDNFCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x35197F0", Offset = "0x35187F0", VA = "0x1835197F0")]
		[AsyncStateMachine(typeof(AFMDHCPMIHO<, >.GGOBJJDNFCE.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> CACBMBNGNCH(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly Task<T> NFANMEMOADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	protected readonly CancellationTokenSource OCCBKDMNJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool EDDFAKMICOP;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Task<T> AOAGMFCPOKC
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public FFKFAKMNOMC<T> CCIMJCDPLMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool OAFFKLKKCNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x81F7E0", Offset = "0x81E7E0", VA = "0x18081F7E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x34E1E30", Offset = "0x34E0E30", VA = "0x1834E1E30")]
	protected AFMDHCPMIHO(TTask NFANMEMOADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x34E1AC0", Offset = "0x34E0AC0", VA = "0x1834E1AC0", Slot = "1")]
	~AFMDHCPMIHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x34E1AA0", Offset = "0x34E0AA0", VA = "0x1834E1AA0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x34E1CC0", Offset = "0x34E0CC0", VA = "0x1834E1CC0")]
	private void NIDAGEDDLKC(bool AKLPFMELMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T EPPALDGDAPA(TTask BBJFPKNCKHH);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void GAOGLNGMMLM();
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class IFLAHLAOMAP
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5DC2CD0", Offset = "0x5DC1CD0", VA = "0x185DC2CD0")]
	[NotNull]
	public static byte[] CEJJMOFNCMG(this GKCNABJFLDD ONEKIEBDCOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5DC2D40", Offset = "0x5DC1D40", VA = "0x185DC2D40")]
	[NotNull]
	public static byte[] CEJJMOFNCMG(this GKCNABJFLDD ONEKIEBDCOG, HashAlgorithmName IBDDLNDNIML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3070", Offset = "0x5DC2070", VA = "0x185DC3070")]
	public static bool EKBFOCIGICG([CanBeNull] this GKCNABJFLDD ONEKIEBDCOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5DC2ED0", Offset = "0x5DC1ED0", VA = "0x185DC2ED0")]
	public static bool EKBFOCIGICG([CanBeNull] this GKCNABJFLDD ONEKIEBDCOG, [Out] string KHEFJOIGNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5DC2DB0", Offset = "0x5DC1DB0", VA = "0x185DC2DB0")]
	private static bool DJDHPIGGGNF([NotNull] GKCNABJFLDD ONEKIEBDCOG, [Out][CanBeNull] byte[] LMHBEBLEIGO, [Out][CanBeNull] byte[] OCACBLDHMCO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class NDCCOFECLOL
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5AD0", Offset = "0x5DC4AD0", VA = "0x185DC5AD0")]
	[NotNull]
	public static byte[] CEJJMOFNCMG(this EHIBLOPHBLE GBGMIKLAKMO, HashAlgorithmName IBDDLNDNIML, byte[] JEENAIJJNAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface EHIBLOPHBLE
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash PBHLHLBGOBP);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface GKCNABJFLDD : EHIBLOPHBLE
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[CanBeNull]
	byte[] GGEMLMFGMGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	[CanBeNull]
	byte[] FPFPLGHIMIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class MBNMBDNBOKE
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static readonly ArrayPool<byte> GIJOGFJOPIF;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static bool OPJFEAOMHCP;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5040", Offset = "0x5DC4040", VA = "0x185DC5040")]
	public static void FDBJAMIGDAD(this IncrementalHash BAOKOIMIFLD, [CanBeNull] GameObject GFBHJHHLEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x2576170", Offset = "0x2575170", VA = "0x182576170")]
	public static void FDBJAMIGDAD<T>(this IncrementalHash BAOKOIMIFLD, [CanBeNull] T NDABCGGAOCM) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2576860", Offset = "0x2575860", VA = "0x182576860")]
	public static void JBNKBPOKDOF<T>(this IncrementalHash BAOKOIMIFLD, [CanBeNull] T GBGMIKLAKMO) where T : EHIBLOPHBLE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2575C50", Offset = "0x2574C50", VA = "0x182575C50")]
	public static void EAMEBBCAHBI<T>(this IncrementalHash BAOKOIMIFLD, [CanBeNull] IList<T> NPHAFMEGMBC) where T : EHIBLOPHBLE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5DC55F0", Offset = "0x5DC45F0", VA = "0x185DC55F0")]
	private static bool PEAKBBDHDPE([CanBeNull] EHIBLOPHBLE GBGMIKLAKMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5DC4CA0", Offset = "0x5DC3CA0", VA = "0x185DC4CA0")]
	public static void BPBNOGCHJJA(this IncrementalHash PBHLHLBGOBP, [CanBeNull] string KAMLFNFBPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5250", Offset = "0x5DC4250", VA = "0x185DC5250")]
	public static void KFNLBJDDAFH(this IncrementalHash PBHLHLBGOBP, long NNCELCHNIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5DC4A70", Offset = "0x5DC3A70", VA = "0x185DC4A70")]
	public static void BHHDLBOAACN(this IncrementalHash PBHLHLBGOBP, int KCCAAPHMPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5DC4E70", Offset = "0x5DC3E70", VA = "0x185DC4E70")]
	public static void CNMCHHBENAA(this IncrementalHash PBHLHLBGOBP, short JOFICIAKMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5DC4D60", Offset = "0x5DC3D60", VA = "0x185DC4D60")]
	public static void CLINOLCENIG(this IncrementalHash PBHLHLBGOBP, byte BFLCOPGOECJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5480", Offset = "0x5DC4480", VA = "0x185DC5480")]
	public static void OECMGCPLNHD(this IncrementalHash PBHLHLBGOBP, bool BGAHICIKHBJ, bool BPLHOHFPPLM = false, bool DOPDDBAJMCD = false, bool HIEFKBGBCHB = false, bool LJHBCGLMDOB = false, bool HFNKFHKDBFB = false, bool OBJBGCHODLK = false, bool GOANAKLDCDP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2576230", Offset = "0x2575230", VA = "0x182576230")]
	public static void ILBIDBFBIEB<T>(this IncrementalHash PBHLHLBGOBP, T KFLFOHECPON) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5DC4D00", Offset = "0x5DC3D00", VA = "0x185DC4D00")]
	public static void CCCFPIPIBPF(this IncrementalHash PBHLHLBGOBP, float HMDKPEMBEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5680", Offset = "0x5DC4680", VA = "0x185DC5680")]
	public static void PHFCCPPPDLH(this IncrementalHash PBHLHLBGOBP, ulong FPNANLKIENN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5420", Offset = "0x5DC4420", VA = "0x185DC5420")]
	public static void MHGFNAOANDI(this IncrementalHash PBHLHLBGOBP, uint APLJKBAJNIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5DC4C40", Offset = "0x5DC3C40", VA = "0x185DC4C40")]
	public static void BJIJDNFKAAD(this IncrementalHash PBHLHLBGOBP, ushort JHGJNHENOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5120", Offset = "0x5DC4120", VA = "0x185DC5120")]
	public static void HOJBNKMHAOD(this IncrementalHash PBHLHLBGOBP, Vector3 PBHCCNEJHHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class JAEPHHJFOEK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3370", Offset = "0x5DC2370", VA = "0x185DC3370")]
	public JAEPHHJFOEK(string NCBOINMNCHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public abstract class KKNAHDMIHEL<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	internal class OIENADPNGPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public TNode IEOMMHOPOKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public TNode IGPIMCJILMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public OJIBJPEHANL JJNKNHMBGLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public List<OJIBJPEHANL> HGBGFIFOJJI;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public OIENADPNGPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal struct OJIBJPEHANL : IComparable<OJIBJPEHANL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int ELAMBHMPGHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public TClaimant DODKJLCIGIP;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xB38FC0", Offset = "0xB37FC0", VA = "0x180B38FC0")]
		public OJIBJPEHANL(int ELAMBHMPGHD, TClaimant DODKJLCIGIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3E035A0", Offset = "0x3E025A0", VA = "0x183E035A0")]
		public bool AFPHFFBONGO([In] OJIBJPEHANL EJEDDDCGMMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3E03600", Offset = "0x3E02600", VA = "0x183E03600")]
		public bool AGEMMEKBAAI([In] OJIBJPEHANL EJEDDDCGMMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3E03610", Offset = "0x3E02610", VA = "0x183E03610", Slot = "4")]
		public int CompareTo(OJIBJPEHANL EJEDDDCGMMB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3E03620", Offset = "0x3E02620", VA = "0x183E03620", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum MBLOPOPEOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class JMBLJAEHJCA : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public KKNAHDMIHEL<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8C0A40", Offset = "0x8BFA40", VA = "0x1808C0A40")]
		[DebuggerHidden]
		public JMBLJAEHJCA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x38F8450", Offset = "0x38F7450", VA = "0x1838F8450", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x38F8610", Offset = "0x38F7610", VA = "0x1838F8610", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x38F8530", Offset = "0x38F7530", VA = "0x1838F8530", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x33C2670", Offset = "0x33C1670", VA = "0x1833C2670", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly NIHMLKLENDI<OIENADPNGPO> PNHBNPENGLO;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly NIHMLKLENDI<List<OJIBJPEHANL>> DLIMHOMIDOL;

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static int NHJJAJEOGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	internal readonly Dictionary<TClaimant, TNode> DOALEEFHMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	internal readonly Dictionary<TNode, OIENADPNGPO> IJJGOOLLNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private MBLOPOPEOEJ PMFIIBOFEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private bool BKIGCJKEOGE;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode LHNOALLBDNH(TNode OCIGNENFCHG);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void BLFOOPEPJAL(TNode OCIGNENFCHG, TClaimant CIJBJNHJFKL, TClaimant JCKCHKFNNDC);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x39D2CA0", Offset = "0x39D1CA0", VA = "0x1839D2CA0")]
	public KKNAHDMIHEL(MBLOPOPEOEJ PMFIIBOFEAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x39D1680", Offset = "0x39D0680", VA = "0x1839D1680")]
	public void DFIDHKGNFGD(TNode OCIGNENFCHG, TNode GLMIFAAAHGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x39D1710", Offset = "0x39D0710", VA = "0x1839D1710")]
	public void DLAJCBOHJFB(TClaimant DODKJLCIGIP, TNode AEHDHPKOAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x39D1830", Offset = "0x39D0830", VA = "0x1839D1830", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x39D1B70", Offset = "0x39D0B70", VA = "0x1839D1B70")]
	private void FHFMFBKECGJ(TClaimant DODKJLCIGIP, TNode CNPIAIKJCAC, TNode AEHDHPKOAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x39D21B0", Offset = "0x39D11B0", VA = "0x1839D21B0")]
	private int IMMDPPJHFGN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x39D2220", Offset = "0x39D1220", VA = "0x1839D2220")]
	private void JJAFIMFKLDJ(TClaimant DODKJLCIGIP, TNode BJDJEPAFDLF, TNode HPIAGANECMG, int CGOJGNPMMNN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x39D2A50", Offset = "0x39D1A50", VA = "0x1839D2A50")]
	private void MMBCLPOAKAJ(OJIBJPEHANL BBNFFEFOHKG, OIENADPNGPO IOCPKHOAOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x39D2770", Offset = "0x39D1770", VA = "0x1839D2770")]
	private void MEHACOGIMFB(TClaimant DODKJLCIGIP, TNode BJDJEPAFDLF, TNode HPIAGANECMG, int CGOJGNPMMNN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x39D1570", Offset = "0x39D0570", VA = "0x1839D1570")]
	private void CPKMOLBCMEI(OJIBJPEHANL BBNFFEFOHKG, TNode OCIGNENFCHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x39D20C0", Offset = "0x39D10C0", VA = "0x1839D20C0")]
	private void IGPEJCCHGFF(OJIBJPEHANL BBNFFEFOHKG, OIENADPNGPO IOCPKHOAOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x39D2640", Offset = "0x39D1640", VA = "0x1839D2640")]
	private void JLPICHKMFEG(OIENADPNGPO IOCPKHOAOLP, bool PENNOPLDMPA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x39D1D80", Offset = "0x39D0D80", VA = "0x1839D1D80")]
	private void HFKOBIPJDGO(OIENADPNGPO IOCPKHOAOLP, TNode GLMIFAAAHGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x39D2560", Offset = "0x39D1560", VA = "0x1839D2560")]
	[IteratorStateMachine(typeof(KKNAHDMIHEL<, >.JMBLJAEHJCA))]
	private IEnumerable<TNode> JJJIEEJCJDM(TNode BJDJEPAFDLF, TNode HPIAGANECMG, bool ANDIGDOLDOC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x39D1480", Offset = "0x39D0480", VA = "0x1839D1480")]
	private OIENADPNGPO CMMCCNDLCDO(TNode OCIGNENFCHG, TNode IGPIMCJILMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x39D1A00", Offset = "0x39D0A00", VA = "0x1839D1A00")]
	private OIENADPNGPO EHGIHLFJDLL(TNode OCIGNENFCHG, TNode IGPIMCJILMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x39D1C10", Offset = "0x39D0C10", VA = "0x1839D1C10")]
	private void GBKJNICBJME(OIENADPNGPO IOCPKHOAOLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class FAIAFJEFEKO<T> : IEnumerable<FAIAFJEFEKO<T>.FOCDBJGNMHA>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct FOCDBJGNMHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public T APPJEOKOGAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public int NFJIPMHILEL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class OMJOCJGHMII : IEnumerator<FOCDBJGNMHA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private FAIAFJEFEKO<T> CBCDPFHOAJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private int NFJIPMHILEL;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x3126BB0", Offset = "0x3125BB0", VA = "0x183126BB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public FOCDBJGNMHA PADEIDMLAKM
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x3E06810", Offset = "0x3E05810", VA = "0x183E06810", Slot = "4")]
			get
			{
				return default(FOCDBJGNMHA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3E06720", Offset = "0x3E05720", VA = "0x183E06720")]
		public OMJOCJGHMII(FAIAFJEFEKO<T> CBCDPFHOAJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3E066A0", Offset = "0x3E056A0", VA = "0x183E066A0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3177C10", Offset = "0x3176C10", VA = "0x183177C10", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x1ADADA0", Offset = "0x1AD9DA0", VA = "0x181ADADA0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private struct OBOFPKADNOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public bool DHPKPMNOFHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public T APPJEOKOGAK;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private const int ILBDCKPNHBB = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly Dictionary<T, int> JLCGMIMKKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private OBOFPKADNOH[] NEBOFLCGENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int ABPLPMNHKOC;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int PGGCFNKBDMK
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7B13F0", Offset = "0x7B03F0", VA = "0x1807B13F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7B0F30", Offset = "0x7AFF30", VA = "0x1807B0F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int PLKFCNLILAN
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2F73550", Offset = "0x2F72550", VA = "0x182F73550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x34464C0", Offset = "0x34454C0", VA = "0x1834464C0")]
	public FAIAFJEFEKO(int IKHECAIEEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x34460F0", Offset = "0x34450F0", VA = "0x1834460F0")]
	public FAIAFJEFEKO(FOCDBJGNMHA[] PLEANGJJAHB, bool KNEAMDGJEFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3445C10", Offset = "0x3444C10", VA = "0x183445C10")]
	public int OHEGMPMGCNL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3445130", Offset = "0x3444130", VA = "0x183445130")]
	private int HOLFKGCGAFH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3445BE0", Offset = "0x3444BE0", VA = "0x183445BE0", Slot = "6")]
	protected virtual uint NOBCCKOHCJI(uint PBHLHLBGOBP, T APPJEOKOGAK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3444FF0", Offset = "0x3443FF0", VA = "0x183444FF0")]
	public bool FKIGMPOKHPA(T APPJEOKOGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x3445B40", Offset = "0x3444B40", VA = "0x183445B40")]
	public int KOJELGHJPNP(T APPJEOKOGAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x3445A70", Offset = "0x3444A70", VA = "0x183445A70")]
	public T KIJPBGKOCGH(int NFJIPMHILEL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x34457C0", Offset = "0x34447C0", VA = "0x1834457C0")]
	public bool KBPGNNBKMBB(T APPJEOKOGAK, bool KAPMLMHCLGA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x3445810", Offset = "0x3444810", VA = "0x183445810")]
	public bool KBPGNNBKMBB(T APPJEOKOGAK, int NFJIPMHILEL, bool KAPMLMHCLGA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x3445090", Offset = "0x3444090", VA = "0x183445090")]
	private int GNCMCABMBKC(int HOLHNBPNHFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x3445CA0", Offset = "0x3444CA0", VA = "0x183445CA0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3445CA0", Offset = "0x3444CA0", VA = "0x183445CA0", Slot = "4")]
	private IEnumerator<FOCDBJGNMHA> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class NIHMLKLENDI<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Stack<T> OGDMHDGIHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly List<T> CDKIDIKLBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly int DNIHBICOBEM;

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x3D23A40", Offset = "0x3D22A40", VA = "0x183D23A40")]
	public static NIHMLKLENDI<T> ECJIHNBOGAC(int IKHECAIEEHO = 0, int DNIHBICOBEM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x3D24130", Offset = "0x3D23130", VA = "0x183D24130")]
	public NIHMLKLENDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x3D23F90", Offset = "0x3D22F90", VA = "0x183D23F90")]
	public NIHMLKLENDI(int IKHECAIEEHO, int DNIHBICOBEM = int.MaxValue, bool MLEBAPNJGJO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3D23E10", Offset = "0x3D22E10", VA = "0x183D23E10")]
	public T LJOHOPNAHNO()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3D23B20", Offset = "0x3D22B20", VA = "0x183D23B20")]
	public void FBELCMGCHEP(T APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3D23820", Offset = "0x3D22820", VA = "0x183D23820")]
	private void BBKPANLPILI(T APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x3D23DF0", Offset = "0x3D22DF0", VA = "0x183D23DF0")]
	private void IHFKBMLALBC(T APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x3D23900", Offset = "0x3D22900", VA = "0x183D23900", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x3D23BF0", Offset = "0x3D22BF0", VA = "0x183D23BF0")]
	private void IAICADAHGMC(IEnumerable<T> ALBJDCCCHNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class IANJBCGLHPG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Dictionary<int, T> NFLGAILPFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private T CNPDPLJAFJD;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public virtual T PEPGFFDKDMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x76F1A0", Offset = "0x76E1A0", VA = "0x18076F1A0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x371ABB0", Offset = "0x3719BB0", VA = "0x18371ABB0")]
	public bool FAGMKNGAFHE(T APPJEOKOGAK, int ELAMBHMPGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x371AB40", Offset = "0x3719B40", VA = "0x18371AB40")]
	public bool CNNLAKNGPJG(int ELAMBHMPGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x371ACF0", Offset = "0x3719CF0", VA = "0x18371ACF0")]
	public T NBDMEHPBFJN(int BOMHFHAJKFO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x371B1E0", Offset = "0x371A1E0", VA = "0x18371B1E0")]
	private bool PHJEHBLHGCH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x371ACA0", Offset = "0x3719CA0", VA = "0x18371ACA0")]
	public bool KMJKDBDGJFH(int ELAMBHMPGHD, [Out] T APPJEOKOGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x371B280", Offset = "0x371A280", VA = "0x18371B280")]
	public IANJBCGLHPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class JLKIOHOILNB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	protected struct KEPOOPADLJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public T INAJMIAKCCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int DCKPBJNDJIN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	protected readonly List<KEPOOPADLJI> DJBMCFBLDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private T IBOMDJLPEKO;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int PLKFCNLILAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2F73550", Offset = "0x2F72550", VA = "0x182F73550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x38F4A40", Offset = "0x38F3A40", VA = "0x1838F4A40")]
	public bool AKPLCCANECI(T APPJEOKOGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x38F4BC0", Offset = "0x38F3BC0", VA = "0x1838F4BC0")]
	public void GPDFOMDKBKK(T APPJEOKOGAK, int ELAMBHMPGHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x38F4CE0", Offset = "0x38F3CE0", VA = "0x1838F4CE0")]
	public bool MOJJDBCCFOB(T APPJEOKOGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x38F4F90", Offset = "0x38F3F90", VA = "0x1838F4F90")]
	public void PMEKKAMOFIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x38F4C60", Offset = "0x38F3C60", VA = "0x1838F4C60")]
	public T LAAJALCBAEJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x38F4E30", Offset = "0x38F3E30", VA = "0x1838F4E30")]
	private void PDKCBIGAMED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x38F4FF0", Offset = "0x38F3FF0", VA = "0x1838F4FF0")]
	public JLKIOHOILNB()
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
		[APIEEPBMFLD(CDNIJDNCOPP.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x5DC6110", Offset = "0x5DC5110", VA = "0x185DC6110")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x5DC63E0", Offset = "0x5DC53E0", VA = "0x185DC63E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x5DC62F0", Offset = "0x5DC52F0", VA = "0x185DC62F0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5DC6060", Offset = "0x5DC5060", VA = "0x185DC6060")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x5DC6330", Offset = "0x5DC5330", VA = "0x185DC6330")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x5DC6240", Offset = "0x5DC5240", VA = "0x185DC6240")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5DC5FD0", Offset = "0x5DC4FD0", VA = "0x185DC5FD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x40BA4E0", Offset = "0x40B94E0", VA = "0x1840BA4E0", Slot = "4")]
		public virtual T AJGMGNJKHFH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class LPPAEBKFHEF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly Dictionary<byte, LPLMAACPPOH> LPLJDCBGCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly NIHMLKLENDI<LPLMAACPPOH> EBPFEBKAGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly bool DMDDCLAELDM;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public LPLMAACPPOH JDFEHPFNMKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x76F1B0", Offset = "0x76E1B0", VA = "0x18076F1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public Vector2 MEJJMOLCFFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xABD4C0", Offset = "0xABC4C0", VA = "0x180ABD4C0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xD8D280", Offset = "0xD8C280", VA = "0x180D8D280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	private Vector2 APLHOIBMLEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xDC27D0", Offset = "0xDC17D0", VA = "0x180DC27D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public Vector2 EDMFFKOGOGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5DC4160", Offset = "0x5DC3160", VA = "0x185DC4160")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x774F50", Offset = "0x773F50", VA = "0x180774F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int NBPBBBNCOII
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x779C50", Offset = "0x778C50", VA = "0x180779C50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x779FE0", Offset = "0x778FE0", VA = "0x180779FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5DC4490", Offset = "0x5DC3490", VA = "0x185DC4490")]
	public LPPAEBKFHEF(Bounds GIEMONAMMEL, Vector2[] BDGNFFBNBIB, int NCCNCBDOJCB, byte HOLHNBPNHFM, float FKFBMLCLEJJ = 0f, [Optional] NIHMLKLENDI<LPLMAACPPOH> EBPFEBKAGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3E40", Offset = "0x5DC2E40", VA = "0x185DC3E40")]
	public LPLMAACPPOH DIKDEDGOJPG(byte NFJIPMHILEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5DC39C0", Offset = "0x5DC29C0", VA = "0x185DC39C0")]
	public void BHPBOPAIPGC(Vector3 LPGLCEHEHMC, float HEPPGOGEJMI, float KEGPJCHBFBM, List<byte> NKFONPLOPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1AE5510", Offset = "0x1AE4510", VA = "0x181AE5510")]
	public void BPMCDCKIEFM(LPLMAACPPOH.OFPAKPELOMK ENLCPJLKLDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5DC43A0", Offset = "0x5DC33A0", VA = "0x185DC43A0")]
	public static int NJMDLMBKLFG(Vector2[] BDGNFFBNBIB, int NCCNCBDOJCB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3F60", Offset = "0x5DC2F60", VA = "0x185DC3F60")]
	private LPLMAACPPOH GKBINLCMJBD(byte NFJIPMHILEL, LPLMAACPPOH.MPBMFECALHB HBJIPMLLPIO, LPLMAACPPOH IGPIMCJILMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3A90", Offset = "0x5DC2A90", VA = "0x185DC3A90")]
	private void CCLIHHJIPBO(LPLMAACPPOH IGPIMCJILMM, Vector2[] BDGNFFBNBIB, int NCIIHBKBNEM, int HBAJDCLOFCN, int AEJBEOAHKFK, int EJCLOCPEJBD, float FKFBMLCLEJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5DC4180", Offset = "0x5DC3180", VA = "0x185DC4180")]
	private void KBPIDBCMJJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3EA0", Offset = "0x5DC2EA0", VA = "0x185DC3EA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3F00", Offset = "0x5DC2F00", VA = "0x185DC3F00", Slot = "1")]
	~LPPAEBKFHEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class LPLMAACPPOH
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public enum MPBMFECALHB
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum OFPAKPELOMK
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
	public byte GMIBMNELHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public Vector3 KFFPPANMFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public Vector3 FJPPAJJFFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public Vector3 JILDCOKGHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public Vector3 KKDKBKDOLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public MPBMFECALHB GLFDHCPPDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public LPLMAACPPOH CPGMADILNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public List<LPLMAACPPOH> IPCBAIOENHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public bool NJCMEBGPDNK;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5DC39A0", Offset = "0x5DC29A0", VA = "0x185DC39A0")]
	public LPLMAACPPOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3530", Offset = "0x5DC2530", VA = "0x185DC3530")]
	public void AFEGLLIBHOI(LPLMAACPPOH DNNMPMAOGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0")]
	public void BPMCDCKIEFM(int GMNABCLMHBE, OFPAKPELOMK ENLCPJLKLDO, int JBELPPCMPGD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3650", Offset = "0x5DC2650", VA = "0x185DC3650")]
	public void BHPBOPAIPGC(List<byte> NKFONPLOPGJ, Vector3 LPGLCEHEHMC, float HEPPGOGEJMI, float KEGPJCHBFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3940", Offset = "0x5DC2940", VA = "0x185DC3940")]
	public bool NMPEIKGCCAM(Vector3 MIELJCMDEKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3970", Offset = "0x5DC2970", VA = "0x185DC3970")]
	public bool ONBOAJBCAOK(Vector3 MIELJCMDEKP, float FJKMFGHNGAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5DC38B0", Offset = "0x5DC28B0", VA = "0x185DC38B0")]
	public void EMCBFDNIFOC()
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
		public struct ONOIGDELILF<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private readonly List<Component> LOKHPAFMLOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private readonly bool FBGGJINMGFH;

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x3A50C20", Offset = "0x3A4FC20", VA = "0x183A50C20")]
			public ONOIGDELILF(List<Component> LOKHPAFMLOJ, bool FBGGJINMGFH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x3E0CFA0", Offset = "0x3E0BFA0", VA = "0x183E0CFA0")]
			public HCEHPHKFBMB<T> PKEKCLMIDEH()
			{
				return default(HCEHPHKFBMB<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x3E0D010", Offset = "0x3E0C010", VA = "0x183E0D010", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x3E0D010", Offset = "0x3E0C010", VA = "0x183E0D010", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public struct HCEHPHKFBMB<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private readonly List<Component> LOKHPAFMLOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private readonly bool FBGGJINMGFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private int NFJIPMHILEL;

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public T PADEIDMLAKM
			{
				[Cpp2IlInjected.Token(Token = "0x60001EB")]
				[Cpp2IlInjected.Address(RVA = "0x35E8C60", Offset = "0x35E7C60", VA = "0x1835E8C60", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001EC")]
				[Cpp2IlInjected.Address(RVA = "0x35E8BF0", Offset = "0x35E7BF0", VA = "0x1835E8BF0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x35E8C30", Offset = "0x35E7C30", VA = "0x1835E8C30")]
			public HCEHPHKFBMB(List<Component> LOKHPAFMLOJ, bool FBGGJINMGFH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x35E8B30", Offset = "0x35E7B30", VA = "0x1835E8B30", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x35E8B40", Offset = "0x35E7B40", VA = "0x1835E8B40", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x3168200", Offset = "0x3167200", VA = "0x183168200", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7AA0", Offset = "0x5DC6AA0", VA = "0x185DC7AA0")]
		private void EMCBFDNIFOC(GameObject OKFEGDLOMNK, bool OFOIDDLLFEI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7C10", Offset = "0x5DC6C10", VA = "0x185DC7C10")]
		public static void EMCBFDNIFOC(GameObject OKFEGDLOMNK, ToolHierarchyCache LCMBPFCEKII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x278D480", Offset = "0x278C480", VA = "0x18278D480")]
		public void PNMHIJJLFJC<T>(Action<T> NFDFJOBAEPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x278D350", Offset = "0x278C350", VA = "0x18278D350")]
		public T NCAGIEPAKGG<T>(bool FBGGJINMGFH = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x278D3C0", Offset = "0x278C3C0", VA = "0x18278D3C0")]
		public ONOIGDELILF<T> NEMCGHHJNJD<T>(bool FBGGJINMGFH = false) where T : class
		{
			return default(ONOIGDELILF<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7750", Offset = "0x5DC6750", VA = "0x185DC7750")]
		public List<Component> BAJLOHAAMJB(Type CFGJPNBLNDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7DD0", Offset = "0x5DC6DD0", VA = "0x185DC7DD0", Slot = "4")]
		public bool Equals(ToolHierarchyCache LNKHMLIBJEP, ToolHierarchyCache DLOPBGEOAKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7E50", Offset = "0x5DC6E50", VA = "0x185DC7E50", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache GPCHHCACPPJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class NJKCLLPNBGK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private int IKHECAIEEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private int IMAJGFICCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private List<T> DHAGBOIMPBD;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public int PLKFCNLILAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3444C60", Offset = "0x3443C60", VA = "0x183444C60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public T CLAGMKDPLCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3D25070", Offset = "0x3D24070", VA = "0x183D25070")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public T EDLMNLHFHEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3D252B0", Offset = "0x3D242B0", VA = "0x183D252B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public T NIONEEAOMHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3D24D90", Offset = "0x3D23D90", VA = "0x183D24D90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x3D253C0", Offset = "0x3D243C0", VA = "0x183D253C0")]
	public NJKCLLPNBGK(int IKHECAIEEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3D24F70", Offset = "0x3D23F70", VA = "0x183D24F70")]
	public void GPDFOMDKBKK(T KIAKAIHDPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x3D25380", Offset = "0x3D24380", VA = "0x183D25380")]
	public void PMEKKAMOFIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x3D251E0", Offset = "0x3D241E0", VA = "0x183D251E0")]
	public void LNPIMAAMLOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x3D24D30", Offset = "0x3D23D30", VA = "0x183D24D30")]
	public void AIMNNGNKMPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x3D24E70", Offset = "0x3D23E70", VA = "0x183D24E70")]
	public void CPANCDOMGAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class MPKMDECLIGE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private struct FJOHFNAECJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int DCKPBJNDJIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public T INAJMIAKCCF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly Dictionary<object, FJOHFNAECJM> NFLGAILPFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly EqualityComparer<T> KODINOKDNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private T CNPDPLJAFJD;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public virtual T PEPGFFDKDMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xEC8640", Offset = "0xEC7640", VA = "0x180EC8640", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3CCA100", Offset = "0x3CC9100", VA = "0x183CCA100", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool FJBFOIKKLKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3CCA080", Offset = "0x3CC9080", VA = "0x183CCA080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public object GMNMHKMBANA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x76F1D0", Offset = "0x76E1D0", VA = "0x18076F1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x76F220", Offset = "0x76E220", VA = "0x18076F220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x3CC99D0", Offset = "0x3CC89D0", VA = "0x183CC99D0")]
	public bool FAGMKNGAFHE(T APPJEOKOGAK, object PDIBILKHEBM, int ELAMBHMPGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x3CC95A0", Offset = "0x3CC85A0", VA = "0x183CC95A0")]
	public bool CNNLAKNGPJG(object PDIBILKHEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x3CCA4E0", Offset = "0x3CC94E0", VA = "0x183CCA4E0")]
	public bool KMJKDBDGJFH(object PDIBILKHEBM, [Out] T APPJEOKOGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3CCD310", Offset = "0x3CCC310", VA = "0x183CCD310")]
	public void PMEKKAMOFIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x3CCCA50", Offset = "0x3CCBA50", VA = "0x183CCCA50")]
	private bool PHJEHBLHGCH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x3CCD340", Offset = "0x3CCC340", VA = "0x183CCD340")]
	public MPKMDECLIGE()
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
