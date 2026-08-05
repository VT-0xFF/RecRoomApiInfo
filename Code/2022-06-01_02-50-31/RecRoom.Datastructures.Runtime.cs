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
public class NDMHIHKEIHB : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8034A0", Offset = "0x801EA0", VA = "0x1808034A0")]
	public NDMHIHKEIHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4D13CF0", Offset = "0x4D126F0", VA = "0x184D13CF0")]
	public byte[] MKENIGOPKLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void NOMEMMFIDOE(IncrementalHash JGDFFEGEHJN);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6179D0", Offset = "0x6163D0", VA = "0x1806179D0")]
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
	[ILKDPHKLFGP]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[ILKDPHKLFGP]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4D16F10", Offset = "0x4D15910", VA = "0x184D16F10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4D16ED0", Offset = "0x4D158D0", VA = "0x184D16ED0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4D16F50", Offset = "0x4D15950", VA = "0x184D16F50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4D17160", Offset = "0x4D15B60", VA = "0x184D17160")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4D170D0", Offset = "0x4D15AD0", VA = "0x184D170D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC19470", Offset = "0xC17E70", VA = "0x180C19470")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x89FFC0", Offset = "0x89E9C0", VA = "0x18089FFC0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4D16E90", Offset = "0x4D15890", VA = "0x184D16E90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4D17040", Offset = "0x4D15A40", VA = "0x184D17040")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4D16980", Offset = "0x4D15380", VA = "0x184D16980")]
	public void CopyBounds(SavedExtents KKPJJILPNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4D16E00", Offset = "0x4D15800", VA = "0x184D16E00")]
	public void SetLocalSpaceBounds(Bounds BGEACEGDCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA705F0", Offset = "0xA6EFF0", VA = "0x180A705F0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4D16DF0", Offset = "0x4D157F0", VA = "0x184D16DF0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4D169B0", Offset = "0x4D153B0", VA = "0x184D169B0")]
	private void MOENMEPFJBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4D16BC0", Offset = "0x4D155C0", VA = "0x184D16BC0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4D163C0", Offset = "0x4D14DC0", VA = "0x184D163C0")]
	public static void CalculateLocalBoundsFor(GameObject BHNNPCJCNFB, out Bounds BGEACEGDCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4D16300", Offset = "0x4D14D00", VA = "0x184D16300")]
	private static void BEDHJGMPEGN(Bounds ODMIEFIFOGP, Color HJNCMGDJMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4D16E20", Offset = "0x4D15820", VA = "0x184D16E20")]
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
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x551E80", VA = "0x180553480")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x577BA0", Offset = "0x5765A0", VA = "0x180577BA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x556460", Offset = "0x554E60", VA = "0x180556460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "4")]
	public virtual void HCEENOMJCEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x218A560", Offset = "0x2188F60", VA = "0x18218A560")]
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
	[SerializeField]
	[NDMHIHKEIHB]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3E6E7A0", Offset = "0x3E6D1A0", VA = "0x183E6E7A0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3E6E2E0", Offset = "0x3E6CCE0", VA = "0x183E6E2E0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3E6EDA0", Offset = "0x3E6D7A0", VA = "0x183E6EDA0")]
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
	private sealed class OMNKKHMNHEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x218A560", Offset = "0x2188F60", VA = "0x18218A560")]
		public OMNKKHMNHEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x34CC850", Offset = "0x34CB250", VA = "0x1834CC850")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[NDMHIHKEIHB]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x551E80", VA = "0x180553480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x34C6BC0", Offset = "0x34C55C0", VA = "0x1834C6BC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x34C6BF0", Offset = "0x34C55F0", VA = "0x1834C6BF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x34C6B10", Offset = "0x34C5510", VA = "0x1834C6B10", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal this[TKey IPKOPOLJGIA]
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x34C6B40", Offset = "0x34C5540", VA = "0x1834C6B40", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x34C6A10", Offset = "0x34C5410", VA = "0x1834C6A10", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x34C6270", Offset = "0x34C4C70", VA = "0x1834C6270", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x34C5BE0", Offset = "0x34C45E0", VA = "0x1834C5BE0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x34C5810", Offset = "0x34C4210", VA = "0x1834C5810", Slot = "14")]
	protected virtual string KKDKJCFKGBL(TKeyVal FJMNBLAAFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x34C5720", Offset = "0x34C4120", VA = "0x1834C5720", Slot = "4")]
	public bool ContainsKey(TKey IPKOPOLJGIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x34C6900", Offset = "0x34C5300", VA = "0x1834C6900", Slot = "5")]
	public bool TryGetValue(TKey IPKOPOLJGIA, out TVal HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x34C5750", Offset = "0x34C4150", VA = "0x1834C5750", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x34C5750", Offset = "0x34C4150", VA = "0x1834C5750", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x34C6930", Offset = "0x34C5330", VA = "0x1834C6930")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class IEJJNHDDFJM<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class ABFLKBLOBNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x218A560", Offset = "0x2188F60", VA = "0x18218A560")]
		public ABFLKBLOBNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x36EBB40", Offset = "0x36EA540", VA = "0x1836EBB40")]
		internal bool <GetSamples>b__0(global::GHPCCKONNPP<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly float JAFOOGAIPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly float OCCMICHODDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private List<global::GHPCCKONNPP<float, T>> LGBDJMEGJND;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int IOKMIKHMKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x36EF840", Offset = "0x36EE240", VA = "0x1836EF840")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x36F0310", Offset = "0x36EED10", VA = "0x1836F0310")]
	public IEJJNHDDFJM(float AGCBKMIFLFC, float AAHIOJOILOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x36EF940", Offset = "0x36EE340", VA = "0x1836EF940")]
	public bool IFIOCFDHKMJ(float NONCEAIIEGI, T HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x36EFC00", Offset = "0x36EE600", VA = "0x1836EFC00")]
	public int KABKEFDIIMM(float NONCEAIIEGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x36EFC90", Offset = "0x36EE690", VA = "0x1836EFC90")]
	public IEnumerable<T> NIJOFHDLPBI(float NONCEAIIEGI, [Optional] float? NACLGINJHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x36EFC60", Offset = "0x36EE660", VA = "0x1836EFC60")]
	public void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x36EF780", Offset = "0x36EE180", VA = "0x1836EF780")]
	private void DHOCDOFJNDM(float NONCEAIIEGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class KIKDHOGEGMJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct EBIBILOMHNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T CKLNJLLILCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float HGAAJENFOAO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static float PCFFIFDEJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<T> PEPGBGFHBAO;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const int CKKGPCMLFPJ = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private EBIBILOMHNE[] OBKDNKHGCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int BNMHJJMIIEO;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float DIMGDELPGLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x705150", Offset = "0x703B50", VA = "0x180705150")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x705220", Offset = "0x703C20", VA = "0x180705220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x43FC570", Offset = "0x43FAF70", VA = "0x1843FC570")]
	public KIKDHOGEGMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x43FC490", Offset = "0x43FAE90", VA = "0x1843FC490")]
	public KIKDHOGEGMJ(int OCEBHFCGEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x43FB100", Offset = "0x43F9B00", VA = "0x1843FB100")]
	public void CEGAKGBDODP(float NONCEAIIEGI, T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x43FC1A0", Offset = "0x43FABA0", VA = "0x1843FC1A0")]
	public void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x43FB440", Offset = "0x43F9E40", VA = "0x1843FB440")]
	public bool GPIAFHLKOIJ(float PCMPCCDMENE, float DFOBKDIMJBK, out T HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x43FB960", Offset = "0x43FA360", VA = "0x1843FB960")]
	public bool IEJNICJCADA(float PCMPCCDMENE, float DFOBKDIMJBK, out T HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x43FBED0", Offset = "0x43FA8D0", VA = "0x1843FBED0")]
	public void KCHHMOEPHIA(float PCMPCCDMENE, float DFOBKDIMJBK, List<T> HKIDJJNOKDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x43FC020", Offset = "0x43FAA20", VA = "0x1843FC020")]
	private int KHAIPGDMNGM(int KENCBHODIGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x43FB1E0", Offset = "0x43F9BE0", VA = "0x1843FB1E0")]
	private void EEIEJBLIGFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T CKOACBJGNBE();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T FFBJENIJDLH(T JINPLGIOFKM, T LFEBODKGKDF, float LIKLFJCOLDP);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T DDDAANLCBKM(T HPIAFNBPEPC, float LIKLFJCOLDP);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T MOEMPOOLPNC(T JINPLGIOFKM, T LFEBODKGKDF);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T PPNBKFKKGMO(T JINPLGIOFKM, T LFEBODKGKDF);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class ADNCMNGFEJN : global::KIKDHOGEGMJ<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4D11640", Offset = "0x4D10040", VA = "0x184D11640", Slot = "4")]
	protected override Vector3 CKOACBJGNBE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4D11750", Offset = "0x4D10150", VA = "0x184D11750", Slot = "5")]
	protected override Vector3 FFBJENIJDLH(Vector3 JINPLGIOFKM, Vector3 LFEBODKGKDF, float LIKLFJCOLDP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4D116B0", Offset = "0x4D100B0", VA = "0x184D116B0", Slot = "6")]
	protected override Vector3 DDDAANLCBKM(Vector3 HPIAFNBPEPC, float LIKLFJCOLDP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4D11810", Offset = "0x4D10210", VA = "0x184D11810", Slot = "7")]
	protected override Vector3 MOEMPOOLPNC(Vector3 JINPLGIOFKM, Vector3 LFEBODKGKDF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4D118C0", Offset = "0x4D102C0", VA = "0x184D118C0", Slot = "8")]
	protected override Vector3 PPNBKFKKGMO(Vector3 JINPLGIOFKM, Vector3 LFEBODKGKDF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4D11930", Offset = "0x4D10330", VA = "0x184D11930")]
	public ADNCMNGFEJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ADJEMJCOCJP : global::KIKDHOGEGMJ<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4D115E0", Offset = "0x4D0FFE0", VA = "0x184D115E0")]
	public ADJEMJCOCJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4D11570", Offset = "0x4D0FF70", VA = "0x184D11570")]
	public ADJEMJCOCJP(int OCEBHFCGEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6FAC90", Offset = "0x6F9690", VA = "0x1806FAC90", Slot = "4")]
	protected override float CKOACBJGNBE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4D114E0", Offset = "0x4D0FEE0", VA = "0x184D114E0", Slot = "5")]
	protected override float FFBJENIJDLH(float JINPLGIOFKM, float LFEBODKGKDF, float LIKLFJCOLDP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3E046C0", Offset = "0x3E030C0", VA = "0x183E046C0", Slot = "6")]
	protected override float DDDAANLCBKM(float HPIAFNBPEPC, float LIKLFJCOLDP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2C129A0", Offset = "0x2C113A0", VA = "0x182C129A0", Slot = "7")]
	protected override float MOEMPOOLPNC(float JINPLGIOFKM, float LFEBODKGKDF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4D11560", Offset = "0x4D0FF60", VA = "0x184D11560", Slot = "8")]
	protected override float PPNBKFKKGMO(float JINPLGIOFKM, float LFEBODKGKDF)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MEJGOLOPLKC
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x20CEAD0", Offset = "0x20CD4D0", VA = "0x1820CEAD0")]
	public static global::ABEDILJIAPD<T1> AEEGCHIFHAD<T1>(T1 FFPLCKNOIJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x22B57B0", Offset = "0x22B41B0", VA = "0x1822B57B0")]
	public static global::GHPCCKONNPP<T1, T2> AEEGCHIFHAD<T1, T2>(T1 FFPLCKNOIJF, T2 PFDFNGBPEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2405CA0", Offset = "0x24046A0", VA = "0x182405CA0")]
	public static global::NIIEGAEAHFF<T1, T2, T3> AEEGCHIFHAD<T1, T2, T3>(T1 FFPLCKNOIJF, T2 PFDFNGBPEKC, T3 GJNNGGGLLFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x22B42D0", Offset = "0x22B2CD0", VA = "0x1822B42D0")]
	public static global::MMBLNDKFEMM<T1, T2, T3, T4> AEEGCHIFHAD<T1, T2, T3, T4>(T1 FFPLCKNOIJF, T2 PFDFNGBPEKC, T3 GJNNGGGLLFH, T4 LFHILNIMOAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2404340", Offset = "0x2402D40", VA = "0x182404340")]
	public static global::LPBGDHOCHEG<T1, T2, T3, T4, T5> AEEGCHIFHAD<T1, T2, T3, T4, T5>(T1 FFPLCKNOIJF, T2 PFDFNGBPEKC, T3 GJNNGGGLLFH, T4 LFHILNIMOAL, T5 ABHMDAJFHHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2629070", Offset = "0x2627A70", VA = "0x182629070")]
	public static global::CNFFLOJGPAG<T1, T2, T3, T4, T5, T6> AEEGCHIFHAD<T1, T2, T3, T4, T5, T6>(T1 FFPLCKNOIJF, T2 PFDFNGBPEKC, T3 GJNNGGGLLFH, T4 LFHILNIMOAL, T5 ABHMDAJFHHN, T6 KBMGLBCENKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2405D30", Offset = "0x2404730", VA = "0x182405D30")]
	public static global::JHMNEELDOJH<T1, T2, T3, T4, T5, T6, T7> AEEGCHIFHAD<T1, T2, T3, T4, T5, T6, T7>(T1 FFPLCKNOIJF, T2 PFDFNGBPEKC, T3 GJNNGGGLLFH, T4 LFHILNIMOAL, T5 ABHMDAJFHHN, T6 KBMGLBCENKA, T7 NIEGEJPKHEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x22B5820", Offset = "0x22B4220", VA = "0x1822B5820")]
	public static global::FIGMLOCBGGD<T1, T2, T3, T4, T5, T6, T7, T8> AEEGCHIFHAD<T1, T2, T3, T4, T5, T6, T7, T8>(T1 FFPLCKNOIJF, T2 PFDFNGBPEKC, T3 GJNNGGGLLFH, T4 LFHILNIMOAL, T5 ABHMDAJFHHN, T6 KBMGLBCENKA, T7 NIEGEJPKHEH, T8 EMGLEAGCDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1EEF240", Offset = "0x1EEDC40", VA = "0x181EEF240")]
	[IteratorStateMachine(typeof(MJENGIHLDEP))]
	public static IEnumerable<global::GHPCCKONNPP<T1, T2>> IDDGEAIABPG<T1, T2>(IEnumerable<T1> MMADIBJKHHM, IEnumerable<T2> ODMIEFIFOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1EFAD10", Offset = "0x1EF9710", VA = "0x181EFAD10")]
	[IteratorStateMachine(typeof(EIEKLJAKJEJ))]
	public static IEnumerable<global::NIIEGAEAHFF<T1, T2, T3>> IDDGEAIABPG<T1, T2, T3>(IEnumerable<T1> MMADIBJKHHM, IEnumerable<T2> ODMIEFIFOGP, IEnumerable<T3> HJNCMGDJMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2985FC0", Offset = "0x29849C0", VA = "0x182985FC0")]
	internal static int PEJKCNNAGOB(int JINCBLKDBJA, int ONCFPCCCMFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x450EA70", Offset = "0x450D470", VA = "0x18450EA70")]
	internal static int PEJKCNNAGOB(int JINCBLKDBJA, int ONCFPCCCMFJ, int AJKJJPBAMGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x450EA80", Offset = "0x450D480", VA = "0x18450EA80")]
	internal static int PEJKCNNAGOB(int JINCBLKDBJA, int ONCFPCCCMFJ, int AJKJJPBAMGM, int AGALNAMNBBM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4D14F00", Offset = "0x4D13900", VA = "0x184D14F00")]
	internal static int PEJKCNNAGOB(int JINCBLKDBJA, int ONCFPCCCMFJ, int AJKJJPBAMGM, int AGALNAMNBBM, int OHAPPGKFBOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4D14F50", Offset = "0x4D13950", VA = "0x184D14F50")]
	internal static int PEJKCNNAGOB(int JINCBLKDBJA, int ONCFPCCCMFJ, int AJKJJPBAMGM, int AGALNAMNBBM, int OHAPPGKFBOF, int HBAKNGKNOJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4D14F70", Offset = "0x4D13970", VA = "0x184D14F70")]
	internal static int PEJKCNNAGOB(int JINCBLKDBJA, int ONCFPCCCMFJ, int AJKJJPBAMGM, int AGALNAMNBBM, int OHAPPGKFBOF, int HBAKNGKNOJL, int PEPFFPKCLEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4D14F20", Offset = "0x4D13920", VA = "0x184D14F20")]
	internal static int PEJKCNNAGOB(int JINCBLKDBJA, int ONCFPCCCMFJ, int AJKJJPBAMGM, int AGALNAMNBBM, int OHAPPGKFBOF, int HBAKNGKNOJL, int PEPFFPKCLEL, int NGDHEGLCLNM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class ABEDILJIAPD<T1> : IComparable<global::ABEDILJIAPD<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 POFAJGDOKPK;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1202180", Offset = "0x1200B80", VA = "0x181202180")]
	public ABEDILJIAPD(T1 FFPLCKNOIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x42225A0", Offset = "0x4220FA0", VA = "0x1842225A0", Slot = "4")]
	public int CompareTo(global::ABEDILJIAPD<T1> KKPJJILPNAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4222610", Offset = "0x4221010", VA = "0x184222610", Slot = "0")]
	public override bool Equals(object KKPJJILPNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xA63130", Offset = "0xA61B30", VA = "0x180A63130", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x42226B0", Offset = "0x42210B0", VA = "0x1842226B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GHPCCKONNPP<T1, T2> : IComparable<global::GHPCCKONNPP<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T1 POFAJGDOKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T2 MHCJAMGIMBD;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x333DBC0", Offset = "0x333C5C0", VA = "0x18333DBC0")]
	public GHPCCKONNPP(T1 FFPLCKNOIJF, T2 PFDFNGBPEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x333C270", Offset = "0x333AC70", VA = "0x18333C270", Slot = "4")]
	public int CompareTo(global::GHPCCKONNPP<T1, T2> KKPJJILPNAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x333C870", Offset = "0x333B270", VA = "0x18333C870", Slot = "0")]
	public override bool Equals(object KKPJJILPNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x333CF90", Offset = "0x333B990", VA = "0x18333CF90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x333D8D0", Offset = "0x333C2D0", VA = "0x18333D8D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NIIEGAEAHFF<T1, T2, T3> : IComparable<global::NIIEGAEAHFF<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 POFAJGDOKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 MHCJAMGIMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T3 FNAKGHABMHG;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3E238C0", Offset = "0x3E222C0", VA = "0x183E238C0")]
	public NIIEGAEAHFF(T1 FFPLCKNOIJF, T2 PFDFNGBPEKC, T3 GJNNGGGLLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3E231E0", Offset = "0x3E21BE0", VA = "0x183E231E0", Slot = "4")]
	public int CompareTo(global::NIIEGAEAHFF<T1, T2, T3> KKPJJILPNAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3E232E0", Offset = "0x3E21CE0", VA = "0x183E232E0", Slot = "0")]
	public override bool Equals(object KKPJJILPNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3E235D0", Offset = "0x3E21FD0", VA = "0x183E235D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3E23640", Offset = "0x3E22040", VA = "0x183E23640", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class MMBLNDKFEMM<T1, T2, T3, T4> : IComparable<global::MMBLNDKFEMM<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T1 POFAJGDOKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T2 MHCJAMGIMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T3 FNAKGHABMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T4 DIPECNGNIGN;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1202C30", Offset = "0x1201630", VA = "0x181202C30")]
	public MMBLNDKFEMM(T1 FFPLCKNOIJF, T2 PFDFNGBPEKC, T3 GJNNGGGLLFH, T4 LFHILNIMOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3EC7170", Offset = "0x3EC5B70", VA = "0x183EC7170", Slot = "4")]
	public int CompareTo(global::MMBLNDKFEMM<T1, T2, T3, T4> KKPJJILPNAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3EC72B0", Offset = "0x3EC5CB0", VA = "0x183EC72B0", Slot = "0")]
	public override bool Equals(object KKPJJILPNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3EC73D0", Offset = "0x3EC5DD0", VA = "0x183EC73D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3EC7490", Offset = "0x3EC5E90", VA = "0x183EC7490", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class LPBGDHOCHEG<T1, T2, T3, T4, T5> : IComparable<global::LPBGDHOCHEG<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T1 POFAJGDOKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T2 MHCJAMGIMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T3 FNAKGHABMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T4 DIPECNGNIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T5 HBBKALIGAHB;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1206630", Offset = "0x1205030", VA = "0x181206630")]
	public LPBGDHOCHEG(T1 FFPLCKNOIJF, T2 PFDFNGBPEKC, T3 GJNNGGGLLFH, T4 LFHILNIMOAL, T5 ABHMDAJFHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2D24C40", Offset = "0x2D23640", VA = "0x182D24C40", Slot = "4")]
	public int CompareTo(global::LPBGDHOCHEG<T1, T2, T3, T4, T5> KKPJJILPNAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2D24DC0", Offset = "0x2D237C0", VA = "0x182D24DC0", Slot = "0")]
	public override bool Equals(object KKPJJILPNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2D24F00", Offset = "0x2D23900", VA = "0x182D24F00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2D25000", Offset = "0x2D23A00", VA = "0x182D25000", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class CNFFLOJGPAG<T1, T2, T3, T4, T5, T6> : IComparable<global::CNFFLOJGPAG<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 POFAJGDOKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 MHCJAMGIMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 FNAKGHABMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 DIPECNGNIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 HBBKALIGAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 DIBDECALFKO;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x12081C0", Offset = "0x1206BC0", VA = "0x1812081C0")]
	public CNFFLOJGPAG(T1 FFPLCKNOIJF, T2 PFDFNGBPEKC, T3 GJNNGGGLLFH, T4 LFHILNIMOAL, T5 ABHMDAJFHHN, T6 KBMGLBCENKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x346EA40", Offset = "0x346D440", VA = "0x18346EA40", Slot = "4")]
	public int CompareTo(global::CNFFLOJGPAG<T1, T2, T3, T4, T5, T6> KKPJJILPNAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x346EC00", Offset = "0x346D600", VA = "0x18346EC00", Slot = "0")]
	public override bool Equals(object KKPJJILPNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x346ED70", Offset = "0x346D770", VA = "0x18346ED70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x346EE90", Offset = "0x346D890", VA = "0x18346EE90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class JHMNEELDOJH<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::JHMNEELDOJH<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T1 POFAJGDOKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T2 MHCJAMGIMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T3 FNAKGHABMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T4 DIPECNGNIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T5 HBBKALIGAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T6 DIBDECALFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T7 KLPNELLILFC;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1204D70", Offset = "0x1203770", VA = "0x181204D70")]
	public JHMNEELDOJH(T1 FFPLCKNOIJF, T2 PFDFNGBPEKC, T3 GJNNGGGLLFH, T4 LFHILNIMOAL, T5 ABHMDAJFHHN, T6 KBMGLBCENKA, T7 NIEGEJPKHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x29D5590", Offset = "0x29D3F90", VA = "0x1829D5590", Slot = "4")]
	public int CompareTo(global::JHMNEELDOJH<T1, T2, T3, T4, T5, T6, T7> KKPJJILPNAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x29D5790", Offset = "0x29D4190", VA = "0x1829D5790", Slot = "0")]
	public override bool Equals(object KKPJJILPNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x29D5930", Offset = "0x29D4330", VA = "0x1829D5930", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x29D5A80", Offset = "0x29D4480", VA = "0x1829D5A80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FIGMLOCBGGD<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::FIGMLOCBGGD<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T1 POFAJGDOKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T2 MHCJAMGIMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T3 FNAKGHABMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T4 DIPECNGNIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T5 HBBKALIGAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T6 DIBDECALFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T7 KLPNELLILFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T8 KGGJJADAOON;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x36DABF0", Offset = "0x36D95F0", VA = "0x1836DABF0")]
	public FIGMLOCBGGD(T1 FFPLCKNOIJF, T2 PFDFNGBPEKC, T3 GJNNGGGLLFH, T4 LFHILNIMOAL, T5 ABHMDAJFHHN, T6 KBMGLBCENKA, T7 NIEGEJPKHEH, T8 EMGLEAGCDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x36DA4E0", Offset = "0x36D8EE0", VA = "0x1836DA4E0", Slot = "4")]
	public int CompareTo(global::FIGMLOCBGGD<T1, T2, T3, T4, T5, T6, T7, T8> KKPJJILPNAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x36DA730", Offset = "0x36D9130", VA = "0x1836DA730", Slot = "0")]
	public override bool Equals(object KKPJJILPNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x36DA8F0", Offset = "0x36D92F0", VA = "0x1836DA8F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x36DAA60", Offset = "0x36D9460", VA = "0x1836DAA60", Slot = "3")]
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
	public T CKLNJLLILCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x552A10", Offset = "0x551410", VA = "0x180552A10")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x60BBE0", Offset = "0x60A5E0", VA = "0x18060BBE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float FEKFKICLHID
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x673EC0", Offset = "0x6728C0", VA = "0x180673EC0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3E881E0", Offset = "0x3E86BE0", VA = "0x183E881E0")]
	public T FNOAEHJLKJE(float LIKLFJCOLDP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3E88380", Offset = "0x3E86D80", VA = "0x183E88380")]
	public T HAMJADEJKJG(float LIKLFJCOLDP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T FFBJENIJDLH(T JINPLGIOFKM, T LFEBODKGKDF, float LIKLFJCOLDP);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x218A560", Offset = "0x2188F60", VA = "0x18218A560")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4D12A10", Offset = "0x4D11410", VA = "0x184D12A10", Slot = "4")]
	protected override float FFBJENIJDLH(float JINPLGIOFKM, float LFEBODKGKDF, float LIKLFJCOLDP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4D12A90", Offset = "0x4D11490", VA = "0x184D12A90")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4D180C0", Offset = "0x4D16AC0", VA = "0x184D180C0", Slot = "4")]
	protected override Vector3 FFBJENIJDLH(Vector3 JINPLGIOFKM, Vector3 LFEBODKGKDF, float LIKLFJCOLDP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4D18180", Offset = "0x4D16B80", VA = "0x184D18180")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4D11C10", Offset = "0x4D10610", VA = "0x184D11C10", Slot = "4")]
	protected override Color FFBJENIJDLH(Color JINPLGIOFKM, Color LFEBODKGKDF, float LIKLFJCOLDP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4D11C60", Offset = "0x4D10660", VA = "0x184D11C60")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public sealed class AHBHFGACMJH<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly MNJOJABCHIF IBEADABEDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private T[] CJNEAIJOKBO;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int HEBEBONJJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5779B0", Offset = "0x5763B0", VA = "0x1805779B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x649700", Offset = "0x648100", VA = "0x180649700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2512140", Offset = "0x2510B40", VA = "0x182512140")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x25121C0", Offset = "0x2510BC0", VA = "0x1825121C0")]
	public static global::AHBHFGACMJH<T> IHEMFNLEEFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2512390", Offset = "0x2510D90", VA = "0x182512390")]
	public static global::AHBHFGACMJH<T> OAMDHNFPPAC(int POIIDIEGIKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2512830", Offset = "0x2511230", VA = "0x182512830")]
	private AHBHFGACMJH(T[] HCJBDDKLCHE, int POIIDIEGIKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2512040", Offset = "0x2510A40", VA = "0x182512040", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2511770", Offset = "0x2510170", VA = "0x182511770")]
	public void CEGAKGBDODP(in T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x25122F0", Offset = "0x2510CF0", VA = "0x1825122F0")]
	public void LLGMOJMHILP(int LGBFGOJBLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2511980", Offset = "0x2510380", VA = "0x182511980")]
	public void COGGGHKGHDA(int OCEBHFCGEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x25124D0", Offset = "0x2510ED0", VA = "0x1825124D0")]
	private void PJBHCHFGCIP(int POIIDIEGIKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class HMNBNIBPKIB
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2626430", Offset = "0x2624E30", VA = "0x182626430")]
	public static global::AHBHFGACMJH<T> IHEMFNLEEFI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x20D3750", Offset = "0x20D2150", VA = "0x1820D3750")]
	public static global::AHBHFGACMJH<T> OAMDHNFPPAC<T>(int POIIDIEGIKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct JNDLBBMPEGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<ADCKJAHNEMI>> BFOKGHDJJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int NHGHBGICDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int DPBCGDFIDNN;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0xC883D0", Offset = "0xC86DD0", VA = "0x180C883D0")]
	private JNDLBBMPEGP(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<ADCKJAHNEMI>> MBHDBPMFIMN, int JEDNHHHPONP, int CEIPHPMCIKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4D14260", Offset = "0x4D12C60", VA = "0x184D14260")]
	public static JNDLBBMPEGP IHEMFNLEEFI()
	{
		return default(JNDLBBMPEGP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4D13FF0", Offset = "0x4D129F0", VA = "0x184D13FF0")]
	public (int, int, Task) FIDFDMNAOMJ(int MFEJPJDDMMA)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4D13F40", Offset = "0x4D12940", VA = "0x184D13F40")]
	public void AGNPANHEADC(int MFEJPJDDMMA, int CEIPHPMCIKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class JILGKPBMAJO<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly Dictionary<TKey, TVal> KLPHHKKKNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Dictionary<TVal, TKey> CBEBJAGALGB;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int HEBEBONJJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x25A0F10", Offset = "0x259F910", VA = "0x1825A0F10", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool GLELDCPAEJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x577B90", Offset = "0x576590", VA = "0x180577B90", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public ICollection<TKey> FIMGPPJIOLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x28CBE80", Offset = "0x28CA880", VA = "0x1828CBE80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TVal> NAJHJDNPGBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x29D69A0", Offset = "0x29D53A0", VA = "0x1829D69A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public TVal INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x29D6970", Offset = "0x29D5370", VA = "0x1829D6970", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x29D69D0", Offset = "0x29D53D0", VA = "0x1829D69D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TKey INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x29D6330", Offset = "0x29D4D30", VA = "0x1829D6330")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x29D65B0", Offset = "0x29D4FB0", VA = "0x1829D65B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x29D6040", Offset = "0x29D4A40", VA = "0x1829D6040", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x29D6810", Offset = "0x29D5210", VA = "0x1829D6810", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x29CBAD0", Offset = "0x29CA4D0", VA = "0x1829CBAD0", Slot = "9")]
	public void Add(TKey IPKOPOLJGIA, TVal HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x29D5EF0", Offset = "0x29D48F0", VA = "0x1829D5EF0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> LHLOAJPGJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x25D0A90", Offset = "0x25CF490", VA = "0x1825D0A90", Slot = "8")]
	public bool ContainsKey(TKey IPKOPOLJGIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x29D60A0", Offset = "0x29D4AA0", VA = "0x1829D60A0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> LHLOAJPGJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x29D6760", Offset = "0x29D5160", VA = "0x1829D6760", Slot = "10")]
	public bool Remove(TKey IPKOPOLJGIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x29D6760", Offset = "0x29D5160", VA = "0x1829D6760", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> LHLOAJPGJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x29D6860", Offset = "0x29D5260", VA = "0x1829D6860", Slot = "11")]
	public bool TryGetValue(TKey IPKOPOLJGIA, out TVal HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x29D6360", Offset = "0x29D4D60", VA = "0x1829D6360", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x29D6100", Offset = "0x29D4B00", VA = "0x1829D6100", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] OBKDNKHGCJN, int MPFHIKENPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x29D5F50", Offset = "0x29D4950", VA = "0x1829D5F50")]
	public void CEGAKGBDODP(TVal LFNNMJBIDMK, TKey IPKOPOLJGIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x29D6000", Offset = "0x29D4A00", VA = "0x1829D6000")]
	public void CEGAKGBDODP(KeyValuePair<TVal, TKey> LHLOAJPGJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x29D61C0", Offset = "0x29D4BC0", VA = "0x1829D61C0")]
	public bool DHHOKDEFFJG(TVal IPKOPOLJGIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x29D6700", Offset = "0x29D5100", VA = "0x1829D6700")]
	public bool PNJHNNLCLCE(KeyValuePair<TVal, TKey> LHLOAJPGJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x29D6160", Offset = "0x29D4B60", VA = "0x1829D6160")]
	public bool DFDJPGANONL(TVal IPKOPOLJGIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x29D6160", Offset = "0x29D4B60", VA = "0x1829D6160")]
	public bool DFDJPGANONL(KeyValuePair<TVal, TKey> LHLOAJPGJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x29D6300", Offset = "0x29D4D00", VA = "0x1829D6300")]
	public bool FIJKPMMFIIC(TVal IPKOPOLJGIA, out TKey HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x29D6680", Offset = "0x29D5080", VA = "0x1829D6680")]
	public IEnumerator<KeyValuePair<TVal, TKey>> PHLDJJFJBPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x29D6460", Offset = "0x29D4E60", VA = "0x1829D6460")]
	private void KGHLNDLOLKI(TKey IPKOPOLJGIA, TVal LFNNMJBIDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x29D61F0", Offset = "0x29D4BF0", VA = "0x1829D61F0")]
	private void EFNMKJJJOOF(TKey IPKOPOLJGIA, TVal LFNNMJBIDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x29D5D70", Offset = "0x29D4770", VA = "0x1829D5D70")]
	private bool AHJGLOGLDGK(TKey IPKOPOLJGIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x29D5CB0", Offset = "0x29D46B0", VA = "0x1829D5CB0")]
	private bool AHJGLOGLDGK(TVal LFNNMJBIDMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x29D6890", Offset = "0x29D5290", VA = "0x1829D6890")]
	public JILGKPBMAJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DefaultMember("Item")]
public class NJCCFCAFAEN<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private global::NJCCFCAFAEN<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x705150", Offset = "0x703B50", VA = "0x180705150", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x3E17AE0", Offset = "0x3E164E0", VA = "0x183E17AE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3E17D40", Offset = "0x3E16740", VA = "0x183E17D40")]
		public Enumerator(global::NJCCFCAFAEN<T> HKIDJJNOKDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3E175C0", Offset = "0x3E15FC0", VA = "0x183E175C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3E17740", Offset = "0x3E16140", VA = "0x183E17740", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3E17090", Offset = "0x3E15A90", VA = "0x183E17090")]
		private void JLLKHMLEHLM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private T[] OEKOKLAIABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int KLJIMEJKFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private int LAPEEJFJAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int NAGACMCOIBH;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int HEBEBONJJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3E25A20", Offset = "0x3E24420", VA = "0x183E25A20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public T INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3E24AC0", Offset = "0x3E234C0", VA = "0x183E24AC0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3E25980", Offset = "0x3E24380", VA = "0x183E25980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3E25E70", Offset = "0x3E24870", VA = "0x183E25E70")]
	public NJCCFCAFAEN(int POIIDIEGIKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3E243C0", Offset = "0x3E22DC0", VA = "0x183E243C0")]
	public void CEGAKGBDODP(T LIKLFJCOLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3E24BF0", Offset = "0x3E235F0", VA = "0x183E24BF0")]
	public void KFNDGCHILFO(IEnumerable<T> EDBHCCMMIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3E25A00", Offset = "0x3E24400", VA = "0x183E25A00")]
	public void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3E23DF0", Offset = "0x3E227F0", VA = "0x183E23DF0")]
	public void BACKBAAEHPM(int LKEJFKMJCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3E25BC0", Offset = "0x3E245C0", VA = "0x183E25BC0")]
	public void OOECKNIPCPL(int LKEJFKMJCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3E24680", Offset = "0x3E23080", VA = "0x183E24680")]
	public void GHNEPOMHABF(T[] OBKDNKHGCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3E25B50", Offset = "0x3E24550", VA = "0x183E25B50")]
	public Enumerator OIGPEBHIBKC()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3E25DD0", Offset = "0x3E247D0", VA = "0x183E25DD0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3E25DD0", Offset = "0x3E247D0", VA = "0x183E25DD0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3E23F70", Offset = "0x3E22970", VA = "0x183E23F70")]
	private int BCDGLMHPBGM(int LGBFGOJBLFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3E25C50", Offset = "0x3E24650", VA = "0x183E25C50")]
	private int PCEKCHLLGDG(int LGBFGOJBLFK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct JMJLIJNCAMJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly IDisposable[] CJNEAIJOKBO;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x75BBA0", Offset = "0x75A5A0", VA = "0x18075BBA0")]
	public JMJLIJNCAMJ(params IDisposable[] HCJBDDKLCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1371AF0", Offset = "0x13704F0", VA = "0x181371AF0")]
	public static JMJLIJNCAMJ IHEMFNLEEFI(params IDisposable[] HCJBDDKLCHE)
	{
		return default(JMJLIJNCAMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4D13E20", Offset = "0x4D12820", VA = "0x184D13E20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct BMNIGFIILMA<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly IDisposable AKDBJOGFAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public T CKLNJLLILCL;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x28E4F20", Offset = "0x28E3920", VA = "0x1828E4F20")]
	public BMNIGFIILMA(IDisposable DADDDHJHLLC, in T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x261F4A0", Offset = "0x261DEA0", VA = "0x18261F4A0")]
	public static global::BMNIGFIILMA<U> AIEILCDBPIK<U>(in global::BMNIGFIILMA<T> DADDDHJHLLC, in U HPIAFNBPEPC)
	{
		return default(global::BMNIGFIILMA<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x22B43A0", Offset = "0x22B2DA0", VA = "0x1822B43A0")]
	public global::BMNIGFIILMA<U> HMKLBEBOLAK<U>(in U HPIAFNBPEPC)
	{
		return default(global::BMNIGFIILMA<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x261F4E0", Offset = "0x261DEE0", VA = "0x18261F4E0")]
	public static global::BMNIGFIILMA<(T, U)> PBNCMBAAHCI<U>(in global::BMNIGFIILMA<T> MMADIBJKHHM, in global::BMNIGFIILMA<U> ODMIEFIFOGP)
	{
		return default(global::BMNIGFIILMA<(T, U)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x28E4D90", Offset = "0x28E3790", VA = "0x1828E4D90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class KFKNLDALKIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2628830", Offset = "0x2627230", VA = "0x182628830")]
	public static global::BMNIGFIILMA<T> IHEMFNLEEFI<T>(IDisposable DADDDHJHLLC, in T HPIAFNBPEPC)
	{
		return default(global::BMNIGFIILMA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x22B43A0", Offset = "0x22B2DA0", VA = "0x1822B43A0")]
	public static global::BMNIGFIILMA<U> AIEILCDBPIK<U, T>(in global::BMNIGFIILMA<T> IDFCIBCAHOM, in U HPIAFNBPEPC)
	{
		return default(global::BMNIGFIILMA<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2628880", Offset = "0x2627280", VA = "0x182628880")]
	public static global::BMNIGFIILMA<(T, U)> PBNCMBAAHCI<T, U>(in global::BMNIGFIILMA<T> MMADIBJKHHM, in global::BMNIGFIILMA<U> ODMIEFIFOGP)
	{
		return default(global::BMNIGFIILMA<(T, U)>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct MNJOJABCHIF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x577B90", Offset = "0x576590", VA = "0x180577B90")]
	public static MNJOJABCHIF LOLOAKHPFFF<T>([Optional] string AJECLBDJOME, [Optional] string HPPKBEOKBOH, bool NKHEFGHCICL = false)
	{
		return default(MNJOJABCHIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DefaultMember("Item")]
public class LLPDFMMJLIL<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<Internal, External> EBJJNPLJGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Func<External, Internal> OHOJALAJBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private IList<Internal> NIHCHNNEJAD;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public IList<Internal> PGIOLLNBJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5534B0", Offset = "0x551EB0", VA = "0x1805534B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x556540", Offset = "0x554F40", VA = "0x180556540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool GLELDCPAEJH
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x649680", Offset = "0x648080", VA = "0x180649680", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x834870", Offset = "0x833270", VA = "0x180834870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public External INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2D21CA0", Offset = "0x2D206A0", VA = "0x182D21CA0", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2D21D40", Offset = "0x2D20740", VA = "0x182D21D40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int HEBEBONJJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2D21C40", Offset = "0x2D20640", VA = "0x182D21C40", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2D21BB0", Offset = "0x2D205B0", VA = "0x182D21BB0")]
	public LLPDFMMJLIL(Func<Internal, External> EBJJNPLJGHL, Func<External, Internal> OHOJALAJBFP, bool PBLMIOJCCCI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2D218C0", Offset = "0x2D202C0", VA = "0x182D218C0", Slot = "6")]
	public int IndexOf(External LHLOAJPGJBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2D21540", Offset = "0x2D1FF40", VA = "0x182D21540", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2D215A0", Offset = "0x2D1FFA0", VA = "0x182D215A0", Slot = "13")]
	public bool Contains(External LHLOAJPGJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2D21630", Offset = "0x2D20030", VA = "0x182D21630", Slot = "14")]
	public void CopyTo(External[] OBKDNKHGCJN, int MPFHIKENPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x2D21450", Offset = "0x2D1FE50", VA = "0x182D21450", Slot = "11")]
	public void Add(External LHLOAJPGJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2D219B0", Offset = "0x2D203B0", VA = "0x182D219B0", Slot = "7")]
	public void Insert(int LGBFGOJBLFK, External LHLOAJPGJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2D21B20", Offset = "0x2D20520", VA = "0x182D21B20", Slot = "15")]
	public bool Remove(External LHLOAJPGJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2D21A50", Offset = "0x2D20450", VA = "0x182D21A50", Slot = "8")]
	public void RemoveAt(int LGBFGOJBLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2D21850", Offset = "0x2D20250", VA = "0x182D21850", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2196290", Offset = "0x2194C90", VA = "0x182196290", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public class BFGCFOAHEJP<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly Func<Internal, External> EBJJNPLJGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IReadOnlyList<Internal> NIHCHNNEJAD;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IReadOnlyList<Internal> PGIOLLNBJLM
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x556460", Offset = "0x554E60", VA = "0x180556460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool GLELDCPAEJH
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x577CA0", Offset = "0x5766A0", VA = "0x180577CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public External INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x28DEBC0", Offset = "0x28DD5C0", VA = "0x1828DEBC0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int HEBEBONJJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x28DEB60", Offset = "0x28DD560", VA = "0x1828DEB60", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1202180", Offset = "0x1200B80", VA = "0x181202180")]
	public BFGCFOAHEJP(Func<Internal, External> EBJJNPLJGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x28DEB10", Offset = "0x28DD510", VA = "0x1828DEB10")]
	public BFGCFOAHEJP(IReadOnlyList<Internal> NIHCHNNEJAD, Func<Internal, External> EBJJNPLJGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x28DE820", Offset = "0x28DD220", VA = "0x1828DE820")]
	public void GHNEPOMHABF(External[] OBKDNKHGCJN, int MPFHIKENPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x28DEA40", Offset = "0x28DD440", VA = "0x1828DEA40", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x219DD50", Offset = "0x219C750", VA = "0x18219DD50", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class GIMABIOHNJM<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private IReadOnlyList<Internal> NIHCHNNEJAD;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IReadOnlyList<Internal> PGIOLLNBJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x551E80", VA = "0x180553480")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x577180", Offset = "0x575B80", VA = "0x180577180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool GLELDCPAEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x577CA0", Offset = "0x5766A0", VA = "0x180577CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public External INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x333E120", Offset = "0x333CB20", VA = "0x18333E120", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int HEBEBONJJIP
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x333E0C0", Offset = "0x333CAC0", VA = "0x18333E0C0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x1202180", Offset = "0x1200B80", VA = "0x181202180")]
	public GIMABIOHNJM(IReadOnlyList<Internal> NIHCHNNEJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x333E020", Offset = "0x333CA20", VA = "0x18333E020")]
	public bool PNJHNNLCLCE(External LHLOAJPGJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x333DD80", Offset = "0x333C780", VA = "0x18333DD80")]
	public void GHNEPOMHABF(External[] OBKDNKHGCJN, int MPFHIKENPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x333DFB0", Offset = "0x333C9B0", VA = "0x18333DFB0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2196290", Offset = "0x2194C90", VA = "0x182196290", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public abstract class OAGHJEALHBP
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void AFPAFNCPPJC(object[] MDAKEHNEFOP);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	protected OAGHJEALHBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public abstract class FOPPJNMOPMA<T> : OAGHJEALHBP
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	protected struct NGBFPLCLLCD
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public enum HENIEDLGEPJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public HENIEDLGEPJ IEADHAAGEDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public T APBFEHIGAIL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private int GOLHMLPFEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly bool AMILABFIICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected readonly bool ANANKCHONON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	protected List<T> EGBAHAAMKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private List<NGBFPLCLLCD> EBBBPJHKBFI;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool AOCNFPCEACC
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x3337630", Offset = "0x3336030", VA = "0x183337630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3337670", Offset = "0x3336070", VA = "0x183337670")]
	protected FOPPJNMOPMA(bool ANANKCHONON, bool AMILABFIICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3337070", Offset = "0x3335A70", VA = "0x183337070")]
	protected bool DCKMIAAAKEH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3337420", Offset = "0x3335E20", VA = "0x183337420")]
	protected void HCLLKBIFEHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3337270", Offset = "0x3335C70", VA = "0x183337270")]
	protected void DKPJDNFMGOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x33958C0", Offset = "0x33942C0", VA = "0x1833958C0")]
	private static void IANCMNNBLOG<U>(ref List<U> NIHCHNNEJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3336EF0", Offset = "0x33358F0", VA = "0x183336EF0", Slot = "5")]
	public void CEGAKGBDODP(T APBFEHIGAIL, bool LGNKOGCKIDP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3337110", Offset = "0x3335B10", VA = "0x183337110", Slot = "6")]
	public void DFDJPGANONL(T APBFEHIGAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3337500", Offset = "0x3335F00", VA = "0x183337500")]
	public void KOBBDDIILEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface MMEFPGHPAAE
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEGAKGBDODP(Action APBFEHIGAIL, bool LGNKOGCKIDP = false);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFDJPGANONL(Action APBFEHIGAIL);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class HDFEEIPOLMP : global::FOPPJNMOPMA<Action>, MMEFPGHPAAE
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x4D13BE0", Offset = "0x4D125E0", VA = "0x184D13BE0")]
	public HDFEEIPOLMP(bool ANANKCHONON = false, bool AMILABFIICD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x4D13960", Offset = "0x4D12360", VA = "0x184D13960")]
	public void DAJKIBHPPOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x4D138E0", Offset = "0x4D122E0", VA = "0x184D138E0", Slot = "4")]
	public override void AFPAFNCPPJC(object[] MDAKEHNEFOP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x4D13B20", Offset = "0x4D12520", VA = "0x184D13B20")]
	public static HDFEEIPOLMP EKHKEPKDEBI(HDFEEIPOLMP LLHFMAEOJED, Action APBFEHIGAIL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x4D13B80", Offset = "0x4D12580", VA = "0x184D13B80")]
	public static HDFEEIPOLMP LOLOPLNMBHA(HDFEEIPOLMP LLHFMAEOJED, Action APBFEHIGAIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface EEPIKJDCGCN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEGAKGBDODP(Action<T> APBFEHIGAIL, bool LGNKOGCKIDP = false);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFDJPGANONL(Action<T> APBFEHIGAIL);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class EFMFOCNIOPF<T> : global::FOPPJNMOPMA<Action<T>>, global::EEPIKJDCGCN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x28E7910", Offset = "0x28E6310", VA = "0x1828E7910")]
	public EFMFOCNIOPF(bool ANANKCHONON = false, bool AMILABFIICD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x37DC5D0", Offset = "0x37DAFD0", VA = "0x1837DC5D0")]
	public void DAJKIBHPPOA(T LIKLFJCOLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x37DAFB0", Offset = "0x37D99B0", VA = "0x1837DAFB0", Slot = "4")]
	public override void AFPAFNCPPJC(object[] MDAKEHNEFOP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x37DF270", Offset = "0x37DDC70", VA = "0x1837DF270")]
	public static global::EFMFOCNIOPF<T> EKHKEPKDEBI(global::EFMFOCNIOPF<T> LLHFMAEOJED, Action<T> APBFEHIGAIL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x37DF310", Offset = "0x37DDD10", VA = "0x1837DF310")]
	public static global::EFMFOCNIOPF<T> LOLOPLNMBHA(global::EFMFOCNIOPF<T> LLHFMAEOJED, Action<T> APBFEHIGAIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface BAGPEALCKJE<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEGAKGBDODP(Action<T, U> APBFEHIGAIL, bool LGNKOGCKIDP = false);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFDJPGANONL(Action<T, U> APBFEHIGAIL);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class CJGBOLGJMCH<T, U> : global::FOPPJNMOPMA<Action<T, U>>, global::BAGPEALCKJE<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x28E7910", Offset = "0x28E6310", VA = "0x1828E7910")]
	public CJGBOLGJMCH(bool ANANKCHONON = false, bool AMILABFIICD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3464E10", Offset = "0x3463810", VA = "0x183464E10")]
	public void DAJKIBHPPOA(T LIKLFJCOLDP, U MCMCJFLBICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x34624A0", Offset = "0x3460EA0", VA = "0x1834624A0", Slot = "4")]
	public override void AFPAFNCPPJC(object[] MDAKEHNEFOP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3467430", Offset = "0x3465E30", VA = "0x183467430")]
	public static global::CJGBOLGJMCH<T, U> EKHKEPKDEBI(global::CJGBOLGJMCH<T, U> LLHFMAEOJED, Action<T, U> APBFEHIGAIL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x34674D0", Offset = "0x3465ED0", VA = "0x1834674D0")]
	public static global::CJGBOLGJMCH<T, U> LOLOPLNMBHA(global::CJGBOLGJMCH<T, U> LLHFMAEOJED, Action<T, U> APBFEHIGAIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface APDHOFAMAJN<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEGAKGBDODP(Action<T, U, V> APBFEHIGAIL, bool LGNKOGCKIDP = false);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFDJPGANONL(Action<T, U, V> APBFEHIGAIL);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class EDJDGMIOKFD<T, U, V> : global::FOPPJNMOPMA<Action<T, U, V>>, global::APDHOFAMAJN<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x28E7910", Offset = "0x28E6310", VA = "0x1828E7910")]
	public EDJDGMIOKFD(bool ANANKCHONON = false, bool AMILABFIICD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x36C4690", Offset = "0x36C3090", VA = "0x1836C4690")]
	public void DAJKIBHPPOA(T LIKLFJCOLDP, U MCMCJFLBICH, V MEFNHMKKCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x36C2530", Offset = "0x36C0F30", VA = "0x1836C2530", Slot = "4")]
	public override void AFPAFNCPPJC(object[] MDAKEHNEFOP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x36C5360", Offset = "0x36C3D60", VA = "0x1836C5360")]
	public static global::EDJDGMIOKFD<T, U, V> EKHKEPKDEBI(global::EDJDGMIOKFD<T, U, V> LLHFMAEOJED, Action<T, U, V> APBFEHIGAIL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x36C5400", Offset = "0x36C3E00", VA = "0x1836C5400")]
	public static global::EDJDGMIOKFD<T, U, V> LOLOPLNMBHA(global::EDJDGMIOKFD<T, U, V> LLHFMAEOJED, Action<T, U, V> APBFEHIGAIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface KMCEOBKPJEJ<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEGAKGBDODP(Action<T, U, V, W> APBFEHIGAIL, bool LGNKOGCKIDP = false);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFDJPGANONL(Action<T, U, V, W> APBFEHIGAIL);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class MPOGAFMLBCJ<T, U, V, W> : global::FOPPJNMOPMA<Action<T, U, V, W>>, global::KMCEOBKPJEJ<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x28E7910", Offset = "0x28E6310", VA = "0x1828E7910")]
	public MPOGAFMLBCJ(bool ANANKCHONON = false, bool AMILABFIICD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x3ECC960", Offset = "0x3ECB360", VA = "0x183ECC960")]
	public void DAJKIBHPPOA(T LIKLFJCOLDP, U MCMCJFLBICH, V MEFNHMKKCJN, W DECECNMMIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x3ECAC60", Offset = "0x3EC9660", VA = "0x183ECAC60", Slot = "4")]
	public override void AFPAFNCPPJC(object[] MDAKEHNEFOP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3ECCE90", Offset = "0x3ECB890", VA = "0x183ECCE90")]
	public static global::MPOGAFMLBCJ<T, U, V, W> EKHKEPKDEBI(global::MPOGAFMLBCJ<T, U, V, W> LLHFMAEOJED, Action<T, U, V, W> APBFEHIGAIL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3ECCF30", Offset = "0x3ECB930", VA = "0x183ECCF30")]
	public static global::MPOGAFMLBCJ<T, U, V, W> LOLOPLNMBHA(global::MPOGAFMLBCJ<T, U, V, W> LLHFMAEOJED, Action<T, U, V, W> APBFEHIGAIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface LKGLMFHDMBB<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEGAKGBDODP(Action<T, U, V, W, X> APBFEHIGAIL, bool LGNKOGCKIDP = false);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFDJPGANONL(Action<T, U, V, W, X> APBFEHIGAIL);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class FNENIKKGMKH<T, U, V, W, X> : global::FOPPJNMOPMA<Action<T, U, V, W, X>>, global::LKGLMFHDMBB<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x28E7910", Offset = "0x28E6310", VA = "0x1828E7910")]
	public FNENIKKGMKH(bool ANANKCHONON = false, bool AMILABFIICD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x36DD9D0", Offset = "0x36DC3D0", VA = "0x1836DD9D0")]
	public void DAJKIBHPPOA(T LIKLFJCOLDP, U MCMCJFLBICH, V MEFNHMKKCJN, W DECECNMMIBM, X EDIMMNEBDAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x36DD3C0", Offset = "0x36DBDC0", VA = "0x1836DD3C0", Slot = "4")]
	public override void AFPAFNCPPJC(object[] MDAKEHNEFOP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x36DDF80", Offset = "0x36DC980", VA = "0x1836DDF80")]
	public static global::FNENIKKGMKH<T, U, V, W, X> EKHKEPKDEBI(global::FNENIKKGMKH<T, U, V, W, X> LLHFMAEOJED, Action<T, U, V, W, X> APBFEHIGAIL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x36DE020", Offset = "0x36DCA20", VA = "0x1836DE020")]
	public static global::FNENIKKGMKH<T, U, V, W, X> LOLOPLNMBHA(global::FNENIKKGMKH<T, U, V, W, X> LLHFMAEOJED, Action<T, U, V, W, X> APBFEHIGAIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface BPHECDOJFPE<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEGAKGBDODP(Action<T, U, V, W, X, Y> APBFEHIGAIL, bool LGNKOGCKIDP = false);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFDJPGANONL(Action<T, U, V, W, X, Y> APBFEHIGAIL);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class KLMHJBGLJFM<T, U, V, W, X, Y> : global::FOPPJNMOPMA<Action<T, U, V, W, X, Y>>, global::BPHECDOJFPE<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x28E7910", Offset = "0x28E6310", VA = "0x1828E7910")]
	public KLMHJBGLJFM(bool ANANKCHONON = false, bool AMILABFIICD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3DCEC10", Offset = "0x3DCD610", VA = "0x183DCEC10")]
	public void DAJKIBHPPOA(T LIKLFJCOLDP, U MCMCJFLBICH, V MEFNHMKKCJN, W DECECNMMIBM, X EDIMMNEBDAA, Y MLMOIBACOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x3DCDC40", Offset = "0x3DCC640", VA = "0x183DCDC40", Slot = "4")]
	public override void AFPAFNCPPJC(object[] MDAKEHNEFOP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x3DCEED0", Offset = "0x3DCD8D0", VA = "0x183DCEED0")]
	public static global::KLMHJBGLJFM<T, U, V, W, X, Y> EKHKEPKDEBI(global::KLMHJBGLJFM<T, U, V, W, X, Y> LLHFMAEOJED, Action<T, U, V, W, X, Y> APBFEHIGAIL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x3DCEF70", Offset = "0x3DCD970", VA = "0x183DCEF70")]
	public static global::KLMHJBGLJFM<T, U, V, W, X, Y> LOLOPLNMBHA(global::KLMHJBGLJFM<T, U, V, W, X, Y> LLHFMAEOJED, Action<T, U, V, W, X, Y> APBFEHIGAIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public sealed class BMFIIMFMLBD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public readonly struct HJGNGLJGBNL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly global::BMFIIMFMLBD<T> MDPHHLLBPNL;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public T CKLNJLLILCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x28EBB40", Offset = "0x28EA540", VA = "0x1828EBB40")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x28EBB10", Offset = "0x28EA510", VA = "0x1828EBB10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x75BBA0", Offset = "0x75A5A0", VA = "0x18075BBA0")]
		public HJGNGLJGBNL(global::BMFIIMFMLBD<T> MDPHHLLBPNL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct BFBOLLBICHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder<HJGNGLJGBNL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public global::BMFIIMFMLBD<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x28DE600", Offset = "0x28DD000", VA = "0x1828DE600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x28DE7D0", Offset = "0x28DD1D0", VA = "0x1828DE7D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct MBEOPKINLKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder<HJGNGLJGBNL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public global::BMFIIMFMLBD<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x28EBFC0", Offset = "0x28EA9C0", VA = "0x1828EBFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x28DE7D0", Offset = "0x28DD1D0", VA = "0x1828DE7D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly SemaphoreSlim LDANPPGPHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private T HFHPPKKIGDG;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int DDGAHPACBGA
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x28E4430", Offset = "0x28E2E30", VA = "0x1828E4430")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x28E4B30", Offset = "0x28E3530", VA = "0x1828E4B30")]
	public BMFIIMFMLBD(in T HFHPPKKIGDG, int FNGIIPOFJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x28E4BD0", Offset = "0x28E35D0", VA = "0x1828E4BD0")]
	public BMFIIMFMLBD(in T HFHPPKKIGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x28E4A50", Offset = "0x28E3450", VA = "0x1828E4A50")]
	public HJGNGLJGBNL LIKAINBBJEA()
	{
		return default(HJGNGLJGBNL);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x28E4A10", Offset = "0x28E3410", VA = "0x1828E4A10")]
	public HJGNGLJGBNL LIKAINBBJEA(CancellationToken PKFOPLIPJOL)
	{
		return default(HJGNGLJGBNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x28E45D0", Offset = "0x28E2FD0", VA = "0x1828E45D0")]
	[AsyncStateMachine(typeof(global::BMFIIMFMLBD<>.BFBOLLBICHB))]
	public Task<HJGNGLJGBNL> KFOPKMNGNFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x28E4450", Offset = "0x28E2E50", VA = "0x1828E4450")]
	[AsyncStateMachine(typeof(global::BMFIIMFMLBD<>.MBEOPKINLKA))]
	public Task<HJGNGLJGBNL> KFOPKMNGNFO(CancellationToken PKFOPLIPJOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class NFDADLDEDBL
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x4D153B0", Offset = "0x4D13DB0", VA = "0x184D153B0")]
	public static global::BMFIIMFMLBD<ADCKJAHNEMI> IHEMFNLEEFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x4D15410", Offset = "0x4D13E10", VA = "0x184D15410")]
	public static global::BMFIIMFMLBD<ADCKJAHNEMI> IHEMFNLEEFI(int FNGIIPOFJMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x20CEAD0", Offset = "0x20CD4D0", VA = "0x1820CEAD0")]
	public static global::BMFIIMFMLBD<T> IHEMFNLEEFI<T>(in T HFHPPKKIGDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x24048A0", Offset = "0x24032A0", VA = "0x1824048A0")]
	public static global::BMFIIMFMLBD<T> IHEMFNLEEFI<T>(in T HFHPPKKIGDG, int FNGIIPOFJMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class FKMDDFOMGEN<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public delegate bool FONNDHCCJGC(global::FKMDDFOMGEN<T> DAMODCEKDNG);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class JOEEJKDNOCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public global::FKMDDFOMGEN<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x218A560", Offset = "0x2188F60", VA = "0x18218A560")]
		public JOEEJKDNOCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x36E64A0", Offset = "0x36E4EA0", VA = "0x1836E64A0")]
		internal bool <FindNode>b__0(global::FKMDDFOMGEN<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public T AGKFJNOJGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public LinkedList<global::FKMDDFOMGEN<T>> OHMPKMLMHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public global::FKMDDFOMGEN<T> NLPIICDKEMF;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public global::FKMDDFOMGEN<T> OOLIINHPLCC
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5F2180", Offset = "0x5F0B80", VA = "0x1805F2180")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x36DD190", Offset = "0x36DBB90", VA = "0x1836DD190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool HPJALCGKKNC
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x36DC580", Offset = "0x36DAF80", VA = "0x1836DC580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool LGMHDKHGJJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x36DC1A0", Offset = "0x36DABA0", VA = "0x1836DC1A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public global::FKMDDFOMGEN<T> OOHCCBDKGIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x36DC500", Offset = "0x36DAF00", VA = "0x1836DC500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x36DD270", Offset = "0x36DBC70", VA = "0x1836DD270")]
	public FKMDDFOMGEN(T COOFMNDPHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x36DCF90", Offset = "0x36DB990", VA = "0x1836DCF90")]
	public global::FKMDDFOMGEN<T> OJNFEAIHKBO(T PFBOKDIKPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x36DBDD0", Offset = "0x36DA7D0", VA = "0x1836DBDD0")]
	public global::FKMDDFOMGEN<T> BFPHDILCMGH(T NPCOJEPOIJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x36DC1E0", Offset = "0x36DABE0", VA = "0x1836DC1E0")]
	public global::FKMDDFOMGEN<T> DFDJPGANONL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x36DC5B0", Offset = "0x36DAFB0", VA = "0x1836DC5B0")]
	public void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x36DC3F0", Offset = "0x36DADF0", VA = "0x1836DC3F0")]
	public global::FKMDDFOMGEN<T> FAMNLOCJADO(T IPLMPKBGGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x36DBA90", Offset = "0x36DA490", VA = "0x1836DBA90")]
	public static void BBLKKMBKNOG(global::FKMDDFOMGEN<T> KOPEBHECHDF, FONNDHCCJGC BIENEBJDHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x33954A0", Offset = "0x3393EA0", VA = "0x1833954A0")]
	public static void BBLKKMBKNOG<A>(global::FKMDDFOMGEN<T> KOPEBHECHDF, Func<global::FKMDDFOMGEN<T>, A, bool> BIENEBJDHDJ, A MANGGNPAMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x36DACC0", Offset = "0x36D96C0", VA = "0x1836DACC0")]
	public static string ALBLECODCEA(global::FKMDDFOMGEN<T> KOPEBHECHDF, int FBHGCDEDLKH = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x36DCC80", Offset = "0x36DB680", VA = "0x1836DCC80")]
	public static global::FKMDDFOMGEN<T> LPIBNCMAENB(global::FKMDDFOMGEN<T> KOPEBHECHDF, T CNHNGKDBGCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class JAAJCBFBODG<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public delegate Task<TResult> GNIIPNECIDE(TRequest LKGBFLLCPJC, CancellationToken PKFOPLIPJOL);

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public enum DJIIHAHOPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class MALAAOOGFMO
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private const float PGCOKMDKPDE = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TimeSpan OBFCOLELJMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int NDIJAAEPJNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public DJIIHAHOPGJ BNILFIMBNJH;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly MALAAOOGFMO GMBIDLIPEPB;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float KDFDCHGCFIL
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x393CC60", Offset = "0x393B660", VA = "0x18393CC60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public TimeSpan HDGHKJKBEGE
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x551E80", VA = "0x180553480")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x393CD40", Offset = "0x393B740", VA = "0x18393CD40")]
		public MALAAOOGFMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private readonly struct FLAJFNJAMOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public readonly TRequest LKGBFLLCPJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public readonly CancellationToken PKFOPLIPJOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public readonly TaskCompletionSource<TResult> NDMLPENIOHC;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x392DFE0", Offset = "0x392C9E0", VA = "0x18392DFE0")]
		public FLAJFNJAMOH(TRequest LKGBFLLCPJC, TaskCompletionSource<TResult> NDMLPENIOHC, CancellationToken PKFOPLIPJOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class CACPFEPPHIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x218A560", Offset = "0x2188F60", VA = "0x18218A560")]
		public CACPFEPPHIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x25A0F10", Offset = "0x259F910", VA = "0x1825A0F10")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct DCLIEAFOAKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public global::JAAJCBFBODG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x392D3D0", Offset = "0x392BDD0", VA = "0x18392D3D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x834B50", Offset = "0x833550", VA = "0x180834B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class KHJOPGKGDMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public FLAJFNJAMOH req;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public global::JAAJCBFBODG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x218A560", Offset = "0x2188F60", VA = "0x18218A560")]
		public KHJOPGKGDMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x393C810", Offset = "0x393B210", VA = "0x18393C810")]
		internal void <ProcessQueue>b__0(Task<TResult> task)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly CancellationTokenSource JLIFOCMCFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly List<FLAJFNJAMOH> FDAPDKAHHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly MALAAOOGFMO AANBJHIBLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly GNIIPNECIDE KBAPMLFKIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Task DKOPKHNEICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int DJAEGBGILHI;

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x393C4E0", Offset = "0x393AEE0", VA = "0x18393C4E0")]
	public JAAJCBFBODG(GNIIPNECIDE KBAPMLFKIFM, [Optional] MALAAOOGFMO AANBJHIBLKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x393AAB0", Offset = "0x39394B0", VA = "0x18393AAB0")]
	public Task<TResult> EOFLNMMKGAL(TRequest LKGBFLLCPJC, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x393C0F0", Offset = "0x393AAF0", VA = "0x18393C0F0")]
	private void PNGEEEOCHEJ(FLAJFNJAMOH CHMGJPIIMAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x393B6C0", Offset = "0x393A0C0", VA = "0x18393B6C0")]
	[AsyncStateMachine(typeof(global::JAAJCBFBODG<, >.DCLIEAFOAKB))]
	private Task OKILANIGHJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x393B1D0", Offset = "0x3939BD0", VA = "0x18393B1D0")]
	private FLAJFNJAMOH IEDOEIGPOID()
	{
		return default(FLAJFNJAMOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x393B9F0", Offset = "0x393A3F0", VA = "0x18393B9F0")]
	private void PFJBOLDEICN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x393A820", Offset = "0x3939220", VA = "0x18393A820", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class CNMLKNGBCKF<TKey, TVal> : global::EHOMHFNHPNI<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int DMNEKGGEFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	internal Dictionary<TKey, (TVal value, int size)> EJPHIKLHEPO;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	internal override int NNOCMNOEDFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x2DADDC0", Offset = "0x2DAC7C0", VA = "0x182DADDC0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	internal int BMCHNAGKFCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x2DADDF0", Offset = "0x2DAC7F0", VA = "0x182DADDF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public override int HEBEBONJJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x2DADFB0", Offset = "0x2DAC9B0", VA = "0x182DADFB0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE010", Offset = "0x2DACA10", VA = "0x182DAE010")]
	public CNMLKNGBCKF(int POIIDIEGIKN, [Optional] ONEALEOBFDM HLOIHOCJLCG, [Optional] IEqualityComparer<TKey> ANAKMAIDCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x2DADE90", Offset = "0x2DAC890", VA = "0x182DADE90")]
	public void NBJMDEHHCON(TKey IPKOPOLJGIA, TVal HPIAFNBPEPC, bool HPDLFBACPAH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x2DADF30", Offset = "0x2DAC930", VA = "0x182DADF30")]
	public bool NOCAHOFDGBI(TKey IPKOPOLJGIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x2DAD9D0", Offset = "0x2DAC3D0", VA = "0x182DAD9D0", Slot = "6")]
	public override bool FIJKPMMFIIC(TKey OAOOMIMNANF, out TVal HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x2DADB90", Offset = "0x2DAC590", VA = "0x182DADB90")]
	public bool JHGGAHLGFEA(TKey IPKOPOLJGIA, TVal HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x2DADA80", Offset = "0x2DAC480", VA = "0x182DADA80")]
	public bool HBMOJKIDMHB(TKey IPKOPOLJGIA, TVal HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x2DADE20", Offset = "0x2DAC820", VA = "0x182DADE20", Slot = "7")]
	public override void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x2DAD930", Offset = "0x2DAC330", VA = "0x182DAD930")]
	private bool CMAICGFNKAP(TKey IPKOPOLJGIA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[DefaultMember("Item")]
public class EHOMHFNHPNI<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public delegate int ONEALEOBFDM(TKey IPKOPOLJGIA, TVal HPIAFNBPEPC);

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class BEJOFLDGHMN
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public TKey OBDCJIABNIN
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x551E80", VA = "0x180553480")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public TVal CKLNJLLILCL
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x789B40", Offset = "0x788540", VA = "0x180789B40")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x834490", Offset = "0x832E90", VA = "0x180834490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public int PFFOPFIKBNG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x60F490", Offset = "0x60DE90", VA = "0x18060F490")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x5DF150", Offset = "0x5DDB50", VA = "0x1805DF150")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public DateTime BKGAMKIAOKB
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x5534B0", Offset = "0x551EB0", VA = "0x1805534B0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x7DD290", Offset = "0x7DBC90", VA = "0x1807DD290")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x37D9E20", Offset = "0x37D8820", VA = "0x1837D9E20")]
		public BEJOFLDGHMN(TKey IPKOPOLJGIA, TVal LFNNMJBIDMK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public const int HCGKEAJGEDI = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly Dictionary<TKey, LinkedListNode<BEJOFLDGHMN>> NKMJGHAKGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly LinkedList<BEJOFLDGHMN> FFHOCBMIKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	protected readonly ONEALEOBFDM HLOIHOCJLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly TimeSpan CMKGOEEMHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly MJDCPLJHNAK EHMANLPBDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int OOKHCKJPCAE;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int ILJLAIEKJNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x552A00", Offset = "0x551400", VA = "0x180552A00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private bool DKOIPFMOBBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x37E25A0", Offset = "0x37E0FA0", VA = "0x1837E25A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	internal virtual int NNOCMNOEDFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x7FAAD0", Offset = "0x7F94D0", VA = "0x1807FAAD0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private int LKEJFKMJCND
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x25BADE0", Offset = "0x25B97E0", VA = "0x1825BADE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public virtual int HEBEBONJJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2196380", Offset = "0x2194D80", VA = "0x182196380", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<TKey> FIMGPPJIOLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x37E1690", Offset = "0x37E0090", VA = "0x1837E1690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public TVal INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2CB5160", Offset = "0x2CB3B60", VA = "0x182CB5160")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x36BC8A0", Offset = "0x36BB2A0", VA = "0x1836BC8A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x37E2C80", Offset = "0x37E1680", VA = "0x1837E2C80")]
	public EHOMHFNHPNI(int POIIDIEGIKN, [Optional] ONEALEOBFDM HLOIHOCJLCG, [Optional] IEqualityComparer<TKey> ANAKMAIDCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x37E2790", Offset = "0x37E1190", VA = "0x1837E2790")]
	public EHOMHFNHPNI(TimeSpan CMKGOEEMHHN, [Optional] IEqualityComparer<TKey> ANAKMAIDCCF, [Optional] MJDCPLJHNAK EHMANLPBDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x37E2D50", Offset = "0x37E1750", VA = "0x1837E2D50")]
	public EHOMHFNHPNI(int POIIDIEGIKN, TimeSpan CMKGOEEMHHN, [Optional] IEqualityComparer<TKey> ANAKMAIDCCF, [Optional] MJDCPLJHNAK EHMANLPBDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x37E2A30", Offset = "0x37E1430", VA = "0x1837E2A30")]
	public EHOMHFNHPNI(int POIIDIEGIKN, ONEALEOBFDM HLOIHOCJLCG, TimeSpan CMKGOEEMHHN, [Optional] IEqualityComparer<TKey> ANAKMAIDCCF, [Optional] MJDCPLJHNAK EHMANLPBDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x37E22B0", Offset = "0x37E0CB0", VA = "0x1837E22B0")]
	public void NCCPJCEHNKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x37E13B0", Offset = "0x37DFDB0", VA = "0x1837E13B0")]
	public void DDDJGAONDCK(TKey IPKOPOLJGIA, TVal HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x37E1530", Offset = "0x37DFF30", VA = "0x1837E1530")]
	public bool DFDJPGANONL(TKey IPKOPOLJGIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x37E26E0", Offset = "0x37E10E0", VA = "0x1837E26E0")]
	private TVal POIAOKDLGFC(TKey OAOOMIMNANF)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x37E1D50", Offset = "0x37E0750", VA = "0x1837E1D50", Slot = "6")]
	public virtual bool FIJKPMMFIIC(TKey OAOOMIMNANF, out TVal HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x37E2240", Offset = "0x37E0C40", VA = "0x1837E2240", Slot = "7")]
	public virtual void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x37E24E0", Offset = "0x37E0EE0", VA = "0x1837E24E0")]
	private bool OFFKEHMMALG(BEJOFLDGHMN HLAAHLMNEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x37E1180", Offset = "0x37DFB80", VA = "0x1837E1180")]
	private void CMEGALEBIDI(LinkedListNode<BEJOFLDGHMN> PGGKCJCJBKK, TVal ILHPBMJBADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x37E1EA0", Offset = "0x37E08A0", VA = "0x1837E1EA0")]
	private void FJPEKBFHMIJ(TKey IPKOPOLJGIA, TVal HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x37E18B0", Offset = "0x37E02B0", VA = "0x1837E18B0")]
	private void FCJHJCAGDKA(BEJOFLDGHMN HLAAHLMNEHK, TVal ILHPBMJBADK, int EFBBJJEALLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[DefaultMember("Item")]
public class IKDDBLPOFHI<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly List<T> NIHCHNNEJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private HashSet<T> LLLAJNBPKPH;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int HEBEBONJJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x25A0F10", Offset = "0x259F910", VA = "0x1825A0F10", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool GLELDCPAEJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x577B90", Offset = "0x576590", VA = "0x180577B90", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public T INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x35FE460", Offset = "0x35FCE60", VA = "0x1835FE460", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3930450", Offset = "0x392EE50", VA = "0x183930450", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2D28930", Offset = "0x2D27330", VA = "0x182D28930", Slot = "11")]
	public void Add(T LHLOAJPGJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x392FFF0", Offset = "0x392E9F0", VA = "0x18392FFF0")]
	public bool JPOPBPNIDEA(T LHLOAJPGJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x39302F0", Offset = "0x392ECF0", VA = "0x1839302F0", Slot = "15")]
	public bool Remove(T LHLOAJPGJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x392FD30", Offset = "0x392E730", VA = "0x18392FD30", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x218FC40", Offset = "0x218E640", VA = "0x18218FC40", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x392FB30", Offset = "0x392E530", VA = "0x18392FB30", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x36E6130", Offset = "0x36E4B30", VA = "0x1836E6130", Slot = "13")]
	public bool Contains(T LHLOAJPGJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x35FE520", Offset = "0x35FCF20", VA = "0x1835FE520", Slot = "14")]
	public void CopyTo(T[] OBKDNKHGCJN, int MPFHIKENPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x29D6970", Offset = "0x29D5370", VA = "0x1829D6970", Slot = "6")]
	public int IndexOf(T LHLOAJPGJBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x392FE80", Offset = "0x392E880", VA = "0x18392FE80", Slot = "7")]
	public void Insert(int LGBFGOJBLFK, T LHLOAJPGJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x3930190", Offset = "0x392EB90", VA = "0x183930190", Slot = "8")]
	public void RemoveAt(int LGBFGOJBLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x392FB90", Offset = "0x392E590", VA = "0x18392FB90")]
	public void FFEHNBFGLLA(Predicate<T> CGPELKGLDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x3930090", Offset = "0x392EA90", VA = "0x183930090")]
	public void LGPDEMIOEJH(Comparison<T> LGKIPMEPCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x3930370", Offset = "0x392ED70", VA = "0x183930370")]
	public IKDDBLPOFHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class NCHFFAENNCI
{
	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x4D15120", Offset = "0x4D13B20", VA = "0x184D15120")]
	public static Vector3 IEPBPNLNDEK(this GameObject BHNNPCJCNFB, float FIPIOFKIBPB)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x618520", Offset = "0x616F20", VA = "0x180618520")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x4D176A0", Offset = "0x4D160A0", VA = "0x184D176A0")]
		public SerializedGuid(in Guid IJPINJFFNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x4D171F0", Offset = "0x4D15BF0", VA = "0x184D171F0")]
		public static SerializedGuid ACIEFMALEED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x4D172A0", Offset = "0x4D15CA0", VA = "0x184D172A0")]
		public static SerializedGuid DONNEDEOHHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x4D174B0", Offset = "0x4D15EB0", VA = "0x184D174B0")]
		public bool HKNLOOJMFOE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x4D17670", Offset = "0x4D16070", VA = "0x184D17670", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4D175D0", Offset = "0x4D15FD0", VA = "0x184D175D0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4D17540", Offset = "0x4D15F40", VA = "0x184D17540")]
		public bool IAMAEONCFGH(in Guid IJPINJFFNJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x4D17320", Offset = "0x4D15D20", VA = "0x184D17320", Slot = "7")]
		public bool Equals(SerializedGuid KKPJJILPNAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x4D173C0", Offset = "0x4D15DC0", VA = "0x184D173C0", Slot = "0")]
		public override bool Equals(object FBOGCDJOCBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x4D174A0", Offset = "0x4D15EA0", VA = "0x184D174A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x4D17270", Offset = "0x4D15C70", VA = "0x184D17270", Slot = "6")]
		public int CompareTo(SerializedGuid KKPJJILPNAL)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class HEIEJPMKMBB : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly Type EHFELMDBEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly string FOKCFDOMJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly bool EOJAHGJOGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly bool DHCACCHAFNO;

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x4D13C40", Offset = "0x4D12640", VA = "0x184D13C40")]
	public HEIEJPMKMBB(Type LKCENAOIOHO, string HCMHMEJDPIG, bool JFHKOLGCPCE = false, bool MGCENBNJHEG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface HMLPCDLPGDP
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface AJDDGEMIOCA<T> : HMLPCDLPGDP
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	T CKLNJLLILCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool EOIOGMFEFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string CIPMJFEKLJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::AJDDGEMIOCA<T> NCKBIGIMKDH(Action<T> PDEOFMMKBJH);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::AJDDGEMIOCA<T> BBABFNPDLEB(Action<T> PDEOFMMKBJH);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::AJDDGEMIOCA<T> KCDNCIPKEIA(Action<T, T> PKHOIKPNDLP);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::AJDDGEMIOCA<T> EFHNBPIIHGA(Action<T, T> PKHOIKPNDLP);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::AJDDGEMIOCA<T> JNIFGHJLPCA(Action<string> FALGENLGNBH);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::AJDDGEMIOCA<T> DJHBAHMPKGK(Action<string> FALGENLGNBH);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class EHLDODKPGJO<T> : global::AJDDGEMIOCA<T>, HMLPCDLPGDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private global::CJGBOLGJMCH<T, T> EOGDHEELMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private global::EFMFOCNIOPF<T> PHLHMAAFAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private global::EFMFOCNIOPF<string> LFJMGPOHBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private string EPHLCEKHMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private T HEMKPPOPDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private bool MOJEPLADPIO;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public T CKLNJLLILCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x552A10", Offset = "0x551410", VA = "0x180552A10", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2CB97A0", Offset = "0x2CB81A0", VA = "0x182CB97A0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool EOIOGMFEFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x64A5A0", Offset = "0x648FA0", VA = "0x18064A5A0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public string CIPMJFEKLJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x553490", Offset = "0x551E90", VA = "0x180553490", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x29CB600", Offset = "0x29CA000", VA = "0x1829CB600", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x37E0CE0", Offset = "0x37DF6E0", VA = "0x1837E0CE0")]
	private void LGLLPEPAAFA(T KJNOHPBJPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x37E0C40", Offset = "0x37DF640", VA = "0x1837E0C40")]
	private void KDLEFNHLIPC(string OLLHPIFFHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x37E0A40", Offset = "0x37DF440", VA = "0x1837E0A40")]
	public void HEPELHGAALN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x37E0BF0", Offset = "0x37DF5F0", VA = "0x1837E0BF0", Slot = "6")]
	public global::AJDDGEMIOCA<T> KCDNCIPKEIA(Action<T, T> PKHOIKPNDLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x37E09F0", Offset = "0x37DF3F0", VA = "0x1837E09F0", Slot = "7")]
	public global::AJDDGEMIOCA<T> EFHNBPIIHGA(Action<T, T> PKHOIKPNDLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x37E0D80", Offset = "0x37DF780", VA = "0x1837E0D80", Slot = "4")]
	public global::AJDDGEMIOCA<T> NCKBIGIMKDH(Action<T> PKHOIKPNDLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x37E08C0", Offset = "0x37DF2C0", VA = "0x1837E08C0", Slot = "5")]
	public global::AJDDGEMIOCA<T> BBABFNPDLEB(Action<T> PDEOFMMKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x37E0AF0", Offset = "0x37DF4F0", VA = "0x1837E0AF0", Slot = "8")]
	public global::AJDDGEMIOCA<T> JNIFGHJLPCA(Action<string> FALGENLGNBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x37E0910", Offset = "0x37DF310", VA = "0x1837E0910", Slot = "9")]
	public global::AJDDGEMIOCA<T> DJHBAHMPKGK(Action<string> FALGENLGNBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x37E0E10", Offset = "0x37DF810", VA = "0x1837E0E10")]
	public EHLDODKPGJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class DPNNEEOOHJB
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class MAAEPAFBMII<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public global::AJDDGEMIOCA<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public global::EJMKJFHGFHJ<T> promise;

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x218A560", Offset = "0x2188F60", VA = "0x18218A560")]
		public MAAEPAFBMII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x36C6DC0", Offset = "0x36C57C0", VA = "0x1836C6DC0")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x22AE840", Offset = "0x22AD240", VA = "0x1822AE840")]
	public static global::HJGFLNHHJHD<T> DKBJHMNMNDE<T>(this global::AJDDGEMIOCA<T> KNDDGGHPOPB, Action<T> JJBCELLHKLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class MJDCPLJHNAK
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private class BNKGIIAGIFE : MJDCPLJHNAK
	{
		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public static MJDCPLJHNAK JMMDLCEKNJL
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x4D11A50", Offset = "0x4D10450", VA = "0x184D11A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public override DateTime MPDMEOHKEAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x4D11AB0", Offset = "0x4D104B0", VA = "0x184D11AB0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public override float KPLIEDHLNOH
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x4D11B00", Offset = "0x4D10500", VA = "0x184D11B00", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x4D11BB0", Offset = "0x4D105B0", VA = "0x184D11BB0")]
		public BNKGIIAGIFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static MJDCPLJHNAK MEIFENPHKBO;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static MJDCPLJHNAK GMBIDLIPEPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x4D14FA0", Offset = "0x4D139A0", VA = "0x184D14FA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public abstract DateTime MPDMEOHKEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public abstract float KPLIEDHLNOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	protected MJDCPLJHNAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class HOJOEADGGBA : global::EKFIPGGCHNC<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x4D13CB0", Offset = "0x4D126B0", VA = "0x184D13CB0")]
	public HOJOEADGGBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class EKFIPGGCHNC<T> : global::EJNODPAFKHM<T>, FJLFFABKNAJ, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Task<T> MPPMPGNIFOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x551E80", VA = "0x180553480", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private Task BKAMLFEKCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x218F490", Offset = "0x218DE90", VA = "0x18218F490", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public global::HJGFLNHHJHD<T> CGJIFKLEIDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private LCANMJCMFMC MDEJDOKOMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x2195BE0", Offset = "0x21945E0", VA = "0x182195BE0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x34C2F10", Offset = "0x34C1910", VA = "0x1834C2F10")]
	public EKFIPGGCHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class FMOEBBMJIAE : global::EBHNEAJOLEN<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x4D129C0", Offset = "0x4D113C0", VA = "0x184D129C0")]
	public FMOEBBMJIAE(Exception OIFFLJDLBAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class EBHNEAJOLEN<T> : global::EJNODPAFKHM<T>, FJLFFABKNAJ, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Task<T> MPPMPGNIFOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x551E80", VA = "0x180553480", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	private Task BKAMLFEKCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x218F490", Offset = "0x218DE90", VA = "0x18218F490", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public global::HJGFLNHHJHD<T> CGJIFKLEIDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private LCANMJCMFMC MDEJDOKOMCB
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x2195BE0", Offset = "0x21945E0", VA = "0x182195BE0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x36C0120", Offset = "0x36BEB20", VA = "0x1836C0120")]
	public EBHNEAJOLEN(Exception OIFFLJDLBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface FJLFFABKNAJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	[NotNull]
	Task MPPMPGNIFOL
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	[NotNull]
	LCANMJCMFMC CGJIFKLEIDP
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface EJNODPAFKHM<T> : FJLFFABKNAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000063")]
	[NotNull]
	new Task<T> MPPMPGNIFOL
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	[NotNull]
	new global::HJGFLNHHJHD<T> CGJIFKLEIDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public abstract class IGNKPDJGAFD<TTask, T> : global::EJNODPAFKHM<T>, FJLFFABKNAJ, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class PMJHIPMMICD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public global::IGNKPDJGAFD<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x218A560", Offset = "0x2188F60", VA = "0x18218A560")]
		public PMJHIPMMICD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static bool AEAHPKHFCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly Task<T> MLPEOOKMEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	protected readonly CancellationTokenSource LNHBGENCLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool NPBJPMMAPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private SynchronizationContext GKGOACIHEAB;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Task<T> MPPMPGNIFOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x551E80", VA = "0x180553480", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private Task BKAMLFEKCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x551E80", VA = "0x180553480", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::HJGFLNHHJHD<T> CGJIFKLEIDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private LCANMJCMFMC MDEJDOKOMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x218F580", Offset = "0x218DF80", VA = "0x18218F580", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool JKILCLMBBEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x649680", Offset = "0x648080", VA = "0x180649680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x36F5C00", Offset = "0x36F4600", VA = "0x1836F5C00")]
	static IGNKPDJGAFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x36F5EE0", Offset = "0x36F48E0", VA = "0x1836F5EE0")]
	protected IGNKPDJGAFD(TTask MLPEOOKMEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x36F5830", Offset = "0x36F4230", VA = "0x1836F5830", Slot = "1")]
	~IGNKPDJGAFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x36F5760", Offset = "0x36F4160", VA = "0x1836F5760", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x36F5A90", Offset = "0x36F4490", VA = "0x1836F5A90")]
	private void OHNGCEIGACM(bool LEBAAFFLGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T CHBJEJCJPMI(TTask OKDOINGHKFM);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void JGNCDHFKPAD();

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x36F58D0", Offset = "0x36F42D0", VA = "0x1836F58D0")]
	[CompilerGenerated]
	private void HNDNHGIDMAI(object BGOKFFKFKBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class BEIGBOMJAJE : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly Type EHFELMDBEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public readonly string FOKCFDOMJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public readonly bool EOJAHGJOGCH;

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x4D119F0", Offset = "0x4D103F0", VA = "0x184D119F0")]
	public BEIGBOMJAJE(Type LKCENAOIOHO, string HCMHMEJDPIG, bool JFHKOLGCPCE = false)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x54F010", Offset = "0x54DA10", VA = "0x18054F010")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x59B370", Offset = "0x599D70", VA = "0x18059B370")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public T this[int PFAINNECIEO, int CDJDGMLGNGN]
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x2599320", Offset = "0x2597D20", VA = "0x182599320")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x25993C0", Offset = "0x2597DC0", VA = "0x1825993C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x2599290", Offset = "0x2597C90", VA = "0x182599290")]
		public Array2D(uint IHCNDPNEGKP, uint CNICIJGDLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x2599210", Offset = "0x2597C10", VA = "0x182599210")]
		public void KOBBDDIILEP()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x4D11990", Offset = "0x4D10390", VA = "0x184D11990")]
		public Array2DVector3(uint IHCNDPNEGKP, uint CNICIJGDLJM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal static class GCFKBMDONDA
{
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public const int EDDINCLIKIM = -1;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public const int NKKDLADIMFM = 0;
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[DefaultMember("Item")]
public class MFPGGCIEKBM<THandle, TValue> : IDisposable where THandle : struct, JPKBKOFGKDG where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly List<THandle> GFNEMBHFGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly List<TValue> BNGLGDLKMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly Func<TValue> HHFMDMALFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly Action<TValue> NJAPBBEDMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private int FPCMJMNMBFD;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public TValue INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x29D6160", Offset = "0x29D4B60", VA = "0x1829D6160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x2D28640", Offset = "0x2D27040", VA = "0x182D28640")]
	public MFPGGCIEKBM(Action<TValue> NJAPBBEDMLD, [Optional] Func<TValue> HHFMDMALFKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x2D27DD0", Offset = "0x2D267D0", VA = "0x182D27DD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x2D27B40", Offset = "0x2D26540", VA = "0x182D27B40")]
	public THandle AEEGCHIFHAD()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x2D27C80", Offset = "0x2D26680", VA = "0x182D27C80")]
	public THandle CEGAKGBDODP(TValue HPIAFNBPEPC)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x2D27CF0", Offset = "0x2D266F0", VA = "0x182D27CF0")]
	public bool DFDJPGANONL(THandle ANNMBFABHDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x2D27F70", Offset = "0x2D26970", VA = "0x182D27F70")]
	public bool GFMJBBHLHOA(THandle ANNMBFABHDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x2D27ED0", Offset = "0x2D268D0", VA = "0x182D27ED0")]
	public bool FHLLGNFGHGE(THandle ANNMBFABHDN, out TValue HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x2D285F0", Offset = "0x2D26FF0", VA = "0x182D285F0")]
	public TValue POIAOKDLGFC(THandle ANNMBFABHDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x2D28050", Offset = "0x2D26A50", VA = "0x182D28050")]
	public bool GKBEBLCBCBI(THandle ANNMBFABHDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x2D283B0", Offset = "0x2D26DB0", VA = "0x182D283B0")]
	private THandle LCPPMDJJDGK(int LGBFGOJBLFK)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x2D27DA0", Offset = "0x2D267A0", VA = "0x182D27DA0")]
	private TValue DKBJHMNMNDE(int LGBFGOJBLFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x2D285B0", Offset = "0x2D26FB0", VA = "0x182D285B0")]
	private void OCNHPLLAJKD(int LGBFGOJBLFK, in THandle ANNMBFABHDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x2D283E0", Offset = "0x2D26DE0", VA = "0x182D283E0")]
	private void LGLLPEPAAFA(int LGBFGOJBLFK, in TValue HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x2D284A0", Offset = "0x2D26EA0", VA = "0x182D284A0")]
	private THandle NOJNIHGPMCA()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x2D282F0", Offset = "0x2D26CF0", VA = "0x182D282F0")]
	private void JNCGECHLMKO(THandle ANNMBFABHDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x2D28420", Offset = "0x2D26E20", VA = "0x182D28420")]
	private int LMCFDMDAOOM(int NAGACMCOIBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x2D28490", Offset = "0x2D26E90", VA = "0x182D28490")]
	private bool NJGHNFDGOKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x5C8590", Offset = "0x5C6F90", VA = "0x1805C8590")]
	private void JGBJAPHBLKB(THandle ANNMBFABHDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x2D27E50", Offset = "0x2D26850", VA = "0x182D27E50")]
	private bool FABIJJHMFAH(out THandle ANNMBFABHDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x2D28100", Offset = "0x2D26B00", VA = "0x182D28100")]
	private bool HJMIHMAIENG(out THandle ANNMBFABHDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x2D28430", Offset = "0x2D26E30", VA = "0x182D28430")]
	private void NHCMDPNILCM(THandle ANNMBFABHDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x2D281D0", Offset = "0x2D26BD0", VA = "0x182D281D0")]
	private void JDCCECFBNOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface JPKBKOFGKDG
{
	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	int LJFCMJHPBPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	int AJBHNBBCJNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface ICODKHMKNJJ<T> : JPKBKOFGKDG, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class JFKIOEGBNBI
{
	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x27B3FD0", Offset = "0x27B29D0", VA = "0x1827B3FD0")]
	public static bool PINGKOBKAOL<T>(this T ANNMBFABHDN) where T : struct, JPKBKOFGKDG
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class HCDLABNIPAK
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private enum NJKLIHJEJHH : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private int JGDFFEGEHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private bool PHNNCDMBMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NJKLIHJEJHH BEGCHMBIIJM;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool FKDJNNEDMJE
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x4D12C80", Offset = "0x4D11680", VA = "0x184D12C80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool CBJNOCMDFGH
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x4D133C0", Offset = "0x4D11DC0", VA = "0x184D133C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x4D138B0", Offset = "0x4D122B0", VA = "0x184D138B0")]
	public HCDLABNIPAK(bool PHNNCDMBMJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x4D12E30", Offset = "0x4D11830", VA = "0x184D12E30")]
	public void LCMEMBHOLAI(object FBOGCDJOCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x4D12AD0", Offset = "0x4D114D0", VA = "0x184D12AD0")]
	public void DGKAPGGDIGD(int HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x4D12C90", Offset = "0x4D11690", VA = "0x184D12C90")]
	public void GJCPJDDOACF(uint GMANDLKCDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x4D12DC0", Offset = "0x4D117C0", VA = "0x184D12DC0")]
	public void JIIJHONKMMK(bool CODFIBCBHCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x4D12DE0", Offset = "0x4D117E0", VA = "0x184D12DE0")]
	public void KLOFIBCJNFE(long LDALNAELKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x4D12D80", Offset = "0x4D11780", VA = "0x184D12D80")]
	public void IPIJCJFOFCF(ulong FCPCOFJHBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x4D12CA0", Offset = "0x4D116A0", VA = "0x184D12CA0")]
	public void GKBFGBBGLDP(string CDKMLIMBHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x4D12B80", Offset = "0x4D11580", VA = "0x184D12B80")]
	public void DJIECPJKMPK(Enum OIFFLJDLBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x4D13790", Offset = "0x4D12190", VA = "0x184D13790")]
	public void OAJAJLEPAOM(IList NIHCHNNEJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x2559C70", Offset = "0x2558670", VA = "0x182559C70")]
	public void DKONCJIDABP<T, U>(Dictionary<T, U> CPLFDNIMMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x4D133D0", Offset = "0x4D11DD0", VA = "0x184D133D0")]
	private void MOMFEPCKCMH(IDictionary CPLFDNIMMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x4D12D10", Offset = "0x4D11710", VA = "0x184D12D10")]
	public int IAHBFLPMHIN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x4D13350", Offset = "0x4D11D50", VA = "0x184D13350")]
	public short LHFGCMIENKF()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x4D12E20", Offset = "0x4D11820", VA = "0x184D12E20")]
	public void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x4D12C10", Offset = "0x4D11610", VA = "0x184D12C10")]
	private void DKMMFIFBCBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public abstract class MHHNHKEPKOI<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	internal class BJEDOMLGCDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public TNode NPNHPOMDOAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public TNode MMEAACHMALE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public GDHEMPKOKMI DADDDHJHLLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public List<GDHEMPKOKMI> PEIANJJJFKF;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x218A560", Offset = "0x2188F60", VA = "0x18218A560")]
		public BJEDOMLGCDN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal struct GDHEMPKOKMI : IComparable<GDHEMPKOKMI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int KGEFLFECBIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public TClaimant EBODDCDHOFG;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x57F980", Offset = "0x57E380", VA = "0x18057F980")]
		public GDHEMPKOKMI(int KGEFLFECBIL, TClaimant EBODDCDHOFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A800", Offset = "0x2D19200", VA = "0x182D1A800")]
		public bool PNCFKNMKGEK(in GDHEMPKOKMI KKPJJILPNAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A7F0", Offset = "0x2D191F0", VA = "0x182D1A7F0")]
		public bool GOFKMAOLFPB(in GDHEMPKOKMI KKPJJILPNAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A7E0", Offset = "0x2D191E0", VA = "0x182D1A7E0", Slot = "4")]
		public int CompareTo(GDHEMPKOKMI KKPJJILPNAL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A860", Offset = "0x2D19260", VA = "0x182D1A860", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public enum CPFHFFCMLFL
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class AJDEEKDJBNC : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public global::MHHNHKEPKOI<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x2CB9BD0", Offset = "0x2CB85D0", VA = "0x182CB9BD0")]
		[DebuggerHidden]
		public AJDEEKDJBNC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x2D16420", Offset = "0x2D14E20", VA = "0x182D16420", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x2D165E0", Offset = "0x2D14FE0", VA = "0x182D165E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x2D16500", Offset = "0x2D14F00", VA = "0x182D16500", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x2196D30", Offset = "0x2195730", VA = "0x182196D30", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly global::MLKGFJJLMOH<BJEDOMLGCDN> HCDBAFNOCDH;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly global::MLKGFJJLMOH<List<GDHEMPKOKMI>> CHFBMIADJLJ;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static int PJKGFEEOBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	internal readonly Dictionary<TClaimant, TNode> DGJFGDLJKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	internal readonly Dictionary<TNode, BJEDOMLGCDN> HDEKDNBGEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private CPFHFFCMLFL OMMBLABNACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private bool KIHCNAMPEGA;

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode PMGPECBBCKO(TNode DAMODCEKDNG);

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void AAMJBNJLMAP(TNode DAMODCEKDNG, TClaimant NHLNKGDIGIJ, TClaimant IEEINCGKHDC);

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x2D2A5D0", Offset = "0x2D28FD0", VA = "0x182D2A5D0")]
	public MHHNHKEPKOI(CPFHFFCMLFL OMMBLABNACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x2D2A360", Offset = "0x2D28D60", VA = "0x182D2A360")]
	public void PGLKAALDBLH(TNode DAMODCEKDNG, TNode IPLMPKBGGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x2D292A0", Offset = "0x2D27CA0", VA = "0x182D292A0")]
	public void GPKKKACNKFG(TClaimant EBODDCDHOFG, TNode GAGGCAGLEJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x2D28EB0", Offset = "0x2D278B0", VA = "0x182D28EB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x2D29FC0", Offset = "0x2D289C0", VA = "0x182D29FC0")]
	private void MLICLCBABJF(TClaimant EBODDCDHOFG, TNode FCGDBKJFKOE, TNode GAGGCAGLEJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x2D2A060", Offset = "0x2D28A60", VA = "0x182D2A060")]
	private int MLMNFECMKCA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x2D29710", Offset = "0x2D28110", VA = "0x182D29710")]
	private void JANEBJMLJID(TClaimant EBODDCDHOFG, TNode AFCDKCMJHAD, TNode BAAONIKBBCB, int BHDKGGJEJGM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x2D2A3E0", Offset = "0x2D28DE0", VA = "0x182D2A3E0")]
	private void PKHFDKLDHPP(GDHEMPKOKMI HFFFFIDDKJK, BJEDOMLGCDN AJAKEIHKFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x2D294A0", Offset = "0x2D27EA0", VA = "0x182D294A0")]
	private void IGFDMMGOGFK(TClaimant EBODDCDHOFG, TNode AFCDKCMJHAD, TNode BAAONIKBBCB, int BHDKGGJEJGM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x2D293A0", Offset = "0x2D27DA0", VA = "0x182D293A0")]
	private void HNPLOJJDKCA(GDHEMPKOKMI HFFFFIDDKJK, TNode DAMODCEKDNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x2D2A260", Offset = "0x2D28C60", VA = "0x182D2A260")]
	private void PBJBLDBKHGL(GDHEMPKOKMI HFFFFIDDKJK, BJEDOMLGCDN AJAKEIHKFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x2D28D70", Offset = "0x2D27770", VA = "0x182D28D70")]
	private void CLDIGAHKNNH(BJEDOMLGCDN AJAKEIHKFGB, bool PIGMBODBEGD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x2D299C0", Offset = "0x2D283C0", VA = "0x182D299C0")]
	private void KIKEIHBPNPD(BJEDOMLGCDN AJAKEIHKFGB, TNode IPLMPKBGGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x2D291D0", Offset = "0x2D27BD0", VA = "0x182D291D0")]
	[IteratorStateMachine(typeof(global::MHHNHKEPKOI<, >.AJDEEKDJBNC))]
	private IEnumerable<TNode> EIOIIGEMEEM(TNode AFCDKCMJHAD, TNode BAAONIKBBCB, bool KAPNKPEMFLM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x2D29110", Offset = "0x2D27B10", VA = "0x182D29110")]
	private BJEDOMLGCDN EDLBDMAGHMJ(TNode DAMODCEKDNG, TNode MMEAACHMALE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x2D2A0D0", Offset = "0x2D28AD0", VA = "0x182D2A0D0")]
	private BJEDOMLGCDN MNGKNNAIKIN(TNode DAMODCEKDNG, TNode MMEAACHMALE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x2D29E00", Offset = "0x2D28800", VA = "0x182D29E00")]
	private void MKBDIDGKDNM(BJEDOMLGCDN AJAKEIHKFGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class NJNOOENDDGM<T> : IEnumerable<global::NJNOOENDDGM<T>.KJNABALACNK>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public struct KJNABALACNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T HPIAFNBPEPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int LGBFGOJBLFK;
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class IEAAMLAKGCN : IEnumerator<KJNABALACNK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private global::NJNOOENDDGM<T> PLJLJLMPKME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private int LGBFGOJBLFK;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x28C7DF0", Offset = "0x28C67F0", VA = "0x1828C7DF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public KJNABALACNK CJFECBEGNFF
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x28C7E60", Offset = "0x28C6860", VA = "0x1828C7E60", Slot = "4")]
			get
			{
				return default(KJNABALACNK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xAB67D0", Offset = "0xAB51D0", VA = "0x180AB67D0")]
		public IEAAMLAKGCN(global::NJNOOENDDGM<T> PLJLJLMPKME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x28C7D60", Offset = "0x28C6760", VA = "0x1828C7D60", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x968BB0", Offset = "0x9675B0", VA = "0x180968BB0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xA006E0", Offset = "0x9FF0E0", VA = "0x180A006E0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private struct AFKHPJKDAPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool LAEMEOPIMPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public T HPIAFNBPEPC;
	}

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int EDOKLIHEDHK = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private Dictionary<T, int> HGIEMOJPOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private AFKHPJKDAPG[] BNBCDPBPKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int HBCNDILFLFC;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int HEBEBONJJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x28CBE80", Offset = "0x28CA880", VA = "0x1828CBE80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x28CBAA0", Offset = "0x28CA4A0", VA = "0x1828CBAA0")]
	public static global::NJNOOENDDGM<T> NAKJNHOGGFD(KJNABALACNK[] IGKAIJBHEFK, bool KAOFNMPACGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x28CBFE0", Offset = "0x28CA9E0", VA = "0x1828CBFE0")]
	public NJNOOENDDGM(int POIIDIEGIKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x268D5A0", Offset = "0x268BFA0", VA = "0x18268D5A0")]
	public bool KIANONFEMIL(T HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x28CB540", Offset = "0x28C9F40", VA = "0x1828CB540")]
	public bool EBGIIJKHJJI(int LGBFGOJBLFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x28CBEB0", Offset = "0x28CA8B0", VA = "0x1828CBEB0")]
	public bool PNJHNNLCLCE(Func<T, bool> IEGOIPJCKEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x28CB5A0", Offset = "0x28C9FA0", VA = "0x1828CB5A0")]
	public int FPPJIFIPCNC(T HPIAFNBPEPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x28CB4D0", Offset = "0x28C9ED0", VA = "0x1828CB4D0")]
	public T DKBJHMNMNDE(int LGBFGOJBLFK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x28CBA00", Offset = "0x28CA400", VA = "0x1828CBA00")]
	public void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x28CB7B0", Offset = "0x28CA1B0", VA = "0x1828CB7B0")]
	public bool JPOPBPNIDEA(T HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x28CB7D0", Offset = "0x28CA1D0", VA = "0x1828CB7D0")]
	public bool JPOPBPNIDEA(T HPIAFNBPEPC, int LGBFGOJBLFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x28CB450", Offset = "0x28C9E50", VA = "0x1828CB450")]
	public bool DFDJPGANONL(T HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x28CBA50", Offset = "0x28CA450", VA = "0x1828CBA50")]
	public bool LLGMOJMHILP(int LGBFGOJBLFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x28CB3A0", Offset = "0x28C9DA0", VA = "0x1828CB3A0")]
	private void AHJGLOGLDGK(int LGBFGOJBLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x28CB640", Offset = "0x28CA040", VA = "0x1828CB640")]
	public KJNABALACNK[] JKAPMNMJCMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x28CB5F0", Offset = "0x28C9FF0", VA = "0x1828CB5F0")]
	private int GGOHHOLFLME(int KLJIMEJKFHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x28CBF60", Offset = "0x28CA960", VA = "0x1828CBF60", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x28CBF60", Offset = "0x28CA960", VA = "0x1828CBF60", Slot = "4")]
	private IEnumerator<KJNABALACNK> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class MLKGFJJLMOH<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly Stack<T> GMBNIDCEFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly List<T> KKHEMNACCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly int OFCFHBOCLFM;

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public int IGDGOHNMJNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x2598DB0", Offset = "0x25977B0", VA = "0x182598DB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public int AEOEPIJIEON
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x25A1410", Offset = "0x259FE10", VA = "0x1825A1410")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x3EC6160", Offset = "0x3EC4B60", VA = "0x183EC6160")]
	public static global::MLKGFJJLMOH<T> AAAEEDNIJPD(int POIIDIEGIKN = 0, int OFCFHBOCLFM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x3EC6730", Offset = "0x3EC5130", VA = "0x183EC6730")]
	public static global::MLKGFJJLMOH<T> NOFAIKILKMH(int POIIDIEGIKN = 0, int OFCFHBOCLFM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x3EC6B80", Offset = "0x3EC5580", VA = "0x183EC6B80")]
	public MLKGFJJLMOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x3EC69F0", Offset = "0x3EC53F0", VA = "0x183EC69F0")]
	public MLKGFJJLMOH(int POIIDIEGIKN, int OFCFHBOCLFM = int.MaxValue, bool FOPIKMJDGMD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x3EC68C0", Offset = "0x3EC52C0", VA = "0x183EC68C0")]
	public T PFBILCOMHNF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x3EC6800", Offset = "0x3EC5200", VA = "0x183EC6800")]
	public void PEADAJPCKBB(T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x3EC62E0", Offset = "0x3EC4CE0", VA = "0x183EC62E0")]
	private void BMBDAOIMLIC(T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x3EC6710", Offset = "0x3EC5110", VA = "0x183EC6710")]
	private void MCOHLGEHCMF(T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x3EC6670", Offset = "0x3EC5070", VA = "0x183EC6670")]
	[Conditional("DEBUG_BUILD")]
	private void KJBNMKAHPFD(T AFPBKKGAKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x3EC6230", Offset = "0x3EC4C30", VA = "0x183EC6230")]
	[Conditional("DEBUG_BUILD")]
	private void AOEHIGMJJHK(T AFPBKKGAKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x3EC6560", Offset = "0x3EC4F60", VA = "0x183EC6560", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x3EC63A0", Offset = "0x3EC4DA0", VA = "0x183EC63A0")]
	private void COFGEHJMBDI(IEnumerable<T> BNGLGDLKMIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class CPOLPPGHMMP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private Dictionary<int, T> DKPIEMGLOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private T PJPPOOFFKAH;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public virtual T CJFOCCFLMIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x556460", Offset = "0x554E60", VA = "0x180556460", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool JIIEKEKCLDM
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x2DAEBA0", Offset = "0x2DAD5A0", VA = "0x182DAEBA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE550", Offset = "0x2DACF50", VA = "0x182DAE550")]
	public bool FJPEKBFHMIJ(T HPIAFNBPEPC, int KGEFLFECBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE610", Offset = "0x2DAD010", VA = "0x182DAE610")]
	public bool JBHAMDMNDIL(int KGEFLFECBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE940", Offset = "0x2DAD340", VA = "0x182DAE940")]
	public T MIJAEKMFDBA(int DGLEFEIFMKA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE670", Offset = "0x2DAD070", VA = "0x182DAE670")]
	public void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE380", Offset = "0x2DACD80", VA = "0x182DAE380")]
	private bool CKDLHPDFMHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE520", Offset = "0x2DACF20", VA = "0x182DAE520")]
	public bool FIJKPMMFIIC(int KGEFLFECBIL, out T HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x28D97C0", Offset = "0x28D81C0", VA = "0x1828D97C0")]
	public CPOLPPGHMMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class APOLOFCJDHM<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	protected struct IJLMBDBABED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public T CKLNJLLILCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public int KAFHPNHLOLA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	protected readonly List<IJLMBDBABED> OEKOKLAIABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private T NJFBNEODIFC;

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public int HEBEBONJJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x25A0F10", Offset = "0x259F910", VA = "0x1825A0F10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x395C4A0", Offset = "0x395AEA0", VA = "0x18395C4A0")]
	public bool PNJHNNLCLCE(T HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x395BF70", Offset = "0x395A970", VA = "0x18395BF70")]
	public void CEGAKGBDODP(T HPIAFNBPEPC, int KGEFLFECBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x395C010", Offset = "0x395AA10", VA = "0x18395C010")]
	public bool DFDJPGANONL(T HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x395C230", Offset = "0x395AC30", VA = "0x18395C230")]
	public void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x395C130", Offset = "0x395AB30", VA = "0x18395C130")]
	public T DPGIJOAGMLD()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x395C1C0", Offset = "0x395ABC0", VA = "0x18395C1C0")]
	public T IEDOEIGPOID()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x395C290", Offset = "0x395AC90", VA = "0x18395C290")]
	private void MOBCLMJPFEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x395C6F0", Offset = "0x395B0F0", VA = "0x18395C6F0")]
	public APOLOFCJDHM()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[SerializeField]
		[LJOCGMMGCIH(JAJEGMAJLMP.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x4D15C00", Offset = "0x4D14600", VA = "0x184D15C00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x4D160D0", Offset = "0x4D14AD0", VA = "0x184D160D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x4D15EF0", Offset = "0x4D148F0", VA = "0x184D15EF0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x4D16270", Offset = "0x4D14C70", VA = "0x184D16270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x4D15AC0", Offset = "0x4D144C0", VA = "0x184D15AC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x4D15F90", Offset = "0x4D14990", VA = "0x184D15F90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x4D15DB0", Offset = "0x4D147B0", VA = "0x184D15DB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x4D15A20", Offset = "0x4D14420", VA = "0x184D15A20")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface HCNAELDHKIM
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public abstract class ResourcePrefabReference<T> : HCNAELDHKIM where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x25AC5E0", Offset = "0x25AAFE0", VA = "0x1825AC5E0", Slot = "4")]
		public virtual T GMHHAFBJHFI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x218A560", Offset = "0x2188F60", VA = "0x18218A560")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class DNCACFIONHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private readonly Dictionary<byte, NMMNGOKIPCK> EGKKFFOGCIC;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public NMMNGOKIPCK CFOCDAOBNHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x551E80", VA = "0x180553480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x577180", Offset = "0x575B80", VA = "0x180577180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector2 NINJEFGAEEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xC17B90", Offset = "0xC16590", VA = "0x180C17B90")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x28D3B20", Offset = "0x28D2520", VA = "0x1828D3B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Vector2 CJODKLACJPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x11E1140", Offset = "0x11DFB40", VA = "0x1811E1140")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x1B5F4F0", Offset = "0x1B5DEF0", VA = "0x181B5F4F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector2 IKCKMNKBEJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x4D12350", Offset = "0x4D10D50", VA = "0x184D12350")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x4D121C0", Offset = "0x4D10BC0", VA = "0x184D121C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int HILNNHNFBAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x5A2410", Offset = "0x5A0E10", VA = "0x1805A2410")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x5C8590", Offset = "0x5C6F90", VA = "0x1805C8590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x4D124A0", Offset = "0x4D10EA0", VA = "0x184D124A0")]
	public DNCACFIONHP(Bounds BMNAABEIKCK, Vector2[] EMDPMENBBAP, int DNKBNINPIAN, byte KLJIMEJKFHH, float LFDABNFJPIJ = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x4D122D0", Offset = "0x4D10CD0", VA = "0x184D122D0")]
	public NMMNGOKIPCK DPKJGJNIMOA(byte LGBFGOJBLFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x4D121E0", Offset = "0x4D10BE0", VA = "0x184D121E0")]
	public void BGDENAMBGIK(Vector3 BJMMNGJKEHP, float CEGMHBPNKJJ, float EHHNNNKFDKE, ref List<byte> AADODEFOPOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x4D12330", Offset = "0x4D10D30", VA = "0x184D12330")]
	public void EFJBKCAJMEB(NMMNGOKIPCK.MOHEDMFNOLD NLLJNIEDKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x4D12370", Offset = "0x4D10D70", VA = "0x184D12370")]
	private NMMNGOKIPCK LDMFEADCLAN(byte LGBFGOJBLFK, NMMNGOKIPCK.PIALDEDLJFJ HNNELBOHPPO, NMMNGOKIPCK MMEAACHMALE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x4D11CA0", Offset = "0x4D106A0", VA = "0x184D11CA0")]
	private void ACHBJFIOBAL(NMMNGOKIPCK MMEAACHMALE, Vector2[] EMDPMENBBAP, int GOLBBAMMCOP, int NCIIJPJJBMP, int ONJIFDBNIHD, int NFBBNFAHGCK, float LFDABNFJPIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class NMMNGOKIPCK
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public enum PIALDEDLJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public enum MOHEDMFNOLD
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public byte IBOPELBHDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public Vector3 GHFIHJEGBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public Vector3 PFFOPFIKBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public Vector3 JNJNKFAEKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public Vector3 KNJFFAMGHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public PIALDEDLJFJ JPHDCOGHOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public NMMNGOKIPCK OOLIINHPLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public List<NMMNGOKIPCK> AHLHNHJACHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public bool AJHGEHFGIBO;

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x4D15960", Offset = "0x4D14360", VA = "0x184D15960")]
	public NMMNGOKIPCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x4D15900", Offset = "0x4D14300", VA = "0x184D15900")]
	public NMMNGOKIPCK(byte AKGOJHKMAIK, PIALDEDLJFJ HNNELBOHPPO, NMMNGOKIPCK MMEAACHMALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x4D15860", Offset = "0x4D14260", VA = "0x184D15860")]
	public void OJNFEAIHKBO(NMMNGOKIPCK KIBPPDMNMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30")]
	public void EFJBKCAJMEB(int HKOGLPJBHEB, MOHEDMFNOLD NLLJNIEDKGN, int CLFOLDNFMFA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x4D15530", Offset = "0x4D13F30", VA = "0x184D15530")]
	public void BGDENAMBGIK(List<byte> AADODEFOPOL, Vector3 BJMMNGJKEHP, float CEGMHBPNKJJ, float EHHNNNKFDKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x4D15800", Offset = "0x4D14200", VA = "0x184D15800")]
	public bool FDPCGKPNIGN(Vector3 BAMBIPKOPOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x4D157C0", Offset = "0x4D141C0", VA = "0x184D157C0")]
	public bool BNNHGEKPCAN(Vector3 BAMBIPKOPOH, float LMKBLILGPFA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class LLELPLGOPIH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly Dictionary<T, object> BAKHIEGCDJI;

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x28E8BD0", Offset = "0x28E75D0", VA = "0x1828E8BD0")]
	public bool POBJGGCIPJD(T LGGHLCFHBPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x3F207F0", Offset = "0x3F1F1F0", VA = "0x183F207F0")]
	public bool POBJGGCIPJD(T LGGHLCFHBPF, object LBAGELALLHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x3F20830", Offset = "0x3F1F230", VA = "0x183F20830")]
	public bool POBJGGCIPJD(T LGGHLCFHBPF, object LBAGELALLHA, out object LNCFIGGAAMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x3F207B0", Offset = "0x3F1F1B0", VA = "0x183F207B0")]
	public bool FCBEACEDNJE(T LGGHLCFHBPF, object LBAGELALLHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x3F20640", Offset = "0x3F1F040", VA = "0x183F20640")]
	public bool EAEBBJMIMNJ(T LGGHLCFHBPF, object LBAGELALLHA, out object LNCFIGGAAMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x3F20720", Offset = "0x3F1F120", VA = "0x183F20720")]
	public bool FCBEACEDNJE(T LGGHLCFHBPF, object LBAGELALLHA, out object LNCFIGGAAMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x35FE6A0", Offset = "0x35FD0A0", VA = "0x1835FE6A0")]
	public void OEBFADBNNOL(T LGGHLCFHBPF, object LBAGELALLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x3F20680", Offset = "0x3F1F080", VA = "0x183F20680")]
	public void EBHKKPBODGI(T LGGHLCFHBPF, object LBAGELALLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x3F20890", Offset = "0x3F1F290", VA = "0x183F20890")]
	public LLELPLGOPIH()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		public struct IOHBDFACHAD<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			private readonly List<Component> NIHCHNNEJAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			private readonly bool CEOKFKILCAL;

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x913EF0", Offset = "0x9128F0", VA = "0x180913EF0")]
			public IOHBDFACHAD(List<Component> NIHCHNNEJAD, bool CEOKFKILCAL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x259D980", Offset = "0x259C380", VA = "0x18259D980")]
			public ILOCMFKLFJF<T> OIGPEBHIBKC()
			{
				return default(ILOCMFKLFJF<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x259D9F0", Offset = "0x259C3F0", VA = "0x18259D9F0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x259D9F0", Offset = "0x259C3F0", VA = "0x18259D9F0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public struct ILOCMFKLFJF<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private readonly List<Component> NIHCHNNEJAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			private readonly bool CEOKFKILCAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			private int LGBFGOJBLFK;

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public T CJFECBEGNFF
			{
				[Cpp2IlInjected.Token(Token = "0x6000318")]
				[Cpp2IlInjected.Address(RVA = "0x259D870", Offset = "0x259C270", VA = "0x18259D870", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000319")]
				[Cpp2IlInjected.Address(RVA = "0x259D800", Offset = "0x259C200", VA = "0x18259D800", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x259D840", Offset = "0x259C240", VA = "0x18259D840")]
			public ILOCMFKLFJF(List<Component> NIHCHNNEJAD, bool CEOKFKILCAL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x259D730", Offset = "0x259C130", VA = "0x18259D730", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x259D740", Offset = "0x259C140", VA = "0x18259D740", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x259D7F0", Offset = "0x259C1F0", VA = "0x18259D7F0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x4D17F30", Offset = "0x4D16930", VA = "0x184D17F30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x4D17EF0", Offset = "0x4D168F0", VA = "0x184D17EF0")]
		public ToolHierarchyCache(GameObject JJNIJCDCCFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x4D17C50", Offset = "0x4D16650", VA = "0x184D17C50")]
		private void LPDEJFLNIEO(GameObject JJNIJCDCCFE, bool BKLDBHLOPOM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x4D17D70", Offset = "0x4D16770", VA = "0x184D17D70")]
		public static void LPDEJFLNIEO(GameObject JJNIJCDCCFE, ref ToolHierarchyCache GIJBCGBNLPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x4D17810", Offset = "0x4D16210", VA = "0x184D17810")]
		public void FFIODHFMBJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x4D17C00", Offset = "0x4D16600", VA = "0x184D17C00")]
		public void LLKLANHPIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x260DAA0", Offset = "0x260C4A0", VA = "0x18260DAA0")]
		public void LBEJIPOGBCO<T>(Action<T> APBFEHIGAIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x4D176D0", Offset = "0x4D160D0", VA = "0x184D176D0")]
		public Component DAKLCEIBKLD(Type IEADHAAGEDA, bool CEOKFKILCAL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x23DAF30", Offset = "0x23D9930", VA = "0x1823DAF30")]
		public T DAKLCEIBKLD<T>(bool CEOKFKILCAL = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x4D17E00", Offset = "0x4D16800", VA = "0x184D17E00")]
		public IOHBDFACHAD<Component> OJHGLKGBFAE(Type IEADHAAGEDA, bool CEOKFKILCAL = false)
		{
			return default(IOHBDFACHAD<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x2409DB0", Offset = "0x24087B0", VA = "0x182409DB0")]
		public IOHBDFACHAD<T> OJHGLKGBFAE<T>(bool CEOKFKILCAL = false) where T : class
		{
			return default(IOHBDFACHAD<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x4D17950", Offset = "0x4D16350", VA = "0x184D17950")]
		public List<Component> KFBJBMBIGFG(Type IEADHAAGEDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x4D17790", Offset = "0x4D16190", VA = "0x184D17790", Slot = "4")]
		public bool Equals(ToolHierarchyCache EDIMMNEBDAA, ToolHierarchyCache MLMOIBACOIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x4D178E0", Offset = "0x4D162E0", VA = "0x184D178E0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache FBOGCDJOCBP)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public class IMBJPCKJEDI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int POIIDIEGIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private int NMFPCOAIFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private List<T> GGFOIHJNMKM;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int HEBEBONJJIP
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x2598DB0", Offset = "0x25977B0", VA = "0x182598DB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public T GOMEMKPKNPB
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x3934E20", Offset = "0x3933820", VA = "0x183934E20")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public T MLIBEHMPINM
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x3934C70", Offset = "0x3933670", VA = "0x183934C70")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public T PNBJALMDDLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x3934D90", Offset = "0x3933790", VA = "0x183934D90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x3934FA0", Offset = "0x39339A0", VA = "0x183934FA0")]
	public IMBJPCKJEDI(int POIIDIEGIKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x3934A20", Offset = "0x3933420", VA = "0x183934A20")]
	public void CEGAKGBDODP(T MLFFAKCCJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x3934DE0", Offset = "0x39337E0", VA = "0x183934DE0")]
	public void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x3934BD0", Offset = "0x39335D0", VA = "0x183934BD0")]
	public void CHKLFMAIKJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x3934F50", Offset = "0x3933950", VA = "0x183934F50")]
	public void NBMNHOPKPGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x3934F40", Offset = "0x3933940", VA = "0x183934F40")]
	public void LPKIMBJODCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class OKJCMMNOBKI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private bool PCFLFDONLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private Action APBFEHIGAIL;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public static OKJCMMNOBKI LOMFLOMAKPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x4D159A0", Offset = "0x4D143A0", VA = "0x184D159A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool LBBAFOKHDHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x5A23E0", Offset = "0x5A0DE0", VA = "0x1805A23E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7078C0", Offset = "0x7062C0", VA = "0x1807078C0")]
	public OKJCMMNOBKI(Action APBFEHIGAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x4D15980", Offset = "0x4D14380", VA = "0x184D15980")]
	public void DCGILHLCDMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x4D15980", Offset = "0x4D14380", VA = "0x184D15980", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class POLBABBDHLC
{
	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30")]
	public static void AKAHJEOPMPK(LLIMNFKAHGO BJMHHJCFFEB, string DEIBMNKNJEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class NNCJMFIPMAD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	private struct BIAFNOAKGAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public int KAFHPNHLOLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public T CKLNJLLILCL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private Dictionary<object, BIAFNOAKGAK> DKPIEMGLOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private T PJPPOOFFKAH;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public virtual T CJFOCCFLMIE
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xC17B90", Offset = "0xC16590", VA = "0x180C17B90", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x28D3B20", Offset = "0x28D2520", VA = "0x1828D3B20", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool JIIEKEKCLDM
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x28D9790", Offset = "0x28D8190", VA = "0x1828D9790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public object CLBGFENDAOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x5534B0", Offset = "0x551EB0", VA = "0x1805534B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x556540", Offset = "0x554F40", VA = "0x180556540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x28D94F0", Offset = "0x28D7EF0", VA = "0x1828D94F0")]
	public bool FJPEKBFHMIJ(T HPIAFNBPEPC, object LBAGELALLHA, int KGEFLFECBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x28D96A0", Offset = "0x28D80A0", VA = "0x1828D96A0")]
	public bool JBHAMDMNDIL(object LBAGELALLHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x28D8950", Offset = "0x28D7350", VA = "0x1828D8950")]
	public bool FIJKPMMFIIC(object LBAGELALLHA, out T HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x28D9760", Offset = "0x28D8160", VA = "0x1828D9760")]
	public void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x28D4D10", Offset = "0x28D3710", VA = "0x1828D4D10")]
	private bool CKDLHPDFMHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x28D97C0", Offset = "0x28D81C0", VA = "0x1828D97C0")]
	public NNCJMFIPMAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class LKDEAMOGDNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private Dictionary<object, float> DKPIEMGLOOK;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public float NFKICFCDEGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xC19470", Offset = "0xC17E70", VA = "0x180C19470")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xC19490", Offset = "0xC17E90", VA = "0x180C19490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x4D148D0", Offset = "0x4D132D0", VA = "0x184D148D0")]
	public void FJPEKBFHMIJ(float HPIAFNBPEPC, object LBAGELALLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x4D14A60", Offset = "0x4D13460", VA = "0x184D14A60")]
	public void JBHAMDMNDIL(object LBAGELALLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x4D14940", Offset = "0x4D13340", VA = "0x184D14940")]
	private void HHBIFMKFLHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x4D14AD0", Offset = "0x4D134D0", VA = "0x184D14AD0")]
	public LKDEAMOGDNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public sealed class LLIMNFKAHGO
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class JDMINGIOOOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly string NGNKLPAHFLF;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		private JDMINGIOOOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x7078F0", Offset = "0x7062F0", VA = "0x1807078F0")]
		public JDMINGIOOOO(string NGNKLPAHFLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x4D13DD0", Offset = "0x4D127D0", VA = "0x184D13DD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class NKCBCALJOFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		public NKCBCALJOFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x4D15480", Offset = "0x4D13E80", VA = "0x184D15480")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly HashSet<object> HPAHDKMDFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private int MPBLFJNILIK;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool BMFBMPCPNAP
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x4D14C50", Offset = "0x4D13650", VA = "0x184D14C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int HEBEBONJJIP
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x553470", Offset = "0x551E70", VA = "0x180553470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x4D14B50", Offset = "0x4D13550", VA = "0x184D14B50")]
	public bool CEGAKGBDODP(object LBAGELALLHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x4D14BD0", Offset = "0x4D135D0", VA = "0x184D14BD0")]
	public bool DFDJPGANONL(object LBAGELALLHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x4D14CC0", Offset = "0x4D136C0", VA = "0x184D14CC0")]
	public bool PNJHNNLCLCE(object LBAGELALLHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x4D14C60", Offset = "0x4D13660", VA = "0x184D14C60")]
	public void JPGOPKOJPPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x4D14D20", Offset = "0x4D13720", VA = "0x184D14D20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x4D14E90", Offset = "0x4D13890", VA = "0x184D14E90")]
	public LLIMNFKAHGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class IKHDDFHIPAJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private struct GOCMGCHBFCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public float HGAAJENFOAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public T CKLNJLLILCL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private Dictionary<object, GOCMGCHBFCK> DKPIEMGLOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private T GCLKECKMMEB;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public virtual T DJBEJHEJONF
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x1A8D7B0", Offset = "0x1A8C1B0", VA = "0x181A8D7B0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x1A8CF30", Offset = "0x1A8B930", VA = "0x181A8CF30", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public object JHKGKJJHKJH
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x552A10", Offset = "0x551410", VA = "0x180552A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x60BBE0", Offset = "0x60A5E0", VA = "0x18060BBE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool JIIEKEKCLDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x39326E0", Offset = "0x39310E0", VA = "0x1839326E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x39324A0", Offset = "0x3930EA0", VA = "0x1839324A0")]
	public bool FJPEKBFHMIJ(T HPIAFNBPEPC, object LBAGELALLHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x3932680", Offset = "0x3931080", VA = "0x183932680")]
	public bool JBHAMDMNDIL(object LBAGELALLHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x28D9760", Offset = "0x28D8160", VA = "0x1828D9760")]
	public void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x3931E30", Offset = "0x3930830", VA = "0x183931E30")]
	public bool FIJKPMMFIIC(object LBAGELALLHA, out T HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x3931300", Offset = "0x392FD00", VA = "0x183931300")]
	private bool CKDLHPDFMHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x3932720", Offset = "0x3931120", VA = "0x183932720")]
	public IKHDDFHIPAJ()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
public class LGGEBEFKHFL
{
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private static byte[] BNGJCABJHMJ;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static int DABHOAMPMJG;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static int JKHLNLJIIMI;

	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private static BigInteger DBPEINBOKAP;

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public LGGEBEFKHFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x4D14610", Offset = "0x4D13010", VA = "0x184D14610")]
	private static string OGKENCFMFPL(byte[] ODMIEFIFOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x4D142E0", Offset = "0x4D12CE0", VA = "0x184D142E0")]
	public static string KDPIBNPAHEL(byte[] MCBNAPIFOAJ, bool LELELDJDMBB)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000099")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
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
