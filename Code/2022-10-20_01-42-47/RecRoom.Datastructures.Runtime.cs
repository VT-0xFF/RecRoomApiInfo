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
	[Cpp2IlInjected.Address(RVA = "0x6BECE0", Offset = "0x6BDAE0", VA = "0x1806BECE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x677140", Offset = "0x675F40", VA = "0x180677140", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x656F20", VA = "0x180658120", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x658130", Offset = "0x656F30", VA = "0x180658130", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x737040", Offset = "0x735E40", VA = "0x180737040", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash PKCNHEGJGNH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xD12960", Offset = "0xD11760", VA = "0x180D12960")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D56120", Offset = "0x5D54F20", VA = "0x185D56120")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D560E0", Offset = "0x5D54EE0", VA = "0x185D560E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5D56160", Offset = "0x5D54F60", VA = "0x185D56160")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5D56330", Offset = "0x5D55130", VA = "0x185D56330")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5D562A0", Offset = "0x5D550A0", VA = "0x185D562A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xF2FE00", Offset = "0xF2EC00", VA = "0x180F2FE00")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x107ABA0", Offset = "0x10799A0", VA = "0x18107ABA0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5D560A0", Offset = "0x5D54EA0", VA = "0x185D560A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5D56210", Offset = "0x5D55010", VA = "0x185D56210")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5D55AE0", Offset = "0x5D548E0", VA = "0x185D55AE0")]
	public void CopyBounds(SavedExtents HNOJKNGFFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5D56000", Offset = "0x5D54E00", VA = "0x185D56000")]
	public void SetLocalSpaceBounds(Bounds MKMJKAJJCML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x102C870", Offset = "0x102B670", VA = "0x18102C870")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5D55FF0", Offset = "0x5D54DF0", VA = "0x185D55FF0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5D55BD0", Offset = "0x5D549D0", VA = "0x185D55BD0")]
	private void ODIMLOIMPCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5D55DC0", Offset = "0x5D54BC0", VA = "0x185D55DC0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5D554A0", Offset = "0x5D542A0", VA = "0x185D554A0")]
	public static void CalculateLocalBoundsFor(GameObject BFJMKCMPBKG, out Bounds MKMJKAJJCML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5D55B10", Offset = "0x5D54910", VA = "0x185D55B10")]
	private static void DKKOMGEFKPM(Bounds BMMLDIMMAAK, Color KDPJFGIFCOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5D56020", Offset = "0x5D54E20", VA = "0x185D56020")]
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
		[Cpp2IlInjected.Address(RVA = "0x657040", Offset = "0x655E40", VA = "0x180657040")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x677F30", Offset = "0x676D30", VA = "0x180677F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xE17DB0", Offset = "0xE16BB0", VA = "0x180E17DB0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA2FC90", Offset = "0xA2EA90", VA = "0x180A2FC90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "4")]
	public virtual void FBPMKNABHGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
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
	[Cpp2IlInjected.Address(RVA = "0x312F460", Offset = "0x312E260", VA = "0x18312F460", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x312EB90", Offset = "0x312D990", VA = "0x18312EB90", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x312F9A0", Offset = "0x312E7A0", VA = "0x18312F9A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
		public EFADPOCGLGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1AC61A0", Offset = "0x1AC4FA0", VA = "0x181AC61A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x6578C0", VA = "0x180658AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1AE3E10", Offset = "0x1AE2C10", VA = "0x181AE3E10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1AE3E40", Offset = "0x1AE2C40", VA = "0x181AE3E40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1AE3D60", Offset = "0x1AE2B60", VA = "0x181AE3D60", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey CCJNKBLKLDJ]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1AE3D90", Offset = "0x1AE2B90", VA = "0x181AE3D90", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1AE3C60", Offset = "0x1AE2A60", VA = "0x181AE3C60", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1AE35E0", Offset = "0x1AE23E0", VA = "0x181AE35E0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1AE2CB0", Offset = "0x1AE1AB0", VA = "0x181AE2CB0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1AE2BC0", Offset = "0x1AE19C0", VA = "0x181AE2BC0", Slot = "14")]
	protected virtual string FNJLMLMFBBO(TKeyVal CAHHMHDOMJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1AE2B60", Offset = "0x1AE1960", VA = "0x181AE2B60", Slot = "4")]
	public bool ContainsKey(TKey CCJNKBLKLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1AE3B50", Offset = "0x1AE2950", VA = "0x181AE3B50", Slot = "5")]
	public bool TryGetValue(TKey CCJNKBLKLDJ, out TVal IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1AE2C20", Offset = "0x1AE1A20", VA = "0x181AE2C20", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1AE2C20", Offset = "0x1AE1A20", VA = "0x181AE2C20", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1AE3B80", Offset = "0x1AE2980", VA = "0x181AE3B80")]
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
		[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
		public FEGHEBNGINO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x259C1D0", Offset = "0x259AFD0", VA = "0x18259C1D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2669C30", Offset = "0x2668A30", VA = "0x182669C30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2669CB0", Offset = "0x2668AB0", VA = "0x182669CB0")]
	public FJODBEIAGNI(float PFEFIHOHHHJ, float IHEKBHOHGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2669A50", Offset = "0x2668850", VA = "0x182669A50")]
	public bool MIKLGOGDGGE(float EPNJJECKICP, T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2669150", Offset = "0x2667F50", VA = "0x182669150")]
	public int KKPPBHIPEOL(float EPNJJECKICP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x26691B0", Offset = "0x2667FB0", VA = "0x1826691B0")]
	public IEnumerable<T> LMFPILJPJPK(float EPNJJECKICP, [Optional] float? CGNHEIGCKCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2669120", Offset = "0x2667F20", VA = "0x182669120")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2669830", Offset = "0x2668630", VA = "0x182669830")]
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
		[Cpp2IlInjected.Address(RVA = "0xF3EEC0", Offset = "0xF3DCC0", VA = "0x180F3EEC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xF3EEF0", Offset = "0xF3DCF0", VA = "0x180F3EEF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x35F77A0", Offset = "0x35F65A0", VA = "0x1835F77A0")]
	public JBLGNAKMNJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x35F77D0", Offset = "0x35F65D0", VA = "0x1835F77D0")]
	public JBLGNAKMNJK(int MNKEEJPGFOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x35F6C10", Offset = "0x35F5A10", VA = "0x1835F6C10")]
	public void HEFJCCLOLGO(float EPNJJECKICP, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x35F6DD0", Offset = "0x35F5BD0", VA = "0x1835F6DD0")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x35F7370", Offset = "0x35F6170", VA = "0x1835F7370")]
	public bool KLCNLPGKMIO(float AEIJLDBDDCG, float EFOKDAAMCPK, out T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x35F62F0", Offset = "0x35F50F0", VA = "0x1835F62F0")]
	public bool BDBDOFMMLKL(float AEIJLDBDDCG, float EFOKDAAMCPK, out T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x35F6A30", Offset = "0x35F5830", VA = "0x1835F6A30")]
	public void EEBOCFACPNG(float AEIJLDBDDCG, float EFOKDAAMCPK, List<T> CLABEIKAHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x35F67B0", Offset = "0x35F55B0", VA = "0x1835F67B0")]
	private int DLCMMCGHOEB(int MEADGPNFDGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x35F6770", Offset = "0x35F5570", VA = "0x1835F6770")]
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
	[Cpp2IlInjected.Address(RVA = "0xF9F0E0", Offset = "0xF9DEE0", VA = "0x180F9F0E0", Slot = "4")]
	protected override Vector3 BNMBPOAOGGL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x10FAC00", Offset = "0x10F9A00", VA = "0x1810FAC00", Slot = "5")]
	protected override Vector3 ELIBCCJNKOK(Vector3 AIAIDPGGDMM, Vector3 PHPKEGMGOPM, float MGEGOIPHNMM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5D53F10", Offset = "0x5D52D10", VA = "0x185D53F10", Slot = "6")]
	protected override Vector3 JPODFEPGFHD(Vector3 IGJPNMBCJPK, float MGEGOIPHNMM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5D53F70", Offset = "0x5D52D70", VA = "0x185D53F70", Slot = "7")]
	protected override Vector3 MCOEAJIJENK(Vector3 AIAIDPGGDMM, Vector3 PHPKEGMGOPM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5D53EA0", Offset = "0x5D52CA0", VA = "0x185D53EA0", Slot = "8")]
	protected override Vector3 BPGCONMIABP(Vector3 AIAIDPGGDMM, Vector3 PHPKEGMGOPM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5D53FF0", Offset = "0x5D52DF0", VA = "0x185D53FF0")]
	public PDLIGFKKOIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PHEPHJMBCCF : global::JBLGNAKMNJK<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5D54A90", Offset = "0x5D53890", VA = "0x185D54A90")]
	public PHEPHJMBCCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5D54B00", Offset = "0x5D53900", VA = "0x185D54B00")]
	public PHEPHJMBCCF(int MNKEEJPGFOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xF41A80", Offset = "0xF40880", VA = "0x180F41A80", Slot = "4")]
	protected override float BNMBPOAOGGL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3492420", Offset = "0x3491220", VA = "0x183492420", Slot = "5")]
	protected override float ELIBCCJNKOK(float AIAIDPGGDMM, float PHPKEGMGOPM, float MGEGOIPHNMM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4E96C50", Offset = "0x4E95A50", VA = "0x184E96C50", Slot = "6")]
	protected override float JPODFEPGFHD(float IGJPNMBCJPK, float MGEGOIPHNMM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2626F80", Offset = "0x2625D80", VA = "0x182626F80", Slot = "7")]
	protected override float MCOEAJIJENK(float AIAIDPGGDMM, float PHPKEGMGOPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5D54A80", Offset = "0x5D53880", VA = "0x185D54A80", Slot = "8")]
	protected override float BPGCONMIABP(float AIAIDPGGDMM, float PHPKEGMGOPM)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class GCHNEANFBJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x20CA1F0", Offset = "0x20C8FF0", VA = "0x1820CA1F0")]
	public static global::LALDAEGJJFA<T1> DAKLFHBAJIH<T1>(T1 NMINDOPCKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x235C6B0", Offset = "0x235B4B0", VA = "0x18235C6B0")]
	public static global::PMABFILABJH<T1, T2> DAKLFHBAJIH<T1, T2>(T1 NMINDOPCKDG, T2 DDEJHDMCLOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x235C720", Offset = "0x235B520", VA = "0x18235C720")]
	public static global::GMGCAJLHPIK<T1, T2, T3> DAKLFHBAJIH<T1, T2, T3>(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x235CA90", Offset = "0x235B890", VA = "0x18235CA90")]
	public static global::CLFHCNPKBOH<T1, T2, T3, T4> DAKLFHBAJIH<T1, T2, T3, T4>(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC, T4 FPPJLFGGHIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x235C9F0", Offset = "0x235B7F0", VA = "0x18235C9F0")]
	public static global::CAPGKAKHPDC<T1, T2, T3, T4, T5> DAKLFHBAJIH<T1, T2, T3, T4, T5>(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC, T4 FPPJLFGGHIM, T5 GBLFKENMGAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x235C940", Offset = "0x235B740", VA = "0x18235C940")]
	public static global::KHOGFEGEPPG<T1, T2, T3, T4, T5, T6> DAKLFHBAJIH<T1, T2, T3, T4, T5, T6>(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC, T4 FPPJLFGGHIM, T5 GBLFKENMGAO, T6 FPLIGHFBGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x235C880", Offset = "0x235B680", VA = "0x18235C880")]
	public static global::PLDBIEDAKMI<T1, T2, T3, T4, T5, T6, T7> DAKLFHBAJIH<T1, T2, T3, T4, T5, T6, T7>(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC, T4 FPPJLFGGHIM, T5 GBLFKENMGAO, T6 FPLIGHFBGCD, T7 GPDCNGPPIBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x235C7B0", Offset = "0x235B5B0", VA = "0x18235C7B0")]
	public static global::DEKMENFBCJI<T1, T2, T3, T4, T5, T6, T7, T8> DAKLFHBAJIH<T1, T2, T3, T4, T5, T6, T7, T8>(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC, T4 FPPJLFGGHIM, T5 GBLFKENMGAO, T6 FPLIGHFBGCD, T7 GPDCNGPPIBB, T8 OEMHJNGLELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x152B230", Offset = "0x152A030", VA = "0x18152B230")]
	[IteratorStateMachine(typeof(JGNFANIOHJJ))]
	public static IEnumerable<global::PMABFILABJH<T1, T2>> KAGONGNLDCG<T1, T2>(IEnumerable<T1> BMPDKJEHGIN, IEnumerable<T2> BMMLDIMMAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x152B410", Offset = "0x152A210", VA = "0x18152B410")]
	[IteratorStateMachine(typeof(CNNFKOIEOMN))]
	public static IEnumerable<global::GMGCAJLHPIK<T1, T2, T3>> KAGONGNLDCG<T1, T2, T3>(IEnumerable<T1> BMPDKJEHGIN, IEnumerable<T2> BMMLDIMMAAK, IEnumerable<T3> KDPJFGIFCOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x815500", Offset = "0x814300", VA = "0x180815500")]
	internal static int KAIAGLGGKBN(int KDGFGJINLNH, int MKOOFNNADNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8154F0", Offset = "0x8142F0", VA = "0x1808154F0")]
	internal static int KAIAGLGGKBN(int KDGFGJINLNH, int MKOOFNNADNC, int OAHNOOAJAIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8154D0", Offset = "0x8142D0", VA = "0x1808154D0")]
	internal static int KAIAGLGGKBN(int KDGFGJINLNH, int MKOOFNNADNC, int OAHNOOAJAIM, int HBAHEGCGDKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5D50B00", Offset = "0x5D4F900", VA = "0x185D50B00")]
	internal static int KAIAGLGGKBN(int KDGFGJINLNH, int MKOOFNNADNC, int OAHNOOAJAIM, int HBAHEGCGDKF, int GEAPDGBPDNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5D50B20", Offset = "0x5D4F920", VA = "0x185D50B20")]
	internal static int KAIAGLGGKBN(int KDGFGJINLNH, int MKOOFNNADNC, int OAHNOOAJAIM, int HBAHEGCGDKF, int GEAPDGBPDNE, int FOBOIBCDKHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5D50B70", Offset = "0x5D4F970", VA = "0x185D50B70")]
	internal static int KAIAGLGGKBN(int KDGFGJINLNH, int MKOOFNNADNC, int OAHNOOAJAIM, int HBAHEGCGDKF, int GEAPDGBPDNE, int FOBOIBCDKHN, int MAEKELKOLGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5D50B40", Offset = "0x5D4F940", VA = "0x185D50B40")]
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
	[Cpp2IlInjected.Address(RVA = "0x17ABF10", Offset = "0x17AAD10", VA = "0x1817ABF10")]
	public LALDAEGJJFA(T1 NMINDOPCKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3B07E70", Offset = "0x3B06C70", VA = "0x183B07E70", Slot = "4")]
	public int CompareTo(global::LALDAEGJJFA<T1> HNOJKNGFFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3B07EE0", Offset = "0x3B06CE0", VA = "0x183B07EE0", Slot = "0")]
	public override bool Equals(object HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xD0BA20", Offset = "0xD0A820", VA = "0x180D0BA20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3B07F80", Offset = "0x3B06D80", VA = "0x183B07F80", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x35ED0B0", Offset = "0x35EBEB0", VA = "0x1835ED0B0")]
	public PMABFILABJH(T1 NMINDOPCKDG, T2 DDEJHDMCLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x35EB2B0", Offset = "0x35EA0B0", VA = "0x1835EB2B0", Slot = "4")]
	public int CompareTo(global::PMABFILABJH<T1, T2> HNOJKNGFFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x35EB6F0", Offset = "0x35EA4F0", VA = "0x1835EB6F0", Slot = "0")]
	public override bool Equals(object HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x35EC390", Offset = "0x35EB190", VA = "0x1835EC390", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x35ECAA0", Offset = "0x35EB8A0", VA = "0x1835ECAA0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BBA810", Offset = "0x2BB9610", VA = "0x182BBA810")]
	public GMGCAJLHPIK(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA000", Offset = "0x2BB8E00", VA = "0x182BBA000", Slot = "4")]
	public int CompareTo(global::GMGCAJLHPIK<T1, T2, T3> HNOJKNGFFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA2F0", Offset = "0x2BB90F0", VA = "0x182BBA2F0", Slot = "0")]
	public override bool Equals(object HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA4F0", Offset = "0x2BB92F0", VA = "0x182BBA4F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA660", Offset = "0x2BB9460", VA = "0x182BBA660", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x2601F10", Offset = "0x2600D10", VA = "0x182601F10")]
	public CLFHCNPKBOH(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC, T4 FPPJLFGGHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2601AC0", Offset = "0x26008C0", VA = "0x182601AC0", Slot = "4")]
	public int CompareTo(global::CLFHCNPKBOH<T1, T2, T3, T4> HNOJKNGFFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2601C00", Offset = "0x2600A00", VA = "0x182601C00", Slot = "0")]
	public override bool Equals(object HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2601D20", Offset = "0x2600B20", VA = "0x182601D20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2601DE0", Offset = "0x2600BE0", VA = "0x182601DE0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x28F2A20", Offset = "0x28F1820", VA = "0x1828F2A20")]
	public CAPGKAKHPDC(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC, T4 FPPJLFGGHIM, T5 GBLFKENMGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x34036E0", Offset = "0x34024E0", VA = "0x1834036E0", Slot = "4")]
	public int CompareTo(global::CAPGKAKHPDC<T1, T2, T3, T4, T5> HNOJKNGFFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3403860", Offset = "0x3402660", VA = "0x183403860", Slot = "0")]
	public override bool Equals(object HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x34039A0", Offset = "0x34027A0", VA = "0x1834039A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3403AA0", Offset = "0x34028A0", VA = "0x183403AA0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x310C460", Offset = "0x310B260", VA = "0x18310C460")]
	public KHOGFEGEPPG(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC, T4 FPPJLFGGHIM, T5 GBLFKENMGAO, T6 FPLIGHFBGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x310BEA0", Offset = "0x310ACA0", VA = "0x18310BEA0", Slot = "4")]
	public int CompareTo(global::KHOGFEGEPPG<T1, T2, T3, T4, T5, T6> HNOJKNGFFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x310C060", Offset = "0x310AE60", VA = "0x18310C060", Slot = "0")]
	public override bool Equals(object HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x310C1D0", Offset = "0x310AFD0", VA = "0x18310C1D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x310C2F0", Offset = "0x310B0F0", VA = "0x18310C2F0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x3172BF0", Offset = "0x31719F0", VA = "0x183172BF0")]
	public PLDBIEDAKMI(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC, T4 FPPJLFGGHIM, T5 GBLFKENMGAO, T6 FPLIGHFBGCD, T7 GPDCNGPPIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3172570", Offset = "0x3171370", VA = "0x183172570", Slot = "4")]
	public int CompareTo(global::PLDBIEDAKMI<T1, T2, T3, T4, T5, T6, T7> HNOJKNGFFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3172770", Offset = "0x3171570", VA = "0x183172770", Slot = "0")]
	public override bool Equals(object HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3172910", Offset = "0x3171710", VA = "0x183172910", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3172A60", Offset = "0x3171860", VA = "0x183172A60", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x26FBD00", Offset = "0x26FAB00", VA = "0x1826FBD00")]
	public DEKMENFBCJI(T1 NMINDOPCKDG, T2 DDEJHDMCLOA, T3 POEHBDGICHC, T4 FPPJLFGGHIM, T5 GBLFKENMGAO, T6 FPLIGHFBGCD, T7 GPDCNGPPIBB, T8 OEMHJNGLELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x26FB5D0", Offset = "0x26FA3D0", VA = "0x1826FB5D0", Slot = "4")]
	public int CompareTo(global::DEKMENFBCJI<T1, T2, T3, T4, T5, T6, T7, T8> HNOJKNGFFBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x26FB820", Offset = "0x26FA620", VA = "0x1826FB820", Slot = "0")]
	public override bool Equals(object HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x26FB9E0", Offset = "0x26FA7E0", VA = "0x1826FB9E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x26FBB50", Offset = "0x26FA950", VA = "0x1826FBB50", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x1963360", Offset = "0x1962160", VA = "0x181963360")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3975500", Offset = "0x3974300", VA = "0x183975500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float OHKFNMEMBFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x11CBD30", Offset = "0x11CAB30", VA = "0x1811CBD30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3975930", Offset = "0x3974730", VA = "0x183975930")]
	public T IDMFPCCIJGG(float MGEGOIPHNMM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3975580", Offset = "0x3974380", VA = "0x183975580")]
	public T BELDBJKBCMF(float MGEGOIPHNMM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T ELIBCCJNKOK(T AIAIDPGGDMM, T PHPKEGMGOPM, float MGEGOIPHNMM);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3492420", Offset = "0x3491220", VA = "0x183492420", Slot = "4")]
	protected override float ELIBCCJNKOK(float AIAIDPGGDMM, float PHPKEGMGOPM, float MGEGOIPHNMM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D50850", Offset = "0x5D4F650", VA = "0x185D50850")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x10FAC00", Offset = "0x10F9A00", VA = "0x1810FAC00", Slot = "4")]
	protected override Vector3 ELIBCCJNKOK(Vector3 AIAIDPGGDMM, Vector3 PHPKEGMGOPM, float MGEGOIPHNMM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5D572C0", Offset = "0x5D560C0", VA = "0x185D572C0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5D501B0", Offset = "0x5D4EFB0", VA = "0x185D501B0", Slot = "4")]
	protected override Color ELIBCCJNKOK(Color AIAIDPGGDMM, Color PHPKEGMGOPM, float MGEGOIPHNMM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5D50200", Offset = "0x5D4F000", VA = "0x185D50200")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class JMGENFMKBJM : global::IGFGNFBNCFM<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5D51B10", Offset = "0x5D50910", VA = "0x185D51B10")]
	public JMGENFMKBJM(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5D51B60", Offset = "0x5D50960", VA = "0x185D51B60")]
	public JMGENFMKBJM(BFKLEOLBFKE[] NGBKPJMNOJL, bool CJEDMAAIJEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5D51AA0", Offset = "0x5D508A0", VA = "0x185D51AA0", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public INLHGLENJLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5D51890", Offset = "0x5D50690", VA = "0x185D51890")]
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
	[Cpp2IlInjected.Address(RVA = "0xB712D0", Offset = "0xB700D0", VA = "0x180B712D0")]
	private CCFKCPBJFFM(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<NOAPHGCLLPE>> GMDNKLDPALN, int IKOLEADJCBB, int IPNILBFBOEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F6C0", Offset = "0x5D4E4C0", VA = "0x185D4F6C0")]
	public static CCFKCPBJFFM MIHDEIPKAKJ()
	{
		return default(CCFKCPBJFFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F2D0", Offset = "0x5D4E0D0", VA = "0x185D4F2D0")]
	public (int, int, Task) DAOPLKHGKIO(int KKLMLLAHIKF, [Optional] CancellationToken GPNLCIOKAPO)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F1F0", Offset = "0x5D4DFF0", VA = "0x185D4F1F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x17B4FA0", Offset = "0x17B3DA0", VA = "0x1817B4FA0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool OONDNCJIJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x65AD00", Offset = "0x659B00", VA = "0x18065AD00", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> GNHOOAGJOGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x23C5300", Offset = "0x23C4100", VA = "0x1823C5300", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> BKNOINJLBPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x1FC5ED0", Offset = "0x1FC4CD0", VA = "0x181FC5ED0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x259BE10", Offset = "0x259AC10", VA = "0x18259BE10", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x259BE40", Offset = "0x259AC40", VA = "0x18259BE40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x259B7F0", Offset = "0x259A5F0", VA = "0x18259B7F0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x259B570", Offset = "0x259A370", VA = "0x18259B570")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x259B450", Offset = "0x259A250", VA = "0x18259B450", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x259BC90", Offset = "0x259AA90", VA = "0x18259BC90", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x259B280", Offset = "0x259A080", VA = "0x18259B280", Slot = "9")]
	public void Add(TKey CCJNKBLKLDJ, TVal IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x259B2E0", Offset = "0x259A0E0", VA = "0x18259B2E0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x259B4B0", Offset = "0x259A2B0", VA = "0x18259B4B0", Slot = "8")]
	public bool ContainsKey(TKey CCJNKBLKLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5900", Offset = "0x1FC4700", VA = "0x181FC5900", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x259BC60", Offset = "0x259AA60", VA = "0x18259BC60", Slot = "10")]
	public bool Remove(TKey CCJNKBLKLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x259BC60", Offset = "0x259AA60", VA = "0x18259BC60", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x17B69C0", Offset = "0x17B57C0", VA = "0x1817B69C0", Slot = "11")]
	public bool TryGetValue(TKey CCJNKBLKLDJ, out TVal IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x259B680", Offset = "0x259A480", VA = "0x18259B680", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x259B510", Offset = "0x259A310", VA = "0x18259B510", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] DEJEDNNJILK, int AGJLGNIMOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x259B770", Offset = "0x259A570", VA = "0x18259B770")]
	public void HEFJCCLOLGO(TVal BIILFBFAAOF, TKey CCJNKBLKLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x259B7B0", Offset = "0x259A5B0", VA = "0x18259B7B0")]
	public void HEFJCCLOLGO(KeyValuePair<TVal, TKey> GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x259B650", Offset = "0x259A450", VA = "0x18259B650")]
	public bool GAOLFNHFINJ(TVal CCJNKBLKLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x259B5F0", Offset = "0x259A3F0", VA = "0x18259B5F0")]
	public bool FKLGFCOHCLF(KeyValuePair<TVal, TKey> GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x259B220", Offset = "0x259A020", VA = "0x18259B220")]
	public bool AKJLIPOIGHF(TVal CCJNKBLKLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x259B220", Offset = "0x259A020", VA = "0x18259B220")]
	public bool AKJLIPOIGHF(KeyValuePair<TVal, TKey> GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x259B310", Offset = "0x259A110", VA = "0x18259B310")]
	public bool CECEMJJAJEO(TVal CCJNKBLKLDJ, out TKey IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x259B8B0", Offset = "0x259A6B0", VA = "0x18259B8B0")]
	public IEnumerator<KeyValuePair<TVal, TKey>> MBDPPCMHIHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x259B340", Offset = "0x259A140", VA = "0x18259B340")]
	private void CJMLMJJNOLA(TKey CCJNKBLKLDJ, TVal BIILFBFAAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x259B1A0", Offset = "0x2599FA0", VA = "0x18259B1A0")]
	private void AKEMGCGHGMJ(TKey CCJNKBLKLDJ, TVal BIILFBFAAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x259BAB0", Offset = "0x259A8B0", VA = "0x18259BAB0")]
	private bool OMFGKOPAABL(TKey CCJNKBLKLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x259B930", Offset = "0x259A730", VA = "0x18259B930")]
	private bool OMFGKOPAABL(TVal BIILFBFAAOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x259BD30", Offset = "0x259AB30", VA = "0x18259BD30")]
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
			[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x6578C0", VA = "0x180658AC0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2C21F50", Offset = "0x2C20D50", VA = "0x182C21F50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2C23660", Offset = "0x2C22460", VA = "0x182C23660")]
		public Enumerator(global::DODFIGEAAMK<T> CLABEIKAHOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2C1E1D0", Offset = "0x2C1CFD0", VA = "0x182C1E1D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2C1FBA0", Offset = "0x2C1E9A0", VA = "0x182C1FBA0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2C1EF40", Offset = "0x2C1DD40", VA = "0x182C1EF40")]
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
		[Cpp2IlInjected.Address(RVA = "0x359B540", Offset = "0x359A340", VA = "0x18359B540")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x359B6D0", Offset = "0x359A4D0", VA = "0x18359B6D0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x359B1A0", Offset = "0x3599FA0", VA = "0x18359B1A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x359CE30", Offset = "0x359BC30", VA = "0x18359CE30")]
	public DODFIGEAAMK(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x359B480", Offset = "0x359A280", VA = "0x18359B480")]
	public void HEFJCCLOLGO(T MGEGOIPHNMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x359BD40", Offset = "0x359AB40", VA = "0x18359BD40")]
	public void MBOIAEPEMME(IEnumerable<T> IEJLANBMLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x359B580", Offset = "0x359A380", VA = "0x18359B580")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x359AEF0", Offset = "0x3599CF0", VA = "0x18359AEF0")]
	public void AFMOCBFFKLG(int KOHJDBBJEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x359C6E0", Offset = "0x359B4E0", VA = "0x18359C6E0")]
	public void NLNAGEFBDKO(int KOHJDBBJEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x359CA10", Offset = "0x359B810", VA = "0x18359CA10")]
	public void PPKHELNFGHN(T[] DEJEDNNJILK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x359AFF0", Offset = "0x3599DF0", VA = "0x18359AFF0")]
	public Enumerator BALJJOIEHDJ()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x359CDB0", Offset = "0x359BBB0", VA = "0x18359CDB0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x359CDB0", Offset = "0x359BBB0", VA = "0x18359CDB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x359C5F0", Offset = "0x359B3F0", VA = "0x18359C5F0")]
	private int NKPOMEGNFJL(int AIPHGHFENPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x359B220", Offset = "0x359A020", VA = "0x18359B220")]
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
		[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x656F20", VA = "0x180658120")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x658130", Offset = "0x656F30", VA = "0x180658130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool OONDNCJIJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x762B40", Offset = "0x761940", VA = "0x180762B40", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x711170", Offset = "0x70FF70", VA = "0x180711170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public External MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3413D90", Offset = "0x3412B90", VA = "0x183413D90", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3413E30", Offset = "0x3412C30", VA = "0x183413E30", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3413D30", Offset = "0x3412B30", VA = "0x183413D30", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3160BD0", Offset = "0x315F9D0", VA = "0x183160BD0")]
	public CEOPBBNBALE(Func<Internal, External> DMOLCMIDIPC, Func<External, Internal> NKGCIMMLMNL, bool EFNCJMHMODB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3413A50", Offset = "0x3412850", VA = "0x183413A50", Slot = "6")]
	public int IndexOf(External GDCPKDNOEGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x34136D0", Offset = "0x34124D0", VA = "0x1834136D0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3413730", Offset = "0x3412530", VA = "0x183413730", Slot = "13")]
	public bool Contains(External GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x34137C0", Offset = "0x34125C0", VA = "0x1834137C0", Slot = "14")]
	public void CopyTo(External[] DEJEDNNJILK, int AGJLGNIMOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x34135E0", Offset = "0x34123E0", VA = "0x1834135E0", Slot = "11")]
	public void Add(External GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3413B40", Offset = "0x3412940", VA = "0x183413B40", Slot = "7")]
	public void Insert(int AIPHGHFENPJ, External GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3413CA0", Offset = "0x3412AA0", VA = "0x183413CA0", Slot = "15")]
	public bool Remove(External GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3413BE0", Offset = "0x34129E0", VA = "0x183413BE0", Slot = "8")]
	public void RemoveAt(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x34139E0", Offset = "0x34127E0", VA = "0x1834139E0", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x1ACD550", Offset = "0x1ACC350", VA = "0x181ACD550", Slot = "17")]
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
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x677140", Offset = "0x675F40", VA = "0x180677140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool OONDNCJIJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x678020", Offset = "0x676E20", VA = "0x180678020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public External MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2D8F9A0", Offset = "0x2D8E7A0", VA = "0x182D8F9A0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2D8F940", Offset = "0x2D8E740", VA = "0x182D8F940", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x17ABF10", Offset = "0x17AAD10", VA = "0x1817ABF10")]
	public JNJFGLHJIAA(Func<Internal, External> DMOLCMIDIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2D8F8F0", Offset = "0x2D8E6F0", VA = "0x182D8F8F0")]
	public JNJFGLHJIAA(IReadOnlyList<Internal> LPDILHBGHIJ, Func<Internal, External> DMOLCMIDIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2D8F6D0", Offset = "0x2D8E4D0", VA = "0x182D8F6D0")]
	public void PPKHELNFGHN(External[] DEJEDNNJILK, int AGJLGNIMOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2D8F660", Offset = "0x2D8E460", VA = "0x182D8F660", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1EC89E0", Offset = "0x1EC77E0", VA = "0x181EC89E0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x6578C0", VA = "0x180658AC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x677130", Offset = "0x675F30", VA = "0x180677130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool OONDNCJIJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x678020", Offset = "0x676E20", VA = "0x180678020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public External MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x1ADB590", Offset = "0x1ADA390", VA = "0x181ADB590", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x1ADB530", Offset = "0x1ADA330", VA = "0x181ADB530", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x17ABF10", Offset = "0x17AAD10", VA = "0x1817ABF10")]
	public ENHAAEOHKMG(IReadOnlyList<Internal> LPDILHBGHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x1ADB1F0", Offset = "0x1AD9FF0", VA = "0x181ADB1F0")]
	public bool FKLGFCOHCLF(External GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x1ADB300", Offset = "0x1ADA100", VA = "0x181ADB300")]
	public void PPKHELNFGHN(External[] DEJEDNNJILK, int AGJLGNIMOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x1ADB290", Offset = "0x1ADA090", VA = "0x181ADB290", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1ACD550", Offset = "0x1ACC350", VA = "0x181ACD550", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2766F40", Offset = "0x2765D40", VA = "0x182766F40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2767380", Offset = "0x2766180", VA = "0x182767380")]
	protected MGFMFOPAFMH(bool BFGABEDFGDF, bool IFHECGMDCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2766F80", Offset = "0x2765D80", VA = "0x182766F80")]
	protected bool IHANIHNJOHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2767110", Offset = "0x2765F10", VA = "0x182767110")]
	protected void KCDLPJCFPBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x27671D0", Offset = "0x2765FD0", VA = "0x1827671D0")]
	protected void OPBGBGHEECH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x27EEF60", Offset = "0x27EDD60", VA = "0x1827EEF60")]
	private static void ECHDNBIJIMA<U>(ref List<U> LPDILHBGHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2766DE0", Offset = "0x2765BE0", VA = "0x182766DE0", Slot = "5")]
	public void HEFJCCLOLGO(T CGKOOFFNHKL, bool AKNODPLKBJA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2766CA0", Offset = "0x2765AA0", VA = "0x182766CA0", Slot = "6")]
	public void AKJLIPOIGHF(T CGKOOFFNHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2767000", Offset = "0x2765E00", VA = "0x182767000")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D51250", Offset = "0x5D50050", VA = "0x185D51250")]
	public HOPKEKFNJGO(bool BFGABEDFGDF = false, bool IFHECGMDCMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5D51040", Offset = "0x5D4FE40", VA = "0x185D51040")]
	public void PFJMFFOKNBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5D50F10", Offset = "0x5D4FD10", VA = "0x185D50F10", Slot = "4")]
	public override void BOFGMCIJMOB(object[] KMLLOCJHKPB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5D50F80", Offset = "0x5D4FD80", VA = "0x185D50F80")]
	public static HOPKEKFNJGO KFDPIIJCIIP(HOPKEKFNJGO FCEJCCPBICH, Action CGKOOFFNHKL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5D50FE0", Offset = "0x5D4FDE0", VA = "0x185D50FE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1AD10B0", Offset = "0x1ACFEB0", VA = "0x181AD10B0")]
	public DGLAMKJBKDM(bool BFGABEDFGDF = false, bool IFHECGMDCMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x27010A0", Offset = "0x26FFEA0", VA = "0x1827010A0")]
	public void PFJMFFOKNBK(T MGEGOIPHNMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x26FF590", Offset = "0x26FE390", VA = "0x1826FF590", Slot = "4")]
	public override void BOFGMCIJMOB(object[] KMLLOCJHKPB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2700F60", Offset = "0x26FFD60", VA = "0x182700F60")]
	public static global::DGLAMKJBKDM<T> KFDPIIJCIIP(global::DGLAMKJBKDM<T> FCEJCCPBICH, Action<T> CGKOOFFNHKL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2701000", Offset = "0x26FFE00", VA = "0x182701000")]
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
	[Cpp2IlInjected.Address(RVA = "0x1AD10B0", Offset = "0x1ACFEB0", VA = "0x181AD10B0")]
	public LLCCCNFJKCL(bool BFGABEDFGDF = false, bool IFHECGMDCMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x2E36D30", Offset = "0x2E35B30", VA = "0x182E36D30")]
	public void PFJMFFOKNBK(T MGEGOIPHNMM, U NDFNJFAPKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x2E342D0", Offset = "0x2E330D0", VA = "0x182E342D0", Slot = "4")]
	public override void BOFGMCIJMOB(object[] KMLLOCJHKPB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2E35C30", Offset = "0x2E34A30", VA = "0x182E35C30")]
	public static global::LLCCCNFJKCL<T, U> KFDPIIJCIIP(global::LLCCCNFJKCL<T, U> FCEJCCPBICH, Action<T, U> CGKOOFFNHKL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2E35CD0", Offset = "0x2E34AD0", VA = "0x182E35CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1AD10B0", Offset = "0x1ACFEB0", VA = "0x181AD10B0")]
	public EJCHHEKFLCK(bool BFGABEDFGDF = false, bool IFHECGMDCMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x1ACFEF0", Offset = "0x1ACECF0", VA = "0x181ACFEF0")]
	public void PFJMFFOKNBK(T MGEGOIPHNMM, U NDFNJFAPKCG, V HFMHCLGICNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x1ACE910", Offset = "0x1ACD710", VA = "0x181ACE910", Slot = "4")]
	public override void BOFGMCIJMOB(object[] KMLLOCJHKPB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x1ACF160", Offset = "0x1ACDF60", VA = "0x181ACF160")]
	public static global::EJCHHEKFLCK<T, U, V> KFDPIIJCIIP(global::EJCHHEKFLCK<T, U, V> FCEJCCPBICH, Action<T, U, V> CGKOOFFNHKL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x1ACF200", Offset = "0x1ACE000", VA = "0x181ACF200")]
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
	[Cpp2IlInjected.Address(RVA = "0x1AD10B0", Offset = "0x1ACFEB0", VA = "0x181AD10B0")]
	public BPHJINJDCNI(bool BFGABEDFGDF = false, bool IFHECGMDCMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x1EC2C80", Offset = "0x1EC1A80", VA = "0x181EC2C80")]
	public void PFJMFFOKNBK(T MGEGOIPHNMM, U NDFNJFAPKCG, V HFMHCLGICNJ, W KKGHEBDDELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x1EC0440", Offset = "0x1EBF240", VA = "0x181EC0440", Slot = "4")]
	public override void BOFGMCIJMOB(object[] KMLLOCJHKPB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x1EC18B0", Offset = "0x1EC06B0", VA = "0x181EC18B0")]
	public static global::BPHJINJDCNI<T, U, V, W> KFDPIIJCIIP(global::BPHJINJDCNI<T, U, V, W> FCEJCCPBICH, Action<T, U, V, W> CGKOOFFNHKL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x1EC1950", Offset = "0x1EC0750", VA = "0x181EC1950")]
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
	[Cpp2IlInjected.Address(RVA = "0x1AD10B0", Offset = "0x1ACFEB0", VA = "0x181AD10B0")]
	public FLKKAPMNAPH(bool BFGABEDFGDF = false, bool IFHECGMDCMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x266D5D0", Offset = "0x266C3D0", VA = "0x18266D5D0")]
	public void PFJMFFOKNBK(T MGEGOIPHNMM, U NDFNJFAPKCG, V HFMHCLGICNJ, W KKGHEBDDELA, X KNMKEOOODCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x266D1A0", Offset = "0x266BFA0", VA = "0x18266D1A0", Slot = "4")]
	public override void BOFGMCIJMOB(object[] KMLLOCJHKPB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x266D490", Offset = "0x266C290", VA = "0x18266D490")]
	public static global::FLKKAPMNAPH<T, U, V, W, X> KFDPIIJCIIP(global::FLKKAPMNAPH<T, U, V, W, X> FCEJCCPBICH, Action<T, U, V, W, X> CGKOOFFNHKL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x266D530", Offset = "0x266C330", VA = "0x18266D530")]
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
	[Cpp2IlInjected.Address(RVA = "0x1AD10B0", Offset = "0x1ACFEB0", VA = "0x181AD10B0")]
	public BJEBAFPKEPO(bool BFGABEDFGDF = false, bool IFHECGMDCMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x24F3A80", Offset = "0x24F2880", VA = "0x1824F3A80")]
	public void PFJMFFOKNBK(T MGEGOIPHNMM, U NDFNJFAPKCG, V HFMHCLGICNJ, W KKGHEBDDELA, X KNMKEOOODCL, Y EMKKILCIAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x24F3600", Offset = "0x24F2400", VA = "0x1824F3600", Slot = "4")]
	public override void BOFGMCIJMOB(object[] KMLLOCJHKPB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x24F3940", Offset = "0x24F2740", VA = "0x1824F3940")]
	public static global::BJEBAFPKEPO<T, U, V, W, X, Y> KFDPIIJCIIP(global::BJEBAFPKEPO<T, U, V, W, X, Y> FCEJCCPBICH, Action<T, U, V, W, X, Y> CGKOOFFNHKL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x24F39E0", Offset = "0x24F27E0", VA = "0x1824F39E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x23D4770", Offset = "0x23D3570", VA = "0x1823D4770")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x23D4740", Offset = "0x23D3540", VA = "0x1823D4740", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8648F0", Offset = "0x8636F0", VA = "0x1808648F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x23B3C80", Offset = "0x23B2A80", VA = "0x1823B3C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x1FFA980", Offset = "0x1FF9780", VA = "0x181FFA980", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x24F2D90", Offset = "0x24F1B90", VA = "0x1824F2D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x1FFA980", Offset = "0x1FF9780", VA = "0x181FFA980", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x359CED0", Offset = "0x359BCD0", VA = "0x18359CED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x359D540", Offset = "0x359C340", VA = "0x18359D540")]
	public DPDBANLLCHB(in T ADCLMADMKEO, int EOLLBDABFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x359D510", Offset = "0x359C310", VA = "0x18359D510")]
	public DPDBANLLCHB(in T ADCLMADMKEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x359D4D0", Offset = "0x359C2D0", VA = "0x18359D4D0")]
	public APJLHEHHPLO KNHOBDNOPAG()
	{
		return default(APJLHEHHPLO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x359D490", Offset = "0x359C290", VA = "0x18359D490")]
	public APJLHEHHPLO KNHOBDNOPAG(CancellationToken GPNLCIOKAPO)
	{
		return default(APJLHEHHPLO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x359D330", Offset = "0x359C130", VA = "0x18359D330")]
	[AsyncStateMachine(typeof(global::DPDBANLLCHB<>.ADIDHHDFJJE))]
	public Task<APJLHEHHPLO> JILDGGEHMAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x359D050", Offset = "0x359BE50", VA = "0x18359D050")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D52DF0", Offset = "0x5D51BF0", VA = "0x185D52DF0")]
	public static global::DPDBANLLCHB<NOAPHGCLLPE> MIHDEIPKAKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5D52E50", Offset = "0x5D51C50", VA = "0x185D52E50")]
	public static global::DPDBANLLCHB<NOAPHGCLLPE> MIHDEIPKAKJ(int EOLLBDABFNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x20CA1F0", Offset = "0x20C8FF0", VA = "0x1820CA1F0")]
	public static global::DPDBANLLCHB<T> MIHDEIPKAKJ<T>(in T ADCLMADMKEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x236A0D0", Offset = "0x2368ED0", VA = "0x18236A0D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2915730", Offset = "0x2914530", VA = "0x182915730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan HMADCCDOBKA
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x6578C0", VA = "0x180658AC0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2915810", Offset = "0x2914610", VA = "0x182915810")]
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
		[Cpp2IlInjected.Address(RVA = "0x276F9D0", Offset = "0x276E7D0", VA = "0x18276F9D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
		public IIPKFMMJLMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x17B4FA0", Offset = "0x17B3DA0", VA = "0x1817B4FA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x25065D0", Offset = "0x25053D0", VA = "0x1825065D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F70990", Offset = "0x2F6F790", VA = "0x182F70990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E120", VA = "0x18065F320", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3590BF0", Offset = "0x358F9F0", VA = "0x183590BF0")]
	public DNBNOMMLHDF(CCGPMIENEGA GCFALEHIFLC, [Optional] HEACGNJJANC FDDPIIDBENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x358FDC0", Offset = "0x358EBC0", VA = "0x18358FDC0")]
	public Task<TResult> MALNAJHIBFG(TRequest NMKJPBEONAN, CancellationToken GPNLCIOKAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x358F200", Offset = "0x358E000", VA = "0x18358F200")]
	private void ACDFKBIFHGN(MKIDIHDKCME CJGJCKBAIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x35904D0", Offset = "0x358F2D0", VA = "0x1835904D0")]
	[AsyncStateMachine(typeof(global::DNBNOMMLHDF<, >.BNGJMLIDHKL))]
	private Task MCEBBCLHLJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x358FB70", Offset = "0x358E970", VA = "0x18358FB70")]
	private MKIDIHDKCME ICCBDBEBDBJ()
	{
		return default(MKIDIHDKCME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x358F5A0", Offset = "0x358E3A0", VA = "0x18358F5A0")]
	[AsyncStateMachine(typeof(global::DNBNOMMLHDF<, >.OACBKAOOALJ))]
	private Task GFCGGNHPJCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3590970", Offset = "0x358F770", VA = "0x183590970")]
	private void OGJLEIEFKOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x358F320", Offset = "0x358E120", VA = "0x18358F320", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x41FD960", Offset = "0x41FC760", VA = "0x1841FD960", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int OACNGCDEPNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x41FD930", Offset = "0x41FC730", VA = "0x1841FD930")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x41FDA30", Offset = "0x41FC830", VA = "0x1841FDA30", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x41FDF40", Offset = "0x41FCD40", VA = "0x1841FDF40")]
	public BCJGEIEPHMJ(int CHMDLBBFMNF, [Optional] POIMLJHIOIB BGOKELNJCKK, [Optional] IEqualityComparer<TKey> EMOGODJCHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x41FD990", Offset = "0x41FC790", VA = "0x1841FD990")]
	public void HLAPECFMGBJ(TKey CCJNKBLKLDJ, TVal IGJPNMBCJPK, bool AFFICNKLOAK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x41FDB00", Offset = "0x41FC900", VA = "0x1841FDB00")]
	public bool JGFCJGCMJIK(TKey CCJNKBLKLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x41FD890", Offset = "0x41FC690", VA = "0x1841FD890", Slot = "6")]
	public override bool CECEMJJAJEO(TKey ANHJHIFLNAP, out TVal IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x41FDC20", Offset = "0x41FCA20", VA = "0x1841FDC20")]
	public bool KJCKEGMFBCA(TKey CCJNKBLKLDJ, TVal IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x41FDE30", Offset = "0x41FCC30", VA = "0x1841FDE30")]
	public bool PNCCILMHKNM(TKey CCJNKBLKLDJ, TVal IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x41FDA90", Offset = "0x41FC890", VA = "0x1841FDA90", Slot = "7")]
	public override void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x41FDB80", Offset = "0x41FC980", VA = "0x1841FDB80")]
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
			[Cpp2IlInjected.Address(RVA = "0xE11EB0", Offset = "0xE10CB0", VA = "0x180E11EB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x656F20", VA = "0x180658120")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x658130", Offset = "0x656F30", VA = "0x180658130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int PANMOHPAPDK
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x6791B0", Offset = "0x677FB0", VA = "0x1806791B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xB1BCF0", Offset = "0xB1AAF0", VA = "0x180B1BCF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public DateTime EBOIDOANILN
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x66D6F0", Offset = "0x66C4F0", VA = "0x18066D6F0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xCBC3C0", Offset = "0xCBB1C0", VA = "0x180CBC3C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2EA8F40", Offset = "0x2EA7D40", VA = "0x182EA8F40")]
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
		[Cpp2IlInjected.Address(RVA = "0x657020", Offset = "0x655E20", VA = "0x180657020")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FD3CD0", Offset = "0x1FD2AD0", VA = "0x181FD3CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal virtual int FMNPGKADBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x73A090", Offset = "0x738E90", VA = "0x18073A090", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private int KOHJDBBJEKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x1E70980", Offset = "0x1E6F780", VA = "0x181E70980")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x1ABE010", Offset = "0x1ABCE10", VA = "0x181ABE010", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<TKey> GNHOOAGJOGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x1FD3790", Offset = "0x1FD2590", VA = "0x181FD3790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public TVal MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x1FD54B0", Offset = "0x1FD42B0", VA = "0x181FD54B0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x1FD42E0", Offset = "0x1FD30E0", VA = "0x181FD42E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6890", Offset = "0x1FD5690", VA = "0x181FD6890")]
	public NBIICPFMMDD(int CHMDLBBFMNF, [Optional] POIMLJHIOIB BGOKELNJCKK, [Optional] IEqualityComparer<TKey> EMOGODJCHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x1FD66A0", Offset = "0x1FD54A0", VA = "0x181FD66A0")]
	public NBIICPFMMDD(TimeSpan LMANHNCHJCA, [Optional] IEqualityComparer<TKey> EMOGODJCHKN, [Optional] PCCFJFHBKMO BODBBFPNIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6580", Offset = "0x1FD5380", VA = "0x181FD6580")]
	public NBIICPFMMDD(int CHMDLBBFMNF, TimeSpan LMANHNCHJCA, [Optional] IEqualityComparer<TKey> EMOGODJCHKN, [Optional] PCCFJFHBKMO BODBBFPNIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6300", Offset = "0x1FD5100", VA = "0x181FD6300")]
	public NBIICPFMMDD(int CHMDLBBFMNF, POIMLJHIOIB BGOKELNJCKK, TimeSpan LMANHNCHJCA, [Optional] IEqualityComparer<TKey> EMOGODJCHKN, [Optional] PCCFJFHBKMO BODBBFPNIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5CF0", Offset = "0x1FD4AF0", VA = "0x181FD5CF0")]
	public void PGHLLDMAKON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x1FD60A0", Offset = "0x1FD4EA0", VA = "0x181FD60A0")]
	public void PIGMJENILDA(TKey CCJNKBLKLDJ, TVal IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x1FD3620", Offset = "0x1FD2420", VA = "0x181FD3620")]
	public bool AKJLIPOIGHF(TKey CCJNKBLKLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x1FD3B40", Offset = "0x1FD2940", VA = "0x181FD3B40")]
	private TVal BOPAOPJOHPG(TKey ANHJHIFLNAP)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4010", Offset = "0x1FD2E10", VA = "0x181FD4010", Slot = "6")]
	public virtual bool CECEMJJAJEO(TKey ANHJHIFLNAP, out TVal IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4B00", Offset = "0x1FD3900", VA = "0x181FD4B00", Slot = "7")]
	public virtual void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x1FD31E0", Offset = "0x1FD1FE0", VA = "0x181FD31E0")]
	private bool AFAPCIEDBMB(LOHNIHEMMIG NJLMIMMKHOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4FF0", Offset = "0x1FD3DF0", VA = "0x181FD4FF0")]
	private void JOOPJAFPNIA(LinkedListNode<LOHNIHEMMIG> JEJKKAMKIIN, TVal LNHLJHKJGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4900", Offset = "0x1FD3700", VA = "0x181FD4900")]
	private void FEJCNECMMHF(TKey CCJNKBLKLDJ, TVal IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5690", Offset = "0x1FD4490", VA = "0x181FD5690")]
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
		[Cpp2IlInjected.Address(RVA = "0x17B4FA0", Offset = "0x17B3DA0", VA = "0x1817B4FA0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool OONDNCJIJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x65AD00", Offset = "0x659B00", VA = "0x18065AD00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x24F1DB0", Offset = "0x24F0BB0", VA = "0x1824F1DB0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2EA8370", Offset = "0x2EA7170", VA = "0x182EA8370", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x2770400", Offset = "0x276F200", VA = "0x182770400", Slot = "11")]
	public void Add(T GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x2EA7C30", Offset = "0x2EA6A30", VA = "0x182EA7C30")]
	public bool LHAEMCGIOMO(T GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x2EA8150", Offset = "0x2EA6F50", VA = "0x182EA8150", Slot = "15")]
	public bool Remove(T GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x26F7DF0", Offset = "0x26F6BF0", VA = "0x1826F7DF0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x23D4710", Offset = "0x23D3510", VA = "0x1823D4710", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x2EA7A10", Offset = "0x2EA6810", VA = "0x182EA7A10", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x2E2D070", Offset = "0x2E2BE70", VA = "0x182E2D070", Slot = "13")]
	public bool Contains(T GDCPKDNOEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2EA7A70", Offset = "0x2EA6870", VA = "0x182EA7A70", Slot = "14")]
	public void CopyTo(T[] DEJEDNNJILK, int AGJLGNIMOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x259BE10", Offset = "0x259AC10", VA = "0x18259BE10", Slot = "6")]
	public int IndexOf(T GDCPKDNOEGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x2EA7AA0", Offset = "0x2EA68A0", VA = "0x182EA7AA0", Slot = "7")]
	public void Insert(int AIPHGHFENPJ, T GDCPKDNOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x2EA7F20", Offset = "0x2EA6D20", VA = "0x182EA7F20", Slot = "8")]
	public void RemoveAt(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x2EA7E50", Offset = "0x2EA6C50", VA = "0x182EA7E50")]
	public void PLJGJCHOOLO(Predicate<T> ADBPGLEFIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x2EA79E0", Offset = "0x2EA67E0", VA = "0x182EA79E0")]
	public void CLOFDOFJEEC(Comparison<T> JDKEEHIDKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x2EA81D0", Offset = "0x2EA6FD0", VA = "0x182EA81D0")]
	public LOFDAGFECGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class DOHOJBEKMME
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x5D50380", Offset = "0x5D4F180", VA = "0x185D50380")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DC6650", Offset = "0x2DC5450", VA = "0x182DC6650")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5D568A0", Offset = "0x5D556A0", VA = "0x185D568A0")]
		public SerializedGuid(in Guid AJPBBJHOAOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x5D566A0", Offset = "0x5D554A0", VA = "0x185D566A0")]
		public static SerializedGuid FLDLPLFNNMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x5D56740", Offset = "0x5D55540", VA = "0x185D56740")]
		public static SerializedGuid OEHONHADFCL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x5D56480", Offset = "0x5D55280", VA = "0x185D56480")]
		public bool EFLLLAPDHEA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x5D56870", Offset = "0x5D55670", VA = "0x185D56870", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5D567D0", Offset = "0x5D555D0", VA = "0x185D567D0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x5D563C0", Offset = "0x5D551C0", VA = "0x185D563C0")]
		public bool CHHJCFLIPIC(in Guid AJPBBJHOAOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5D56510", Offset = "0x5D55310", VA = "0x185D56510", Slot = "7")]
		public bool Equals(SerializedGuid HNOJKNGFFBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5D565C0", Offset = "0x5D553C0", VA = "0x185D565C0", Slot = "0")]
		public override bool Equals(object CCPIHKCBGHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x5D56730", Offset = "0x5D55530", VA = "0x185D56730", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5D56450", Offset = "0x5D55250", VA = "0x185D56450", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D4D600", Offset = "0x5D4C400", VA = "0x185D4D600")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D6F0", Offset = "0x66C4F0", VA = "0x18066D6F0", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x244F1B0", Offset = "0x244DFB0", VA = "0x18244F1B0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool MALHPKIFHPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x722540", Offset = "0x721340", VA = "0x180722540", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string NJKGPGIFKGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6718E0", Offset = "0x6706E0", VA = "0x1806718E0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xEA8650", Offset = "0xEA7450", VA = "0x180EA8650", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x2E0A0D0", Offset = "0x2E08ED0", VA = "0x182E0A0D0")]
	private void OOGPKFNOLPA(T DEHKKADBBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x2E09CE0", Offset = "0x2E08AE0", VA = "0x182E09CE0")]
	private void AIEKGKBOABF(string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x2E09EA0", Offset = "0x2E08CA0", VA = "0x182E09EA0")]
	public void EJCGBCFCFCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x2E09DE0", Offset = "0x2E08BE0", VA = "0x182E09DE0", Slot = "6")]
	public global::NEKADIDIOHG<T> DENKJFAEPEK(Action<T, T> IHKABJJNGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x2E09FF0", Offset = "0x2E08DF0", VA = "0x182E09FF0", Slot = "7")]
	public global::NEKADIDIOHG<T> IKOPNAELIMN(Action<T, T> IHKABJJNGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x2E0A040", Offset = "0x2E08E40", VA = "0x182E0A040", Slot = "4")]
	public global::NEKADIDIOHG<T> JBPBOAEOEMF(Action<T> IHKABJJNGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x2E09D90", Offset = "0x2E08B90", VA = "0x182E09D90", Slot = "5")]
	public global::NEKADIDIOHG<T> APDPJHBKMKP(Action<T> HIHPGOGCEJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x2E09F50", Offset = "0x2E08D50", VA = "0x182E09F50", Slot = "8")]
	public global::NEKADIDIOHG<T> GDMPJHEDNBP(Action<string> BNGCFDGNMDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x2E09E30", Offset = "0x2E08C30", VA = "0x182E09E30", Slot = "9")]
	public global::NEKADIDIOHG<T> DGIDOPJGBJE(Action<string> BNGCFDGNMDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x2E0A170", Offset = "0x2E08F70", VA = "0x182E0A170")]
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
		[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
		public CKJNKICDCCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x26010D0", Offset = "0x25FFED0", VA = "0x1826010D0")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x30A4B50", Offset = "0x30A3950", VA = "0x1830A4B50")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E24660", Offset = "0x2E23460", VA = "0x182E24660")]
		public LFINMJIEICI(long AGIHFJLDMFB, int CJNKPBOCJNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x2E246D0", Offset = "0x2E234D0", VA = "0x182E246D0")]
		public LFINMJIEICI(long AGIHFJLDMFB, long PBJEENCKMAH, int CJNKPBOCJNJ, int KAILDPGMOAM, bool BMAOLOJDNEG, string AJPJIDCOHMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x2E244D0", Offset = "0x2E232D0", VA = "0x182E244D0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void EDOKCIEOOKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2E24480", Offset = "0x2E23280", VA = "0x182E24480")]
		public int BPCLJBHHMED()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x2E24640", Offset = "0x2E23440", VA = "0x182E24640")]
		public int PFOGOHBEGDD(int OOHJFEOAEOL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x2E24540", Offset = "0x2E23340", VA = "0x182E24540")]
		public double INNDPLNJJCH()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2E245B0", Offset = "0x2E233B0", VA = "0x182E245B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x17B7060", Offset = "0x17B5E60", VA = "0x1817B7060")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x2308950", Offset = "0x2307750", VA = "0x182308950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public IEnumerable<GEKJCIHAMFL> NEAKJMIFMMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x2308A90", Offset = "0x2307890", VA = "0x182308A90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public LFINMJIEICI CNMCDLACFBF
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x14DBEC0", Offset = "0x14DACC0", VA = "0x1814DBEC0")]
			[CompilerGenerated]
			get
			{
				return default(LFINMJIEICI);
			}
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x2308AB0", Offset = "0x23078B0", VA = "0x182308AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x2308AE0", Offset = "0x23078E0", VA = "0x182308AE0")]
		internal GEKJCIHAMFL(global::EHGJMLLEIHA<TKey> APDIGEDLLAL, TKey CCJNKBLKLDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x2308980", Offset = "0x2307780", VA = "0x182308980")]
		public GEKJCIHAMFL NHEGBMPLEGG(TKey CCJNKBLKLDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x23086C0", Offset = "0x23074C0", VA = "0x1823086C0")]
		public void BAJMMIABKCA(TKey CCJNKBLKLDJ, Action<GEKJCIHAMFL> CGKOOFFNHKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x27E38F0", Offset = "0x27E26F0", VA = "0x1827E38F0")]
		public T BAJMMIABKCA<T>(TKey CCJNKBLKLDJ, Func<GEKJCIHAMFL, T> LKLJLJNAKDG)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x27E39E0", Offset = "0x27E27E0", VA = "0x1827E39E0")]
		[AsyncStateMachine(typeof(EJENFOAEIOD))]
		public Task<T> NOOHLLGCOBD<T>(TKey CCJNKBLKLDJ, Func<GEKJCIHAMFL, Task<T>> LKLJLJNAKDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x23087A0", Offset = "0x23075A0", VA = "0x1823087A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BBF6F0", Offset = "0x2BBE4F0", VA = "0x182BBF6F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x4573320", Offset = "0x4572120", VA = "0x184573320", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x2BBFA80", Offset = "0x2BBE880", VA = "0x182BBFA80")]
		[DebuggerHidden]
		public DLLOOAPEIBA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x17AC2E0", Offset = "0x17AB0E0", VA = "0x1817AC2E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x4572EA0", Offset = "0x4571CA0", VA = "0x184572EA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x4573380", Offset = "0x4572180", VA = "0x184573380")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x45732E0", Offset = "0x45720E0", VA = "0x1845732E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x4573220", Offset = "0x4572020", VA = "0x184573220", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LFINMJIEICI)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x1E72AA0", Offset = "0x1E718A0", VA = "0x181E72AA0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BBF6F0", Offset = "0x2BBE4F0", VA = "0x182BBF6F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2EA8B20", Offset = "0x2EA7920", VA = "0x182EA8B20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x2BBFA80", Offset = "0x2BBE880", VA = "0x182BBFA80")]
		[DebuggerHidden]
		public LOFFOJBNFOB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x2EA8B80", Offset = "0x2EA7980", VA = "0x182EA8B80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x2EA8430", Offset = "0x2EA7230", VA = "0x182EA8430", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x2EA8C20", Offset = "0x2EA7A20", VA = "0x182EA8C20")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x2EA8C80", Offset = "0x2EA7A80", VA = "0x182EA8C80")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2EA8AE0", Offset = "0x2EA78E0", VA = "0x182EA8AE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x2EA89D0", Offset = "0x2EA77D0", VA = "0x182EA89D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LFINMJIEICI)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x2EA8AB0", Offset = "0x2EA78B0", VA = "0x182EA8AB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6718E0", Offset = "0x6706E0", VA = "0x1806718E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6570D0", Offset = "0x655ED0", VA = "0x1806570D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x1AC81D0", Offset = "0x1AC6FD0", VA = "0x181AC81D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public long FPEHLJJEBOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x1AC81B0", Offset = "0x1AC6FB0", VA = "0x181AC81B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int KCPCEIPPBPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x1AC8230", Offset = "0x1AC7030", VA = "0x181AC8230")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x1AC83E0", Offset = "0x1AC71E0", VA = "0x181AC83E0")]
	public EHGJMLLEIHA(TKey LPJIDKAIAHI, [Optional] int? CJNKPBOCJNJ, [Optional][CanBeNull] Stopwatch DCONEIAFJGN, [Optional] Action<TKey, LFINMJIEICI> LMGGKKPJMLE, [Optional] Action<TKey, LFINMJIEICI> CNJHAMHHDFI, [Optional] Action<global::EHGJMLLEIHA<TKey>> JILJHJDEKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x1AC8100", Offset = "0x1AC6F00", VA = "0x181AC8100", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x1AC83C0", Offset = "0x1AC71C0", VA = "0x181AC83C0")]
	public void OMKFLJFBNAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x1AC8190", Offset = "0x1AC6F90", VA = "0x181AC8190")]
	public void IOLANELGBOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x1AC8330", Offset = "0x1AC7130", VA = "0x181AC8330")]
	[IteratorStateMachine(typeof(global::EHGJMLLEIHA<>.DLLOOAPEIBA))]
	public IEnumerable<(TKey, List<TKey>, LFINMJIEICI)> NBLLALKOPIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x1AC8260", Offset = "0x1AC7060", VA = "0x181AC8260")]
	[IteratorStateMachine(typeof(global::EHGJMLLEIHA<>.LOFFOJBNFOB))]
	private IEnumerable<(TKey, List<TKey>, LFINMJIEICI)> NBLLALKOPIL(List<TKey> KCGMDGFIHOJ, GEKJCIHAMFL DDOOJJJHNHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x1AC8080", Offset = "0x1AC6E80", VA = "0x181AC8080")]
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
	[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
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
	[Cpp2IlInjected.Address(RVA = "0x2EA5470", Offset = "0x2EA4270", VA = "0x182EA5470")]
	protected string IOOIHINPGPD(double KPHOHPEDFHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x2EA56C0", Offset = "0x2EA44C0", VA = "0x182EA56C0")]
	protected string LDNJOGONJOF(int KMKBHIDEHKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x2EA5430", Offset = "0x2EA4230", VA = "0x182EA5430")]
	private static string EPMCEDIGHMI(TKey CCJNKBLKLDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x2EA54E0", Offset = "0x2EA42E0", VA = "0x182EA54E0", Slot = "4")]
	public override string KCPKNEMHAIG(global::EHGJMLLEIHA<TKey> APDIGEDLLAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2EA5590", Offset = "0x2EA4390", VA = "0x182EA5590")]
	public string KCPKNEMHAIG(global::EHGJMLLEIHA<TKey> APDIGEDLLAL, [NotNull] LPCEAMJLPJC ADMFMGGDLGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string EMMKIMDMMHH(global::EHGJMLLEIHA<TKey> APDIGEDLLAL, [NotNull] LPCEAMJLPJC ADMFMGGDLGH);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x1ACD550", Offset = "0x1ACC350", VA = "0x181ACD550")]
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
	[Cpp2IlInjected.Address(RVA = "0x2DEA560", Offset = "0x2DE9360", VA = "0x182DEA560")]
	private static string EPMCEDIGHMI(TKey CCJNKBLKLDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2DEAE20", Offset = "0x2DE9C20", VA = "0x182DEAE20")]
	public NGLJPEDJLFA(string EDAHGMBLEFA = "F2", double GDNOCDDMPPE = double.MaxValue, bool OFABEKEOFHH = false, int HFMGMFPCCCB = int.MaxValue, [Optional] ISet<string> PINCNCDBLJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2DEAAE0", Offset = "0x2DE98E0", VA = "0x182DEAAE0", Slot = "4")]
	public override Dictionary<string, string> KCPKNEMHAIG(global::EHGJMLLEIHA<TKey> APDIGEDLLAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2DEAB90", Offset = "0x2DE9990", VA = "0x182DEAB90")]
	private bool MHOAAMOADMG(string LIJFPGLLLDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x2DEA5A0", Offset = "0x2DE93A0", VA = "0x182DEA5A0")]
	public Dictionary<string, string> KCPKNEMHAIG(global::EHGJMLLEIHA<TKey> APDIGEDLLAL, ELOIBNJHNEJ ADMFMGGDLGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x2DEAC70", Offset = "0x2DE9A70", VA = "0x182DEAC70")]
	private string PANHNJGFHJD(StringBuilder LKFKIAFIGCP, List<TKey> MILADPHKBEN, ELOIBNJHNEJ ADMFMGGDLGH, bool EMFHALGFDPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x2DEA3E0", Offset = "0x2DE91E0", VA = "0x182DEA3E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x26687E0", Offset = "0x26675E0", VA = "0x1826687E0")]
	private FHMKBMDFHMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x2667700", Offset = "0x2666500", VA = "0x182667700", Slot = "5")]
	protected override string EMMKIMDMMHH(global::EHGJMLLEIHA<TKey> APDIGEDLLAL, LPCEAMJLPJC ADMFMGGDLGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x26685F0", Offset = "0x26673F0", VA = "0x1826685F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
		public CKGHNHCAIAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x17AC740", Offset = "0x17AB540", VA = "0x1817AC740")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x2C9FB10", Offset = "0x2C9E910", VA = "0x182C9FB10", Slot = "5")]
	protected override string EMMKIMDMMHH(global::EHGJMLLEIHA<TKey> APDIGEDLLAL, LPCEAMJLPJC ADMFMGGDLGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x26F7FC0", Offset = "0x26F6DC0", VA = "0x1826F7FC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public FHMINHEPIEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5D507C0", Offset = "0x5D4F5C0", VA = "0x185D507C0")]
		internal void <Wrap>b__0(global::EHGJMLLEIHA<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x5D52BC0", Offset = "0x5D519C0", VA = "0x185D52BC0")]
	public LBHPPCDHALB([Optional] string BFFLLNCOKMN, [Optional] int? CJNKPBOCJNJ, [Optional] Stopwatch DCONEIAFJGN, [Optional] Action<string, LFINMJIEICI> LMGGKKPJMLE, [Optional] Action<string, LFINMJIEICI> CNJHAMHHDFI, [Optional] Action<LBHPPCDHALB> JILJHJDEKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x5D52AE0", Offset = "0x5D518E0", VA = "0x185D52AE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5D4DD00", Offset = "0x5D4CB00", VA = "0x185D4DD00")]
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
			[Cpp2IlInjected.Address(RVA = "0x5D4DCB0", Offset = "0x5D4CAB0", VA = "0x185D4DCB0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override float BFPMBFEGEAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x5D4DCA0", Offset = "0x5D4CAA0", VA = "0x185D4DCA0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x5D4DE00", Offset = "0x5D4CC00", VA = "0x185D4DE00")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D53D10", Offset = "0x5D52B10", VA = "0x185D53D10")]
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
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	protected PCCFJFHBKMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class CNPEPHDIAMN : global::KFHMMJCAHMJ<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x5D50170", Offset = "0x5D4EF70", VA = "0x185D50170")]
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
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x6578C0", VA = "0x180658AC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x158F160", Offset = "0x158DF60", VA = "0x18158F160", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::DGCAEBAFOOK<T> NMJDKNOJAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xEA84C0", Offset = "0xEA72C0", VA = "0x180EA84C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x3104930", Offset = "0x3103730", VA = "0x183104930")]
	public KFHMMJCAHMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class JKMEDAKMFJK : global::NOJAKAOFMOA<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x5D51A50", Offset = "0x5D50850", VA = "0x185D51A50")]
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
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x6578C0", VA = "0x180658AC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x158F160", Offset = "0x158DF60", VA = "0x18158F160", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::DGCAEBAFOOK<T> NMJDKNOJAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xEA84C0", Offset = "0xEA72C0", VA = "0x180EA84C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x2CA3ED0", Offset = "0x2CA2CD0", VA = "0x182CA3ED0")]
	public NOJAKAOFMOA(Exception BKGIODDNKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
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
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x6578C0", VA = "0x180658AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Task MBKBJAIGLLH
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x6578C0", VA = "0x180658AC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public global::DGCAEBAFOOK<T> NMJDKNOJAFO
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x227D5F0", Offset = "0x227C3F0", VA = "0x18227D5F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool LOOFPCGMKLN
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x762B40", Offset = "0x761940", VA = "0x180762B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x24ED2C0", Offset = "0x24EC0C0", VA = "0x1824ED2C0")]
	static BEPDLHFOHBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x24ED770", Offset = "0x24EC570", VA = "0x1824ED770")]
	protected BEPDLHFOHBM(TTask JJCIEPGHDBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x24ECF70", Offset = "0x24EBD70", VA = "0x1824ECF70", Slot = "1")]
	~BEPDLHFOHBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x24ECF40", Offset = "0x24EBD40", VA = "0x1824ECF40", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x24ECFE0", Offset = "0x24EBDE0", VA = "0x1824ECFE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x24ECEF0", Offset = "0x24EBCF0", VA = "0x1824ECEF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5D50BA0", Offset = "0x5D4F9A0", VA = "0x185D50BA0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x5D50D30", Offset = "0x5D4FB30", VA = "0x185D50D30")]
		public GODGJDEFNDM(float FOACNEHDHLI, float CBNJCJLIEMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x5D50BB0", Offset = "0x5D4F9B0", VA = "0x185D50BB0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FCABF0", Offset = "0x1FC99F0", VA = "0x181FCABF0")]
		get
		{
			return default(GODGJDEFNDM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float AFEPPNOIIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x5D4F920", Offset = "0x5D4E720", VA = "0x185D4F920", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event MGLOKFBMOMI IBPFPEKACBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x5D4FF30", Offset = "0x5D4ED30", VA = "0x185D4FF30", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x5D4FA20", Offset = "0x5D4E820", VA = "0x185D4FA20", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x5D4FFF0", Offset = "0x5D4EDF0", VA = "0x185D4FFF0")]
	public CJPAOFNIIFD(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F940", Offset = "0x5D4E740", VA = "0x185D4F940")]
	public OLCAEPENJCG JLKHMCPFMIM(GODGJDEFNDM IEJLANBMLJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x5D4FAE0", Offset = "0x5D4E8E0", VA = "0x185D4FAE0")]
	public void LPDKOIBHNFN(DJABOFDMEMI LNOIHANMLEE, [Optional] GODGJDEFNDM MCJCCAPLEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F8D0", Offset = "0x5D4E6D0", VA = "0x185D4F8D0")]
	internal int FKENAIAHEAH(DJABOFDMEMI HBCDOHJNOJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F9D0", Offset = "0x5D4E7D0", VA = "0x185D4F9D0")]
	internal GODGJDEFNDM JNFBABGBIFI(int AIPHGHFENPJ)
	{
		return default(GODGJDEFNDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F740", Offset = "0x5D4E540", VA = "0x185D4F740", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D51300", Offset = "0x5D50100", VA = "0x185D51300")]
		public IIAPNCMBNCO(DJABOFDMEMI HBCDOHJNOJM, MGLOKFBMOMI GKAOJENLDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x5D512B0", Offset = "0x5D500B0", VA = "0x185D512B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x5D50240", Offset = "0x5D4F040", VA = "0x185D50240")]
	internal static bool CALOBKLNFMD(float BMPDKJEHGIN, float BMMLDIMMAAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x489C890", Offset = "0x489B690", VA = "0x18489C890")]
	internal static float MDOCPMOMFLF(float BMPDKJEHGIN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x5D502C0", Offset = "0x5D4F0C0", VA = "0x185D502C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xF2FE00", Offset = "0xF2EC00", VA = "0x180F2FE00", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x5D53A20", Offset = "0x5D52820", VA = "0x185D53A20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event MGLOKFBMOMI IBPFPEKACBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x5D53B80", Offset = "0x5D52980", VA = "0x185D53B80", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x5D53AE0", Offset = "0x5D528E0", VA = "0x185D53AE0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public OLCAEPENJCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public static class PFDKDLHNGHK
{
	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5D54930", Offset = "0x5D53730", VA = "0x185D54930")]
	[NotNull]
	public static byte[] DCEJPOHKLOD(this NIPAEPLNJMM PGBLJCOLKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5D549A0", Offset = "0x5D537A0", VA = "0x185D549A0")]
	[NotNull]
	public static byte[] DCEJPOHKLOD(this NIPAEPLNJMM PGBLJCOLKOA, HashAlgorithmName HKKDBKLHMJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x5D54680", Offset = "0x5D53480", VA = "0x185D54680")]
	public static bool CMCHABMICCB([CanBeNull] this NIPAEPLNJMM PGBLJCOLKOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5D544E0", Offset = "0x5D532E0", VA = "0x185D544E0")]
	public static bool CMCHABMICCB([CanBeNull] this NIPAEPLNJMM PGBLJCOLKOA, out string EGNBEILEKKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x5D54A10", Offset = "0x5D53810", VA = "0x185D54A10")]
	private static string PALKABLKHAF([CanBeNull] byte[] HFAIGCGNPJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x5D54810", Offset = "0x5D53610", VA = "0x185D54810")]
	private static bool DBDKFNPBADC([NotNull] NIPAEPLNJMM PGBLJCOLKOA, [CanBeNull] out byte[] ABIOPBANALL, [CanBeNull] out byte[] DAJKGKGPPDH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class GCFNCJLJLGB
{
	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x5D50890", Offset = "0x5D4F690", VA = "0x185D50890")]
	[NotNull]
	public static byte[] DCEJPOHKLOD(this JDBJPKOCHPF FIPIBFLOINL, byte[] MBFPOLMHNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5D508D0", Offset = "0x5D4F6D0", VA = "0x185D508D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D51940", Offset = "0x5D50740", VA = "0x185D51940")]
		public JCEPHOPMDCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x5D518E0", Offset = "0x5D506E0", VA = "0x185D518E0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x25E92C0", Offset = "0x25E80C0", VA = "0x1825E92C0")]
	[Conditional("UNITY_EDITOR")]
	private static void OKMGHCAMKNL<T>(params T[] HIFGENFODLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E3E0", Offset = "0x5D4D1E0", VA = "0x185D4E3E0")]
	public static IDisposable EOLGJDIEOML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x5D4EEE0", Offset = "0x5D4DCE0", VA = "0x185D4EEE0")]
	public static void PAMGGGELPJC(this IncrementalHash MPBCJIPHAFL, [CanBeNull] GameObject BFJMKCMPBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x25E95B0", Offset = "0x25E83B0", VA = "0x1825E95B0")]
	public static void PAMGGGELPJC<T>(this IncrementalHash MPBCJIPHAFL, [CanBeNull] T AFOPPLDIMJL) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x25E8B40", Offset = "0x25E7940", VA = "0x1825E8B40")]
	public static void EHIKJAPAENC<T>(this IncrementalHash MPBCJIPHAFL, [CanBeNull] T FIPIBFLOINL) where T : JDBJPKOCHPF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x25E9680", Offset = "0x25E8480", VA = "0x1825E9680")]
	public static void PAPDJEAIPJK<T>(this IncrementalHash MPBCJIPHAFL, [CanBeNull] IList<T> PEAHLGOOOIO) where T : JDBJPKOCHPF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E5F0", Offset = "0x5D4D3F0", VA = "0x185D4E5F0")]
	private static bool IKDGPDPCNPA([CanBeNull] JDBJPKOCHPF FIPIBFLOINL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E750", Offset = "0x5D4D550", VA = "0x185D4E750")]
	public static void KMJILBGMNLB(this IncrementalHash PKCNHEGJGNH, [CanBeNull] string KFCEHAILNOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E7B0", Offset = "0x5D4D5B0", VA = "0x185D4E7B0")]
	public static void KOGBMIOOMEH(this IncrementalHash PKCNHEGJGNH, long JKGNEOGOKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5D4DF70", Offset = "0x5D4CD70", VA = "0x185D4DF70")]
	public static void AADKNOMNCLL(this IncrementalHash PKCNHEGJGNH, int FGFDCPICAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E980", Offset = "0x5D4D780", VA = "0x185D4E980")]
	public static void KPLIDHECCMN(this IncrementalHash PKCNHEGJGNH, short ANFPDIMPJNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D4EBB0", Offset = "0x5D4D9B0", VA = "0x185D4EBB0")]
	public static void NGAFDEGANNI(this IncrementalHash PKCNHEGJGNH, byte PLMOPNOHALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E1B0", Offset = "0x5D4CFB0", VA = "0x185D4E1B0")]
	public static void BNPENPIGGPL(this IncrementalHash PKCNHEGJGNH, bool CNFBDAILKKM, bool LJBGNCAJFOD = false, bool DDLFMMPIEEK = false, bool DHCJADKACEM = false, bool ACLFALACBKN = false, bool HHLHLPJHCBL = false, bool DPDPPGPPGDB = false, bool MGDBGAFAAGI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x25E8BD0", Offset = "0x25E79D0", VA = "0x1825E8BD0")]
	public static void IGKHICHCGFB<T>(this IncrementalHash PKCNHEGJGNH, T HOBDFMBOEKJ) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x5D4EB50", Offset = "0x5D4D950", VA = "0x185D4EB50")]
	public static void LIDIJHEGIDK(this IncrementalHash PKCNHEGJGNH, float JNBOKKKFNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E6F0", Offset = "0x5D4D4F0", VA = "0x185D4E6F0")]
	public static void JLOMIPMOBAN(this IncrementalHash PKCNHEGJGNH, double KLOJPDOOPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E140", Offset = "0x5D4CF40", VA = "0x185D4E140")]
	public static void APGHMLLOEHI(this IncrementalHash PKCNHEGJGNH, ulong LFFHHADNBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E380", Offset = "0x5D4D180", VA = "0x185D4E380")]
	public static void CKICEEAPHDE(this IncrementalHash PKCNHEGJGNH, uint GFKEJJLCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E680", Offset = "0x5D4D480", VA = "0x185D4E680")]
	public static void JLJGIJFFHPP(this IncrementalHash PKCNHEGJGNH, ushort CCDPLMEOBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E480", Offset = "0x5D4D280", VA = "0x185D4E480")]
	public static void HGBLGCDHPJE(this IncrementalHash PKCNHEGJGNH, Vector3 NKACMCKINJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x5D4ED20", Offset = "0x5D4DB20", VA = "0x185D4ED20")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D52D10", Offset = "0x5D51B10", VA = "0x185D52D10")]
	public LNDPPEMEKCF(Type ICHCDGFAFMA, string HCNFPHKIIJH, bool LPNDFHNCPIB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class OLFLOAGCDHH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x5D53CA0", Offset = "0x5D52AA0", VA = "0x185D53CA0")]
	public OLFLOAGCDHH(string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x5D53C20", Offset = "0x5D52A20", VA = "0x185D53C20")]
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
			[Cpp2IlInjected.Address(RVA = "0x657040", Offset = "0x655E40", VA = "0x180657040")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x66D790", Offset = "0x66C590", VA = "0x18066D790")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public T this[int HLAPKJLCEDC, int BOGPBFBHDOE]
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x35715F0", Offset = "0x35703F0", VA = "0x1835715F0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x3571690", Offset = "0x3570490", VA = "0x183571690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x3571560", Offset = "0x3570360", VA = "0x183571560")]
		public Array2D(uint KLFKELPFFNF, uint AGONAJNGCCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x35714E0", Offset = "0x35702E0", VA = "0x1835714E0")]
		public void IIOELKEIHEG()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x5D4DE60", Offset = "0x5D4CC60", VA = "0x185D4DE60")]
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
		[Cpp2IlInjected.Address(RVA = "0x259B220", Offset = "0x259A020", VA = "0x18259B220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x2F892D0", Offset = "0x2F880D0", VA = "0x182F892D0")]
	public OHAJLNOFLKM(Action<TValue> DFNIIHBCCOD, [Optional] Func<TValue> PFLFMAIAICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2F88CF0", Offset = "0x2F87AF0", VA = "0x182F88CF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2F88BA0", Offset = "0x2F879A0", VA = "0x182F88BA0")]
	public THandle DAKLFHBAJIH()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2F88FD0", Offset = "0x2F87DD0", VA = "0x182F88FD0")]
	public THandle HEFJCCLOLGO(TValue IGJPNMBCJPK)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2F88A40", Offset = "0x2F87840", VA = "0x182F88A40")]
	public bool AKJLIPOIGHF(THandle MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2F88890", Offset = "0x2F87690", VA = "0x182F88890")]
	public bool ACKFNLGGLJE(THandle MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x2F89120", Offset = "0x2F87F20", VA = "0x182F89120")]
	public bool KNMEGLCAMII(THandle MIGDJNOKMHC, out TValue IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x2F88AF0", Offset = "0x2F878F0", VA = "0x182F88AF0")]
	public TValue BOPAOPJOHPG(THandle MIGDJNOKMHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x2F88960", Offset = "0x2F87760", VA = "0x182F88960")]
	public bool AEBBOEKMPNE(THandle MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x2F88A10", Offset = "0x2F87810", VA = "0x182F88A10")]
	private THandle AKEDIKAPJNI(int AIPHGHFENPJ)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x2F88E90", Offset = "0x2F87C90", VA = "0x182F88E90")]
	private TValue FMDMOKNGPIL(int AIPHGHFENPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x2F89240", Offset = "0x2F88040", VA = "0x182F89240")]
	private void LLMGNABJPBK(int AIPHGHFENPJ, in THandle MIGDJNOKMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2F89290", Offset = "0x2F88090", VA = "0x182F89290")]
	private void OOGPKFNOLPA(int AIPHGHFENPJ, in TValue IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x2F88EC0", Offset = "0x2F87CC0", VA = "0x182F88EC0")]
	private THandle GLBGHPMKCDI()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x2F88C40", Offset = "0x2F87A40", VA = "0x182F88C40")]
	private void DLOAHCHNKCJ(THandle MIGDJNOKMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x2F89040", Offset = "0x2F87E40", VA = "0x182F89040")]
	private int INGBECJDIGI(int JKGBPKEJAFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2F89280", Offset = "0x2F88080", VA = "0x182F89280")]
	private bool OEJPECIBDFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6BE640", Offset = "0x6BD440", VA = "0x1806BE640")]
	private void HMEPPCBJPKP(THandle MIGDJNOKMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2F891C0", Offset = "0x2F87FC0", VA = "0x182F891C0")]
	private bool LDAAGBHHMPI(out THandle MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2F89050", Offset = "0x2F87E50", VA = "0x182F89050")]
	private bool JLNIOIOMGFP(out THandle MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x2F88B40", Offset = "0x2F87940", VA = "0x182F88B40")]
	private void COEFPBLADKG(THandle MIGDJNOKMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x2F88D70", Offset = "0x2F87B70", VA = "0x182F88D70")]
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
	[Cpp2IlInjected.Address(RVA = "0x25EA9B0", Offset = "0x25E97B0", VA = "0x1825EA9B0")]
	public static bool KOPGOIJFDNG<T>(this T MIGDJNOKMHC, T HNOJKNGFFBE) where T : struct, GPAFGALANDE
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x25EA9D0", Offset = "0x25E97D0", VA = "0x1825EA9D0")]
	public static bool PPICPACFBLI<T>(this T MIGDJNOKMHC) where T : struct, GPAFGALANDE
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F0E0", Offset = "0x5D4DEE0", VA = "0x185D4F0E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D52250", Offset = "0x5D51050", VA = "0x185D52250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool NIGLMGEEEPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x5D51CB0", Offset = "0x5D50AB0", VA = "0x185D51CB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x5D52AB0", Offset = "0x5D518B0", VA = "0x185D52AB0")]
	public KFJBGPOMJGH(bool OCOBBJHPBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x5D52300", Offset = "0x5D51100", VA = "0x185D52300")]
	public void OAIILMFFBEL(object CCPIHKCBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x5D521B0", Offset = "0x5D50FB0", VA = "0x185D521B0")]
	public void JOEJBFPKOLJ(int IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CA0", Offset = "0x5D50AA0", VA = "0x185D51CA0")]
	public void BLAMKCFOGNJ(uint NCCNCJLDCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x5D522E0", Offset = "0x5D510E0", VA = "0x185D522E0")]
	public void NLOPPDKPKOK(bool BIHHMPJOIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x5D52260", Offset = "0x5D51060", VA = "0x185D52260")]
	public void LNPDJAMFDLL(long MOELJPNIGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x5D522A0", Offset = "0x5D510A0", VA = "0x185D522A0")]
	public void MIIINPIAEFK(ulong KPLEFKIAFMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5D51C30", Offset = "0x5D50A30", VA = "0x185D51C30")]
	public void ANNLPGCBPFJ(string JNFDLMOFJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CC0", Offset = "0x5D50AC0", VA = "0x185D51CC0")]
	public void CKBKGKCLOOB(Enum BKGIODDNKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5D52980", Offset = "0x5D51780", VA = "0x185D52980")]
	public void PBCCLDBBLPO(IList LPDILHBGHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x25533B0", Offset = "0x25521B0", VA = "0x1825533B0")]
	public void CGLFAJBMBNM<T, U>(Dictionary<T, U> IBHEDDBCHGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x5D51E40", Offset = "0x5D50C40", VA = "0x185D51E40")]
	private void IJHEMNCPIDE(IDictionary IBHEDDBCHGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x5D51D50", Offset = "0x5D50B50", VA = "0x185D51D50")]
	public int DBNECDHGCNK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5D51DC0", Offset = "0x5D50BC0", VA = "0x185D51DC0")]
	public short GGPFADGJLCK()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5D51E30", Offset = "0x5D50C30", VA = "0x185D51E30")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5D51BC0", Offset = "0x5D509C0", VA = "0x185D51BC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
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
		[Cpp2IlInjected.Address(RVA = "0x6820B0", Offset = "0x680EB0", VA = "0x1806820B0")]
		public OHNENLDBNBJ(int HKOHGCMCHKO, TClaimant EPPHKPPJDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x300E160", Offset = "0x300CF60", VA = "0x18300E160")]
		public bool KFNCPIDDDPI(in OHNENLDBNBJ HNOJKNGFFBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x300E150", Offset = "0x300CF50", VA = "0x18300E150")]
		public bool FELEKGPHEFH(in OHNENLDBNBJ HNOJKNGFFBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x300E140", Offset = "0x300CF40", VA = "0x18300E140", Slot = "4")]
		public int CompareTo(OHNENLDBNBJ HNOJKNGFFBE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x300E1C0", Offset = "0x300CFC0", VA = "0x18300E1C0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x17AC390", Offset = "0x17AB190", VA = "0x1817AC390")]
		[DebuggerHidden]
		public ENJGCONDEEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x1ADB650", Offset = "0x1ADA450", VA = "0x181ADB650", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x1ADB810", Offset = "0x1ADA610", VA = "0x181ADB810", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x1ADB730", Offset = "0x1ADA530", VA = "0x181ADB730", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xEA69C0", Offset = "0xEA57C0", VA = "0x180EA69C0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x17ABD50", Offset = "0x17AAB50", VA = "0x1817ABD50")]
	public ICFLMNMBPDL(HEONEGFGDFK CIJCIMPGNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x17AB4D0", Offset = "0x17AA2D0", VA = "0x1817AB4D0")]
	public void JDANKEGANBP(TNode MKLEFAMNJAC, TNode JDMCICBCFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x17ABA50", Offset = "0x17AA850", VA = "0x1817ABA50")]
	public void MNDDIEIPBHB(TClaimant EPPHKPPJDLJ, TNode ECHEODLBJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x17AAA10", Offset = "0x17A9810", VA = "0x1817AAA10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x17ABB50", Offset = "0x17AA950", VA = "0x1817ABB50")]
	private void NCMMPGCMBFM(TClaimant EPPHKPPJDLJ, TNode FDJMINNOJFC, TNode ECHEODLBJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x17AB030", Offset = "0x17A9E30", VA = "0x1817AB030")]
	private int FDKAHEPLLGF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x17AAD80", Offset = "0x17A9B80", VA = "0x1817AAD80")]
	private void EOLMEFKPPCK(TClaimant EPPHKPPJDLJ, TNode LMOILGHACLK, TNode FMEILHGLAMN, int NEMILMGLEJO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x17AA980", Offset = "0x17A9780", VA = "0x1817AA980")]
	private void BOOJKOFJPDI(OHNENLDBNBJ MMEBOPCCHDA, DMLALCOCLHK MLIJNOGINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x17AB270", Offset = "0x17AA070", VA = "0x1817AB270")]
	private void IKMPBHGIJHN(TClaimant EPPHKPPJDLJ, TNode LMOILGHACLK, TNode FMEILHGLAMN, int NEMILMGLEJO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x17AB160", Offset = "0x17A9F60", VA = "0x1817AB160")]
	private void FJGNMDABFEE(OHNENLDBNBJ MMEBOPCCHDA, TNode MKLEFAMNJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x17AA7C0", Offset = "0x17A95C0", VA = "0x1817AA7C0")]
	private void AKLKNEDNFFH(OHNENLDBNBJ MMEBOPCCHDA, DMLALCOCLHK MLIJNOGINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x17AAC70", Offset = "0x17A9A70", VA = "0x1817AAC70")]
	private void EEJOGEKIEBF(DMLALCOCLHK MLIJNOGINAM, bool HKLGLCKOJDF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x17AB550", Offset = "0x17AA350", VA = "0x1817AB550")]
	private void LONBOHKOAAL(DMLALCOCLHK MLIJNOGINAM, TNode JDMCICBCFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x17AB090", Offset = "0x17A9E90", VA = "0x1817AB090")]
	[IteratorStateMachine(typeof(global::ICFLMNMBPDL<, >.ENJGCONDEEE))]
	private IEnumerable<TNode> FGINIIAEMEC(TNode LMOILGHACLK, TNode FMEILHGLAMN, bool KJIBNILOJHD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x17AA8C0", Offset = "0x17A96C0", VA = "0x1817AA8C0")]
	private DMLALCOCLHK ANAILDODKJN(TNode MKLEFAMNJAC, TNode ADECAOLBLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x17AB8C0", Offset = "0x17AA6C0", VA = "0x1817AB8C0")]
	private DMLALCOCLHK MHNONCHFHNM(TNode MKLEFAMNJAC, TNode ADECAOLBLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x17AA600", Offset = "0x17A9400", VA = "0x1817AA600")]
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
			[Cpp2IlInjected.Address(RVA = "0xE9ACF0", Offset = "0xE99AF0", VA = "0x180E9ACF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public BFKLEOLBFKE MFINOJMLAJL
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x2D89CF0", Offset = "0x2D88AF0", VA = "0x182D89CF0", Slot = "4")]
			get
			{
				return default(BFKLEOLBFKE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x65B060", Offset = "0x659E60", VA = "0x18065B060")]
		public JLCBBEPDNNN(global::IGFGNFBNCFM<T> AHGHAANFJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x2D89BF0", Offset = "0x2D889F0", VA = "0x182D89BF0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x65B050", Offset = "0x659E50", VA = "0x18065B050", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xB6E180", Offset = "0xB6CF80", VA = "0x180B6E180", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x677D90", Offset = "0x676B90", VA = "0x180677D90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x812370", Offset = "0x811170", VA = "0x180812370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x17B4FA0", Offset = "0x17B3DA0", VA = "0x1817B4FA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x17B61B0", Offset = "0x17B4FB0", VA = "0x1817B61B0")]
	public IGFGNFBNCFM(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x17B6290", Offset = "0x17B5090", VA = "0x1817B6290")]
	public IGFGNFBNCFM(BFKLEOLBFKE[] NGBKPJMNOJL, bool CJEDMAAIJEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x17B4B30", Offset = "0x17B3930", VA = "0x1817B4B30")]
	public int EFDGKMDLMNK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x17B5B30", Offset = "0x17B4930", VA = "0x1817B5B30")]
	private int OMOBMOMCFJE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x17B4BA0", Offset = "0x17B39A0", VA = "0x1817B4BA0", Slot = "6")]
	protected virtual uint FAFAEFMGNCB(uint PKCNHEGJGNH, T IGJPNMBCJPK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x17B4EB0", Offset = "0x17B3CB0", VA = "0x1817B4EB0")]
	public bool GFFDKFLDOGB(T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x17B4A90", Offset = "0x17B3890", VA = "0x1817B4A90")]
	public bool DNJJODPKEOD(int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x17B4CA0", Offset = "0x17B3AA0", VA = "0x1817B4CA0")]
	public bool FKLGFCOHCLF(Func<T, bool> EHDENJOEBEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x17B4F40", Offset = "0x17B3D40", VA = "0x1817B4F40")]
	public int GGKMBKAEBGM(T IGJPNMBCJPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x17B4D70", Offset = "0x17B3B70", VA = "0x1817B4D70")]
	public T FMDMOKNGPIL(int AIPHGHFENPJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x17B4FD0", Offset = "0x17B3DD0", VA = "0x1817B4FD0")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x17B5700", Offset = "0x17B4500", VA = "0x1817B5700")]
	public bool LHAEMCGIOMO(T IGJPNMBCJPK, bool DBMEGJOBOOF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x17B5300", Offset = "0x17B4100", VA = "0x1817B5300")]
	public bool LHAEMCGIOMO(T IGJPNMBCJPK, int AIPHGHFENPJ, bool DBMEGJOBOOF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x17B48E0", Offset = "0x17B36E0", VA = "0x1817B48E0")]
	public bool AKJLIPOIGHF(T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x17B4E30", Offset = "0x17B3C30", VA = "0x1817B4E30")]
	public bool GEPHADMCPNH(int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x17B5770", Offset = "0x17B4570", VA = "0x1817B5770")]
	private void OMFGKOPAABL(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x17B51C0", Offset = "0x17B3FC0", VA = "0x1817B51C0")]
	public BFKLEOLBFKE[] JEAKIKGHNCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x17B4A40", Offset = "0x17B3840", VA = "0x1817B4A40")]
	private int CDHMBNHDIMD(int HMJFOJBNOAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x17B5D30", Offset = "0x17B4B30", VA = "0x1817B5D30", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x17B5D30", Offset = "0x17B4B30", VA = "0x1817B5D30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x316E680", Offset = "0x316D480", VA = "0x18316E680")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Handle NHEHBINCOGM
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x316DBE0", Offset = "0x316C9E0", VA = "0x18316DBE0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x316EA00", Offset = "0x316D800", VA = "0x18316EA00")]
		public PJBKNJHEFBK(global::JLCPNFGEOBK<Handle> PIDJNOBOEBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x316E960", Offset = "0x316D760", VA = "0x18316E960")]
		public DNJLGGCBKBG MIHDEIPKAKJ(in DNJLGGCBKBG KIHDPCDCOMG)
		{
			return default(DNJLGGCBKBG);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x316E8C0", Offset = "0x316D6C0", VA = "0x18316E8C0")]
		public HHMLOMLKNND MIHDEIPKAKJ(in HHMLOMLKNND KIHDPCDCOMG)
		{
			return default(HHMLOMLKNND);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x316E000", Offset = "0x316CE00", VA = "0x18316E000")]
		public bool HMKKNIINHFB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x316DFB0", Offset = "0x316CDB0", VA = "0x18316DFB0")]
		private int EHIEMAAGKII(string GOJKMEMCPDE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x316E7D0", Offset = "0x316D5D0", VA = "0x18316E7D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x35914C0", Offset = "0x35902C0", VA = "0x1835914C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x29286D0", Offset = "0x29274D0", VA = "0x1829286D0")]
		public DNJLGGCBKBG(global::JLCPNFGEOBK<Handle> PIDJNOBOEBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x2928550", Offset = "0x2927350", VA = "0x182928550")]
		public bool HMKKNIINHFB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x35913C0", Offset = "0x35901C0", VA = "0x1835913C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2928650", Offset = "0x2927450", VA = "0x182928650")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x29286D0", Offset = "0x29274D0", VA = "0x1829286D0")]
		public HHMLOMLKNND(global::JLCPNFGEOBK<Handle> PIDJNOBOEBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x2928550", Offset = "0x2927350", VA = "0x182928550")]
		public bool HMKKNIINHFB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x2928450", Offset = "0x2927250", VA = "0x182928450")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D8D880", Offset = "0x2D8C680", VA = "0x182D8D880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int KEHBMLJLDDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x2D8D2C0", Offset = "0x2D8C0C0", VA = "0x182D8D2C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int POBHNCDBPKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int ACKACKBIKOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public DNJLGGCBKBG CAKCMHFHGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C060", Offset = "0x2D8AE60", VA = "0x182D8C060")]
		get
		{
			return default(DNJLGGCBKBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public HHMLOMLKNND KJHLMJNOKGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x2D89EB0", Offset = "0x2D88CB0", VA = "0x182D89EB0")]
		get
		{
			return default(HHMLOMLKNND);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x2D8E220", Offset = "0x2D8D020", VA = "0x182D8E220")]
	public JLCPNFGEOBK(int BOCABLLJGMP, Allocator JEOILJEOOOI = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x2D8BB70", Offset = "0x2D8A970", VA = "0x182D8BB70")]
	public void ICKDJJKFGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0xE14230", Offset = "0xE13030", VA = "0x180E14230")]
	public static int INGBECJDIGI(int HFMHCLGICNJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x2D89F50", Offset = "0x2D88D50", VA = "0x182D89F50")]
	public static bool BAOIFAGJEEM(int HFMHCLGICNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x2D8ADD0", Offset = "0x2D89BD0", VA = "0x182D8ADD0")]
	public static bool FBMPFDIMJCM(int HFMHCLGICNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x2D8D3C0", Offset = "0x2D8C1C0", VA = "0x182D8D3C0")]
	public bool LLJLJAOOPBD(int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x2D8E070", Offset = "0x2D8CE70", VA = "0x182D8E070")]
	public bool PJJDNLFCCFI(int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x2D8D040", Offset = "0x2D8BE40", VA = "0x182D8D040")]
	public bool KDAIOGGPNLA(Handle MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x2D8C820", Offset = "0x2D8B620", VA = "0x182D8C820")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void JPLJFJIJDLO(Handle MIGDJNOKMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x2D8DC90", Offset = "0x2D8CA90", VA = "0x182D8DC90")]
	public Handle PJAPBNCMBEB()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x2D8B3C0", Offset = "0x2D8A1C0", VA = "0x182D8B3C0")]
	public void FJFBBHGFOEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x2D8BA00", Offset = "0x2D8A800", VA = "0x182D8BA00")]
	public void IALCHHDMNFP(Handle MIGDJNOKMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x2D8BDE0", Offset = "0x2D8ABE0", VA = "0x182D8BDE0")]
	public bool IHGIDBJFPED(Handle MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x2D8D960", Offset = "0x2D8C760", VA = "0x182D8D960")]
	private bool PCOOKELLJJG(int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x2D8AC60", Offset = "0x2D89A60", VA = "0x182D8AC60")]
	private void EJMEKAMIFIO(out int AIPHGHFENPJ, out int JKGBPKEJAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x2D8A480", Offset = "0x2D89280", VA = "0x182D8A480")]
	private void DLGFPDHJMBK(Handle MIGDJNOKMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x2D8C1F0", Offset = "0x2D8AFF0", VA = "0x182D8C1F0")]
	private void INHEPIOCHAN(int AIPHGHFENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x2D8A0C0", Offset = "0x2D88EC0", VA = "0x182D8A0C0")]
	private bool CLLDIKMGNKF(out int AIPHGHFENPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x2D8A680", Offset = "0x2D89480", VA = "0x182D8A680")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E10120", Offset = "0x2E0EF20", VA = "0x182E10120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int KEHBMLJLDDD
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x2E0FFA0", Offset = "0x2E0EDA0", VA = "0x182E0FFA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x2E0EF50", Offset = "0x2E0DD50", VA = "0x182E0EF50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public T MGJNMHFDFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x2E0FC50", Offset = "0x2E0EA50", VA = "0x182E0FC50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2E10E80", Offset = "0x2E0FC80", VA = "0x182E10E80")]
	public OPFKIBDDGAC(int BOCABLLJGMP, [Optional] Action<T> EGMBCEFPMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x2E0EF80", Offset = "0x2E0DD80", VA = "0x182E0EF80")]
	public void ICKDJJKFGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x2E0FA80", Offset = "0x2E0E880", VA = "0x182E0FA80")]
	public bool KDAIOGGPNLA(Handle MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void JPLJFJIJDLO(Handle MIGDJNOKMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x2E0EA00", Offset = "0x2E0D800", VA = "0x182E0EA00")]
	public T BOPAOPJOHPG(Handle MIGDJNOKMHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x2E0FEF0", Offset = "0x2E0ECF0", VA = "0x182E0FEF0")]
	public bool KNMEGLCAMII(Handle MIGDJNOKMHC, out T CCPIHKCBGHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x2E104E0", Offset = "0x2E0F2E0", VA = "0x182E104E0")]
	public void PIGMJENILDA(Handle MIGDJNOKMHC, T KMCKONMJFFK, out T NALMGNHPGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x2E101A0", Offset = "0x2E0EFA0", VA = "0x182E101A0")]
	public void PIGMJENILDA(Handle MIGDJNOKMHC, T KMCKONMJFFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x2E0F8A0", Offset = "0x2E0E6A0", VA = "0x182E0F8A0")]
	public bool JKMDIHKOIGC(Handle MIGDJNOKMHC, T KMCKONMJFFK, out T NALMGNHPGDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x2E0F3F0", Offset = "0x2E0E1F0", VA = "0x182E0F3F0")]
	public bool JKMDIHKOIGC(Handle MIGDJNOKMHC, T KMCKONMJFFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x2E0EB20", Offset = "0x2E0D920", VA = "0x182E0EB20")]
	public Handle HEFJCCLOLGO(T CCPIHKCBGHF)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x2E10580", Offset = "0x2E0F380", VA = "0x182E10580")]
	public void PLJGJCHOOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x2E0DDA0", Offset = "0x2E0CBA0", VA = "0x182E0DDA0")]
	public void AKJLIPOIGHF(Handle MIGDJNOKMHC, out T NALMGNHPGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x2E0E010", Offset = "0x2E0CE10", VA = "0x182E0E010")]
	public void AKJLIPOIGHF(Handle MIGDJNOKMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x2E0E5A0", Offset = "0x2E0D3A0", VA = "0x182E0E5A0")]
	public bool BNPPCNDHKAP(Handle MIGDJNOKMHC, out T NALMGNHPGDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x2E0E840", Offset = "0x2E0D640", VA = "0x182E0E840")]
	public bool BNPPCNDHKAP(Handle MIGDJNOKMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x2E0EAC0", Offset = "0x2E0D8C0", VA = "0x182E0EAC0")]
	private T GEPHADMCPNH(int AIPHGHFENPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x2E0F240", Offset = "0x2E0E040", VA = "0x182E0F240")]
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
		[Cpp2IlInjected.Address(RVA = "0x17B7060", Offset = "0x17B5E60", VA = "0x1817B7060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int OKMJDACDFKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x2281700", Offset = "0x2280500", VA = "0x182281700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x23C5C20", Offset = "0x23C4A20", VA = "0x1823C5C20")]
	public static global::ALEKOGIBJDP<T> JMMOFKMJOMM(int CHMDLBBFMNF = 0, int EPOOANDMMJL = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x23C5DA0", Offset = "0x23C4BA0", VA = "0x1823C5DA0")]
	public static global::ALEKOGIBJDP<T> MKABKNECJPE(int CHMDLBBFMNF = 0, int EPOOANDMMJL = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x23C6010", Offset = "0x23C4E10", VA = "0x1823C6010")]
	public ALEKOGIBJDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x23C6050", Offset = "0x23C4E50", VA = "0x1823C6050")]
	public ALEKOGIBJDP(int CHMDLBBFMNF, int EPOOANDMMJL = int.MaxValue, bool DDEEMBNHFIG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x23C5A70", Offset = "0x23C4870", VA = "0x1823C5A70")]
	public T FKJKJFLCNLI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x23C5CF0", Offset = "0x23C4AF0", VA = "0x1823C5CF0")]
	public void LKKBDAMJBBO(T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x23C58B0", Offset = "0x23C46B0", VA = "0x1823C58B0")]
	private void CHLOBPCCNFE(T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x23C5C00", Offset = "0x23C4A00", VA = "0x1823C5C00")]
	private void JHBDGFKGBHD(T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x23C5B80", Offset = "0x23C4980", VA = "0x1823C5B80")]
	[Conditional("DEBUG_BUILD")]
	private void FMKODGJKDKE(T FNOFBOPMDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x23C5820", Offset = "0x23C4620", VA = "0x1823C5820")]
	[Conditional("DEBUG_BUILD")]
	private void CGAFMCMLFAN(T FNOFBOPMDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x23C5980", Offset = "0x23C4780", VA = "0x1823C5980", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x23C5E70", Offset = "0x23C4C70", VA = "0x1823C5E70")]
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
		[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x677140", Offset = "0x675F40", VA = "0x180677140", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool LMCAAOFIENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x2E2D4B0", Offset = "0x2E2C2B0", VA = "0x182E2D4B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x2E2D1F0", Offset = "0x2E2BFF0", VA = "0x182E2D1F0")]
	public bool FEJCNECMMHF(T IGJPNMBCJPK, int HKOHGCMCHKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x2E2D3F0", Offset = "0x2E2C1F0", VA = "0x182E2D3F0")]
	public bool GFIDHGBMMBC(int HKOHGCMCHKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2E2D6F0", Offset = "0x2E2C4F0", VA = "0x182E2D6F0")]
	public T PEDKMDPFNBI(int FAJKJFLNAAF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x2E2D450", Offset = "0x2E2C250", VA = "0x182E2D450")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x2E2D250", Offset = "0x2E2C050", VA = "0x182E2D250")]
	private bool GCGOFAALEHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x2E2D160", Offset = "0x2E2BF60", VA = "0x182E2D160")]
	public bool CECEMJJAJEO(int HKOHGCMCHKO, out T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x259B080", Offset = "0x2599E80", VA = "0x18259B080")]
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
		[Cpp2IlInjected.Address(RVA = "0x17B4FA0", Offset = "0x17B3DA0", VA = "0x1817B4FA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x1AC8D60", Offset = "0x1AC7B60", VA = "0x181AC8D60")]
	public bool FKLGFCOHCLF(T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x1AC8F70", Offset = "0x1AC7D70", VA = "0x181AC8F70")]
	public void HEFJCCLOLGO(T IGJPNMBCJPK, int HKOHGCMCHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x1AC8A80", Offset = "0x1AC7880", VA = "0x181AC8A80")]
	public bool AKJLIPOIGHF(T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x1AC9080", Offset = "0x1AC7E80", VA = "0x181AC9080")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x1AC90E0", Offset = "0x1AC7EE0", VA = "0x181AC90E0")]
	public T PCOGBLDCONM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x1AC9010", Offset = "0x1AC7E10", VA = "0x181AC9010")]
	public T ICCBDBEBDBJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x1AC8BA0", Offset = "0x1AC79A0", VA = "0x181AC8BA0")]
	private void DMCIMOOOJKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x1AC9150", Offset = "0x1AC7F50", VA = "0x181AC9150")]
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
			[Cpp2IlInjected.Address(RVA = "0x5D54F20", Offset = "0x5D53D20", VA = "0x185D54F20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x5D552B0", Offset = "0x5D540B0", VA = "0x185D552B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x5D55130", Offset = "0x5D53F30", VA = "0x185D55130")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x5D55410", Offset = "0x5D54210", VA = "0x185D55410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x5D54E40", Offset = "0x5D53C40", VA = "0x185D54E40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x5D551D0", Offset = "0x5D53FD0", VA = "0x185D551D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x5D55050", Offset = "0x5D53E50", VA = "0x185D55050")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x5D54DF0", Offset = "0x5D53BF0", VA = "0x185D54DF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AF11C0", Offset = "0x2AEFFC0", VA = "0x182AF11C0", Slot = "4")]
		public virtual T GCFGDHINFFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xE9C870", Offset = "0xE9B670", VA = "0x180E9C870")]
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
		[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x6578C0", VA = "0x180658AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x677130", Offset = "0x675F30", VA = "0x180677130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector2 GAKMPLLBFML
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x15B68F0", Offset = "0x15B56F0", VA = "0x1815B68F0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x6A0CD0", Offset = "0x69FAD0", VA = "0x1806A0CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector2 IELDGPPLJLD
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x1E63390", Offset = "0x1E62190", VA = "0x181E63390")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x1582100", Offset = "0x1580F00", VA = "0x181582100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector2 MGOGNDBCJOF
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x5D52EC0", Offset = "0x5D51CC0", VA = "0x185D52EC0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x12AE4F0", Offset = "0x12AD2F0", VA = "0x1812AE4F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int HLILMKNMKDI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x6570E0", Offset = "0x655EE0", VA = "0x1806570E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x6BE640", Offset = "0x6BD440", VA = "0x1806BE640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D535C0", Offset = "0x5D523C0", VA = "0x185D535C0")]
	public OIMDLLNEAFM(Bounds AMFAFDADKEK, Vector2[] DMPGLONGKPD, int IMAEPENEFAA, byte HMJFOJBNOAJ, float KLOIGECHDKI = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D53040", Offset = "0x5D51E40", VA = "0x185D53040")]
	public PFCMOJKBLHA EIAHHAHGNPN(byte AIPHGHFENPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5D534A0", Offset = "0x5D522A0", VA = "0x185D534A0")]
	public void FMCBJMBGGEK(Vector3 EIIEKPIPEEF, float AGDGJEDGMPN, float PEBBGPHOPOC, ref List<byte> PAAEMJHEMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5D535A0", Offset = "0x5D523A0", VA = "0x185D535A0")]
	public void JDMNBCLKEGJ(PFCMOJKBLHA.OCLGPCGPGOI IBAAEKMJMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5D52EE0", Offset = "0x5D51CE0", VA = "0x185D52EE0")]
	private PFCMOJKBLHA CMFKGPNDDDO(byte AIPHGHFENPJ, PFCMOJKBLHA.IMAAIIAEMDK DPNHOHGBFCN, PFCMOJKBLHA ADECAOLBLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x5D530A0", Offset = "0x5D51EA0", VA = "0x185D530A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D544C0", Offset = "0x5D532C0", VA = "0x185D544C0")]
	public PFCMOJKBLHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5D54460", Offset = "0x5D53260", VA = "0x185D54460")]
	public PFCMOJKBLHA(byte FCDKMJOKGIE, IMAAIIAEMDK DPNHOHGBFCN, PFCMOJKBLHA ADECAOLBLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x5D54360", Offset = "0x5D53160", VA = "0x185D54360")]
	public void NKNHNPFFGPO(PFCMOJKBLHA NIPKJIJGCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
	public void JDMNBCLKEGJ(int NBFDHJCONPH, OCLGPCGPGOI IBAAEKMJMNL, int CKFKONADBAB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x5D540B0", Offset = "0x5D52EB0", VA = "0x185D540B0")]
	public void FMCBJMBGGEK(List<byte> PAAEMJHEMAA, Vector3 EIIEKPIPEEF, float AGDGJEDGMPN, float PEBBGPHOPOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5D54060", Offset = "0x5D52E60", VA = "0x185D54060")]
	public bool AIFMGHHDJML(Vector3 EFCGBFLJIDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x5D54420", Offset = "0x5D53220", VA = "0x185D54420")]
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
	[Cpp2IlInjected.Address(RVA = "0x17AC740", Offset = "0x17AB540", VA = "0x1817AC740")]
	public bool JHAGOKLKPEA(T PHPHBAGDNPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2767D90", Offset = "0x2766B90", VA = "0x182767D90")]
	public bool JHAGOKLKPEA(T PHPHBAGDNPE, object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x2767D30", Offset = "0x2766B30", VA = "0x182767D30")]
	public bool JHAGOKLKPEA(T PHPHBAGDNPE, object MKDOEIGPNGM, out object PLCBFAGFNLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x2767B80", Offset = "0x2766980", VA = "0x182767B80")]
	public bool BMPCKDFLJDD(T PHPHBAGDNPE, object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2767CF0", Offset = "0x2766AF0", VA = "0x182767CF0")]
	public bool INKHBMEJKFF(T PHPHBAGDNPE, object MKDOEIGPNGM, out object PLCBFAGFNLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x2767BC0", Offset = "0x27669C0", VA = "0x182767BC0")]
	public bool BMPCKDFLJDD(T PHPHBAGDNPE, object MKDOEIGPNGM, out object PLCBFAGFNLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2767B50", Offset = "0x2766950", VA = "0x182767B50")]
	public void BGFFCKJLFCP(T PHPHBAGDNPE, object MKDOEIGPNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2767C50", Offset = "0x2766A50", VA = "0x182767C50")]
	public void FIKGBJLIHAO(T PHPHBAGDNPE, object MKDOEIGPNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x2767DD0", Offset = "0x2766BD0", VA = "0x182767DD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1264670", Offset = "0x1263470", VA = "0x181264670")]
			public BGCANLKPIMO(List<Component> LPDILHBGHIJ, bool DNAIHDDDAFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x24EE5F0", Offset = "0x24ED3F0", VA = "0x1824EE5F0")]
			public ALCFPIODMBB<T> BALJJOIEHDJ()
			{
				return default(ALCFPIODMBB<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x24EE660", Offset = "0x24ED460", VA = "0x1824EE660", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x24EE660", Offset = "0x24ED460", VA = "0x1824EE660", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x23C5660", Offset = "0x23C4460", VA = "0x1823C5660", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003E1")]
				[Cpp2IlInjected.Address(RVA = "0x23C55F0", Offset = "0x23C43F0", VA = "0x1823C55F0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x23C5630", Offset = "0x23C4430", VA = "0x1823C5630")]
			public ALCFPIODMBB(List<Component> LPDILHBGHIJ, bool DNAIHDDDAFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x23C5520", Offset = "0x23C4320", VA = "0x1823C5520", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x23C5530", Offset = "0x23C4330", VA = "0x1823C5530", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x23C55E0", Offset = "0x23C43E0", VA = "0x1823C55E0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x5D57160", Offset = "0x5D55F60", VA = "0x185D57160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x5D57120", Offset = "0x5D55F20", VA = "0x185D57120")]
		public ToolHierarchyCache(GameObject NLMNGLPMKIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x5D56B80", Offset = "0x5D55980", VA = "0x185D56B80")]
		private void ILMEFAAGLOH(GameObject NLMNGLPMKIH, bool EFJKFNKFDIO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x5D56CE0", Offset = "0x5D55AE0", VA = "0x185D56CE0")]
		public static void ILMEFAAGLOH(GameObject NLMNGLPMKIH, ref ToolHierarchyCache BGMEKLANEFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x5D56AF0", Offset = "0x5D558F0", VA = "0x185D56AF0")]
		public void GDABPBLHHDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x5D568D0", Offset = "0x5D556D0", VA = "0x185D568D0")]
		public void BODKONPEAMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x2414040", Offset = "0x2412E40", VA = "0x182414040")]
		public void OCIPHBIPPGC<T>(Action<T> CGKOOFFNHKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x5D56920", Offset = "0x5D55720", VA = "0x185D56920")]
		public Component EAAFOKEDLAE(Type NKICFHCCMMH, bool DNAIHDDDAFO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x2413EF0", Offset = "0x2412CF0", VA = "0x182413EF0")]
		public T EAAFOKEDLAE<T>(bool DNAIHDDDAFO = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x5D56A70", Offset = "0x5D55870", VA = "0x185D56A70")]
		public BGCANLKPIMO<Component> FBDIHCHJNKN(Type NKICFHCCMMH, bool DNAIHDDDAFO = false)
		{
			return default(BGCANLKPIMO<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2413F70", Offset = "0x2412D70", VA = "0x182413F70")]
		public BGCANLKPIMO<T> FBDIHCHJNKN<T>(bool DNAIHDDDAFO = false) where T : class
		{
			return default(BGCANLKPIMO<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x5D56D70", Offset = "0x5D55B70", VA = "0x185D56D70")]
		public List<Component> MDKFECCCDEA(Type NKICFHCCMMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x5D569F0", Offset = "0x5D557F0", VA = "0x185D569F0", Slot = "4")]
		public bool Equals(ToolHierarchyCache KNMKEOOODCL, ToolHierarchyCache EMKKILCIAOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x5D56B00", Offset = "0x5D55900", VA = "0x185D56B00", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x17B7060", Offset = "0x17B5E60", VA = "0x1817B7060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public T KCJGEAHJJCN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x24F2650", Offset = "0x24F1450", VA = "0x1824F2650")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public T DPIAKLCPMIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x24F2460", Offset = "0x24F1260", VA = "0x1824F2460")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public T JCBNPIAHHCB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x24F2520", Offset = "0x24F1320", VA = "0x1824F2520")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x24F26E0", Offset = "0x24F14E0", VA = "0x1824F26E0")]
	public BIHBJNOIAFJ(int CHMDLBBFMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x24F2230", Offset = "0x24F1030", VA = "0x1824F2230")]
	public void HEFJCCLOLGO(T MBKFGPPACCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x24F23E0", Offset = "0x24F11E0", VA = "0x1824F23E0")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x24F2190", Offset = "0x24F0F90", VA = "0x1824F2190")]
	public void DGLNJJPOGHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x24F24D0", Offset = "0x24F12D0", VA = "0x1824F24D0")]
	public void OLCMHINEDDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x24F24C0", Offset = "0x24F12C0", VA = "0x1824F24C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D50E90", Offset = "0x5D4FC90", VA = "0x185D50E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool MAFLJCDFJLF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x65B250", Offset = "0x65A050", VA = "0x18065B250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x1441A90", Offset = "0x1440890", VA = "0x181441A90")]
	public HFJELPPAOJM(Action CGKOOFFNHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x5D50E70", Offset = "0x5D4FC70", VA = "0x185D50E70")]
	public void NBKICENBLEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x5D50E70", Offset = "0x5D4FC70", VA = "0x185D50E70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class NKDJAOAMIIC
{
	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FCB0", VA = "0x180670EB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x676E40", VA = "0x180678040", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x1AD64E0", Offset = "0x1AD52E0", VA = "0x181AD64E0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool LMCAAOFIENA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x259B010", Offset = "0x2599E10", VA = "0x18259B010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public object JHHBPMBHNBH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x6718E0", Offset = "0x6706E0", VA = "0x1806718E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x6991C0", Offset = "0x697FC0", VA = "0x1806991C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x25963B0", Offset = "0x25951B0", VA = "0x1825963B0")]
	public bool FEJCNECMMHF(T IGJPNMBCJPK, object MKDOEIGPNGM, int HKOHGCMCHKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x259AF70", Offset = "0x2599D70", VA = "0x18259AF70")]
	public bool GFIDHGBMMBC(object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x2595CB0", Offset = "0x2594AB0", VA = "0x182595CB0")]
	public bool CECEMJJAJEO(object MKDOEIGPNGM, out T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x259AFE0", Offset = "0x2599DE0", VA = "0x18259AFE0")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x2596FC0", Offset = "0x2595DC0", VA = "0x182596FC0")]
	private bool GCGOFAALEHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x259B080", Offset = "0x2599E80", VA = "0x18259B080")]
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
		[Cpp2IlInjected.Address(RVA = "0xF2FE00", Offset = "0xF2EC00", VA = "0x180F2FE00")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xD636C0", Offset = "0xD624C0", VA = "0x180D636C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x5D54B70", Offset = "0x5D53970", VA = "0x185D54B70")]
	public void FEJCNECMMHF(float IGJPNMBCJPK, object MKDOEIGPNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x5D54BE0", Offset = "0x5D539E0", VA = "0x185D54BE0")]
	public void GFIDHGBMMBC(object MKDOEIGPNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x5D54C50", Offset = "0x5D53A50", VA = "0x185D54C50")]
	private void NCKMPFFNPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x5D54D70", Offset = "0x5D53B70", VA = "0x185D54D70")]
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
	[Cpp2IlInjected.Address(RVA = "0x657F40", Offset = "0x656D40", VA = "0x180657F40")]
	public EABJGGDLAPO(string MKKAPGFCJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5D50700", Offset = "0x5D4F500", VA = "0x185D50700")]
	public EABJGGDLAPO(UnityEngine.Object LKHBCBIAPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x5D506B0", Offset = "0x5D4F4B0", VA = "0x185D506B0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
		public BELENFMGBFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x5D4DEC0", Offset = "0x5D4CCC0", VA = "0x185D4DEC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D51440", Offset = "0x5D50240", VA = "0x185D51440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool MGBIGNFKMDM
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x5D51390", Offset = "0x5D50190", VA = "0x185D51390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int MNCJKLLDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x658BD0", Offset = "0x6579D0", VA = "0x180658BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x5D51570", Offset = "0x5D50370", VA = "0x185D51570")]
	public bool HEFJCCLOLGO(object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x5D513A0", Offset = "0x5D501A0", VA = "0x185D513A0")]
	public bool AKJLIPOIGHF(object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x5D51510", Offset = "0x5D50310", VA = "0x185D51510")]
	public bool FKLGFCOHCLF(object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x5D51660", Offset = "0x5D50460", VA = "0x185D51660")]
	public void IHIGDLFAICK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5D516D0", Offset = "0x5D504D0", VA = "0x185D516D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0xFAA130", Offset = "0xFA8F30", VA = "0x180FAA130", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x14DBF00", Offset = "0x14DAD00", VA = "0x1814DBF00", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public object BPHBJABLGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x66D6F0", Offset = "0x66C4F0", VA = "0x18066D6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x6EFAE0", Offset = "0x6EE8E0", VA = "0x1806EFAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool LMCAAOFIENA
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x2E4C670", Offset = "0x2E4B470", VA = "0x182E4C670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x2E4ACA0", Offset = "0x2E49AA0", VA = "0x182E4ACA0")]
	public bool FEJCNECMMHF(T IGJPNMBCJPK, object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x2E4C610", Offset = "0x2E4B410", VA = "0x182E4C610")]
	public bool GFIDHGBMMBC(object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x259AFE0", Offset = "0x2599DE0", VA = "0x18259AFE0")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x2E4A7D0", Offset = "0x2E495D0", VA = "0x182E4A7D0")]
	public bool CECEMJJAJEO(object MKDOEIGPNGM, out T IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x2E4AFB0", Offset = "0x2E49DB0", VA = "0x182E4AFB0")]
	private bool GCGOFAALEHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x2E4C6B0", Offset = "0x2E4B4B0", VA = "0x182E4C6B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
	public ABAJDIGBNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x5D4D670", Offset = "0x5D4C470", VA = "0x185D4D670")]
	private static string DPCKFJIDOBP(byte[] BMMLDIMMAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x5D4D780", Offset = "0x5D4C580", VA = "0x185D4D780")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
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
