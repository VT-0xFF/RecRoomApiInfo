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
using Mono.Math;
using Unity.Collections;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class KIJCDAJOLJD : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x686190", Offset = "0x684F90", VA = "0x180686190")]
	public KIJCDAJOLJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, NIPAEPLNJMM, JDBJPKOCHPF, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x660AF0", Offset = "0x65F8F0", VA = "0x180660AF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x65B250", Offset = "0x65A050", VA = "0x18065B250", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6A0580", Offset = "0x69F380", VA = "0x1806A0580", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6E71E0", Offset = "0x6E5FE0", VA = "0x1806E71E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash PKCNHEGJGNH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xC042B0", Offset = "0xC030B0", VA = "0x180C042B0")]
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
	[DEIKCOMKPHJ]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[DEIKCOMKPHJ]
	[SerializeField]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5D334A0", Offset = "0x5D322A0", VA = "0x185D334A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D33460", Offset = "0x5D32260", VA = "0x185D33460")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5D334E0", Offset = "0x5D322E0", VA = "0x185D334E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5D336B0", Offset = "0x5D324B0", VA = "0x185D336B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5D33620", Offset = "0x5D32420", VA = "0x185D33620")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xDEE130", Offset = "0xDECF30", VA = "0x180DEE130")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xF39750", Offset = "0xF38550", VA = "0x180F39750")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5D33420", Offset = "0x5D32220", VA = "0x185D33420")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5D33590", Offset = "0x5D32390", VA = "0x185D33590")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5D32E60", Offset = "0x5D31C60", VA = "0x185D32E60")]
	public void CopyBounds(SavedExtents HNOJKNGFFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5D33380", Offset = "0x5D32180", VA = "0x185D33380")]
	public void SetLocalSpaceBounds(Bounds MKMJKAJJCML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xEEB3B0", Offset = "0xEEA1B0", VA = "0x180EEB3B0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5D33370", Offset = "0x5D32170", VA = "0x185D33370")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5D32F50", Offset = "0x5D31D50", VA = "0x185D32F50")]
	private void ODIMLOIMPCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5D33140", Offset = "0x5D31F40", VA = "0x185D33140")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5D32820", Offset = "0x5D31620", VA = "0x185D32820")]
	public static void CalculateLocalBoundsFor(GameObject BFJMKCMPBKG, out Bounds MKMJKAJJCML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5D32E90", Offset = "0x5D31C90", VA = "0x185D32E90")]
	private static void DKKOMGEFKPM(Bounds BMMLDIMMAAK, Color KDPJFGIFCOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5D333A0", Offset = "0x5D321A0", VA = "0x185D333A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x657020", Offset = "0x655E20", VA = "0x180657020")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6618F0", Offset = "0x6606F0", VA = "0x1806618F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xCD58C0", Offset = "0xCD46C0", VA = "0x180CD58C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xCD59D0", Offset = "0xCD47D0", VA = "0x180CD59D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "4")]
	public virtual void FBPMKNABHGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
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
	[KIJCDAJOLJD]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3024A30", Offset = "0x3023830", VA = "0x183024A30", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3024160", Offset = "0x3022F60", VA = "0x183024160", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3024F70", Offset = "0x3023D70", VA = "0x183024F70")]
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
	private sealed class EFADPOCGLGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
		public EFADPOCGLGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x19854F0", Offset = "0x19842F0", VA = "0x1819854F0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	[KIJCDAJOLJD]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x19A2FD0", Offset = "0x19A1DD0", VA = "0x1819A2FD0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x19A3000", Offset = "0x19A1E00", VA = "0x1819A3000", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x19A2F20", Offset = "0x19A1D20", VA = "0x1819A2F20", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey CCJNKBLKLDJ]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x19A2F50", Offset = "0x19A1D50", VA = "0x1819A2F50", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x19A2E20", Offset = "0x19A1C20", VA = "0x1819A2E20", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x19A27A0", Offset = "0x19A15A0", VA = "0x1819A27A0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x19A1E70", Offset = "0x19A0C70", VA = "0x1819A1E70", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x19A1D80", Offset = "0x19A0B80", VA = "0x1819A1D80", Slot = "14")]
	protected virtual string FNJLMLMFBBO(TKeyVal CAHHMHDOMJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x19A1D20", Offset = "0x19A0B20", VA = "0x1819A1D20", Slot = "4")]
	public bool ContainsKey(TKey CCJNKBLKLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x19A2D10", Offset = "0x19A1B10", VA = "0x1819A2D10", Slot = "5")]
	public bool TryGetValue(TKey CCJNKBLKLDJ, out TVal IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x19A1DE0", Offset = "0x19A0BE0", VA = "0x1819A1DE0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x19A1DE0", Offset = "0x19A0BE0", VA = "0x1819A1DE0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x19A2D40", Offset = "0x19A1B40", VA = "0x1819A2D40")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FJODBEIAGNI<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class FEGHEBNGINO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
		public FEGHEBNGINO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x245ADA0", Offset = "0x2459BA0", VA = "0x18245ADA0")]
		internal bool <GetSamples>b__0(global::PMABFILABJH<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float NEECFLIOPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float OPPNDEGGOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<global::PMABFILABJH<float, T>> JICIEFJDEKA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int GKELHGEOEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2528860", Offset = "0x2527660", VA = "0x182528860")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x25288E0", Offset = "0x25276E0", VA = "0x1825288E0")]
	public FJODBEIAGNI(float PFEFIHOHHHJ, float IHEKBHOHGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2528680", Offset = "0x2527480", VA = "0x182528680")]
	public bool MIKLGOGDGGE(float EPNJJECKICP, T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2527D80", Offset = "0x2526B80", VA = "0x182527D80")]
	public int KKPPBHIPEOL(float EPNJJECKICP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2527DE0", Offset = "0x2526BE0", VA = "0x182527DE0")]
	public IEnumerable<T> LMFPILJPJPK(float EPNJJECKICP, [Optional] float? CGNHEIGCKCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2527D50", Offset = "0x2526B50", VA = "0x182527D50")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2528460", Offset = "0x2527260", VA = "0x182528460")]
	private void MDCCMOFJMDE(float EPNJJECKICP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class JBLGNAKMNJK<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct PKJEMEFLGJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T AAFFKFKIJDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float PDOCOMCOHFL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float GNOFDMIJMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> FJEILAFLLJJ;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int NKHBPGAALFE = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private PKJEMEFLGJJ[] DEJEDNNJILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int OANDGKLJOPF;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float EIIMCDJMMCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xDFD1F0", Offset = "0xDFBFF0", VA = "0x180DFD1F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xDFD220", Offset = "0xDFC020", VA = "0x180DFD220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3510FE0", Offset = "0x350FDE0", VA = "0x183510FE0")]
	public JBLGNAKMNJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3511010", Offset = "0x350FE10", VA = "0x183511010")]
	public JBLGNAKMNJK(int MNKEEJPGFOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3510450", Offset = "0x350F250", VA = "0x183510450")]
	public void HEFJCCLOLGO(float EPNJJECKICP, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3510610", Offset = "0x350F410", VA = "0x183510610")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3510BB0", Offset = "0x350F9B0", VA = "0x183510BB0")]
	public bool KLCNLPGKMIO(float AEIJLDBDDCG, float EFOKDAAMCPK, out T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x350FB30", Offset = "0x350E930", VA = "0x18350FB30")]
	public bool BDBDOFMMLKL(float AEIJLDBDDCG, float EFOKDAAMCPK, out T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3510270", Offset = "0x350F070", VA = "0x183510270")]
	public void EEBOCFACPNG(float AEIJLDBDDCG, float EFOKDAAMCPK, List<T> CLABEIKAHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x350FFF0", Offset = "0x350EDF0", VA = "0x18350FFF0")]
	private int DLCMMCGHOEB(int MEADGPNFDGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x350FFB0", Offset = "0x350EDB0", VA = "0x18350FFB0")]
	private void CILDGJIDJJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BNMBPOAOGGL();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T ELIBCCJNKOK(T AIAIDPGGDMM, T PHPKEGMGOPM, float MGEGOIPHNMM);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T JPODFEPGFHD(T IGJPNMBCJPK, float MGEGOIPHNMM);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T MCOEAJIJENK(T AIAIDPGGDMM, T PHPKEGMGOPM);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T BPGCONMIABP(T AIAIDPGGDMM, T PHPKEGMGOPM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PDLIGFKKOIO : global::JBLGNAKMNJK<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xE5D450", Offset = "0xE5C250", VA = "0x180E5D450", Slot = "4")]
	protected override Vector3 BNMBPOAOGGL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xFB9FB0", Offset = "0xFB8DB0", VA = "0x180FB9FB0", Slot = "5")]
	protected override Vector3 ELIBCCJNKOK(Vector3 AIAIDPGGDMM, Vector3 PHPKEGMGOPM, float MGEGOIPHNMM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5D31290", Offset = "0x5D30090", VA = "0x185D31290", Slot = "6")]
	protected override Vector3 JPODFEPGFHD(Vector3 IGJPNMBCJPK, float MGEGOIPHNMM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5D312F0", Offset = "0x5D300F0", VA = "0x185D312F0", Slot = "7")]
	protected override Vector3 MCOEAJIJENK(Vector3 AIAIDPGGDMM, Vector3 PHPKEGMGOPM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5D31220", Offset = "0x5D30020", VA = "0x185D31220", Slot = "8")]
	protected override Vector3 BPGCONMIABP(Vector3 AIAIDPGGDMM, Vector3 PHPKEGMGOPM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5D31370", Offset = "0x5D30170", VA = "0x185D31370")]
	public PDLIGFKKOIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PHEPHJMBCCF : global::JBLGNAKMNJK<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5D31E10", Offset = "0x5D30C10", VA = "0x185D31E10")]
	public PHEPHJMBCCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5D31E80", Offset = "0x5D30C80", VA = "0x185D31E80")]
	public PHEPHJMBCCF(int MNKEEJPGFOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xDFFDB0", Offset = "0xDFEBB0", VA = "0x180DFFDB0", Slot = "4")]
	protected override float BNMBPOAOGGL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x33AB9B0", Offset = "0x33AA7B0", VA = "0x1833AB9B0", Slot = "5")]
	protected override float ELIBCCJNKOK(float AIAIDPGGDMM, float PHPKEGMGOPM, float MGEGOIPHNMM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4E6FB50", Offset = "0x4E6E950", VA = "0x184E6FB50", Slot = "6")]
	protected override float JPODFEPGFHD(float IGJPNMBCJPK, float MGEGOIPHNMM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x24E5BB0", Offset = "0x24E49B0", VA = "0x1824E5BB0", Slot = "7")]
	protected override float MCOEAJIJENK(float AIAIDPGGDMM, float PHPKEGMGOPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5D31E00", Offset = "0x5D30C00", VA = "0x185D31E00", Slot = "8")]
	protected override float BPGCONMIABP(float AIAIDPGGDMM, float PHPKEGMGOPM)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class GCHNEANFBJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1F89860", Offset = "0x1F88660", VA = "0x181F89860")]
	public static global::LALDAEGJJFA<T1> DAKLFHBAJIH<T1>(T1 NMINDOPCKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x221B930", Offset = "0x221A730", VA = "0x18221B930")]
	public static global::PMABFILABJH<T1, T2> DAKLFHBAJIH<T1, T2>(T1 NMINDOPCKDG, T2 DDEJHDMCLOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x221B9A0", Offset = "0x221A7A0", VA = "0x18221B9A0")]
	public static global::GMGCAJLHPIK<T1, T2, T3> DAKLFHBAJIH<T1, T2, T3>(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x221BD10", Offset = "0x221AB10", VA = "0x18221BD10")]
	public static global::CLFHCNPKBOH<T1, T2, T3, T4> DAKLFHBAJIH<T1, T2, T3, T4>(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC, T4 FPPJLFGGHIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x221BC70", Offset = "0x221AA70", VA = "0x18221BC70")]
	public static global::CAPGKAKHPDC<T1, T2, T3, T4, T5> DAKLFHBAJIH<T1, T2, T3, T4, T5>(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC, T4 FPPJLFGGHIM, T5 GBLFKENMGAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x221BBC0", Offset = "0x221A9C0", VA = "0x18221BBC0")]
	public static global::KHOGFEGEPPG<T1, T2, T3, T4, T5, T6> DAKLFHBAJIH<T1, T2, T3, T4, T5, T6>(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC, T4 FPPJLFGGHIM, T5 GBLFKENMGAO, T6 FPLIGHFBGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x221BB00", Offset = "0x221A900", VA = "0x18221BB00")]
	public static global::PLDBIEDAKMI<T1, T2, T3, T4, T5, T6, T7> DAKLFHBAJIH<T1, T2, T3, T4, T5, T6, T7>(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC, T4 FPPJLFGGHIM, T5 GBLFKENMGAO, T6 FPLIGHFBGCD, T7 GPDCNGPPIBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x221BA30", Offset = "0x221A830", VA = "0x18221BA30")]
	public static global::DEKMENFBCJI<T1, T2, T3, T4, T5, T6, T7, T8> DAKLFHBAJIH<T1, T2, T3, T4, T5, T6, T7, T8>(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC, T4 FPPJLFGGHIM, T5 GBLFKENMGAO, T6 FPLIGHFBGCD, T7 GPDCNGPPIBB, T8 OEMHJNGLELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x13E9E90", Offset = "0x13E8C90", VA = "0x1813E9E90")]
	[IteratorStateMachine(typeof(JGNFANIOHJJ))]
	public static IEnumerable<global::PMABFILABJH<T1, T2>> KAGONGNLDCG<T1, T2>(IEnumerable<T1> BMPDKJEHGIN, IEnumerable<T2> BMMLDIMMAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x13EA070", Offset = "0x13E8E70", VA = "0x1813EA070")]
	[IteratorStateMachine(typeof(CNNFKOIEOMN))]
	public static IEnumerable<global::GMGCAJLHPIK<T1, T2, T3>> KAGONGNLDCG<T1, T2, T3>(IEnumerable<T1> BMPDKJEHGIN, IEnumerable<T2> BMMLDIMMAAK, IEnumerable<T3> KDPJFGIFCOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1E7A820", Offset = "0x1E79620", VA = "0x181E7A820")]
	internal static int KAIAGLGGKBN(int KDGFGJINLNH, int MKOOFNNADNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3BCCBF0", Offset = "0x3BCB9F0", VA = "0x183BCCBF0")]
	internal static int KAIAGLGGKBN(int KDGFGJINLNH, int MKOOFNNADNC, int OAHNOOAJAIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3BCCBD0", Offset = "0x3BCB9D0", VA = "0x183BCCBD0")]
	internal static int KAIAGLGGKBN(int KDGFGJINLNH, int MKOOFNNADNC, int OAHNOOAJAIM, int HBAHEGCGDKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DE80", Offset = "0x5D2CC80", VA = "0x185D2DE80")]
	internal static int KAIAGLGGKBN(int KDGFGJINLNH, int MKOOFNNADNC, int OAHNOOAJAIM, int HBAHEGCGDKF, int GEAPDGBPDNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DEA0", Offset = "0x5D2CCA0", VA = "0x185D2DEA0")]
	internal static int KAIAGLGGKBN(int KDGFGJINLNH, int MKOOFNNADNC, int OAHNOOAJAIM, int HBAHEGCGDKF, int GEAPDGBPDNE, int FOBOIBCDKHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DEF0", Offset = "0x5D2CCF0", VA = "0x185D2DEF0")]
	internal static int KAIAGLGGKBN(int KDGFGJINLNH, int MKOOFNNADNC, int OAHNOOAJAIM, int HBAHEGCGDKF, int GEAPDGBPDNE, int FOBOIBCDKHN, int MAEKELKOLGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DEC0", Offset = "0x5D2CCC0", VA = "0x185D2DEC0")]
	internal static int KAIAGLGGKBN(int KDGFGJINLNH, int MKOOFNNADNC, int OAHNOOAJAIM, int HBAHEGCGDKF, int GEAPDGBPDNE, int FOBOIBCDKHN, int MAEKELKOLGE, int IBEHKJEGGAP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class LALDAEGJJFA<T1> : IComparable<global::LALDAEGJJFA<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T1 DHCFOINGBHC;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x166AFE0", Offset = "0x1669DE0", VA = "0x18166AFE0")]
	public LALDAEGJJFA(T1 NMINDOPCKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3A8C870", Offset = "0x3A8B670", VA = "0x183A8C870", Slot = "4")]
	public int CompareTo(global::LALDAEGJJFA<T1> HNOJKNGFFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3A8C8E0", Offset = "0x3A8B6E0", VA = "0x183A8C8E0", Slot = "0")]
	public override bool Equals(object HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xA5BA30", Offset = "0xA5A830", VA = "0x180A5BA30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3A8C980", Offset = "0x3A8B780", VA = "0x183A8C980", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PMABFILABJH<T1, T2> : IComparable<global::PMABFILABJH<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 DHCFOINGBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 KJPNGCOOEJF;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3506900", Offset = "0x3505700", VA = "0x183506900")]
	public PMABFILABJH(T1 NMINDOPCKDG, T2 DDEJHDMCLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3504B00", Offset = "0x3503900", VA = "0x183504B00", Slot = "4")]
	public int CompareTo(global::PMABFILABJH<T1, T2> HNOJKNGFFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3504F40", Offset = "0x3503D40", VA = "0x183504F40", Slot = "0")]
	public override bool Equals(object HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3505BE0", Offset = "0x35049E0", VA = "0x183505BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x35062F0", Offset = "0x35050F0", VA = "0x1835062F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class GMGCAJLHPIK<T1, T2, T3> : IComparable<global::GMGCAJLHPIK<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T1 DHCFOINGBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T2 KJPNGCOOEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T3 CCPBNNKKEOI;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2A78EF0", Offset = "0x2A77CF0", VA = "0x182A78EF0")]
	public GMGCAJLHPIK(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2A786E0", Offset = "0x2A774E0", VA = "0x182A786E0", Slot = "4")]
	public int CompareTo(global::GMGCAJLHPIK<T1, T2, T3> HNOJKNGFFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2A789D0", Offset = "0x2A777D0", VA = "0x182A789D0", Slot = "0")]
	public override bool Equals(object HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2A78BD0", Offset = "0x2A779D0", VA = "0x182A78BD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2A78D40", Offset = "0x2A77B40", VA = "0x182A78D40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class CLFHCNPKBOH<T1, T2, T3, T4> : IComparable<global::CLFHCNPKBOH<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T1 DHCFOINGBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T2 KJPNGCOOEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T3 CCPBNNKKEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T4 DIDMNICMMJP;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x24C0AC0", Offset = "0x24BF8C0", VA = "0x1824C0AC0")]
	public CLFHCNPKBOH(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC, T4 FPPJLFGGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x24C0670", Offset = "0x24BF470", VA = "0x1824C0670", Slot = "4")]
	public int CompareTo(global::CLFHCNPKBOH<T1, T2, T3, T4> HNOJKNGFFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x24C07B0", Offset = "0x24BF5B0", VA = "0x1824C07B0", Slot = "0")]
	public override bool Equals(object HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x24C08D0", Offset = "0x24BF6D0", VA = "0x1824C08D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x24C0990", Offset = "0x24BF790", VA = "0x1824C0990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class CAPGKAKHPDC<T1, T2, T3, T4, T5> : IComparable<global::CAPGKAKHPDC<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T1 DHCFOINGBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T2 KJPNGCOOEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T3 CCPBNNKKEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T4 DIDMNICMMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T5 KOMNPBOOGEB;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x27B1640", Offset = "0x27B0440", VA = "0x1827B1640")]
	public CAPGKAKHPDC(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC, T4 FPPJLFGGHIM, T5 GBLFKENMGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x331CC70", Offset = "0x331BA70", VA = "0x18331CC70", Slot = "4")]
	public int CompareTo(global::CAPGKAKHPDC<T1, T2, T3, T4, T5> HNOJKNGFFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x331CDF0", Offset = "0x331BBF0", VA = "0x18331CDF0", Slot = "0")]
	public override bool Equals(object HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x331CF30", Offset = "0x331BD30", VA = "0x18331CF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x331D030", Offset = "0x331BE30", VA = "0x18331D030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class KHOGFEGEPPG<T1, T2, T3, T4, T5, T6> : IComparable<global::KHOGFEGEPPG<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T1 DHCFOINGBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T2 KJPNGCOOEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T3 CCPBNNKKEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T4 DIDMNICMMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T5 KOMNPBOOGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T6 JJICPPMKADB;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3001A90", Offset = "0x3000890", VA = "0x183001A90")]
	public KHOGFEGEPPG(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC, T4 FPPJLFGGHIM, T5 GBLFKENMGAO, T6 FPLIGHFBGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x30014D0", Offset = "0x30002D0", VA = "0x1830014D0", Slot = "4")]
	public int CompareTo(global::KHOGFEGEPPG<T1, T2, T3, T4, T5, T6> HNOJKNGFFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3001690", Offset = "0x3000490", VA = "0x183001690", Slot = "0")]
	public override bool Equals(object HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3001800", Offset = "0x3000600", VA = "0x183001800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3001920", Offset = "0x3000720", VA = "0x183001920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class PLDBIEDAKMI<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::PLDBIEDAKMI<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T1 DHCFOINGBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T2 KJPNGCOOEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T3 CCPBNNKKEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T4 DIDMNICMMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T5 KOMNPBOOGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T6 JJICPPMKADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T7 OAOHENKGOEB;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x30681C0", Offset = "0x3066FC0", VA = "0x1830681C0")]
	public PLDBIEDAKMI(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC, T4 FPPJLFGGHIM, T5 GBLFKENMGAO, T6 FPLIGHFBGCD, T7 GPDCNGPPIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3067B40", Offset = "0x3066940", VA = "0x183067B40", Slot = "4")]
	public int CompareTo(global::PLDBIEDAKMI<T1, T2, T3, T4, T5, T6, T7> HNOJKNGFFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3067D40", Offset = "0x3066B40", VA = "0x183067D40", Slot = "0")]
	public override bool Equals(object HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3067EE0", Offset = "0x3066CE0", VA = "0x183067EE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3068030", Offset = "0x3066E30", VA = "0x183068030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class DEKMENFBCJI<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::DEKMENFBCJI<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T1 DHCFOINGBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T2 KJPNGCOOEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T3 CCPBNNKKEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T4 DIDMNICMMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T5 KOMNPBOOGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T6 JJICPPMKADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly T7 OAOHENKGOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly T8 EDBFJNKKPBK;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x25BA910", Offset = "0x25B9710", VA = "0x1825BA910")]
	public DEKMENFBCJI(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC, T4 FPPJLFGGHIM, T5 GBLFKENMGAO, T6 FPLIGHFBGCD, T7 GPDCNGPPIBB, T8 OEMHJNGLELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x25BA1E0", Offset = "0x25B8FE0", VA = "0x1825BA1E0", Slot = "4")]
	public int CompareTo(global::DEKMENFBCJI<T1, T2, T3, T4, T5, T6, T7, T8> HNOJKNGFFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x25BA430", Offset = "0x25B9230", VA = "0x1825BA430", Slot = "0")]
	public override bool Equals(object HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x25BA5F0", Offset = "0x25B93F0", VA = "0x1825BA5F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x25BA760", Offset = "0x25B9560", VA = "0x1825BA760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T AAFFKFKIJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1822740", Offset = "0x1821540", VA = "0x181822740")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x38F9F50", Offset = "0x38F8D50", VA = "0x1838F9F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float OHKFNMEMBFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x108B080", Offset = "0x1089E80", VA = "0x18108B080")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x38FA380", Offset = "0x38F9180", VA = "0x1838FA380")]
	public T IDMFPCCIJGG(float MGEGOIPHNMM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x38F9FD0", Offset = "0x38F8DD0", VA = "0x1838F9FD0")]
	public T BELDBJKBCMF(float MGEGOIPHNMM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T ELIBCCJNKOK(T AIAIDPGGDMM, T PHPKEGMGOPM, float MGEGOIPHNMM);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x33AB9B0", Offset = "0x33AA7B0", VA = "0x1833AB9B0", Slot = "4")]
	protected override float ELIBCCJNKOK(float AIAIDPGGDMM, float PHPKEGMGOPM, float MGEGOIPHNMM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DBD0", Offset = "0x5D2C9D0", VA = "0x185D2DBD0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0xFB9FB0", Offset = "0xFB8DB0", VA = "0x180FB9FB0", Slot = "4")]
	protected override Vector3 ELIBCCJNKOK(Vector3 AIAIDPGGDMM, Vector3 PHPKEGMGOPM, float MGEGOIPHNMM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5D34640", Offset = "0x5D33440", VA = "0x185D34640")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D530", Offset = "0x5D2C330", VA = "0x185D2D530", Slot = "4")]
	protected override Color ELIBCCJNKOK(Color AIAIDPGGDMM, Color PHPKEGMGOPM, float MGEGOIPHNMM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D580", Offset = "0x5D2C380", VA = "0x185D2D580")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class JMGENFMKBJM : global::IGFGNFBNCFM<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5D2EE90", Offset = "0x5D2DC90", VA = "0x185D2EE90")]
	public JMGENFMKBJM(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5D2EEE0", Offset = "0x5D2DCE0", VA = "0x185D2EEE0")]
	public JMGENFMKBJM(BFKLEOLBFKE[] NGBKPJMNOJL, bool CJEDMAAIJEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5D2EE20", Offset = "0x5D2DC20", VA = "0x185D2EE20", Slot = "6")]
	protected override uint FAFAEFMGNCB(uint PKCNHEGJGNH, string IGJPNMBCJPK)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class DPNDFADNENP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IDisposable JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public DPNDFADNENP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct CCFKCPBJFFM
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class INLHGLENJLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public TaskCompletionSource<NOAPHGCLLPE> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public INLHGLENJLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5D2EC10", Offset = "0x5D2DA10", VA = "0x185D2EC10")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<NOAPHGCLLPE>> IKOMNHMPMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int NFHKMINGPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int ENAJEKBICDE;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0xB8EA10", Offset = "0xB8D810", VA = "0x180B8EA10")]
	private CCFKCPBJFFM(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<NOAPHGCLLPE>> GMDNKLDPALN, int IKOLEADJCBB, int IPNILBFBOEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CA40", Offset = "0x5D2B840", VA = "0x185D2CA40")]
	public static CCFKCPBJFFM MIHDEIPKAKJ()
	{
		return default(CCFKCPBJFFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C650", Offset = "0x5D2B450", VA = "0x185D2C650")]
	public (int, int, Task) DAOPLKHGKIO(int KKLMLLAHIKF, [Optional] CancellationToken GPNLCIOKAPO)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C570", Offset = "0x5D2B370", VA = "0x185D2C570")]
	public void ABLFFODOBHI(int KKLMLLAHIKF, int IPNILBFBOEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DefaultMember("Item")]
public class FCPKILMBEJN<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Dictionary<TKey, TVal> CINMFEFLEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<TVal, TKey> EOGBCNENJID;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x1674330", Offset = "0x1673130", VA = "0x181674330", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool OONDNCJIJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x65A820", Offset = "0x659620", VA = "0x18065A820", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> GNHOOAGJOGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x22845A0", Offset = "0x22833A0", VA = "0x1822845A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> BKNOINJLBPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x1E85540", Offset = "0x1E84340", VA = "0x181E85540", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x245A9E0", Offset = "0x24597E0", VA = "0x18245A9E0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x245AA10", Offset = "0x2459810", VA = "0x18245AA10", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x245A3C0", Offset = "0x24591C0", VA = "0x18245A3C0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x245A140", Offset = "0x2458F40", VA = "0x18245A140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x245A020", Offset = "0x2458E20", VA = "0x18245A020", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x245A860", Offset = "0x2459660", VA = "0x18245A860", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2459E50", Offset = "0x2458C50", VA = "0x182459E50", Slot = "9")]
	public void Add(TKey CCJNKBLKLDJ, TVal IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2459EB0", Offset = "0x2458CB0", VA = "0x182459EB0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x245A080", Offset = "0x2458E80", VA = "0x18245A080", Slot = "8")]
	public bool ContainsKey(TKey CCJNKBLKLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1E84F70", Offset = "0x1E83D70", VA = "0x181E84F70", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x245A830", Offset = "0x2459630", VA = "0x18245A830", Slot = "10")]
	public bool Remove(TKey CCJNKBLKLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x245A830", Offset = "0x2459630", VA = "0x18245A830", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1675D50", Offset = "0x1674B50", VA = "0x181675D50", Slot = "11")]
	public bool TryGetValue(TKey CCJNKBLKLDJ, out TVal IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x245A250", Offset = "0x2459050", VA = "0x18245A250", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x245A0E0", Offset = "0x2458EE0", VA = "0x18245A0E0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] DEJEDNNJILK, int AGJLGNIMOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x245A340", Offset = "0x2459140", VA = "0x18245A340")]
	public void HEFJCCLOLGO(TVal BIILFBFAAOF, TKey CCJNKBLKLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x245A380", Offset = "0x2459180", VA = "0x18245A380")]
	public void HEFJCCLOLGO(KeyValuePair<TVal, TKey> GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x245A220", Offset = "0x2459020", VA = "0x18245A220")]
	public bool GAOLFNHFINJ(TVal CCJNKBLKLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x245A1C0", Offset = "0x2458FC0", VA = "0x18245A1C0")]
	public bool FKLGFCOHCLF(KeyValuePair<TVal, TKey> GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2459DF0", Offset = "0x2458BF0", VA = "0x182459DF0")]
	public bool AKJLIPOIGHF(TVal CCJNKBLKLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2459DF0", Offset = "0x2458BF0", VA = "0x182459DF0")]
	public bool AKJLIPOIGHF(KeyValuePair<TVal, TKey> GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2459EE0", Offset = "0x2458CE0", VA = "0x182459EE0")]
	public bool CECEMJJAJEO(TVal CCJNKBLKLDJ, out TKey IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x245A480", Offset = "0x2459280", VA = "0x18245A480")]
	public IEnumerator<KeyValuePair<TVal, TKey>> MBDPPCMHIHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2459F10", Offset = "0x2458D10", VA = "0x182459F10")]
	private void CJMLMJJNOLA(TKey CCJNKBLKLDJ, TVal BIILFBFAAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2459D70", Offset = "0x2458B70", VA = "0x182459D70")]
	private void AKEMGCGHGMJ(TKey CCJNKBLKLDJ, TVal BIILFBFAAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x245A680", Offset = "0x2459480", VA = "0x18245A680")]
	private bool OMFGKOPAABL(TKey CCJNKBLKLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x245A500", Offset = "0x2459300", VA = "0x18245A500")]
	private bool OMFGKOPAABL(TVal BIILFBFAAOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x245A900", Offset = "0x2459700", VA = "0x18245A900")]
	public FCPKILMBEJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class DODFIGEAAMK<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private global::DODFIGEAAMK<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2AE02D0", Offset = "0x2ADF0D0", VA = "0x182AE02D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2AE19E0", Offset = "0x2AE07E0", VA = "0x182AE19E0")]
		public Enumerator(global::DODFIGEAAMK<T> CLABEIKAHOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC550", Offset = "0x2ADB350", VA = "0x182ADC550", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2ADDF20", Offset = "0x2ADCD20", VA = "0x182ADDF20", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2ADD2C0", Offset = "0x2ADC0C0", VA = "0x182ADD2C0")]
		private void NHMPMKJDMCI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private T[] IMPDEOOHCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int HMJFOJBNOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int FNKNJJDKBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private int JKGBPKEJAFA;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x34B4D90", Offset = "0x34B3B90", VA = "0x1834B4D90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x34B4F20", Offset = "0x34B3D20", VA = "0x1834B4F20")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x34B49F0", Offset = "0x34B37F0", VA = "0x1834B49F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x34B6680", Offset = "0x34B5480", VA = "0x1834B6680")]
	public DODFIGEAAMK(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x34B4CD0", Offset = "0x34B3AD0", VA = "0x1834B4CD0")]
	public void HEFJCCLOLGO(T MGEGOIPHNMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x34B5590", Offset = "0x34B4390", VA = "0x1834B5590")]
	public void MBOIAEPEMME(IEnumerable<T> IEJLANBMLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x34B4DD0", Offset = "0x34B3BD0", VA = "0x1834B4DD0")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x34B4740", Offset = "0x34B3540", VA = "0x1834B4740")]
	public void AFMOCBFFKLG(int KOHJDBBJEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x34B5F30", Offset = "0x34B4D30", VA = "0x1834B5F30")]
	public void NLNAGEFBDKO(int KOHJDBBJEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x34B6260", Offset = "0x34B5060", VA = "0x1834B6260")]
	public void PPKHELNFGHN(T[] DEJEDNNJILK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x34B4840", Offset = "0x34B3640", VA = "0x1834B4840")]
	public Enumerator BALJJOIEHDJ()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x34B6600", Offset = "0x34B5400", VA = "0x1834B6600", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x34B6600", Offset = "0x34B5400", VA = "0x1834B6600", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x34B5E40", Offset = "0x34B4C40", VA = "0x1834B5E40")]
	private int NKPOMEGNFJL(int AIPHGHFENPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x34B4A70", Offset = "0x34B3870", VA = "0x1834B4A70")]
	private int FNKOOOHJHLL(int AIPHGHFENPJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public class CEOPBBNBALE<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Func<Internal, External> DMOLCMIDIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<External, Internal> NKGCIMMLMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private IList<Internal> LPDILHBGHIJ;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IList<Internal> DIDGKJLMCBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x65B250", Offset = "0x65A050", VA = "0x18065B250")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6A0580", Offset = "0x69F380", VA = "0x1806A0580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool OONDNCJIJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7CA100", Offset = "0x7C8F00", VA = "0x1807CA100", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6A05E0", Offset = "0x69F3E0", VA = "0x1806A05E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public External MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x332D320", Offset = "0x332C120", VA = "0x18332D320", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x332D3C0", Offset = "0x332C1C0", VA = "0x18332D3C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x332D2C0", Offset = "0x332C0C0", VA = "0x18332D2C0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x30561A0", Offset = "0x3054FA0", VA = "0x1830561A0")]
	public CEOPBBNBALE(Func<Internal, External> DMOLCMIDIPC, Func<External, Internal> NKGCIMMLMNL, bool EFNCJMHMODB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x332CFE0", Offset = "0x332BDE0", VA = "0x18332CFE0", Slot = "6")]
	public int IndexOf(External GDCPKDNOEGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x332CC60", Offset = "0x332BA60", VA = "0x18332CC60", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x332CCC0", Offset = "0x332BAC0", VA = "0x18332CCC0", Slot = "13")]
	public bool Contains(External GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x332CD50", Offset = "0x332BB50", VA = "0x18332CD50", Slot = "14")]
	public void CopyTo(External[] DEJEDNNJILK, int AGJLGNIMOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x332CB70", Offset = "0x332B970", VA = "0x18332CB70", Slot = "11")]
	public void Add(External GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x332D0D0", Offset = "0x332BED0", VA = "0x18332D0D0", Slot = "7")]
	public void Insert(int AIPHGHFENPJ, External GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x332D230", Offset = "0x332C030", VA = "0x18332D230", Slot = "15")]
	public bool Remove(External GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x332D170", Offset = "0x332BF70", VA = "0x18332D170", Slot = "8")]
	public void RemoveAt(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x332CF70", Offset = "0x332BD70", VA = "0x18332CF70", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x198C8A0", Offset = "0x198B6A0", VA = "0x18198C8A0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class JNJFGLHJIAA<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Func<Internal, External> DMOLCMIDIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private IReadOnlyList<Internal> LPDILHBGHIJ;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<Internal> DIDGKJLMCBO
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x660AF0", Offset = "0x65F8F0", VA = "0x180660AF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool OONDNCJIJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6619E0", Offset = "0x6607E0", VA = "0x1806619E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public External MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2C4DDC0", Offset = "0x2C4CBC0", VA = "0x182C4DDC0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2C4DD60", Offset = "0x2C4CB60", VA = "0x182C4DD60", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x166AFE0", Offset = "0x1669DE0", VA = "0x18166AFE0")]
	public JNJFGLHJIAA(Func<Internal, External> DMOLCMIDIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2C4DD10", Offset = "0x2C4CB10", VA = "0x182C4DD10")]
	public JNJFGLHJIAA(IReadOnlyList<Internal> LPDILHBGHIJ, Func<Internal, External> DMOLCMIDIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2C4DAF0", Offset = "0x2C4C8F0", VA = "0x182C4DAF0")]
	public void PPKHELNFGHN(External[] DEJEDNNJILK, int AGJLGNIMOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2C4DA80", Offset = "0x2C4C880", VA = "0x182C4DA80", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1D87FF0", Offset = "0x1D86DF0", VA = "0x181D87FF0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class ENHAAEOHKMG<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IReadOnlyList<Internal> LPDILHBGHIJ;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IReadOnlyList<Internal> DIDGKJLMCBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x660AE0", Offset = "0x65F8E0", VA = "0x180660AE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool OONDNCJIJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6619E0", Offset = "0x6607E0", VA = "0x1806619E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public External MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x199A750", Offset = "0x1999550", VA = "0x18199A750", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x199A6F0", Offset = "0x19994F0", VA = "0x18199A6F0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x166AFE0", Offset = "0x1669DE0", VA = "0x18166AFE0")]
	public ENHAAEOHKMG(IReadOnlyList<Internal> LPDILHBGHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x199A3B0", Offset = "0x19991B0", VA = "0x18199A3B0")]
	public bool FKLGFCOHCLF(External GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x199A4C0", Offset = "0x19992C0", VA = "0x18199A4C0")]
	public void PPKHELNFGHN(External[] DEJEDNNJILK, int AGJLGNIMOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x199A450", Offset = "0x1999250", VA = "0x18199A450", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x198C8A0", Offset = "0x198B6A0", VA = "0x18198C8A0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class OOBIPEFEBFC
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void BOFGMCIJMOB(object[] KMLLOCJHKPB);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	protected OOBIPEFEBFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public abstract class MGFMFOPAFMH<T> : OOBIPEFEBFC
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	protected struct OOANCOEDOMG
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public enum EHMCAOLLPOA
		{
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public EHMCAOLLPOA NKICFHCCMMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T CGKOOFFNHKL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int AAEDHDPJJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly bool IFHECGMDCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	protected readonly bool BFGABEDFGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected List<T> NNOKMJLHIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<OOANCOEDOMG> HIKNIBPGCPD;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool LMPMKEPAAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2625B20", Offset = "0x2624920", VA = "0x182625B20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2625F60", Offset = "0x2624D60", VA = "0x182625F60")]
	protected MGFMFOPAFMH(bool BFGABEDFGDF, bool IFHECGMDCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2625B60", Offset = "0x2624960", VA = "0x182625B60")]
	protected bool IHANIHNJOHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2625CF0", Offset = "0x2624AF0", VA = "0x182625CF0")]
	protected void KCDLPJCFPBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2625DB0", Offset = "0x2624BB0", VA = "0x182625DB0")]
	protected void OPBGBGHEECH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x26ADB80", Offset = "0x26AC980", VA = "0x1826ADB80")]
	private static void ECHDNBIJIMA<U>(ref List<U> LPDILHBGHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x26259C0", Offset = "0x26247C0", VA = "0x1826259C0", Slot = "5")]
	public void HEFJCCLOLGO(T CGKOOFFNHKL, bool AKNODPLKBJA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2625880", Offset = "0x2624680", VA = "0x182625880", Slot = "6")]
	public void AKJLIPOIGHF(T CGKOOFFNHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2625BE0", Offset = "0x26249E0", VA = "0x182625BE0")]
	public void IIOELKEIHEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface ONAKOFCPCOE
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEFJCCLOLGO(Action CGKOOFFNHKL, bool AKNODPLKBJA = false);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKJLIPOIGHF(Action CGKOOFFNHKL);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class HOPKEKFNJGO : global::MGFMFOPAFMH<Action>, ONAKOFCPCOE
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E5D0", Offset = "0x5D2D3D0", VA = "0x185D2E5D0")]
	public HOPKEKFNJGO(bool BFGABEDFGDF = false, bool IFHECGMDCMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E3C0", Offset = "0x5D2D1C0", VA = "0x185D2E3C0")]
	public void PFJMFFOKNBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E290", Offset = "0x5D2D090", VA = "0x185D2E290", Slot = "4")]
	public override void BOFGMCIJMOB(object[] KMLLOCJHKPB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E300", Offset = "0x5D2D100", VA = "0x185D2E300")]
	public static HOPKEKFNJGO KFDPIIJCIIP(HOPKEKFNJGO FCEJCCPBICH, Action CGKOOFFNHKL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E360", Offset = "0x5D2D160", VA = "0x185D2E360")]
	public static HOPKEKFNJGO MPKLCJPFEHE(HOPKEKFNJGO FCEJCCPBICH, Action CGKOOFFNHKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface CFMDFNLANIJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEFJCCLOLGO(Action<T> CGKOOFFNHKL, bool AKNODPLKBJA = false);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKJLIPOIGHF(Action<T> CGKOOFFNHKL);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class DGLAMKJBKDM<T> : global::MGFMFOPAFMH<Action<T>>, global::CFMDFNLANIJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x1990400", Offset = "0x198F200", VA = "0x181990400")]
	public DGLAMKJBKDM(bool BFGABEDFGDF = false, bool IFHECGMDCMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x25BFCB0", Offset = "0x25BEAB0", VA = "0x1825BFCB0")]
	public void PFJMFFOKNBK(T MGEGOIPHNMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x25BE1A0", Offset = "0x25BCFA0", VA = "0x1825BE1A0", Slot = "4")]
	public override void BOFGMCIJMOB(object[] KMLLOCJHKPB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x25BFB70", Offset = "0x25BE970", VA = "0x1825BFB70")]
	public static global::DGLAMKJBKDM<T> KFDPIIJCIIP(global::DGLAMKJBKDM<T> FCEJCCPBICH, Action<T> CGKOOFFNHKL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x25BFC10", Offset = "0x25BEA10", VA = "0x1825BFC10")]
	public static global::DGLAMKJBKDM<T> MPKLCJPFEHE(global::DGLAMKJBKDM<T> FCEJCCPBICH, Action<T> CGKOOFFNHKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface CNLDHNPGIHO<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEFJCCLOLGO(Action<T, U> CGKOOFFNHKL, bool AKNODPLKBJA = false);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKJLIPOIGHF(Action<T, U> CGKOOFFNHKL);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class LLCCCNFJKCL<T, U> : global::MGFMFOPAFMH<Action<T, U>>, global::CNLDHNPGIHO<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x1990400", Offset = "0x198F200", VA = "0x181990400")]
	public LLCCCNFJKCL(bool BFGABEDFGDF = false, bool IFHECGMDCMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x2CF5150", Offset = "0x2CF3F50", VA = "0x182CF5150")]
	public void PFJMFFOKNBK(T MGEGOIPHNMM, U NDFNJFAPKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x2CF26F0", Offset = "0x2CF14F0", VA = "0x182CF26F0", Slot = "4")]
	public override void BOFGMCIJMOB(object[] KMLLOCJHKPB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2CF4050", Offset = "0x2CF2E50", VA = "0x182CF4050")]
	public static global::LLCCCNFJKCL<T, U> KFDPIIJCIIP(global::LLCCCNFJKCL<T, U> FCEJCCPBICH, Action<T, U> CGKOOFFNHKL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2CF40F0", Offset = "0x2CF2EF0", VA = "0x182CF40F0")]
	public static global::LLCCCNFJKCL<T, U> MPKLCJPFEHE(global::LLCCCNFJKCL<T, U> FCEJCCPBICH, Action<T, U> CGKOOFFNHKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface ABAIGLNNAKP<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEFJCCLOLGO(Action<T, U, V> CGKOOFFNHKL, bool AKNODPLKBJA = false);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKJLIPOIGHF(Action<T, U, V> CGKOOFFNHKL);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class EJCHHEKFLCK<T, U, V> : global::MGFMFOPAFMH<Action<T, U, V>>, global::ABAIGLNNAKP<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x1990400", Offset = "0x198F200", VA = "0x181990400")]
	public EJCHHEKFLCK(bool BFGABEDFGDF = false, bool IFHECGMDCMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x198F240", Offset = "0x198E040", VA = "0x18198F240")]
	public void PFJMFFOKNBK(T MGEGOIPHNMM, U NDFNJFAPKCG, V HFMHCLGICNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x198DC60", Offset = "0x198CA60", VA = "0x18198DC60", Slot = "4")]
	public override void BOFGMCIJMOB(object[] KMLLOCJHKPB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x198E4B0", Offset = "0x198D2B0", VA = "0x18198E4B0")]
	public static global::EJCHHEKFLCK<T, U, V> KFDPIIJCIIP(global::EJCHHEKFLCK<T, U, V> FCEJCCPBICH, Action<T, U, V> CGKOOFFNHKL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x198E550", Offset = "0x198D350", VA = "0x18198E550")]
	public static global::EJCHHEKFLCK<T, U, V> MPKLCJPFEHE(global::EJCHHEKFLCK<T, U, V> FCEJCCPBICH, Action<T, U, V> CGKOOFFNHKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface HMHLANANKLE<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEFJCCLOLGO(Action<T, U, V, W> CGKOOFFNHKL, bool AKNODPLKBJA = false);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKJLIPOIGHF(Action<T, U, V, W> CGKOOFFNHKL);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class BPHJINJDCNI<T, U, V, W> : global::MGFMFOPAFMH<Action<T, U, V, W>>, global::HMHLANANKLE<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x1990400", Offset = "0x198F200", VA = "0x181990400")]
	public BPHJINJDCNI(bool BFGABEDFGDF = false, bool IFHECGMDCMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x1D82290", Offset = "0x1D81090", VA = "0x181D82290")]
	public void PFJMFFOKNBK(T MGEGOIPHNMM, U NDFNJFAPKCG, V HFMHCLGICNJ, W KKGHEBDDELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x1D7FA50", Offset = "0x1D7E850", VA = "0x181D7FA50", Slot = "4")]
	public override void BOFGMCIJMOB(object[] KMLLOCJHKPB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x1D80EC0", Offset = "0x1D7FCC0", VA = "0x181D80EC0")]
	public static global::BPHJINJDCNI<T, U, V, W> KFDPIIJCIIP(global::BPHJINJDCNI<T, U, V, W> FCEJCCPBICH, Action<T, U, V, W> CGKOOFFNHKL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x1D80F60", Offset = "0x1D7FD60", VA = "0x181D80F60")]
	public static global::BPHJINJDCNI<T, U, V, W> MPKLCJPFEHE(global::BPHJINJDCNI<T, U, V, W> FCEJCCPBICH, Action<T, U, V, W> CGKOOFFNHKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface IMJNHIOLGDG<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEFJCCLOLGO(Action<T, U, V, W, X> CGKOOFFNHKL, bool AKNODPLKBJA = false);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKJLIPOIGHF(Action<T, U, V, W, X> CGKOOFFNHKL);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class FLKKAPMNAPH<T, U, V, W, X> : global::MGFMFOPAFMH<Action<T, U, V, W, X>>, global::IMJNHIOLGDG<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x1990400", Offset = "0x198F200", VA = "0x181990400")]
	public FLKKAPMNAPH(bool BFGABEDFGDF = false, bool IFHECGMDCMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x252C200", Offset = "0x252B000", VA = "0x18252C200")]
	public void PFJMFFOKNBK(T MGEGOIPHNMM, U NDFNJFAPKCG, V HFMHCLGICNJ, W KKGHEBDDELA, X KNMKEOOODCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x252BDD0", Offset = "0x252ABD0", VA = "0x18252BDD0", Slot = "4")]
	public override void BOFGMCIJMOB(object[] KMLLOCJHKPB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x252C0C0", Offset = "0x252AEC0", VA = "0x18252C0C0")]
	public static global::FLKKAPMNAPH<T, U, V, W, X> KFDPIIJCIIP(global::FLKKAPMNAPH<T, U, V, W, X> FCEJCCPBICH, Action<T, U, V, W, X> CGKOOFFNHKL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x252C160", Offset = "0x252AF60", VA = "0x18252C160")]
	public static global::FLKKAPMNAPH<T, U, V, W, X> MPKLCJPFEHE(global::FLKKAPMNAPH<T, U, V, W, X> FCEJCCPBICH, Action<T, U, V, W, X> CGKOOFFNHKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface MCJFKKBBPGI<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEFJCCLOLGO(Action<T, U, V, W, X, Y> CGKOOFFNHKL, bool AKNODPLKBJA = false);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKJLIPOIGHF(Action<T, U, V, W, X, Y> CGKOOFFNHKL);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class BJEBAFPKEPO<T, U, V, W, X, Y> : global::MGFMFOPAFMH<Action<T, U, V, W, X, Y>>, global::MCJFKKBBPGI<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x1990400", Offset = "0x198F200", VA = "0x181990400")]
	public BJEBAFPKEPO(bool BFGABEDFGDF = false, bool IFHECGMDCMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x23B2E50", Offset = "0x23B1C50", VA = "0x1823B2E50")]
	public void PFJMFFOKNBK(T MGEGOIPHNMM, U NDFNJFAPKCG, V HFMHCLGICNJ, W KKGHEBDDELA, X KNMKEOOODCL, Y EMKKILCIAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x23B29D0", Offset = "0x23B17D0", VA = "0x1823B29D0", Slot = "4")]
	public override void BOFGMCIJMOB(object[] KMLLOCJHKPB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x23B2D10", Offset = "0x23B1B10", VA = "0x1823B2D10")]
	public static global::BJEBAFPKEPO<T, U, V, W, X, Y> KFDPIIJCIIP(global::BJEBAFPKEPO<T, U, V, W, X, Y> FCEJCCPBICH, Action<T, U, V, W, X, Y> CGKOOFFNHKL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x23B2DB0", Offset = "0x23B1BB0", VA = "0x1823B2DB0")]
	public static global::BJEBAFPKEPO<T, U, V, W, X, Y> MPKLCJPFEHE(global::BJEBAFPKEPO<T, U, V, W, X, Y> FCEJCCPBICH, Action<T, U, V, W, X, Y> CGKOOFFNHKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class DPDBANLLCHB<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct APJLHEHHPLO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly global::DPDBANLLCHB<T> PLEIMFNANHP;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public T AAFFKFKIJDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x2293A10", Offset = "0x2292810", VA = "0x182293A10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x22939E0", Offset = "0x22927E0", VA = "0x1822939E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x74C1F0", Offset = "0x74AFF0", VA = "0x18074C1F0")]
		public APJLHEHHPLO(global::DPDBANLLCHB<T> PLEIMFNANHP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct ADIDHHDFJJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<APJLHEHHPLO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public global::DPDBANLLCHB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2272F20", Offset = "0x2271D20", VA = "0x182272F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x1EB9FF0", Offset = "0x1EB8DF0", VA = "0x181EB9FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct BJCCDIFFBIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder<APJLHEHHPLO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public global::DPDBANLLCHB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x23B2160", Offset = "0x23B0F60", VA = "0x1823B2160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x1EB9FF0", Offset = "0x1EB8DF0", VA = "0x181EB9FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly SemaphoreSlim JHOIDJHANMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private T ADCLMADMKEO;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int KGOAEFBEDMO
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x34B6720", Offset = "0x34B5520", VA = "0x1834B6720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x34B6D90", Offset = "0x34B5B90", VA = "0x1834B6D90")]
	public DPDBANLLCHB(in T ADCLMADMKEO, int EOLLBDABFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x34B6D60", Offset = "0x34B5B60", VA = "0x1834B6D60")]
	public DPDBANLLCHB(in T ADCLMADMKEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x34B6D20", Offset = "0x34B5B20", VA = "0x1834B6D20")]
	public APJLHEHHPLO KNHOBDNOPAG()
	{
		return default(APJLHEHHPLO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x34B6CE0", Offset = "0x34B5AE0", VA = "0x1834B6CE0")]
	public APJLHEHHPLO KNHOBDNOPAG(CancellationToken GPNLCIOKAPO)
	{
		return default(APJLHEHHPLO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x34B6B80", Offset = "0x34B5980", VA = "0x1834B6B80")]
	[AsyncStateMachine(typeof(global::DPDBANLLCHB<>.ADIDHHDFJJE))]
	public Task<APJLHEHHPLO> JILDGGEHMAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x34B68A0", Offset = "0x34B56A0", VA = "0x1834B68A0")]
	[AsyncStateMachine(typeof(global::DPDBANLLCHB<>.BJCCDIFFBIJ))]
	public Task<APJLHEHHPLO> JILDGGEHMAG(CancellationToken GPNLCIOKAPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class NNFMNCGNJLP
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5D30170", Offset = "0x5D2EF70", VA = "0x185D30170")]
	public static global::DPDBANLLCHB<NOAPHGCLLPE> MIHDEIPKAKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5D301D0", Offset = "0x5D2EFD0", VA = "0x185D301D0")]
	public static global::DPDBANLLCHB<NOAPHGCLLPE> MIHDEIPKAKJ(int EOLLBDABFNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x1F89860", Offset = "0x1F88660", VA = "0x181F89860")]
	public static global::DPDBANLLCHB<T> MIHDEIPKAKJ<T>(in T ADCLMADMKEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2229350", Offset = "0x2228150", VA = "0x182229350")]
	public static global::DPDBANLLCHB<T> MIHDEIPKAKJ<T>(in T ADCLMADMKEO, int EOLLBDABFNE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class DNBNOMMLHDF<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public delegate Task<TResult> CCGPMIENEGA(TRequest NMKJPBEONAN, CancellationToken GPNLCIOKAPO);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum PMNMEDJOCHC
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class HEACGNJJANC
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private const float BANILBHLOJA = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TimeSpan GHGEDEHCCGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int MMMALNMGACC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public PMNMEDJOCHC BDHDDJIANPB;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly HEACGNJJANC FOBBLKPOGAD;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float OBDDMCCEBCE
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x27D4370", Offset = "0x27D3170", VA = "0x1827D4370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan HMADCCDOBKA
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x27D4450", Offset = "0x27D3250", VA = "0x1827D4450")]
		public HEACGNJJANC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private readonly struct MKIDIHDKCME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly TRequest NMKJPBEONAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly CancellationToken GPNLCIOKAPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly TaskCompletionSource<TResult> LHCEGKDLLFP;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x262E5B0", Offset = "0x262D3B0", VA = "0x18262E5B0")]
		public MKIDIHDKCME(TRequest NMKJPBEONAN, TaskCompletionSource<TResult> LHCEGKDLLFP, CancellationToken GPNLCIOKAPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class IIPKFMMJLMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
		public IIPKFMMJLMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x1674330", Offset = "0x1673130", VA = "0x181674330")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct BNGJMLIDHKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public global::DNBNOMMLHDF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x23C59A0", Offset = "0x23C47A0", VA = "0x1823C59A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct OACBKAOOALJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::DNBNOMMLHDF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private MKIDIHDKCME <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2E448F0", Offset = "0x2E436F0", VA = "0x182E448F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CancellationTokenSource CAFLMMKDADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<MKIDIHDKCME> OHAAAOMNODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly HEACGNJJANC FDDPIIDBENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly CCGPMIENEGA GCFALEHIFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Task LDMGDIIOMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int MNPGHNDKJHI;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x34AA440", Offset = "0x34A9240", VA = "0x1834AA440")]
	public DNBNOMMLHDF(CCGPMIENEGA GCFALEHIFLC, [Optional] HEACGNJJANC FDDPIIDBENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x34A9610", Offset = "0x34A8410", VA = "0x1834A9610")]
	public Task<TResult> MALNAJHIBFG(TRequest NMKJPBEONAN, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x34A8A50", Offset = "0x34A7850", VA = "0x1834A8A50")]
	private void ACDFKBIFHGN(MKIDIHDKCME CJGJCKBAIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x34A9D20", Offset = "0x34A8B20", VA = "0x1834A9D20")]
	[AsyncStateMachine(typeof(global::DNBNOMMLHDF<, >.BNGJMLIDHKL))]
	private Task MCEBBCLHLJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x34A93C0", Offset = "0x34A81C0", VA = "0x1834A93C0")]
	private MKIDIHDKCME ICCBDBEBDBJ()
	{
		return default(MKIDIHDKCME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x34A8DF0", Offset = "0x34A7BF0", VA = "0x1834A8DF0")]
	[AsyncStateMachine(typeof(global::DNBNOMMLHDF<, >.OACBKAOOALJ))]
	private Task GFCGGNHPJCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x34AA1C0", Offset = "0x34A8FC0", VA = "0x1834AA1C0")]
	private void OGJLEIEFKOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x34A8B70", Offset = "0x34A7970", VA = "0x1834A8B70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class BCJGEIEPHMJ<TKey, TVal> : global::NBIICPFMMDD<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int KJIILFOGNGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	internal Dictionary<TKey, (TVal value, int size)> EDLCOEKGMOH;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal override int FMNPGKADBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x4224420", Offset = "0x4223220", VA = "0x184224420", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int OACNGCDEPNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x42243F0", Offset = "0x42231F0", VA = "0x1842243F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x42244F0", Offset = "0x42232F0", VA = "0x1842244F0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x4224A00", Offset = "0x4223800", VA = "0x184224A00")]
	public BCJGEIEPHMJ(int CHMDLBBFMNF, [Optional] POIMLJHIOIB BGOKELNJCKK, [Optional] IEqualityComparer<TKey> EMOGODJCHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x4224450", Offset = "0x4223250", VA = "0x184224450")]
	public void HLAPECFMGBJ(TKey CCJNKBLKLDJ, TVal IGJPNMBCJPK, bool AFFICNKLOAK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x42245C0", Offset = "0x42233C0", VA = "0x1842245C0")]
	public bool JGFCJGCMJIK(TKey CCJNKBLKLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x4224350", Offset = "0x4223150", VA = "0x184224350", Slot = "6")]
	public override bool CECEMJJAJEO(TKey ANHJHIFLNAP, out TVal IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x42246E0", Offset = "0x42234E0", VA = "0x1842246E0")]
	public bool KJCKEGMFBCA(TKey CCJNKBLKLDJ, TVal IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x42248F0", Offset = "0x42236F0", VA = "0x1842248F0")]
	public bool PNCCILMHKNM(TKey CCJNKBLKLDJ, TVal IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x4224550", Offset = "0x4223350", VA = "0x184224550", Slot = "7")]
	public override void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x4224640", Offset = "0x4223440", VA = "0x184224640")]
	private bool JPMBNFDOCMI(TKey CCJNKBLKLDJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DefaultMember("Item")]
public class NBIICPFMMDD<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public delegate int POIMLJHIOIB(TKey CCJNKBLKLDJ, TVal IGJPNMBCJPK);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class LOHNIHEMMIG
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public TKey HJHOJEFKDAH
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xAC10F0", Offset = "0xABFEF0", VA = "0x180AC10F0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public TVal AAFFKFKIJDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x65B250", Offset = "0x65A050", VA = "0x18065B250")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x6A0580", Offset = "0x69F380", VA = "0x1806A0580")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int PANMOHPAPDK
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x662B90", Offset = "0x661990", VA = "0x180662B90")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x870F80", Offset = "0x86FD80", VA = "0x180870F80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public DateTime EBOIDOANILN
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x657000", Offset = "0x655E00", VA = "0x180657000")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xBB0550", Offset = "0xBAF350", VA = "0x180BB0550")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2D67340", Offset = "0x2D66140", VA = "0x182D67340")]
		public LOHNIHEMMIG(TKey CCJNKBLKLDJ, TVal BIILFBFAAOF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const int JHFGACAIMJP = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly Dictionary<TKey, LinkedListNode<LOHNIHEMMIG>> JNNBOBKGBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly LinkedList<LOHNIHEMMIG> KNKOFIHPGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	protected readonly POIMLJHIOIB BGOKELNJCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly TimeSpan LMANHNCHJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly PCCFJFHBKMO BODBBFPNIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int HNBJFLIKECB;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int KEHBMLJLDDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7B2080", Offset = "0x7B0E80", VA = "0x1807B2080")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool ODLPIEENENN
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x1E93340", Offset = "0x1E92140", VA = "0x181E93340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal virtual int FMNPGKADBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7B2090", Offset = "0x7B0E90", VA = "0x1807B2090", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private int KOHJDBBJEKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x1D2FFB0", Offset = "0x1D2EDB0", VA = "0x181D2FFB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x197D360", Offset = "0x197C160", VA = "0x18197D360", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<TKey> GNHOOAGJOGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x1E92E00", Offset = "0x1E91C00", VA = "0x181E92E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public TVal MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x1E94B20", Offset = "0x1E93920", VA = "0x181E94B20")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x1E93950", Offset = "0x1E92750", VA = "0x181E93950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x1E95F00", Offset = "0x1E94D00", VA = "0x181E95F00")]
	public NBIICPFMMDD(int CHMDLBBFMNF, [Optional] POIMLJHIOIB BGOKELNJCKK, [Optional] IEqualityComparer<TKey> EMOGODJCHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x1E95D10", Offset = "0x1E94B10", VA = "0x181E95D10")]
	public NBIICPFMMDD(TimeSpan LMANHNCHJCA, [Optional] IEqualityComparer<TKey> EMOGODJCHKN, [Optional] PCCFJFHBKMO BODBBFPNIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x1E95BF0", Offset = "0x1E949F0", VA = "0x181E95BF0")]
	public NBIICPFMMDD(int CHMDLBBFMNF, TimeSpan LMANHNCHJCA, [Optional] IEqualityComparer<TKey> EMOGODJCHKN, [Optional] PCCFJFHBKMO BODBBFPNIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x1E95970", Offset = "0x1E94770", VA = "0x181E95970")]
	public NBIICPFMMDD(int CHMDLBBFMNF, POIMLJHIOIB BGOKELNJCKK, TimeSpan LMANHNCHJCA, [Optional] IEqualityComparer<TKey> EMOGODJCHKN, [Optional] PCCFJFHBKMO BODBBFPNIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x1E95360", Offset = "0x1E94160", VA = "0x181E95360")]
	public void PGHLLDMAKON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x1E95710", Offset = "0x1E94510", VA = "0x181E95710")]
	public void PIGMJENILDA(TKey CCJNKBLKLDJ, TVal IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x1E92C90", Offset = "0x1E91A90", VA = "0x181E92C90")]
	public bool AKJLIPOIGHF(TKey CCJNKBLKLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x1E931B0", Offset = "0x1E91FB0", VA = "0x181E931B0")]
	private TVal BOPAOPJOHPG(TKey ANHJHIFLNAP)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x1E93680", Offset = "0x1E92480", VA = "0x181E93680", Slot = "6")]
	public virtual bool CECEMJJAJEO(TKey ANHJHIFLNAP, out TVal IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x1E94170", Offset = "0x1E92F70", VA = "0x181E94170", Slot = "7")]
	public virtual void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x1E92850", Offset = "0x1E91650", VA = "0x181E92850")]
	private bool AFAPCIEDBMB(LOHNIHEMMIG NJLMIMMKHOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x1E94660", Offset = "0x1E93460", VA = "0x181E94660")]
	private void JOOPJAFPNIA(LinkedListNode<LOHNIHEMMIG> JEJKKAMKIIN, TVal LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x1E93F70", Offset = "0x1E92D70", VA = "0x181E93F70")]
	private void FEJCNECMMHF(TKey CCJNKBLKLDJ, TVal IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x1E94D00", Offset = "0x1E93B00", VA = "0x181E94D00")]
	private void NBJCGENJGBF(LOHNIHEMMIG NJLMIMMKHOC, TVal LNHLJHKJGFH, int EPOAMOEJPAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[DefaultMember("Item")]
public class LOFDAGFECGJ<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly List<T> LPDILHBGHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private HashSet<T> FOJHKDGAOEE;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x1674330", Offset = "0x1673130", VA = "0x181674330", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool OONDNCJIJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x65A820", Offset = "0x659620", VA = "0x18065A820", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x23B1180", Offset = "0x23AFF80", VA = "0x1823B1180", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2D66770", Offset = "0x2D65570", VA = "0x182D66770", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x262EFE0", Offset = "0x262DDE0", VA = "0x18262EFE0", Slot = "11")]
	public void Add(T GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x2D66030", Offset = "0x2D64E30", VA = "0x182D66030")]
	public bool LHAEMCGIOMO(T GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x2D66550", Offset = "0x2D65350", VA = "0x182D66550", Slot = "15")]
	public bool Remove(T GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x25B6A00", Offset = "0x25B5800", VA = "0x1825B6A00", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x22939B0", Offset = "0x22927B0", VA = "0x1822939B0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x2D65E10", Offset = "0x2D64C10", VA = "0x182D65E10", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB490", Offset = "0x2CEA290", VA = "0x182CEB490", Slot = "13")]
	public bool Contains(T GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2D65E70", Offset = "0x2D64C70", VA = "0x182D65E70", Slot = "14")]
	public void CopyTo(T[] DEJEDNNJILK, int AGJLGNIMOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x245A9E0", Offset = "0x24597E0", VA = "0x18245A9E0", Slot = "6")]
	public int IndexOf(T GDCPKDNOEGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x2D65EA0", Offset = "0x2D64CA0", VA = "0x182D65EA0", Slot = "7")]
	public void Insert(int AIPHGHFENPJ, T GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x2D66320", Offset = "0x2D65120", VA = "0x182D66320", Slot = "8")]
	public void RemoveAt(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x2D66250", Offset = "0x2D65050", VA = "0x182D66250")]
	public void PLJGJCHOOLO(Predicate<T> ADBPGLEFIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x2D65DE0", Offset = "0x2D64BE0", VA = "0x182D65DE0")]
	public void CLOFDOFJEEC(Comparison<T> JDKEEHIDKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x2D665D0", Offset = "0x2D653D0", VA = "0x182D665D0")]
	public LOFDAGFECGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class DOHOJBEKMME
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D700", Offset = "0x5D2C500", VA = "0x185D2D700")]
	public static Vector3 ELCAFCGEPFL(this GameObject BFJMKCMPBKG, float JJHKDMNGMBB)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x2C84A70", Offset = "0x2C83870", VA = "0x182C84A70")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5D33C20", Offset = "0x5D32A20", VA = "0x185D33C20")]
		public SerializedGuid(in Guid AJPBBJHOAOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x5D33A20", Offset = "0x5D32820", VA = "0x185D33A20")]
		public static SerializedGuid FLDLPLFNNMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x5D33AC0", Offset = "0x5D328C0", VA = "0x185D33AC0")]
		public static SerializedGuid OEHONHADFCL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x5D33800", Offset = "0x5D32600", VA = "0x185D33800")]
		public bool EFLLLAPDHEA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x5D33BF0", Offset = "0x5D329F0", VA = "0x185D33BF0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5D33B50", Offset = "0x5D32950", VA = "0x185D33B50", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x5D33740", Offset = "0x5D32540", VA = "0x185D33740")]
		public bool CHHJCFLIPIC(in Guid AJPBBJHOAOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5D33890", Offset = "0x5D32690", VA = "0x185D33890", Slot = "7")]
		public bool Equals(SerializedGuid HNOJKNGFFBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5D33940", Offset = "0x5D32740", VA = "0x185D33940", Slot = "0")]
		public override bool Equals(object CCPIHKCBGHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x5D33AB0", Offset = "0x5D328B0", VA = "0x185D33AB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5D337D0", Offset = "0x5D325D0", VA = "0x185D337D0", Slot = "6")]
		public int CompareTo(SerializedGuid HNOJKNGFFBE)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class AAOLBCDGNHK : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly Type DJCNMDPDNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly string JGOBLMIOMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly bool APGEFJPOLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool GHFDBCMAFOA;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A980", Offset = "0x5D29780", VA = "0x185D2A980")]
	public AAOLBCDGNHK(Type ICHCDGFAFMA, string HCNFPHKIIJH, bool LPNDFHNCPIB = false, bool CHEHHFOPIMA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface GGKDNJONGAA
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface NEKADIDIOHG<T> : GGKDNJONGAA
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	T AAFFKFKIJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool MALHPKIFHPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string NJKGPGIFKGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::NEKADIDIOHG<T> JBPBOAEOEMF(Action<T> HIHPGOGCEJL);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::NEKADIDIOHG<T> APDPJHBKMKP(Action<T> HIHPGOGCEJL);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::NEKADIDIOHG<T> DENKJFAEPEK(Action<T, T> IHKABJJNGEE);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::NEKADIDIOHG<T> IKOPNAELIMN(Action<T, T> IHKABJJNGEE);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::NEKADIDIOHG<T> GDMPJHEDNBP(Action<string> BNGCFDGNMDH);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::NEKADIDIOHG<T> DGIDOPJGBJE(Action<string> BNGCFDGNMDH);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class OOEBJBEKEBF<T> : global::NEKADIDIOHG<T>, GGKDNJONGAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private global::LLCCCNFJKCL<T, T> AEPJFCKEHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private global::DGLAMKJBKDM<T> ADAEIGHIDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private global::DGLAMKJBKDM<string> OKNKNACBOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private string EGNBEILEKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private T BBLJKOEKFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool DLJPMLMHNBJ;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public T AAFFKFKIJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x657000", Offset = "0x655E00", VA = "0x180657000", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x230E600", Offset = "0x230D400", VA = "0x18230E600", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool MALHPKIFHPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6B19C0", Offset = "0x6B07C0", VA = "0x1806B19C0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string NJKGPGIFKGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x65B270", Offset = "0x65A070", VA = "0x18065B270", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xD66150", Offset = "0xD64F50", VA = "0x180D66150", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x2CC84F0", Offset = "0x2CC72F0", VA = "0x182CC84F0")]
	private void OOGPKFNOLPA(T DEHKKADBBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x2CC8100", Offset = "0x2CC6F00", VA = "0x182CC8100")]
	private void AIEKGKBOABF(string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x2CC82C0", Offset = "0x2CC70C0", VA = "0x182CC82C0")]
	public void EJCGBCFCFCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x2CC8200", Offset = "0x2CC7000", VA = "0x182CC8200", Slot = "6")]
	public global::NEKADIDIOHG<T> DENKJFAEPEK(Action<T, T> IHKABJJNGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x2CC8410", Offset = "0x2CC7210", VA = "0x182CC8410", Slot = "7")]
	public global::NEKADIDIOHG<T> IKOPNAELIMN(Action<T, T> IHKABJJNGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x2CC8460", Offset = "0x2CC7260", VA = "0x182CC8460", Slot = "4")]
	public global::NEKADIDIOHG<T> JBPBOAEOEMF(Action<T> IHKABJJNGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x2CC81B0", Offset = "0x2CC6FB0", VA = "0x182CC81B0", Slot = "5")]
	public global::NEKADIDIOHG<T> APDPJHBKMKP(Action<T> HIHPGOGCEJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x2CC8370", Offset = "0x2CC7170", VA = "0x182CC8370", Slot = "8")]
	public global::NEKADIDIOHG<T> GDMPJHEDNBP(Action<string> BNGCFDGNMDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x2CC8250", Offset = "0x2CC7050", VA = "0x182CC8250", Slot = "9")]
	public global::NEKADIDIOHG<T> DGIDOPJGBJE(Action<string> BNGCFDGNMDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x2CC8590", Offset = "0x2CC7390", VA = "0x182CC8590")]
	public OOEBJBEKEBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class PKHJJPNIHOD
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class CKJNKICDCCO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public global::NEKADIDIOHG<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public global::BCJEBPCHCFD<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
		public CKJNKICDCCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x24BFC80", Offset = "0x24BEA80", VA = "0x1824BFC80")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x2F78F40", Offset = "0x2F77D40", VA = "0x182F78F40")]
	public static global::DGCAEBAFOOK<T> FMDMOKNGPIL<T>(this global::NEKADIDIOHG<T> EOLICAHLJJG, Action<T> GKAOJENLDLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class EHGJMLLEIHA<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public readonly struct LFINMJIEICI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly long AGIHFJLDMFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly long PBJEENCKMAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly int CJNKPBOCJNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int KAILDPGMOAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly bool BMAOLOJDNEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string AJPJIDCOHMD;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x2CE2A80", Offset = "0x2CE1880", VA = "0x182CE2A80")]
		public LFINMJIEICI(long AGIHFJLDMFB, int CJNKPBOCJNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x2CE2AF0", Offset = "0x2CE18F0", VA = "0x182CE2AF0")]
		public LFINMJIEICI(long AGIHFJLDMFB, long PBJEENCKMAH, int CJNKPBOCJNJ, int KAILDPGMOAM, bool BMAOLOJDNEG, string AJPJIDCOHMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x2CE28F0", Offset = "0x2CE16F0", VA = "0x182CE28F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void EDOKCIEOOKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2CE28A0", Offset = "0x2CE16A0", VA = "0x182CE28A0")]
		public int BPCLJBHHMED()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x2CE2A60", Offset = "0x2CE1860", VA = "0x182CE2A60")]
		public int PFOGOHBEGDD(int OOHJFEOAEOL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x2CE2960", Offset = "0x2CE1760", VA = "0x182CE2960")]
		public double INNDPLNJJCH()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2CE29D0", Offset = "0x2CE17D0", VA = "0x182CE29D0")]
		public LFINMJIEICI IOELEPDGGOO(long PBJEENCKMAH, int KAILDPGMOAM)
		{
			return default(LFINMJIEICI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class GEKJCIHAMFL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly TKey HJHOJEFKDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly global::EHGJMLLEIHA<TKey> APDIGEDLLAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<GEKJCIHAMFL> AMLJFCALPFI;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string HIHDLOMCAOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x16763F0", Offset = "0x16751F0", VA = "0x1816763F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x21C7BD0", Offset = "0x21C69D0", VA = "0x1821C7BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public IEnumerable<GEKJCIHAMFL> NEAKJMIFMMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x21C7D10", Offset = "0x21C6B10", VA = "0x1821C7D10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public LFINMJIEICI CNMCDLACFBF
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x139AB10", Offset = "0x1399910", VA = "0x18139AB10")]
			[CompilerGenerated]
			get
			{
				return default(LFINMJIEICI);
			}
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x21C7D30", Offset = "0x21C6B30", VA = "0x1821C7D30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x21C7D60", Offset = "0x21C6B60", VA = "0x1821C7D60")]
		internal GEKJCIHAMFL(global::EHGJMLLEIHA<TKey> APDIGEDLLAL, TKey CCJNKBLKLDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x21C7C00", Offset = "0x21C6A00", VA = "0x1821C7C00")]
		public GEKJCIHAMFL NHEGBMPLEGG(TKey CCJNKBLKLDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x21C7940", Offset = "0x21C6740", VA = "0x1821C7940")]
		public void BAJMMIABKCA(TKey CCJNKBLKLDJ, Action<GEKJCIHAMFL> CGKOOFFNHKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x26A2510", Offset = "0x26A1310", VA = "0x1826A2510")]
		public T BAJMMIABKCA<T>(TKey CCJNKBLKLDJ, Func<GEKJCIHAMFL, T> LKLJLJNAKDG)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x26A2600", Offset = "0x26A1400", VA = "0x1826A2600")]
		[AsyncStateMachine(typeof(EJENFOAEIOD))]
		public Task<T> NOOHLLGCOBD<T>(TKey CCJNKBLKLDJ, Func<GEKJCIHAMFL, Task<T>> LKLJLJNAKDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x21C7A20", Offset = "0x21C6820", VA = "0x1821C7A20", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class DLLOOAPEIBA : IEnumerable<(TKey, List<TKey>, LFINMJIEICI)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LFINMJIEICI)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private (TKey key, List<TKey> path, LFINMJIEICI timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::EHGJMLLEIHA<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private IEnumerator<(TKey key, List<TKey> path, LFINMJIEICI timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private (TKey, List<TKey>, LFINMJIEICI) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x2A7DA70", Offset = "0x2A7C870", VA = "0x182A7DA70", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LFINMJIEICI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x455AF70", Offset = "0x4559D70", VA = "0x18455AF70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DE00", Offset = "0x2A7CC00", VA = "0x182A7DE00")]
		[DebuggerHidden]
		public DLLOOAPEIBA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x166B3B0", Offset = "0x166A1B0", VA = "0x18166B3B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x455AAF0", Offset = "0x45598F0", VA = "0x18455AAF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x455AFD0", Offset = "0x4559DD0", VA = "0x18455AFD0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x455AF30", Offset = "0x4559D30", VA = "0x18455AF30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x455AE70", Offset = "0x4559C70", VA = "0x18455AE70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LFINMJIEICI)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x1D320A0", Offset = "0x1D30EA0", VA = "0x181D320A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class LOFFOJBNFOB : IEnumerable<(TKey, List<TKey>, LFINMJIEICI)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LFINMJIEICI)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private (TKey key, List<TKey> path, LFINMJIEICI timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private GEKJCIHAMFL timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public GEKJCIHAMFL <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public global::EHGJMLLEIHA<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private IEnumerator<GEKJCIHAMFL> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private IEnumerator<(TKey key, List<TKey> path, LFINMJIEICI timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private (TKey, List<TKey>, LFINMJIEICI) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x2A7DA70", Offset = "0x2A7C870", VA = "0x182A7DA70", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LFINMJIEICI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x2D66F20", Offset = "0x2D65D20", VA = "0x182D66F20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DE00", Offset = "0x2A7CC00", VA = "0x182A7DE00")]
		[DebuggerHidden]
		public LOFFOJBNFOB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x2D66F80", Offset = "0x2D65D80", VA = "0x182D66F80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x2D66830", Offset = "0x2D65630", VA = "0x182D66830", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x2D67020", Offset = "0x2D65E20", VA = "0x182D67020")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x2D67080", Offset = "0x2D65E80", VA = "0x182D67080")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2D66EE0", Offset = "0x2D65CE0", VA = "0x182D66EE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x2D66DD0", Offset = "0x2D65BD0", VA = "0x182D66DD0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LFINMJIEICI)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x2D66EB0", Offset = "0x2D65CB0", VA = "0x182D66EB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TKey, LFINMJIEICI> LMGGKKPJMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Action<TKey, LFINMJIEICI> CNJHAMHHDFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Action<global::EHGJMLLEIHA<TKey>> JILJHJDEKCH;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private const string CGMPNCIHIFE = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly GEKJCIHAMFL IGCFMLEOBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool DGKCCECAGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int BMHJFGCKOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Stopwatch DCONEIAFJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly int PLBBBLPILNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private string FILMLELMLNC;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public GEKJCIHAMFL MJDNIFGIJDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x65B270", Offset = "0x65A070", VA = "0x18065B270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	public string HIHDLOMCAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6570F0", Offset = "0x655EF0", VA = "0x1806570F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x1987520", Offset = "0x1986320", VA = "0x181987520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public long FPEHLJJEBOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x1987500", Offset = "0x1986300", VA = "0x181987500")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int KCPCEIPPBPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x1987580", Offset = "0x1986380", VA = "0x181987580")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x1987730", Offset = "0x1986530", VA = "0x181987730")]
	public EHGJMLLEIHA(TKey LPJIDKAIAHI, [Optional] int? CJNKPBOCJNJ, [Optional][CanBeNull] Stopwatch DCONEIAFJGN, [Optional] Action<TKey, LFINMJIEICI> LMGGKKPJMLE, [Optional] Action<TKey, LFINMJIEICI> CNJHAMHHDFI, [Optional] Action<global::EHGJMLLEIHA<TKey>> JILJHJDEKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x1987450", Offset = "0x1986250", VA = "0x181987450", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x1987710", Offset = "0x1986510", VA = "0x181987710")]
	public void OMKFLJFBNAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x19874E0", Offset = "0x19862E0", VA = "0x1819874E0")]
	public void IOLANELGBOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x1987680", Offset = "0x1986480", VA = "0x181987680")]
	[IteratorStateMachine(typeof(global::EHGJMLLEIHA<>.DLLOOAPEIBA))]
	public IEnumerable<(TKey, List<TKey>, LFINMJIEICI)> NBLLALKOPIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x19875B0", Offset = "0x19863B0", VA = "0x1819875B0")]
	[IteratorStateMachine(typeof(global::EHGJMLLEIHA<>.LOFFOJBNFOB))]
	private IEnumerable<(TKey, List<TKey>, LFINMJIEICI)> NBLLALKOPIL(List<TKey> KCGMDGFIHOJ, GEKJCIHAMFL DDOOJJJHNHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x19873D0", Offset = "0x19861D0", VA = "0x1819873D0")]
	private (long, int) CGILPNJCGGN()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class ABFNEAPIAFE<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut KCPKNEMHAIG(global::EHGJMLLEIHA<TKey> APDIGEDLLAL);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
	protected ABFNEAPIAFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class LNOFFBLNBIO<TKey> : global::ABFNEAPIAFE<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate string LPCEAMJLPJC(TKey CCJNKBLKLDJ);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x2D63870", Offset = "0x2D62670", VA = "0x182D63870")]
	protected string IOOIHINPGPD(double KPHOHPEDFHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x2D63AC0", Offset = "0x2D628C0", VA = "0x182D63AC0")]
	protected string LDNJOGONJOF(int KMKBHIDEHKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x2D63830", Offset = "0x2D62630", VA = "0x182D63830")]
	private static string EPMCEDIGHMI(TKey CCJNKBLKLDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x2D638E0", Offset = "0x2D626E0", VA = "0x182D638E0", Slot = "4")]
	public override string KCPKNEMHAIG(global::EHGJMLLEIHA<TKey> APDIGEDLLAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2D63990", Offset = "0x2D62790", VA = "0x182D63990")]
	public string KCPKNEMHAIG(global::EHGJMLLEIHA<TKey> APDIGEDLLAL, [NotNull] LPCEAMJLPJC ADMFMGGDLGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string EMMKIMDMMHH(global::EHGJMLLEIHA<TKey> APDIGEDLLAL, [NotNull] LPCEAMJLPJC ADMFMGGDLGH);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x198C8A0", Offset = "0x198B6A0", VA = "0x18198C8A0")]
	protected LNOFFBLNBIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class NGLJPEDJLFA<TKey> : global::ABFNEAPIAFE<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate string ELOIBNJHNEJ(TKey CCJNKBLKLDJ);

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const int FJJCBOOFHJB = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly string EDAHGMBLEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly double GDNOCDDMPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly bool OFABEKEOFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly int HFMGMFPCCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly ISet<string> PINCNCDBLJN;

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8980", Offset = "0x2CA7780", VA = "0x182CA8980")]
	private static string EPMCEDIGHMI(TKey CCJNKBLKLDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9240", Offset = "0x2CA8040", VA = "0x182CA9240")]
	public NGLJPEDJLFA(string EDAHGMBLEFA = "F2", double GDNOCDDMPPE = double.MaxValue, bool OFABEKEOFHH = false, int HFMGMFPCCCB = int.MaxValue, [Optional] ISet<string> PINCNCDBLJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8F00", Offset = "0x2CA7D00", VA = "0x182CA8F00", Slot = "4")]
	public override Dictionary<string, string> KCPKNEMHAIG(global::EHGJMLLEIHA<TKey> APDIGEDLLAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8FB0", Offset = "0x2CA7DB0", VA = "0x182CA8FB0")]
	private bool MHOAAMOADMG(string LIJFPGLLLDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x2CA89C0", Offset = "0x2CA77C0", VA = "0x182CA89C0")]
	public Dictionary<string, string> KCPKNEMHAIG(global::EHGJMLLEIHA<TKey> APDIGEDLLAL, ELOIBNJHNEJ ADMFMGGDLGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9090", Offset = "0x2CA7E90", VA = "0x182CA9090")]
	private string PANHNJGFHJD(StringBuilder LKFKIAFIGCP, List<TKey> MILADPHKBEN, ELOIBNJHNEJ ADMFMGGDLGH, bool EMFHALGFDPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8800", Offset = "0x2CA7600", VA = "0x182CA8800")]
	private static void DAAFKIGGHIB(StringBuilder LAFEBKCEJNP, string DKGFIOACDBE, bool DMCPKKLABDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class FHMKBMDFHMH<TKey> : global::LNOFFBLNBIO<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct NGFHONCDGIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public LPCEAMJLPJC keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static global::FHMKBMDFHMH<TKey> JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private const int FFHGCCFFLKB = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly string[] OALKJOLENHJ;

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x2527410", Offset = "0x2526210", VA = "0x182527410")]
	private FHMKBMDFHMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x2526330", Offset = "0x2525130", VA = "0x182526330", Slot = "5")]
	protected override string EMMKIMDMMHH(global::EHGJMLLEIHA<TKey> APDIGEDLLAL, LPCEAMJLPJC ADMFMGGDLGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x2527220", Offset = "0x2526020", VA = "0x182527220")]
	[CompilerGenerated]
	internal static string MIEIHKJBLPF(string GPCDLKJMMCL, TKey CCJNKBLKLDJ, ref NGFHONCDGIC P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class NMJMLLFNIAO<TKey> : global::LNOFFBLNBIO<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class CKGHNHCAIAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public LPCEAMJLPJC keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
		public CKGHNHCAIAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x166B810", Offset = "0x166A610", VA = "0x18166B810")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x2B5DE70", Offset = "0x2B5CC70", VA = "0x182B5DE70", Slot = "5")]
	protected override string EMMKIMDMMHH(global::EHGJMLLEIHA<TKey> APDIGEDLLAL, LPCEAMJLPJC ADMFMGGDLGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x25B6BD0", Offset = "0x25B59D0", VA = "0x1825B6BD0")]
	public NMJMLLFNIAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public sealed class LBHPPCDHALB : global::EHGJMLLEIHA<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class FHMINHEPIEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Action<LBHPPCDHALB> callback;

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public FHMINHEPIEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5D2DB40", Offset = "0x5D2C940", VA = "0x185D2DB40")]
		internal void <Wrap>b__0(global::EHGJMLLEIHA<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FF40", Offset = "0x5D2ED40", VA = "0x185D2FF40")]
	public LBHPPCDHALB([Optional] string BFFLLNCOKMN, [Optional] int? CJNKPBOCJNJ, [Optional] Stopwatch DCONEIAFJGN, [Optional] Action<string, LFINMJIEICI> LMGGKKPJMLE, [Optional] Action<string, LFINMJIEICI> CNJHAMHHDFI, [Optional] Action<LBHPPCDHALB> JILJHJDEKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FE60", Offset = "0x5D2EC60", VA = "0x185D2FE60")]
	private static Action<global::EHGJMLLEIHA<string>> BAJMMIABKCA(Action<LBHPPCDHALB> GKAOJENLDLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class PCCFJFHBKMO
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private class AMGBIBIMKHJ : PCCFJFHBKMO
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static PCCFJFHBKMO JNHMLOILMCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x5D2B080", Offset = "0x5D29E80", VA = "0x185D2B080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public override DateTime EJMDHCNLACO
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x5D2B030", Offset = "0x5D29E30", VA = "0x185D2B030", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override float BFPMBFEGEAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x5D2B020", Offset = "0x5D29E20", VA = "0x185D2B020", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x5D2B180", Offset = "0x5D29F80", VA = "0x185D2B180")]
		public AMGBIBIMKHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static PCCFJFHBKMO ILKCJFJFGGG;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static PCCFJFHBKMO FOBBLKPOGAD
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x5D31090", Offset = "0x5D2FE90", VA = "0x185D31090")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public abstract DateTime EJMDHCNLACO
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public abstract float BFPMBFEGEAK
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	protected PCCFJFHBKMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class CNPEPHDIAMN : global::KFHMMJCAHMJ<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D4F0", Offset = "0x5D2C2F0", VA = "0x185D2D4F0")]
	public CNPEPHDIAMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class KFHMMJCAHMJ<T> : global::ANFKCNMPPLG<T>, JDBAPGPMFAN, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Task<T> PHOLALLJMBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private Task MBKBJAIGLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x144DDD0", Offset = "0x144CBD0", VA = "0x18144DDD0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::DGCAEBAFOOK<T> NMJDKNOJAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private NPIGAOPELEF CLHGDAGPLHH
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xD65FC0", Offset = "0xD64DC0", VA = "0x180D65FC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x2FF9F60", Offset = "0x2FF8D60", VA = "0x182FF9F60")]
	public KFHMMJCAHMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class JKMEDAKMFJK : global::NOJAKAOFMOA<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x5D2EDD0", Offset = "0x5D2DBD0", VA = "0x185D2EDD0")]
	public JKMEDAKMFJK(Exception BKGIODDNKLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class NOJAKAOFMOA<T> : global::ANFKCNMPPLG<T>, JDBAPGPMFAN, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Task<T> PHOLALLJMBE
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private Task MBKBJAIGLLH
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x144DDD0", Offset = "0x144CBD0", VA = "0x18144DDD0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::DGCAEBAFOOK<T> NMJDKNOJAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private NPIGAOPELEF CLHGDAGPLHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xD65FC0", Offset = "0xD64DC0", VA = "0x180D65FC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x2B62230", Offset = "0x2B61030", VA = "0x182B62230")]
	public NOJAKAOFMOA(Exception BKGIODDNKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface JDBAPGPMFAN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000069")]
	[NotNull]
	Task PHOLALLJMBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	[NotNull]
	NPIGAOPELEF NMJDKNOJAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface ANFKCNMPPLG<T> : JDBAPGPMFAN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	[NotNull]
	new Task<T> PHOLALLJMBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	[NotNull]
	new global::DGCAEBAFOOK<T> NMJDKNOJAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public abstract class BEPDLHFOHBM<TTask, T> : global::ANFKCNMPPLG<T>, JDBAPGPMFAN, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class BCMLJJAJHDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public global::BEPDLHFOHBM<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
		public BCMLJJAJHDE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static bool KGKJIEADGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly Task<T> JJCIEPGHDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	protected readonly CancellationTokenSource GKECGJILIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool DGKCCECAGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private SynchronizationContext JMCKCLJAIOC;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Task<T> PHOLALLJMBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Task MBKBJAIGLLH
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public global::DGCAEBAFOOK<T> NMJDKNOJAFO
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	private NPIGAOPELEF CLHGDAGPLHH
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x213C880", Offset = "0x213B680", VA = "0x18213C880", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool LOOFPCGMKLN
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x7CA100", Offset = "0x7C8F00", VA = "0x1807CA100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x23AC690", Offset = "0x23AB490", VA = "0x1823AC690")]
	static BEPDLHFOHBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x23ACB40", Offset = "0x23AB940", VA = "0x1823ACB40")]
	protected BEPDLHFOHBM(TTask JJCIEPGHDBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x23AC340", Offset = "0x23AB140", VA = "0x1823AC340", Slot = "1")]
	~BEPDLHFOHBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x23AC310", Offset = "0x23AB110", VA = "0x1823AC310", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x23AC3B0", Offset = "0x23AB1B0", VA = "0x1823AC3B0")]
	private void ICKDJJKFGLI(bool MMOPBOHIFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T LEMMBKMAEIM(TTask GLNFGOOIGIA);

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void OLFAPFGDFCL();

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x23AC2C0", Offset = "0x23AB0C0", VA = "0x1823AC2C0")]
	[CompilerGenerated]
	private void ACIKEIJEINA(object EPHCHIPDIOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface DJABOFDMEMI
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float AFEPPNOIIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event MGLOKFBMOMI IBPFPEKACBI;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class CJPAOFNIIFD : DJABOFDMEMI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public readonly struct GODGJDEFNDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly float JPAMEHCOEPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public readonly float FJOJCNFIGFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		internal readonly bool PPICPACFBLI;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public float PANMOHPAPDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x5D2DF20", Offset = "0x5D2CD20", VA = "0x185D2DF20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E0B0", Offset = "0x5D2CEB0", VA = "0x185D2E0B0")]
		public GODGJDEFNDM(float FOACNEHDHLI, float CBNJCJLIEMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x5D2DF30", Offset = "0x5D2CD30", VA = "0x185D2DF30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class JDBBCANADNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public CJPAOFNIIFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public JDBBCANADNK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly int CHMDLBBFMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private int NODMNKCOLMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly DJABOFDMEMI[] BGKDNKJEJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly MGLOKFBMOMI[] NFACINHMFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly GODGJDEFNDM[] FFMPLKKOONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private GODGJDEFNDM KMFAKDLAGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly OLCAEPENJCG NCPHIEOAAPE;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public GODGJDEFNDM AONBCHMIPAC
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x1E8A260", Offset = "0x1E89060", VA = "0x181E8A260")]
		get
		{
			return default(GODGJDEFNDM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float AFEPPNOIIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x5D2CCA0", Offset = "0x5D2BAA0", VA = "0x185D2CCA0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event MGLOKFBMOMI IBPFPEKACBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D2B0", Offset = "0x5D2C0B0", VA = "0x185D2D2B0", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x5D2CDA0", Offset = "0x5D2BBA0", VA = "0x185D2CDA0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D370", Offset = "0x5D2C170", VA = "0x185D2D370")]
	public CJPAOFNIIFD(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CCC0", Offset = "0x5D2BAC0", VA = "0x185D2CCC0")]
	public OLCAEPENJCG JLKHMCPFMIM(GODGJDEFNDM IEJLANBMLJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CE60", Offset = "0x5D2BC60", VA = "0x185D2CE60")]
	public void LPDKOIBHNFN(DJABOFDMEMI LNOIHANMLEE, [Optional] GODGJDEFNDM MCJCCAPLEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CC50", Offset = "0x5D2BA50", VA = "0x185D2CC50")]
	internal int FKENAIAHEAH(DJABOFDMEMI HBCDOHJNOJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CD50", Offset = "0x5D2BB50", VA = "0x185D2CD50")]
	internal GODGJDEFNDM JNFBABGBIFI(int AIPHGHFENPJ)
	{
		return default(GODGJDEFNDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CAC0", Offset = "0x5D2B8C0", VA = "0x185D2CAC0", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public delegate void MGLOKFBMOMI(float OEFCMOECHGN);
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal static class CBLIAKJDFMN
{
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	internal const float GKJAIAGCKLM = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class DMOPFECHMMO
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private class IIAPNCMBNCO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly DJABOFDMEMI HBCDOHJNOJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private readonly MGLOKFBMOMI GKAOJENLDLL;

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E680", Offset = "0x5D2D480", VA = "0x185D2E680")]
		public IIAPNCMBNCO(DJABOFDMEMI HBCDOHJNOJM, MGLOKFBMOMI GKAOJENLDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E630", Offset = "0x5D2D430", VA = "0x185D2E630", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D5C0", Offset = "0x5D2C3C0", VA = "0x185D2D5C0")]
	internal static bool CALOBKLNFMD(float BMPDKJEHGIN, float BMMLDIMMAAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x487C2E0", Offset = "0x487B0E0", VA = "0x18487C2E0")]
	internal static float MDOCPMOMFLF(float BMPDKJEHGIN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D640", Offset = "0x5D2C440", VA = "0x185D2D640")]
	public static IDisposable GMLLGEOJAAA(this DJABOFDMEMI HBCDOHJNOJM, MGLOKFBMOMI GKAOJENLDLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class OLCAEPENJCG : DJABOFDMEMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float OEFCMOECHGN;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float AFEPPNOIIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xDEE130", Offset = "0xDECF30", VA = "0x180DEE130", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x5D30DA0", Offset = "0x5D2FBA0", VA = "0x185D30DA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event MGLOKFBMOMI IBPFPEKACBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x5D30F00", Offset = "0x5D2FD00", VA = "0x185D30F00", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x5D30E60", Offset = "0x5D2FC60", VA = "0x185D30E60", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public OLCAEPENJCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public static class PFDKDLHNGHK
{
	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5D31CB0", Offset = "0x5D30AB0", VA = "0x185D31CB0")]
	[NotNull]
	public static byte[] DCEJPOHKLOD(this NIPAEPLNJMM PGBLJCOLKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5D31D20", Offset = "0x5D30B20", VA = "0x185D31D20")]
	[NotNull]
	public static byte[] DCEJPOHKLOD(this NIPAEPLNJMM PGBLJCOLKOA, HashAlgorithmName HKKDBKLHMJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x5D31A00", Offset = "0x5D30800", VA = "0x185D31A00")]
	public static bool CMCHABMICCB([CanBeNull] this NIPAEPLNJMM PGBLJCOLKOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5D31860", Offset = "0x5D30660", VA = "0x185D31860")]
	public static bool CMCHABMICCB([CanBeNull] this NIPAEPLNJMM PGBLJCOLKOA, out string EGNBEILEKKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x5D31D90", Offset = "0x5D30B90", VA = "0x185D31D90")]
	private static string PALKABLKHAF([CanBeNull] byte[] HFAIGCGNPJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x5D31B90", Offset = "0x5D30990", VA = "0x185D31B90")]
	private static bool DBDKFNPBADC([NotNull] NIPAEPLNJMM PGBLJCOLKOA, [CanBeNull] out byte[] ABIOPBANALL, [CanBeNull] out byte[] DAJKGKGPPDH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class GCFNCJLJLGB
{
	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DC10", Offset = "0x5D2CA10", VA = "0x185D2DC10")]
	[NotNull]
	public static byte[] DCEJPOHKLOD(this JDBJPKOCHPF FIPIBFLOINL, byte[] MBFPOLMHNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DC50", Offset = "0x5D2CA50", VA = "0x185D2DC50")]
	[NotNull]
	public static byte[] DCEJPOHKLOD(this JDBJPKOCHPF FIPIBFLOINL, HashAlgorithmName HKKDBKLHMJH, byte[] MBFPOLMHNHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface JDBJPKOCHPF
{
	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash PKCNHEGJGNH);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface NIPAEPLNJMM : JDBJPKOCHPF
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	[CanBeNull]
	byte[] FIHFHBNGLKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	[CanBeNull]
	byte[] CJCKGEJJOJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	UnityEngine.Object PPGIHCAMMNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public static class BNAPFGBLMCD
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private class JCEPHOPMDCA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x5D2ECC0", Offset = "0x5D2DAC0", VA = "0x185D2ECC0")]
		public JCEPHOPMDCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x5D2EC60", Offset = "0x5D2DA60", VA = "0x185D2EC60", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private const byte HFFKMHHKNOL = 1;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private const byte PPGIBPNNLIM = 0;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly ArrayPool<byte> GPMJNKBDCON;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static bool MALJBLEFADO;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x24A7E90", Offset = "0x24A6C90", VA = "0x1824A7E90")]
	[Conditional("UNITY_EDITOR")]
	private static void OKMGHCAMKNL<T>(params T[] HIFGENFODLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B760", Offset = "0x5D2A560", VA = "0x185D2B760")]
	public static IDisposable EOLGJDIEOML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C260", Offset = "0x5D2B060", VA = "0x185D2C260")]
	public static void PAMGGGELPJC(this IncrementalHash MPBCJIPHAFL, [CanBeNull] GameObject BFJMKCMPBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x24A8180", Offset = "0x24A6F80", VA = "0x1824A8180")]
	public static void PAMGGGELPJC<T>(this IncrementalHash MPBCJIPHAFL, [CanBeNull] T AFOPPLDIMJL) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x24A7710", Offset = "0x24A6510", VA = "0x1824A7710")]
	public static void EHIKJAPAENC<T>(this IncrementalHash MPBCJIPHAFL, [CanBeNull] T FIPIBFLOINL) where T : JDBJPKOCHPF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x24A8250", Offset = "0x24A7050", VA = "0x1824A8250")]
	public static void PAPDJEAIPJK<T>(this IncrementalHash MPBCJIPHAFL, [CanBeNull] IList<T> PEAHLGOOOIO) where T : JDBJPKOCHPF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B970", Offset = "0x5D2A770", VA = "0x185D2B970")]
	private static bool IKDGPDPCNPA([CanBeNull] JDBJPKOCHPF FIPIBFLOINL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x5D2BAD0", Offset = "0x5D2A8D0", VA = "0x185D2BAD0")]
	public static void KMJILBGMNLB(this IncrementalHash PKCNHEGJGNH, [CanBeNull] string KFCEHAILNOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x5D2BB30", Offset = "0x5D2A930", VA = "0x185D2BB30")]
	public static void KOGBMIOOMEH(this IncrementalHash PKCNHEGJGNH, long JKGNEOGOKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B2F0", Offset = "0x5D2A0F0", VA = "0x185D2B2F0")]
	public static void AADKNOMNCLL(this IncrementalHash PKCNHEGJGNH, int FGFDCPICAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D2BD00", Offset = "0x5D2AB00", VA = "0x185D2BD00")]
	public static void KPLIDHECCMN(this IncrementalHash PKCNHEGJGNH, short ANFPDIMPJNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D2BF30", Offset = "0x5D2AD30", VA = "0x185D2BF30")]
	public static void NGAFDEGANNI(this IncrementalHash PKCNHEGJGNH, byte PLMOPNOHALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B530", Offset = "0x5D2A330", VA = "0x185D2B530")]
	public static void BNPENPIGGPL(this IncrementalHash PKCNHEGJGNH, bool CNFBDAILKKM, bool LJBGNCAJFOD = false, bool DDLFMMPIEEK = false, bool DHCJADKACEM = false, bool ACLFALACBKN = false, bool HHLHLPJHCBL = false, bool DPDPPGPPGDB = false, bool MGDBGAFAAGI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x24A77A0", Offset = "0x24A65A0", VA = "0x1824A77A0")]
	public static void IGKHICHCGFB<T>(this IncrementalHash PKCNHEGJGNH, T HOBDFMBOEKJ) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x5D2BED0", Offset = "0x5D2ACD0", VA = "0x185D2BED0")]
	public static void LIDIJHEGIDK(this IncrementalHash PKCNHEGJGNH, float JNBOKKKFNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x5D2BA70", Offset = "0x5D2A870", VA = "0x185D2BA70")]
	public static void JLOMIPMOBAN(this IncrementalHash PKCNHEGJGNH, double KLOJPDOOPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B4C0", Offset = "0x5D2A2C0", VA = "0x185D2B4C0")]
	public static void APGHMLLOEHI(this IncrementalHash PKCNHEGJGNH, ulong LFFHHADNBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B700", Offset = "0x5D2A500", VA = "0x185D2B700")]
	public static void CKICEEAPHDE(this IncrementalHash PKCNHEGJGNH, uint GFKEJJLCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x5D2BA00", Offset = "0x5D2A800", VA = "0x185D2BA00")]
	public static void JLJGIJFFHPP(this IncrementalHash PKCNHEGJGNH, ushort CCDPLMEOBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B800", Offset = "0x5D2A600", VA = "0x185D2B800")]
	public static void HGBLGCDHPJE(this IncrementalHash PKCNHEGJGNH, Vector3 NKACMCKINJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C0A0", Offset = "0x5D2AEA0", VA = "0x185D2C0A0")]
	public static void OLJAAGAFNAI(this IncrementalHash PKCNHEGJGNH, Quaternion EKNNFKFHKJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class LNDPPEMEKCF : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public readonly Type DJCNMDPDNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly string JGOBLMIOMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly bool APGEFJPOLLJ;

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x5D30090", Offset = "0x5D2EE90", VA = "0x185D30090")]
	public LNDPPEMEKCF(Type ICHCDGFAFMA, string HCNFPHKIIJH, bool LPNDFHNCPIB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class OLFLOAGCDHH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x5D31020", Offset = "0x5D2FE20", VA = "0x185D31020")]
	public OLFLOAGCDHH(string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x5D30FA0", Offset = "0x5D2FDA0", VA = "0x185D30FA0")]
	public OLFLOAGCDHH(string GOJKMEMCPDE, Exception CNFPBKCKKEC)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x657020", Offset = "0x655E20", VA = "0x180657020")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x6570E0", Offset = "0x655EE0", VA = "0x1806570E0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public T this[int HLAPKJLCEDC, int BOGPBFBHDOE]
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x348AE40", Offset = "0x3489C40", VA = "0x18348AE40")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x348AEE0", Offset = "0x3489CE0", VA = "0x18348AEE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x348ADB0", Offset = "0x3489BB0", VA = "0x18348ADB0")]
		public Array2D(uint KLFKELPFFNF, uint AGONAJNGCCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x348AD30", Offset = "0x3489B30", VA = "0x18348AD30")]
		public void IIOELKEIHEG()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x5D2B1E0", Offset = "0x5D29FE0", VA = "0x185D2B1E0")]
		public Array2DVector3(uint KLFKELPFFNF, uint AGONAJNGCCO)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal static class FODBEJIADJN
{
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public const int KFMOONGEAEH = -1;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public const int APMLOGPBPIJ = 0;
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[DefaultMember("Item")]
public class OHAJLNOFLKM<THandle, TValue> : IDisposable where THandle : struct, GPAFGALANDE where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private readonly List<THandle> AGFPEFOAJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly List<TValue> IOOGJNDNHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly Func<TValue> PFLFMAIAICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly Action<TValue> DFNIIHBCCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private int EAGBLHMONMP;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public TValue MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x2459DF0", Offset = "0x2458BF0", VA = "0x182459DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x2E5D230", Offset = "0x2E5C030", VA = "0x182E5D230")]
	public OHAJLNOFLKM(Action<TValue> DFNIIHBCCOD, [Optional] Func<TValue> PFLFMAIAICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2E5CC50", Offset = "0x2E5BA50", VA = "0x182E5CC50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2E5CB00", Offset = "0x2E5B900", VA = "0x182E5CB00")]
	public THandle DAKLFHBAJIH()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2E5CF30", Offset = "0x2E5BD30", VA = "0x182E5CF30")]
	public THandle HEFJCCLOLGO(TValue IGJPNMBCJPK)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2E5C9A0", Offset = "0x2E5B7A0", VA = "0x182E5C9A0")]
	public bool AKJLIPOIGHF(THandle MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2E5C7F0", Offset = "0x2E5B5F0", VA = "0x182E5C7F0")]
	public bool ACKFNLGGLJE(THandle MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x2E5D080", Offset = "0x2E5BE80", VA = "0x182E5D080")]
	public bool KNMEGLCAMII(THandle MIGDJNOKMHC, out TValue IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x2E5CA50", Offset = "0x2E5B850", VA = "0x182E5CA50")]
	public TValue BOPAOPJOHPG(THandle MIGDJNOKMHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x2E5C8C0", Offset = "0x2E5B6C0", VA = "0x182E5C8C0")]
	public bool AEBBOEKMPNE(THandle MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x2E5C970", Offset = "0x2E5B770", VA = "0x182E5C970")]
	private THandle AKEDIKAPJNI(int AIPHGHFENPJ)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x2E5CDF0", Offset = "0x2E5BBF0", VA = "0x182E5CDF0")]
	private TValue FMDMOKNGPIL(int AIPHGHFENPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x2E5D1A0", Offset = "0x2E5BFA0", VA = "0x182E5D1A0")]
	private void LLMGNABJPBK(int AIPHGHFENPJ, in THandle MIGDJNOKMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2E5D1F0", Offset = "0x2E5BFF0", VA = "0x182E5D1F0")]
	private void OOGPKFNOLPA(int AIPHGHFENPJ, in TValue IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x2E5CE20", Offset = "0x2E5BC20", VA = "0x182E5CE20")]
	private THandle GLBGHPMKCDI()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x2E5CBA0", Offset = "0x2E5B9A0", VA = "0x182E5CBA0")]
	private void DLOAHCHNKCJ(THandle MIGDJNOKMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x2E5CFA0", Offset = "0x2E5BDA0", VA = "0x182E5CFA0")]
	private int INGBECJDIGI(int JKGBPKEJAFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2E5D1E0", Offset = "0x2E5BFE0", VA = "0x182E5D1E0")]
	private bool OEJPECIBDFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x685AF0", Offset = "0x6848F0", VA = "0x180685AF0")]
	private void HMEPPCBJPKP(THandle MIGDJNOKMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2E5D120", Offset = "0x2E5BF20", VA = "0x182E5D120")]
	private bool LDAAGBHHMPI(out THandle MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2E5CFB0", Offset = "0x2E5BDB0", VA = "0x182E5CFB0")]
	private bool JLNIOIOMGFP(out THandle MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x2E5CAA0", Offset = "0x2E5B8A0", VA = "0x182E5CAA0")]
	private void COEFPBLADKG(THandle MIGDJNOKMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x2E5CCD0", Offset = "0x2E5BAD0", VA = "0x182E5CCD0")]
	private void FJEGAPCNKDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public interface GPAFGALANDE
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int KIJOKCLKDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	int FOEMNAHJKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public interface OCGKPONDJPA<T> : GPAFGALANDE, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class BPNNCKOADDC
{
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0xAD9780", Offset = "0xAD8580", VA = "0x180AD9780")]
	public static bool KOPGOIJFDNG<T>(this T MIGDJNOKMHC, T HNOJKNGFFBE) where T : struct, GPAFGALANDE
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x24A9580", Offset = "0x24A8380", VA = "0x1824A9580")]
	public static bool PPICPACFBLI<T>(this T MIGDJNOKMHC) where T : struct, GPAFGALANDE
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C460", Offset = "0x5D2B260", VA = "0x185D2C460")]
	public static string JCMOJHJKPIC(this GPAFGALANDE MIGDJNOKMHC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class KFJBGPOMJGH
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private enum IEPHOGLNELK : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private int PKCNHEGJGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private bool OCOBBJHPBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private IEPHOGLNELK PBHDPEJBGCP;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool GHPFNDBDPAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F5D0", Offset = "0x5D2E3D0", VA = "0x185D2F5D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool NIGLMGEEEPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F030", Offset = "0x5D2DE30", VA = "0x185D2F030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FE30", Offset = "0x5D2EC30", VA = "0x185D2FE30")]
	public KFJBGPOMJGH(bool OCOBBJHPBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F680", Offset = "0x5D2E480", VA = "0x185D2F680")]
	public void OAIILMFFBEL(object CCPIHKCBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F530", Offset = "0x5D2E330", VA = "0x185D2F530")]
	public void JOEJBFPKOLJ(int IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F020", Offset = "0x5D2DE20", VA = "0x185D2F020")]
	public void BLAMKCFOGNJ(uint NCCNCJLDCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F660", Offset = "0x5D2E460", VA = "0x185D2F660")]
	public void NLOPPDKPKOK(bool BIHHMPJOIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F5E0", Offset = "0x5D2E3E0", VA = "0x185D2F5E0")]
	public void LNPDJAMFDLL(long MOELJPNIGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F620", Offset = "0x5D2E420", VA = "0x185D2F620")]
	public void MIIINPIAEFK(ulong KPLEFKIAFMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5D2EFB0", Offset = "0x5D2DDB0", VA = "0x185D2EFB0")]
	public void ANNLPGCBPFJ(string JNFDLMOFJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F040", Offset = "0x5D2DE40", VA = "0x185D2F040")]
	public void CKBKGKCLOOB(Enum BKGIODDNKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FD00", Offset = "0x5D2EB00", VA = "0x185D2FD00")]
	public void PBCCLDBBLPO(IList LPDILHBGHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x2411FB0", Offset = "0x2410DB0", VA = "0x182411FB0")]
	public void CGLFAJBMBNM<T, U>(Dictionary<T, U> IBHEDDBCHGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F1C0", Offset = "0x5D2DFC0", VA = "0x185D2F1C0")]
	private void IJHEMNCPIDE(IDictionary IBHEDDBCHGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F0D0", Offset = "0x5D2DED0", VA = "0x185D2F0D0")]
	public int DBNECDHGCNK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F140", Offset = "0x5D2DF40", VA = "0x185D2F140")]
	public short GGPFADGJLCK()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F1B0", Offset = "0x5D2DFB0", VA = "0x185D2F1B0")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5D2EF40", Offset = "0x5D2DD40", VA = "0x185D2EF40")]
	private void ACBFDNGKDHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public abstract class ICFLMNMBPDL<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	internal class DMLALCOCLHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public TNode CFFPEBFKEAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public TNode ADECAOLBLPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public OHNENLDBNBJ CJJNIEGEMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public List<OHNENLDBNBJ> KJJCDPLKCDG;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
		public DMLALCOCLHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal struct OHNENLDBNBJ : IComparable<OHNENLDBNBJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int HKOHGCMCHKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public TClaimant EPPHKPPJDLJ;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x66BAF0", Offset = "0x66A8F0", VA = "0x18066BAF0")]
		public OHNENLDBNBJ(int HKOHGCMCHKO, TClaimant EPPHKPPJDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x2EE1DF0", Offset = "0x2EE0BF0", VA = "0x182EE1DF0")]
		public bool KFNCPIDDDPI(in OHNENLDBNBJ HNOJKNGFFBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x2EE1DE0", Offset = "0x2EE0BE0", VA = "0x182EE1DE0")]
		public bool FELEKGPHEFH(in OHNENLDBNBJ HNOJKNGFFBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x2EE1DD0", Offset = "0x2EE0BD0", VA = "0x182EE1DD0", Slot = "4")]
		public int CompareTo(OHNENLDBNBJ HNOJKNGFFBE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x2EE1E50", Offset = "0x2EE0C50", VA = "0x182EE1E50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public enum HEONEGFGDFK
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class ENJGCONDEEE : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public global::ICFLMNMBPDL<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x166B460", Offset = "0x166A260", VA = "0x18166B460")]
		[DebuggerHidden]
		public ENJGCONDEEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x199A810", Offset = "0x1999610", VA = "0x18199A810", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x199A9D0", Offset = "0x19997D0", VA = "0x18199A9D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x199A8F0", Offset = "0x19996F0", VA = "0x18199A8F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xD644C0", Offset = "0xD632C0", VA = "0x180D644C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly global::ALEKOGIBJDP<DMLALCOCLHK> MIIKKOEMAJL;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly global::ALEKOGIBJDP<List<OHNENLDBNBJ>> KOPOIIDDIPE;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static int LEEIGIEEJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	internal readonly Dictionary<TClaimant, TNode> GDDIBJAKHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	internal readonly Dictionary<TNode, DMLALCOCLHK> GKEJEKPCBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private HEONEGFGDFK CIJCIMPGNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool NNFHDNBGFFL;

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode AILCCJELIAN(TNode MKLEFAMNJAC);

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void MNMOGPHEODB(TNode MKLEFAMNJAC, TClaimant JPGAPFKAPHL, TClaimant BFOPNPBLNGF);

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x166AE20", Offset = "0x1669C20", VA = "0x18166AE20")]
	public ICFLMNMBPDL(HEONEGFGDFK CIJCIMPGNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x166A5A0", Offset = "0x16693A0", VA = "0x18166A5A0")]
	public void JDANKEGANBP(TNode MKLEFAMNJAC, TNode JDMCICBCFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x166AB20", Offset = "0x1669920", VA = "0x18166AB20")]
	public void MNDDIEIPBHB(TClaimant EPPHKPPJDLJ, TNode ECHEODLBJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x1669AE0", Offset = "0x16688E0", VA = "0x181669AE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x166AC20", Offset = "0x1669A20", VA = "0x18166AC20")]
	private void NCMMPGCMBFM(TClaimant EPPHKPPJDLJ, TNode FDJMINNOJFC, TNode ECHEODLBJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x166A100", Offset = "0x1668F00", VA = "0x18166A100")]
	private int FDKAHEPLLGF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x1669E50", Offset = "0x1668C50", VA = "0x181669E50")]
	private void EOLMEFKPPCK(TClaimant EPPHKPPJDLJ, TNode LMOILGHACLK, TNode FMEILHGLAMN, int NEMILMGLEJO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x1669A50", Offset = "0x1668850", VA = "0x181669A50")]
	private void BOOJKOFJPDI(OHNENLDBNBJ MMEBOPCCHDA, DMLALCOCLHK MLIJNOGINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x166A340", Offset = "0x1669140", VA = "0x18166A340")]
	private void IKMPBHGIJHN(TClaimant EPPHKPPJDLJ, TNode LMOILGHACLK, TNode FMEILHGLAMN, int NEMILMGLEJO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x166A230", Offset = "0x1669030", VA = "0x18166A230")]
	private void FJGNMDABFEE(OHNENLDBNBJ MMEBOPCCHDA, TNode MKLEFAMNJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x1669890", Offset = "0x1668690", VA = "0x181669890")]
	private void AKLKNEDNFFH(OHNENLDBNBJ MMEBOPCCHDA, DMLALCOCLHK MLIJNOGINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x1669D40", Offset = "0x1668B40", VA = "0x181669D40")]
	private void EEJOGEKIEBF(DMLALCOCLHK MLIJNOGINAM, bool HKLGLCKOJDF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x166A620", Offset = "0x1669420", VA = "0x18166A620")]
	private void LONBOHKOAAL(DMLALCOCLHK MLIJNOGINAM, TNode JDMCICBCFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x166A160", Offset = "0x1668F60", VA = "0x18166A160")]
	[IteratorStateMachine(typeof(global::ICFLMNMBPDL<, >.ENJGCONDEEE))]
	private IEnumerable<TNode> FGINIIAEMEC(TNode LMOILGHACLK, TNode FMEILHGLAMN, bool KJIBNILOJHD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x1669990", Offset = "0x1668790", VA = "0x181669990")]
	private DMLALCOCLHK ANAILDODKJN(TNode MKLEFAMNJAC, TNode ADECAOLBLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x166A990", Offset = "0x1669790", VA = "0x18166A990")]
	private DMLALCOCLHK MHNONCHFHNM(TNode MKLEFAMNJAC, TNode ADECAOLBLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x16696D0", Offset = "0x16684D0", VA = "0x1816696D0")]
	private void AIPIMJNNDKP(DMLALCOCLHK MLIJNOGINAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class IGFGNFBNCFM<T> : IEnumerable<global::IGFGNFBNCFM<T>.BFKLEOLBFKE>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public struct BFKLEOLBFKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public T IGJPNMBCJPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public int AIPHGHFENPJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class JLCBBEPDNNN : IEnumerator<BFKLEOLBFKE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private global::IGFGNFBNCFM<T> AHGHAANFJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private int AIPHGHFENPJ;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0xD587F0", Offset = "0xD575F0", VA = "0x180D587F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public BFKLEOLBFKE MFINOJMLAJL
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x2C48110", Offset = "0x2C46F10", VA = "0x182C48110", Slot = "4")]
			get
			{
				return default(BFKLEOLBFKE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xC03A20", Offset = "0xC02820", VA = "0x180C03A20")]
		public JLCBBEPDNNN(global::IGFGNFBNCFM<T> AHGHAANFJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x2C48010", Offset = "0x2C46E10", VA = "0x182C48010", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA51580", Offset = "0xA50380", VA = "0x180A51580", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xA5A780", Offset = "0xA59580", VA = "0x180A5A780", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private struct MAOBPJLOEAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public bool BOJKHDGCBJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public T IGJPNMBCJPK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private const int FHOJOKOHPNF = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly Dictionary<T, int> EFPAABHLGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private MAOBPJLOEAF[] DIFOGFHCHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int BPKLOPHLCGD;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int OAGFNIPJHBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x661740", Offset = "0x660540", VA = "0x180661740")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x7B14A0", Offset = "0x7B02A0", VA = "0x1807B14A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x1674330", Offset = "0x1673130", VA = "0x181674330")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x1675540", Offset = "0x1674340", VA = "0x181675540")]
	public IGFGNFBNCFM(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x1675620", Offset = "0x1674420", VA = "0x181675620")]
	public IGFGNFBNCFM(BFKLEOLBFKE[] NGBKPJMNOJL, bool CJEDMAAIJEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x1673EC0", Offset = "0x1672CC0", VA = "0x181673EC0")]
	public int EFDGKMDLMNK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x1674EC0", Offset = "0x1673CC0", VA = "0x181674EC0")]
	private int OMOBMOMCFJE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x1673F30", Offset = "0x1672D30", VA = "0x181673F30", Slot = "6")]
	protected virtual uint FAFAEFMGNCB(uint PKCNHEGJGNH, T IGJPNMBCJPK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x1674240", Offset = "0x1673040", VA = "0x181674240")]
	public bool GFFDKFLDOGB(T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x1673E20", Offset = "0x1672C20", VA = "0x181673E20")]
	public bool DNJJODPKEOD(int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x1674030", Offset = "0x1672E30", VA = "0x181674030")]
	public bool FKLGFCOHCLF(Func<T, bool> EHDENJOEBEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x16742D0", Offset = "0x16730D0", VA = "0x1816742D0")]
	public int GGKMBKAEBGM(T IGJPNMBCJPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x1674100", Offset = "0x1672F00", VA = "0x181674100")]
	public T FMDMOKNGPIL(int AIPHGHFENPJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x1674360", Offset = "0x1673160", VA = "0x181674360")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x1674A90", Offset = "0x1673890", VA = "0x181674A90")]
	public bool LHAEMCGIOMO(T IGJPNMBCJPK, bool DBMEGJOBOOF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x1674690", Offset = "0x1673490", VA = "0x181674690")]
	public bool LHAEMCGIOMO(T IGJPNMBCJPK, int AIPHGHFENPJ, bool DBMEGJOBOOF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x1673C70", Offset = "0x1672A70", VA = "0x181673C70")]
	public bool AKJLIPOIGHF(T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x16741C0", Offset = "0x1672FC0", VA = "0x1816741C0")]
	public bool GEPHADMCPNH(int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x1674B00", Offset = "0x1673900", VA = "0x181674B00")]
	private void OMFGKOPAABL(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x1674550", Offset = "0x1673350", VA = "0x181674550")]
	public BFKLEOLBFKE[] JEAKIKGHNCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x1673DD0", Offset = "0x1672BD0", VA = "0x181673DD0")]
	private int CDHMBNHDIMD(int HMJFOJBNOAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x16750C0", Offset = "0x1673EC0", VA = "0x1816750C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x16750C0", Offset = "0x1673EC0", VA = "0x1816750C0", Slot = "4")]
	private IEnumerator<BFKLEOLBFKE> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct JLCPNFGEOBK<Handle> where Handle : GPAFGALANDE, new()
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private struct PJBKNJHEFBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly global::JLCPNFGEOBK<Handle> PIDJNOBOEBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int AIPHGHFENPJ;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int ILKNCHFMPMB
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x3063C50", Offset = "0x3062A50", VA = "0x183063C50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Handle NHEHBINCOGM
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x30631B0", Offset = "0x3061FB0", VA = "0x1830631B0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x3063FD0", Offset = "0x3062DD0", VA = "0x183063FD0")]
		public PJBKNJHEFBK(global::JLCPNFGEOBK<Handle> PIDJNOBOEBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x3063F30", Offset = "0x3062D30", VA = "0x183063F30")]
		public DNJLGGCBKBG MIHDEIPKAKJ(in DNJLGGCBKBG KIHDPCDCOMG)
		{
			return default(DNJLGGCBKBG);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x3063E90", Offset = "0x3062C90", VA = "0x183063E90")]
		public HHMLOMLKNND MIHDEIPKAKJ(in HHMLOMLKNND KIHDPCDCOMG)
		{
			return default(HHMLOMLKNND);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x30635D0", Offset = "0x30623D0", VA = "0x1830635D0")]
		public bool HMKKNIINHFB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x3063580", Offset = "0x3062380", VA = "0x183063580")]
		private int EHIEMAAGKII(string GOJKMEMCPDE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x3063DA0", Offset = "0x3062BA0", VA = "0x183063DA0")]
		private Handle LBMNDCFMPDC(string GOJKMEMCPDE)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public struct DNJLGGCBKBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private PJBKNJHEFBK OMLHACIHODI;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public int MFINOJMLAJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x34AAD10", Offset = "0x34A9B10", VA = "0x1834AAD10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x27E7310", Offset = "0x27E6110", VA = "0x1827E7310")]
		public DNJLGGCBKBG(global::JLCPNFGEOBK<Handle> PIDJNOBOEBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x27E7190", Offset = "0x27E5F90", VA = "0x1827E7190")]
		public bool HMKKNIINHFB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x34AAC10", Offset = "0x34A9A10", VA = "0x1834AAC10")]
		public DNJLGGCBKBG BALJJOIEHDJ()
		{
			return default(DNJLGGCBKBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public struct HHMLOMLKNND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private PJBKNJHEFBK OMLHACIHODI;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Handle MFINOJMLAJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x27E7290", Offset = "0x27E6090", VA = "0x1827E7290")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x27E7310", Offset = "0x27E6110", VA = "0x1827E7310")]
		public HHMLOMLKNND(global::JLCPNFGEOBK<Handle> PIDJNOBOEBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x27E7190", Offset = "0x27E5F90", VA = "0x1827E7190")]
		public bool HMKKNIINHFB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x27E7090", Offset = "0x27E5E90", VA = "0x1827E7090")]
		public HHMLOMLKNND BALJJOIEHDJ()
		{
			return default(HHMLOMLKNND);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private NativeList<int> JPMLELKNNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private NativeList<int> JGBKDBDBLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private int CJKIABHOBKO;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool DFGMHDKKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x2C4BCA0", Offset = "0x2C4AAA0", VA = "0x182C4BCA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int KEHBMLJLDDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x2C4B6E0", Offset = "0x2C4A4E0", VA = "0x182C4B6E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int POBHNCDBPKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x661750", Offset = "0x660550", VA = "0x180661750")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int ACKACKBIKOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x661750", Offset = "0x660550", VA = "0x180661750")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public DNJLGGCBKBG CAKCMHFHGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x2C4A480", Offset = "0x2C49280", VA = "0x182C4A480")]
		get
		{
			return default(DNJLGGCBKBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public HHMLOMLKNND KJHLMJNOKGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x2C482D0", Offset = "0x2C470D0", VA = "0x182C482D0")]
		get
		{
			return default(HHMLOMLKNND);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x2C4C640", Offset = "0x2C4B440", VA = "0x182C4C640")]
	public JLCPNFGEOBK(int BOCABLLJGMP, Allocator JEOILJEOOOI = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x2C49F90", Offset = "0x2C48D90", VA = "0x182C49F90")]
	public void ICKDJJKFGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0xCD1D30", Offset = "0xCD0B30", VA = "0x180CD1D30")]
	public static int INGBECJDIGI(int HFMHCLGICNJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x2C48370", Offset = "0x2C47170", VA = "0x182C48370")]
	public static bool BAOIFAGJEEM(int HFMHCLGICNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x2C491F0", Offset = "0x2C47FF0", VA = "0x182C491F0")]
	public static bool FBMPFDIMJCM(int HFMHCLGICNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x2C4B7E0", Offset = "0x2C4A5E0", VA = "0x182C4B7E0")]
	public bool LLJLJAOOPBD(int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x2C4C490", Offset = "0x2C4B290", VA = "0x182C4C490")]
	public bool PJJDNLFCCFI(int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x2C4B460", Offset = "0x2C4A260", VA = "0x182C4B460")]
	public bool KDAIOGGPNLA(Handle MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x2C4AC40", Offset = "0x2C49A40", VA = "0x182C4AC40")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void JPLJFJIJDLO(Handle MIGDJNOKMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x2C4C0B0", Offset = "0x2C4AEB0", VA = "0x182C4C0B0")]
	public Handle PJAPBNCMBEB()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x2C497E0", Offset = "0x2C485E0", VA = "0x182C497E0")]
	public void FJFBBHGFOEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x2C49E20", Offset = "0x2C48C20", VA = "0x182C49E20")]
	public void IALCHHDMNFP(Handle MIGDJNOKMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x2C4A200", Offset = "0x2C49000", VA = "0x182C4A200")]
	public bool IHGIDBJFPED(Handle MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x2C4BD80", Offset = "0x2C4AB80", VA = "0x182C4BD80")]
	private bool PCOOKELLJJG(int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x2C49080", Offset = "0x2C47E80", VA = "0x182C49080")]
	private void EJMEKAMIFIO(out int AIPHGHFENPJ, out int JKGBPKEJAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x2C488A0", Offset = "0x2C476A0", VA = "0x182C488A0")]
	private void DLGFPDHJMBK(Handle MIGDJNOKMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x2C4A610", Offset = "0x2C49410", VA = "0x182C4A610")]
	private void INHEPIOCHAN(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x2C484E0", Offset = "0x2C472E0", VA = "0x182C484E0")]
	private bool CLLDIKMGNKF(out int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x2C48AA0", Offset = "0x2C478A0", VA = "0x182C48AA0")]
	private static Handle EDLKFIKCDPF(int AIPHGHFENPJ, int JKGBPKEJAFA)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[DefaultMember("Item")]
public struct OPFKIBDDGAC<Handle, T> where Handle : GPAFGALANDE, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private global::JLCPNFGEOBK<Handle> DPMAKEKJHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private T[] GGGFJPKOCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private Action<T> EGMBCEFPMPF;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool DFGMHDKKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x2CCE540", Offset = "0x2CCD340", VA = "0x182CCE540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int KEHBMLJLDDD
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x2CCE3C0", Offset = "0x2CCD1C0", VA = "0x182CCE3C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x2CCD370", Offset = "0x2CCC170", VA = "0x182CCD370")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public T MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x2CCE070", Offset = "0x2CCCE70", VA = "0x182CCE070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2CCF2A0", Offset = "0x2CCE0A0", VA = "0x182CCF2A0")]
	public OPFKIBDDGAC(int BOCABLLJGMP, [Optional] Action<T> EGMBCEFPMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x2CCD3A0", Offset = "0x2CCC1A0", VA = "0x182CCD3A0")]
	public void ICKDJJKFGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x2CCDEA0", Offset = "0x2CCCCA0", VA = "0x182CCDEA0")]
	public bool KDAIOGGPNLA(Handle MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void JPLJFJIJDLO(Handle MIGDJNOKMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x2CCCE20", Offset = "0x2CCBC20", VA = "0x182CCCE20")]
	public T BOPAOPJOHPG(Handle MIGDJNOKMHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x2CCE310", Offset = "0x2CCD110", VA = "0x182CCE310")]
	public bool KNMEGLCAMII(Handle MIGDJNOKMHC, out T CCPIHKCBGHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x2CCE900", Offset = "0x2CCD700", VA = "0x182CCE900")]
	public void PIGMJENILDA(Handle MIGDJNOKMHC, T KMCKONMJFFK, out T NALMGNHPGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x2CCE5C0", Offset = "0x2CCD3C0", VA = "0x182CCE5C0")]
	public void PIGMJENILDA(Handle MIGDJNOKMHC, T KMCKONMJFFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x2CCDCC0", Offset = "0x2CCCAC0", VA = "0x182CCDCC0")]
	public bool JKMDIHKOIGC(Handle MIGDJNOKMHC, T KMCKONMJFFK, out T NALMGNHPGDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x2CCD810", Offset = "0x2CCC610", VA = "0x182CCD810")]
	public bool JKMDIHKOIGC(Handle MIGDJNOKMHC, T KMCKONMJFFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x2CCCF40", Offset = "0x2CCBD40", VA = "0x182CCCF40")]
	public Handle HEFJCCLOLGO(T CCPIHKCBGHF)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x2CCE9A0", Offset = "0x2CCD7A0", VA = "0x182CCE9A0")]
	public void PLJGJCHOOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x2CCC1C0", Offset = "0x2CCAFC0", VA = "0x182CCC1C0")]
	public void AKJLIPOIGHF(Handle MIGDJNOKMHC, out T NALMGNHPGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x2CCC430", Offset = "0x2CCB230", VA = "0x182CCC430")]
	public void AKJLIPOIGHF(Handle MIGDJNOKMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x2CCC9C0", Offset = "0x2CCB7C0", VA = "0x182CCC9C0")]
	public bool BNPPCNDHKAP(Handle MIGDJNOKMHC, out T NALMGNHPGDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x2CCCC60", Offset = "0x2CCBA60", VA = "0x182CCCC60")]
	public bool BNPPCNDHKAP(Handle MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x2CCCEE0", Offset = "0x2CCBCE0", VA = "0x182CCCEE0")]
	private T GEPHADMCPNH(int AIPHGHFENPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x2CCD660", Offset = "0x2CCC460", VA = "0x182CCD660")]
	private void JHOPBBOOCLA(int DCJPACPBNKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public class ALEKOGIBJDP<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly Stack<T> PIDJNOBOEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly List<T> AKBEBFKIPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly int EPOOANDMMJL;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int OHAOGCHFILC
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x16763F0", Offset = "0x16751F0", VA = "0x1816763F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int OKMJDACDFKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x2140990", Offset = "0x213F790", VA = "0x182140990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x2284EC0", Offset = "0x2283CC0", VA = "0x182284EC0")]
	public static global::ALEKOGIBJDP<T> JMMOFKMJOMM(int CHMDLBBFMNF = 0, int EPOOANDMMJL = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x2285040", Offset = "0x2283E40", VA = "0x182285040")]
	public static global::ALEKOGIBJDP<T> MKABKNECJPE(int CHMDLBBFMNF = 0, int EPOOANDMMJL = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x22852B0", Offset = "0x22840B0", VA = "0x1822852B0")]
	public ALEKOGIBJDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x22852F0", Offset = "0x22840F0", VA = "0x1822852F0")]
	public ALEKOGIBJDP(int CHMDLBBFMNF, int EPOOANDMMJL = int.MaxValue, bool DDEEMBNHFIG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x2284D10", Offset = "0x2283B10", VA = "0x182284D10")]
	public T FKJKJFLCNLI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x2284F90", Offset = "0x2283D90", VA = "0x182284F90")]
	public void LKKBDAMJBBO(T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x2284B50", Offset = "0x2283950", VA = "0x182284B50")]
	private void CHLOBPCCNFE(T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x2284EA0", Offset = "0x2283CA0", VA = "0x182284EA0")]
	private void JHBDGFKGBHD(T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x2284E20", Offset = "0x2283C20", VA = "0x182284E20")]
	[Conditional("DEBUG_BUILD")]
	private void FMKODGJKDKE(T FNOFBOPMDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x2284AC0", Offset = "0x22838C0", VA = "0x182284AC0")]
	[Conditional("DEBUG_BUILD")]
	private void CGAFMCMLFAN(T FNOFBOPMDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x2284C20", Offset = "0x2283A20", VA = "0x182284C20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x2285110", Offset = "0x2283F10", VA = "0x182285110")]
	private void NMCAFHAGLON(IEnumerable<T> IOOGJNDNHCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class LIOMCBDJHJK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private Dictionary<int, T> FDKFBNKCKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private T OIGMABGECII;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public virtual T AKPJHHFDKFF
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x660AF0", Offset = "0x65F8F0", VA = "0x180660AF0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool LMCAAOFIENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x2CEB8D0", Offset = "0x2CEA6D0", VA = "0x182CEB8D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB610", Offset = "0x2CEA410", VA = "0x182CEB610")]
	public bool FEJCNECMMHF(T IGJPNMBCJPK, int HKOHGCMCHKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB810", Offset = "0x2CEA610", VA = "0x182CEB810")]
	public bool GFIDHGBMMBC(int HKOHGCMCHKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2CEBB10", Offset = "0x2CEA910", VA = "0x182CEBB10")]
	public T PEDKMDPFNBI(int FAJKJFLNAAF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB870", Offset = "0x2CEA670", VA = "0x182CEB870")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB670", Offset = "0x2CEA470", VA = "0x182CEB670")]
	private bool GCGOFAALEHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB580", Offset = "0x2CEA380", VA = "0x182CEB580")]
	public bool CECEMJJAJEO(int HKOHGCMCHKO, out T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x2459C50", Offset = "0x2458A50", VA = "0x182459C50")]
	public LIOMCBDJHJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class EICBINKJHDH<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	protected struct CKKOEBBKAHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public T AAFFKFKIJDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public int KBPAGHAOJMH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	protected readonly List<CKKOEBBKAHK> IMPDEOOHCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private T GMOAMOOADBP;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x1674330", Offset = "0x1673130", VA = "0x181674330")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x19880B0", Offset = "0x1986EB0", VA = "0x1819880B0")]
	public bool FKLGFCOHCLF(T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x19882C0", Offset = "0x19870C0", VA = "0x1819882C0")]
	public void HEFJCCLOLGO(T IGJPNMBCJPK, int HKOHGCMCHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x1987DD0", Offset = "0x1986BD0", VA = "0x181987DD0")]
	public bool AKJLIPOIGHF(T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x19883D0", Offset = "0x19871D0", VA = "0x1819883D0")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x1988430", Offset = "0x1987230", VA = "0x181988430")]
	public T PCOGBLDCONM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x1988360", Offset = "0x1987160", VA = "0x181988360")]
	public T ICCBDBEBDBJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x1987EF0", Offset = "0x1986CF0", VA = "0x181987EF0")]
	private void DMCIMOOOJKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x19884A0", Offset = "0x19872A0", VA = "0x1819884A0")]
	public EICBINKJHDH()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[SerializeField]
		[KFIFBFNJECK(GHKBHIFBDKF.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x5D322A0", Offset = "0x5D310A0", VA = "0x185D322A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x5D32630", Offset = "0x5D31430", VA = "0x185D32630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x5D324B0", Offset = "0x5D312B0", VA = "0x185D324B0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x5D32790", Offset = "0x5D31590", VA = "0x185D32790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x5D321C0", Offset = "0x5D30FC0", VA = "0x185D321C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x5D32550", Offset = "0x5D31350", VA = "0x185D32550")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x5D323D0", Offset = "0x5D311D0", VA = "0x185D323D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x5D32170", Offset = "0x5D30F70", VA = "0x185D32170")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public interface GHDMBMNLGPL
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public abstract class ResourcePrefabReference<T> : GHDMBMNLGPL where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x29AF890", Offset = "0x29AE690", VA = "0x1829AF890", Slot = "4")]
		public virtual T GCFGDHINFFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class OIMDLLNEAFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly Dictionary<byte, PFCMOJKBLHA> HHOIJJIHFIO;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public PFCMOJKBLHA BJKMKLFFFGF
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x660AE0", Offset = "0x65F8E0", VA = "0x180660AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector2 GAKMPLLBFML
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x1475560", Offset = "0x1474360", VA = "0x181475560")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xB45840", Offset = "0xB44640", VA = "0x180B45840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector2 IELDGPPLJLD
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x1D229C0", Offset = "0x1D217C0", VA = "0x181D229C0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x1440D70", Offset = "0x143FB70", VA = "0x181440D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector2 MGOGNDBCJOF
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x5D30240", Offset = "0x5D2F040", VA = "0x185D30240")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x116D550", Offset = "0x116C350", VA = "0x18116D550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int HLILMKNMKDI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x67BD10", Offset = "0x67AB10", VA = "0x18067BD10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x685AF0", Offset = "0x6848F0", VA = "0x180685AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D30940", Offset = "0x5D2F740", VA = "0x185D30940")]
	public OIMDLLNEAFM(Bounds AMFAFDADKEK, Vector2[] DMPGLONGKPD, int IMAEPENEFAA, byte HMJFOJBNOAJ, float KLOIGECHDKI = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D303C0", Offset = "0x5D2F1C0", VA = "0x185D303C0")]
	public PFCMOJKBLHA EIAHHAHGNPN(byte AIPHGHFENPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5D30820", Offset = "0x5D2F620", VA = "0x185D30820")]
	public void FMCBJMBGGEK(Vector3 EIIEKPIPEEF, float AGDGJEDGMPN, float PEBBGPHOPOC, ref List<byte> PAAEMJHEMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5D30920", Offset = "0x5D2F720", VA = "0x185D30920")]
	public void JDMNBCLKEGJ(PFCMOJKBLHA.OCLGPCGPGOI IBAAEKMJMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5D30260", Offset = "0x5D2F060", VA = "0x185D30260")]
	private PFCMOJKBLHA CMFKGPNDDDO(byte AIPHGHFENPJ, PFCMOJKBLHA.IMAAIIAEMDK DPNHOHGBFCN, PFCMOJKBLHA ADECAOLBLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x5D30420", Offset = "0x5D2F220", VA = "0x185D30420")]
	private void FCDAGLFIEOD(PFCMOJKBLHA ADECAOLBLPJ, Vector2[] DMPGLONGKPD, int IHFLEPEELEJ, int JAOKBPPGFGL, int GLNMGEHPEGC, int OMDPLFOMPPI, float KLOIGECHDKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public class PFCMOJKBLHA
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public enum IMAAIIAEMDK
	{
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public enum OCLGPCGPGOI
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public byte MELPOBPKFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	public Vector3 CLHHDBNOIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public Vector3 PANMOHPAPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public Vector3 IJGDBADCKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public Vector3 KFICBHMIGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public IMAAIIAEMDK MIJFFBPNKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public PFCMOJKBLHA JPFILNDPPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public List<PFCMOJKBLHA> EGKIDEBBEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public bool DPFNFBGGJFO;

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x5D31840", Offset = "0x5D30640", VA = "0x185D31840")]
	public PFCMOJKBLHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5D317E0", Offset = "0x5D305E0", VA = "0x185D317E0")]
	public PFCMOJKBLHA(byte FCDKMJOKGIE, IMAAIIAEMDK DPNHOHGBFCN, PFCMOJKBLHA ADECAOLBLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x5D316E0", Offset = "0x5D304E0", VA = "0x185D316E0")]
	public void NKNHNPFFGPO(PFCMOJKBLHA NIPKJIJGCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	public void JDMNBCLKEGJ(int NBFDHJCONPH, OCLGPCGPGOI IBAAEKMJMNL, int CKFKONADBAB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x5D31430", Offset = "0x5D30230", VA = "0x185D31430")]
	public void FMCBJMBGGEK(List<byte> PAAEMJHEMAA, Vector3 EIIEKPIPEEF, float AGDGJEDGMPN, float PEBBGPHOPOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5D313E0", Offset = "0x5D301E0", VA = "0x185D313E0")]
	public bool AIFMGHHDJML(Vector3 EFCGBFLJIDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x5D317A0", Offset = "0x5D305A0", VA = "0x185D317A0")]
	public bool PIAIOJAOAPK(Vector3 EFCGBFLJIDP, float GPJEONMCOLC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class MHHFALIGJPC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly Dictionary<T, object> FJDDMGGGPIJ;

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x166B810", Offset = "0x166A610", VA = "0x18166B810")]
	public bool JHAGOKLKPEA(T PHPHBAGDNPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2626970", Offset = "0x2625770", VA = "0x182626970")]
	public bool JHAGOKLKPEA(T PHPHBAGDNPE, object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x2626910", Offset = "0x2625710", VA = "0x182626910")]
	public bool JHAGOKLKPEA(T PHPHBAGDNPE, object MKDOEIGPNGM, out object PLCBFAGFNLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x2626760", Offset = "0x2625560", VA = "0x182626760")]
	public bool BMPCKDFLJDD(T PHPHBAGDNPE, object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x26268D0", Offset = "0x26256D0", VA = "0x1826268D0")]
	public bool INKHBMEJKFF(T PHPHBAGDNPE, object MKDOEIGPNGM, out object PLCBFAGFNLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x26267A0", Offset = "0x26255A0", VA = "0x1826267A0")]
	public bool BMPCKDFLJDD(T PHPHBAGDNPE, object MKDOEIGPNGM, out object PLCBFAGFNLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2626730", Offset = "0x2625530", VA = "0x182626730")]
	public void BGFFCKJLFCP(T PHPHBAGDNPE, object MKDOEIGPNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2626830", Offset = "0x2625630", VA = "0x182626830")]
	public void FIKGBJLIHAO(T PHPHBAGDNPE, object MKDOEIGPNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x26269B0", Offset = "0x26257B0", VA = "0x1826269B0")]
	public MHHFALIGJPC()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x20000AB")]
		public struct BGCANLKPIMO<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			private readonly List<Component> LPDILHBGHIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			private readonly bool DNAIHDDDAFO;

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x742FF0", Offset = "0x741DF0", VA = "0x180742FF0")]
			public BGCANLKPIMO(List<Component> LPDILHBGHIJ, bool DNAIHDDDAFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x23AD9C0", Offset = "0x23AC7C0", VA = "0x1823AD9C0")]
			public ALCFPIODMBB<T> BALJJOIEHDJ()
			{
				return default(ALCFPIODMBB<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x23ADA30", Offset = "0x23AC830", VA = "0x1823ADA30", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x23ADA30", Offset = "0x23AC830", VA = "0x1823ADA30", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		public struct ALCFPIODMBB<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			private readonly List<Component> LPDILHBGHIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			private readonly bool DNAIHDDDAFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			private int AIPHGHFENPJ;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public T MFINOJMLAJL
			{
				[Cpp2IlInjected.Token(Token = "0x60003E0")]
				[Cpp2IlInjected.Address(RVA = "0x2284900", Offset = "0x2283700", VA = "0x182284900", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003E1")]
				[Cpp2IlInjected.Address(RVA = "0x2284890", Offset = "0x2283690", VA = "0x182284890", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x22848D0", Offset = "0x22836D0", VA = "0x1822848D0")]
			public ALCFPIODMBB(List<Component> LPDILHBGHIJ, bool DNAIHDDDAFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x22847C0", Offset = "0x22835C0", VA = "0x1822847C0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x22847D0", Offset = "0x22835D0", VA = "0x1822847D0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x2284880", Offset = "0x2283680", VA = "0x182284880", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x5D344E0", Offset = "0x5D332E0", VA = "0x185D344E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x5D344A0", Offset = "0x5D332A0", VA = "0x185D344A0")]
		public ToolHierarchyCache(GameObject NLMNGLPMKIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x5D33F00", Offset = "0x5D32D00", VA = "0x185D33F00")]
		private void ILMEFAAGLOH(GameObject NLMNGLPMKIH, bool EFJKFNKFDIO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x5D34060", Offset = "0x5D32E60", VA = "0x185D34060")]
		public static void ILMEFAAGLOH(GameObject NLMNGLPMKIH, ref ToolHierarchyCache BGMEKLANEFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x5D33E70", Offset = "0x5D32C70", VA = "0x185D33E70")]
		public void GDABPBLHHDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x5D33C50", Offset = "0x5D32A50", VA = "0x185D33C50")]
		public void BODKONPEAMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x22D32E0", Offset = "0x22D20E0", VA = "0x1822D32E0")]
		public void OCIPHBIPPGC<T>(Action<T> CGKOOFFNHKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x5D33CA0", Offset = "0x5D32AA0", VA = "0x185D33CA0")]
		public Component EAAFOKEDLAE(Type NKICFHCCMMH, bool DNAIHDDDAFO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x22D3190", Offset = "0x22D1F90", VA = "0x1822D3190")]
		public T EAAFOKEDLAE<T>(bool DNAIHDDDAFO = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x5D33DF0", Offset = "0x5D32BF0", VA = "0x185D33DF0")]
		public BGCANLKPIMO<Component> FBDIHCHJNKN(Type NKICFHCCMMH, bool DNAIHDDDAFO = false)
		{
			return default(BGCANLKPIMO<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x22D3210", Offset = "0x22D2010", VA = "0x1822D3210")]
		public BGCANLKPIMO<T> FBDIHCHJNKN<T>(bool DNAIHDDDAFO = false) where T : class
		{
			return default(BGCANLKPIMO<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x5D340F0", Offset = "0x5D32EF0", VA = "0x185D340F0")]
		public List<Component> MDKFECCCDEA(Type NKICFHCCMMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x5D33D70", Offset = "0x5D32B70", VA = "0x185D33D70", Slot = "4")]
		public bool Equals(ToolHierarchyCache KNMKEOOODCL, ToolHierarchyCache EMKKILCIAOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x5D33E80", Offset = "0x5D32C80", VA = "0x185D33E80", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache CCPIHKCBGHF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public class BIHBJNOIAFJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private int CHMDLBBFMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private int AJDJHPPHOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private List<T> JJDMEICMPFG;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x16763F0", Offset = "0x16751F0", VA = "0x1816763F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public T KCJGEAHJJCN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x23B1A20", Offset = "0x23B0820", VA = "0x1823B1A20")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public T DPIAKLCPMIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x23B1830", Offset = "0x23B0630", VA = "0x1823B1830")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public T JCBNPIAHHCB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x23B18F0", Offset = "0x23B06F0", VA = "0x1823B18F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x23B1AB0", Offset = "0x23B08B0", VA = "0x1823B1AB0")]
	public BIHBJNOIAFJ(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x23B1600", Offset = "0x23B0400", VA = "0x1823B1600")]
	public void HEFJCCLOLGO(T MBKFGPPACCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x23B17B0", Offset = "0x23B05B0", VA = "0x1823B17B0")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x23B1560", Offset = "0x23B0360", VA = "0x1823B1560")]
	public void DGLNJJPOGHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x23B18A0", Offset = "0x23B06A0", VA = "0x1823B18A0")]
	public void OLCMHINEDDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x23B1890", Offset = "0x23B0690", VA = "0x1823B1890")]
	public void NOELKBPOBPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class HFJELPPAOJM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private bool JPOECBAFFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private Action CGKOOFFNHKL;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public static HFJELPPAOJM NKFJDGLCHIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E210", Offset = "0x5D2D010", VA = "0x185D2E210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool MAFLJCDFJLF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x6B19D0", Offset = "0x6B07D0", VA = "0x1806B19D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0xA5A6E0", Offset = "0xA594E0", VA = "0x180A5A6E0")]
	public HFJELPPAOJM(Action CGKOOFFNHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E1F0", Offset = "0x5D2CFF0", VA = "0x185D2E1F0")]
	public void NBKICENBLEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E1F0", Offset = "0x5D2CFF0", VA = "0x185D2E1F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class NKDJAOAMIIC
{
	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	public static void OJLLINHKNEF(IJEBMCPBKAP LOAFEMFAKGN, string GPPCNKPNHCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class FCMGPIFHKJF<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private struct KMJGBPEBCIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public int KBPAGHAOJMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public T AAFFKFKIJDJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly Dictionary<object, KMJGBPEBCIH> FDKFBNKCKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private T OIGMABGECII;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public virtual T AKPJHHFDKFF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x661A00", Offset = "0x660800", VA = "0x180661A00", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x1995830", Offset = "0x1994630", VA = "0x181995830", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool LMCAAOFIENA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x2459BE0", Offset = "0x24589E0", VA = "0x182459BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public object JHHBPMBHNBH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x65B270", Offset = "0x65A070", VA = "0x18065B270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x6B19E0", Offset = "0x6B07E0", VA = "0x1806B19E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x2454F80", Offset = "0x2453D80", VA = "0x182454F80")]
	public bool FEJCNECMMHF(T IGJPNMBCJPK, object MKDOEIGPNGM, int HKOHGCMCHKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x2459B40", Offset = "0x2458940", VA = "0x182459B40")]
	public bool GFIDHGBMMBC(object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x2454880", Offset = "0x2453680", VA = "0x182454880")]
	public bool CECEMJJAJEO(object MKDOEIGPNGM, out T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x2459BB0", Offset = "0x24589B0", VA = "0x182459BB0")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x2455B90", Offset = "0x2454990", VA = "0x182455B90")]
	private bool GCGOFAALEHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x2459C50", Offset = "0x2458A50", VA = "0x182459C50")]
	public FCMGPIFHKJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public class PLPHEAOGHDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private Dictionary<object, float> FDKFBNKCKDM;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float DBBMINEOBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xDEE130", Offset = "0xDECF30", VA = "0x180DEE130")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x1075CF0", Offset = "0x1074AF0", VA = "0x181075CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x5D31EF0", Offset = "0x5D30CF0", VA = "0x185D31EF0")]
	public void FEJCNECMMHF(float IGJPNMBCJPK, object MKDOEIGPNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x5D31F60", Offset = "0x5D30D60", VA = "0x185D31F60")]
	public void GFIDHGBMMBC(object MKDOEIGPNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x5D31FD0", Offset = "0x5D30DD0", VA = "0x185D31FD0")]
	private void NCKMPFFNPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x5D320F0", Offset = "0x5D30EF0", VA = "0x185D320F0")]
	public PLPHEAOGHDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class EABJGGDLAPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public readonly string EPECKNALOMA;

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C50", Offset = "0x6C3A50", VA = "0x1806C4C50")]
	public EABJGGDLAPO(string MKKAPGFCJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DA80", Offset = "0x5D2C880", VA = "0x185D2DA80")]
	public EABJGGDLAPO(UnityEngine.Object LKHBCBIAPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DA30", Offset = "0x5D2C830", VA = "0x185D2DA30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public sealed class IJEBMCPBKAP
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class BELENFMGBFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public BELENFMGBFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x5D2B240", Offset = "0x5D2A040", VA = "0x185D2B240")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private HashSet<object> INFHCIHNBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private int BEEGPAHOIGN;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public IReadOnlyCollection<object> LKLHAMANGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E7C0", Offset = "0x5D2D5C0", VA = "0x185D2E7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool MGBIGNFKMDM
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E710", Offset = "0x5D2D510", VA = "0x185D2E710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x688A00", Offset = "0x687800", VA = "0x180688A00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E8F0", Offset = "0x5D2D6F0", VA = "0x185D2E8F0")]
	public bool HEFJCCLOLGO(object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E720", Offset = "0x5D2D520", VA = "0x185D2E720")]
	public bool AKJLIPOIGHF(object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E890", Offset = "0x5D2D690", VA = "0x185D2E890")]
	public bool FKLGFCOHCLF(object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E9E0", Offset = "0x5D2D7E0", VA = "0x185D2E9E0")]
	public void IHIGDLFAICK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5D2EA50", Offset = "0x5D2D850", VA = "0x185D2EA50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public IJEBMCPBKAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class MDKNPIBCCIL<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private struct PMDHPEODCBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public float PDOCOMCOHFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public T AAFFKFKIJDJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private Dictionary<object, PMDHPEODCBA> FDKFBNKCKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private T LBDIMDGAKJF;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public virtual T PHIKHKEBFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0xE684A0", Offset = "0xE672A0", VA = "0x180E684A0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x139AB50", Offset = "0x1399950", VA = "0x18139AB50", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public object BPHBJABLGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x657000", Offset = "0x655E00", VA = "0x180657000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x6B19F0", Offset = "0x6B07F0", VA = "0x1806B19F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool LMCAAOFIENA
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x2D0AA90", Offset = "0x2D09890", VA = "0x182D0AA90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x2D090C0", Offset = "0x2D07EC0", VA = "0x182D090C0")]
	public bool FEJCNECMMHF(T IGJPNMBCJPK, object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x2D0AA30", Offset = "0x2D09830", VA = "0x182D0AA30")]
	public bool GFIDHGBMMBC(object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x2459BB0", Offset = "0x24589B0", VA = "0x182459BB0")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x2D08BF0", Offset = "0x2D079F0", VA = "0x182D08BF0")]
	public bool CECEMJJAJEO(object MKDOEIGPNGM, out T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x2D093D0", Offset = "0x2D081D0", VA = "0x182D093D0")]
	private bool GCGOFAALEHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x2D0AAD0", Offset = "0x2D098D0", VA = "0x182D0AAD0")]
	public MDKNPIBCCIL()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class ABAJDIGBNMI
{
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private static byte[] GCDEGNDFAID;

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private static int BBIOPAKABFB;

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private static int ACMEFJOAGOE;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private static BigInteger MCNKOBABGEE;

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public ABAJDIGBNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A9F0", Offset = "0x5D297F0", VA = "0x185D2A9F0")]
	private static string DPCKFJIDOBP(byte[] BMMLDIMMAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x5D2AB00", Offset = "0x5D29900", VA = "0x185D2AB00")]
	public static string FBACHCLJNPO(byte[] HFAIGCGNPJJ, bool KDMKCCLJMIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20000BA")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
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
