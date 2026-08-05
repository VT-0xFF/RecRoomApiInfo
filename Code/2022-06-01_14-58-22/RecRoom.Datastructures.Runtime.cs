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
	[Cpp2IlInjected.Address(RVA = "0x8F5650", Offset = "0x8F4050", VA = "0x1808F5650")]
	public NDMHIHKEIHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4E45480", Offset = "0x4E43E80", VA = "0x184E45480")]
	public byte[] MKENIGOPKLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void NOMEMMFIDOE(IncrementalHash JGDFFEGEHJN);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6447C0", Offset = "0x6431C0", VA = "0x1806447C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E487C0", Offset = "0x4E471C0", VA = "0x184E487C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4E48780", Offset = "0x4E47180", VA = "0x184E48780")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4E48800", Offset = "0x4E47200", VA = "0x184E48800")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4E48A10", Offset = "0x4E47410", VA = "0x184E48A10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4E48980", Offset = "0x4E47380", VA = "0x184E48980")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xDFCEA0", Offset = "0xDFB8A0", VA = "0x180DFCEA0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9AB3B0", Offset = "0x9A9DB0", VA = "0x1809AB3B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4E48740", Offset = "0x4E47140", VA = "0x184E48740")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4E488F0", Offset = "0x4E472F0", VA = "0x184E488F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4E48230", Offset = "0x4E46C30", VA = "0x184E48230")]
	public void CopyBounds(SavedExtents KKPJJILPNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4E486B0", Offset = "0x4E470B0", VA = "0x184E486B0")]
	public void SetLocalSpaceBounds(Bounds BGEACEGDCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xBC58D0", Offset = "0xBC42D0", VA = "0x180BC58D0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4E486A0", Offset = "0x4E470A0", VA = "0x184E486A0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4E48260", Offset = "0x4E46C60", VA = "0x184E48260")]
	private void MOENMEPFJBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4E48470", Offset = "0x4E46E70", VA = "0x184E48470")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4E47C70", Offset = "0x4E46670", VA = "0x184E47C70")]
	public static void CalculateLocalBoundsFor(GameObject BHNNPCJCNFB, out Bounds BGEACEGDCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4E47BB0", Offset = "0x4E465B0", VA = "0x184E47BB0")]
	private static void BEDHJGMPEGN(Bounds ODMIEFIFOGP, Color HJNCMGDJMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4E486D0", Offset = "0x4E470D0", VA = "0x184E486D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x564480", Offset = "0x562E80", VA = "0x180564480")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x588BA0", Offset = "0x5875A0", VA = "0x180588BA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x567460", Offset = "0x565E60", VA = "0x180567460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "4")]
	public virtual void HCEENOMJCEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x320C820", Offset = "0x320B220", VA = "0x18320C820", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x320C360", Offset = "0x320AD60", VA = "0x18320C360", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x320CE20", Offset = "0x320B820", VA = "0x18320CE20")]
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
		[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
		public OMNKKHMNHEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3938800", Offset = "0x3937200", VA = "0x183938800")]
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
		[Cpp2IlInjected.Address(RVA = "0x564480", Offset = "0x562E80", VA = "0x180564480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x392CBA0", Offset = "0x392B5A0", VA = "0x18392CBA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x392CBD0", Offset = "0x392B5D0", VA = "0x18392CBD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x392CAF0", Offset = "0x392B4F0", VA = "0x18392CAF0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal this[TKey IPKOPOLJGIA]
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x392CB20", Offset = "0x392B520", VA = "0x18392CB20", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x392C9F0", Offset = "0x392B3F0", VA = "0x18392C9F0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x392C250", Offset = "0x392AC50", VA = "0x18392C250", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x392BBC0", Offset = "0x392A5C0", VA = "0x18392BBC0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x392B7F0", Offset = "0x392A1F0", VA = "0x18392B7F0", Slot = "14")]
	protected virtual string KKDKJCFKGBL(TKeyVal FJMNBLAAFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x392B700", Offset = "0x392A100", VA = "0x18392B700", Slot = "4")]
	public bool ContainsKey(TKey IPKOPOLJGIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x392C8E0", Offset = "0x392B2E0", VA = "0x18392C8E0", Slot = "5")]
	public bool TryGetValue(TKey IPKOPOLJGIA, out TVal HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x392B730", Offset = "0x392A130", VA = "0x18392B730", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x392B730", Offset = "0x392A130", VA = "0x18392B730", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x392C910", Offset = "0x392B310", VA = "0x18392C910")]
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
		[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
		public ABFLKBLOBNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x38D0E30", Offset = "0x38CF830", VA = "0x1838D0E30")]
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
		[Cpp2IlInjected.Address(RVA = "0x38D51F0", Offset = "0x38D3BF0", VA = "0x1838D51F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x38D5CC0", Offset = "0x38D46C0", VA = "0x1838D5CC0")]
	public IEJJNHDDFJM(float AGCBKMIFLFC, float AAHIOJOILOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x38D52F0", Offset = "0x38D3CF0", VA = "0x1838D52F0")]
	public bool IFIOCFDHKMJ(float NONCEAIIEGI, T HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x38D55B0", Offset = "0x38D3FB0", VA = "0x1838D55B0")]
	public int KABKEFDIIMM(float NONCEAIIEGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x38D5640", Offset = "0x38D4040", VA = "0x1838D5640")]
	public IEnumerable<T> NIJOFHDLPBI(float NONCEAIIEGI, [Optional] float? NACLGINJHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x38D5610", Offset = "0x38D4010", VA = "0x1838D5610")]
	public void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x38D5130", Offset = "0x38D3B30", VA = "0x1838D5130")]
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
		[Cpp2IlInjected.Address(RVA = "0x774550", Offset = "0x772F50", VA = "0x180774550")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x774620", Offset = "0x773020", VA = "0x180774620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x447ACB0", Offset = "0x44796B0", VA = "0x18447ACB0")]
	public KIKDHOGEGMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x447ABD0", Offset = "0x44795D0", VA = "0x18447ABD0")]
	public KIKDHOGEGMJ(int OCEBHFCGEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4479840", Offset = "0x4478240", VA = "0x184479840")]
	public void CEGAKGBDODP(float NONCEAIIEGI, T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x447A8E0", Offset = "0x44792E0", VA = "0x18447A8E0")]
	public void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4479B80", Offset = "0x4478580", VA = "0x184479B80")]
	public bool GPIAFHLKOIJ(float PCMPCCDMENE, float DFOBKDIMJBK, out T HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x447A0A0", Offset = "0x4478AA0", VA = "0x18447A0A0")]
	public bool IEJNICJCADA(float PCMPCCDMENE, float DFOBKDIMJBK, out T HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x447A610", Offset = "0x4479010", VA = "0x18447A610")]
	public void KCHHMOEPHIA(float PCMPCCDMENE, float DFOBKDIMJBK, List<T> HKIDJJNOKDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x447A760", Offset = "0x4479160", VA = "0x18447A760")]
	private int KHAIPGDMNGM(int KENCBHODIGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4479920", Offset = "0x4478320", VA = "0x184479920")]
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
	[Cpp2IlInjected.Address(RVA = "0x4E42930", Offset = "0x4E41330", VA = "0x184E42930", Slot = "4")]
	protected override Vector3 CKOACBJGNBE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4E42A40", Offset = "0x4E41440", VA = "0x184E42A40", Slot = "5")]
	protected override Vector3 FFBJENIJDLH(Vector3 JINPLGIOFKM, Vector3 LFEBODKGKDF, float LIKLFJCOLDP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4E429A0", Offset = "0x4E413A0", VA = "0x184E429A0", Slot = "6")]
	protected override Vector3 DDDAANLCBKM(Vector3 HPIAFNBPEPC, float LIKLFJCOLDP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4E42B00", Offset = "0x4E41500", VA = "0x184E42B00", Slot = "7")]
	protected override Vector3 MOEMPOOLPNC(Vector3 JINPLGIOFKM, Vector3 LFEBODKGKDF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4E42BB0", Offset = "0x4E415B0", VA = "0x184E42BB0", Slot = "8")]
	protected override Vector3 PPNBKFKKGMO(Vector3 JINPLGIOFKM, Vector3 LFEBODKGKDF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4E42C20", Offset = "0x4E41620", VA = "0x184E42C20")]
	public ADNCMNGFEJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ADJEMJCOCJP : global::KIKDHOGEGMJ<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4E428D0", Offset = "0x4E412D0", VA = "0x184E428D0")]
	public ADJEMJCOCJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4E42860", Offset = "0x4E41260", VA = "0x184E42860")]
	public ADJEMJCOCJP(int OCEBHFCGEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x746D40", Offset = "0x745740", VA = "0x180746D40", Slot = "4")]
	protected override float CKOACBJGNBE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4E427D0", Offset = "0x4E411D0", VA = "0x184E427D0", Slot = "5")]
	protected override float FFBJENIJDLH(float JINPLGIOFKM, float LFEBODKGKDF, float LIKLFJCOLDP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x14BCC30", Offset = "0x14BB630", VA = "0x1814BCC30", Slot = "6")]
	protected override float DDDAANLCBKM(float HPIAFNBPEPC, float LIKLFJCOLDP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x30C5D30", Offset = "0x30C4730", VA = "0x1830C5D30", Slot = "7")]
	protected override float MOEMPOOLPNC(float JINPLGIOFKM, float LFEBODKGKDF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4E42850", Offset = "0x4E41250", VA = "0x184E42850", Slot = "8")]
	protected override float PPNBKFKKGMO(float JINPLGIOFKM, float LFEBODKGKDF)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MEJGOLOPLKC
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x26951A0", Offset = "0x2693BA0", VA = "0x1826951A0")]
	public static global::ABEDILJIAPD<T1> AEEGCHIFHAD<T1>(T1 FFPLCKNOIJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x27C8620", Offset = "0x27C7020", VA = "0x1827C8620")]
	public static global::GHPCCKONNPP<T1, T2> AEEGCHIFHAD<T1, T2>(T1 FFPLCKNOIJF, T2 PFDFNGBPEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x29A7AE0", Offset = "0x29A64E0", VA = "0x1829A7AE0")]
	public static global::NIIEGAEAHFF<T1, T2, T3> AEEGCHIFHAD<T1, T2, T3>(T1 FFPLCKNOIJF, T2 PFDFNGBPEKC, T3 GJNNGGGLLFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x27C72B0", Offset = "0x27C5CB0", VA = "0x1827C72B0")]
	public static global::MMBLNDKFEMM<T1, T2, T3, T4> AEEGCHIFHAD<T1, T2, T3, T4>(T1 FFPLCKNOIJF, T2 PFDFNGBPEKC, T3 GJNNGGGLLFH, T4 LFHILNIMOAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x29A6100", Offset = "0x29A4B00", VA = "0x1829A6100")]
	public static global::LPBGDHOCHEG<T1, T2, T3, T4, T5> AEEGCHIFHAD<T1, T2, T3, T4, T5>(T1 FFPLCKNOIJF, T2 PFDFNGBPEKC, T3 GJNNGGGLLFH, T4 LFHILNIMOAL, T5 ABHMDAJFHHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2B9E950", Offset = "0x2B9D350", VA = "0x182B9E950")]
	public static global::CNFFLOJGPAG<T1, T2, T3, T4, T5, T6> AEEGCHIFHAD<T1, T2, T3, T4, T5, T6>(T1 FFPLCKNOIJF, T2 PFDFNGBPEKC, T3 GJNNGGGLLFH, T4 LFHILNIMOAL, T5 ABHMDAJFHHN, T6 KBMGLBCENKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x29A7B70", Offset = "0x29A6570", VA = "0x1829A7B70")]
	public static global::JHMNEELDOJH<T1, T2, T3, T4, T5, T6, T7> AEEGCHIFHAD<T1, T2, T3, T4, T5, T6, T7>(T1 FFPLCKNOIJF, T2 PFDFNGBPEKC, T3 GJNNGGGLLFH, T4 LFHILNIMOAL, T5 ABHMDAJFHHN, T6 KBMGLBCENKA, T7 NIEGEJPKHEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x27C8690", Offset = "0x27C7090", VA = "0x1827C8690")]
	public static global::FIGMLOCBGGD<T1, T2, T3, T4, T5, T6, T7, T8> AEEGCHIFHAD<T1, T2, T3, T4, T5, T6, T7, T8>(T1 FFPLCKNOIJF, T2 PFDFNGBPEKC, T3 GJNNGGGLLFH, T4 LFHILNIMOAL, T5 ABHMDAJFHHN, T6 KBMGLBCENKA, T7 NIEGEJPKHEH, T8 EMGLEAGCDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x24FDC70", Offset = "0x24FC670", VA = "0x1824FDC70")]
	[IteratorStateMachine(typeof(MJENGIHLDEP))]
	public static IEnumerable<global::GHPCCKONNPP<T1, T2>> IDDGEAIABPG<T1, T2>(IEnumerable<T1> MMADIBJKHHM, IEnumerable<T2> ODMIEFIFOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x269C010", Offset = "0x269AA10", VA = "0x18269C010")]
	[IteratorStateMachine(typeof(EIEKLJAKJEJ))]
	public static IEnumerable<global::NIIEGAEAHFF<T1, T2, T3>> IDDGEAIABPG<T1, T2, T3>(IEnumerable<T1> MMADIBJKHHM, IEnumerable<T2> ODMIEFIFOGP, IEnumerable<T3> HJNCMGDJMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2EF9EA0", Offset = "0x2EF88A0", VA = "0x182EF9EA0")]
	internal static int PEJKCNNAGOB(int JINCBLKDBJA, int ONCFPCCCMFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3EC5770", Offset = "0x3EC4170", VA = "0x183EC5770")]
	internal static int PEJKCNNAGOB(int JINCBLKDBJA, int ONCFPCCCMFJ, int AJKJJPBAMGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3EC5780", Offset = "0x3EC4180", VA = "0x183EC5780")]
	internal static int PEJKCNNAGOB(int JINCBLKDBJA, int ONCFPCCCMFJ, int AJKJJPBAMGM, int AGALNAMNBBM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4E46860", Offset = "0x4E45260", VA = "0x184E46860")]
	internal static int PEJKCNNAGOB(int JINCBLKDBJA, int ONCFPCCCMFJ, int AJKJJPBAMGM, int AGALNAMNBBM, int OHAPPGKFBOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4E468B0", Offset = "0x4E452B0", VA = "0x184E468B0")]
	internal static int PEJKCNNAGOB(int JINCBLKDBJA, int ONCFPCCCMFJ, int AJKJJPBAMGM, int AGALNAMNBBM, int OHAPPGKFBOF, int HBAKNGKNOJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4E468D0", Offset = "0x4E452D0", VA = "0x184E468D0")]
	internal static int PEJKCNNAGOB(int JINCBLKDBJA, int ONCFPCCCMFJ, int AJKJJPBAMGM, int AGALNAMNBBM, int OHAPPGKFBOF, int HBAKNGKNOJL, int PEPFFPKCLEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4E46880", Offset = "0x4E45280", VA = "0x184E46880")]
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
	[Cpp2IlInjected.Address(RVA = "0x178A0C0", Offset = "0x1788AC0", VA = "0x18178A0C0")]
	public ABEDILJIAPD(T1 FFPLCKNOIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3B45920", Offset = "0x3B44320", VA = "0x183B45920", Slot = "4")]
	public int CompareTo(global::ABEDILJIAPD<T1> KKPJJILPNAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3B45990", Offset = "0x3B44390", VA = "0x183B45990", Slot = "0")]
	public override bool Equals(object KKPJJILPNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x750A30", Offset = "0x74F430", VA = "0x180750A30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3B45A30", Offset = "0x3B44430", VA = "0x183B45A30", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x38B2F60", Offset = "0x38B1960", VA = "0x1838B2F60")]
	public GHPCCKONNPP(T1 FFPLCKNOIJF, T2 PFDFNGBPEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x38B1610", Offset = "0x38B0010", VA = "0x1838B1610", Slot = "4")]
	public int CompareTo(global::GHPCCKONNPP<T1, T2> KKPJJILPNAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x38B1C10", Offset = "0x38B0610", VA = "0x1838B1C10", Slot = "0")]
	public override bool Equals(object KKPJJILPNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x38B2330", Offset = "0x38B0D30", VA = "0x1838B2330", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x38B2C70", Offset = "0x38B1670", VA = "0x1838B2C70", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E08610", Offset = "0x3E07010", VA = "0x183E08610")]
	public NIIEGAEAHFF(T1 FFPLCKNOIJF, T2 PFDFNGBPEKC, T3 GJNNGGGLLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3E07F30", Offset = "0x3E06930", VA = "0x183E07F30", Slot = "4")]
	public int CompareTo(global::NIIEGAEAHFF<T1, T2, T3> KKPJJILPNAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3E08030", Offset = "0x3E06A30", VA = "0x183E08030", Slot = "0")]
	public override bool Equals(object KKPJJILPNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3E08320", Offset = "0x3E06D20", VA = "0x183E08320", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3E08390", Offset = "0x3E06D90", VA = "0x183E08390", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x178BD80", Offset = "0x178A780", VA = "0x18178BD80")]
	public MMBLNDKFEMM(T1 FFPLCKNOIJF, T2 PFDFNGBPEKC, T3 GJNNGGGLLFH, T4 LFHILNIMOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3DD5E50", Offset = "0x3DD4850", VA = "0x183DD5E50", Slot = "4")]
	public int CompareTo(global::MMBLNDKFEMM<T1, T2, T3, T4> KKPJJILPNAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3DD5F90", Offset = "0x3DD4990", VA = "0x183DD5F90", Slot = "0")]
	public override bool Equals(object KKPJJILPNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3DD60B0", Offset = "0x3DD4AB0", VA = "0x183DD60B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3DD6170", Offset = "0x3DD4B70", VA = "0x183DD6170", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x178CAC0", Offset = "0x178B4C0", VA = "0x18178CAC0")]
	public LPBGDHOCHEG(T1 FFPLCKNOIJF, T2 PFDFNGBPEKC, T3 GJNNGGGLLFH, T4 LFHILNIMOAL, T5 ABHMDAJFHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x32C2C00", Offset = "0x32C1600", VA = "0x1832C2C00", Slot = "4")]
	public int CompareTo(global::LPBGDHOCHEG<T1, T2, T3, T4, T5> KKPJJILPNAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x32C2D80", Offset = "0x32C1780", VA = "0x1832C2D80", Slot = "0")]
	public override bool Equals(object KKPJJILPNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x32C2EC0", Offset = "0x32C18C0", VA = "0x1832C2EC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x32C2FC0", Offset = "0x32C19C0", VA = "0x1832C2FC0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1792810", Offset = "0x1791210", VA = "0x181792810")]
	public CNFFLOJGPAG(T1 FFPLCKNOIJF, T2 PFDFNGBPEKC, T3 GJNNGGGLLFH, T4 LFHILNIMOAL, T5 ABHMDAJFHHN, T6 KBMGLBCENKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3E57F80", Offset = "0x3E56980", VA = "0x183E57F80", Slot = "4")]
	public int CompareTo(global::CNFFLOJGPAG<T1, T2, T3, T4, T5, T6> KKPJJILPNAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3E58140", Offset = "0x3E56B40", VA = "0x183E58140", Slot = "0")]
	public override bool Equals(object KKPJJILPNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3E582B0", Offset = "0x3E56CB0", VA = "0x183E582B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3E583D0", Offset = "0x3E56DD0", VA = "0x183E583D0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x37370D0", Offset = "0x3735AD0", VA = "0x1837370D0")]
	public JHMNEELDOJH(T1 FFPLCKNOIJF, T2 PFDFNGBPEKC, T3 GJNNGGGLLFH, T4 LFHILNIMOAL, T5 ABHMDAJFHHN, T6 KBMGLBCENKA, T7 NIEGEJPKHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3736A70", Offset = "0x3735470", VA = "0x183736A70", Slot = "4")]
	public int CompareTo(global::JHMNEELDOJH<T1, T2, T3, T4, T5, T6, T7> KKPJJILPNAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3736C70", Offset = "0x3735670", VA = "0x183736C70", Slot = "0")]
	public override bool Equals(object KKPJJILPNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3736E10", Offset = "0x3735810", VA = "0x183736E10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3736F60", Offset = "0x3735960", VA = "0x183736F60", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x3914BC0", Offset = "0x39135C0", VA = "0x183914BC0")]
	public FIGMLOCBGGD(T1 FFPLCKNOIJF, T2 PFDFNGBPEKC, T3 GJNNGGGLLFH, T4 LFHILNIMOAL, T5 ABHMDAJFHHN, T6 KBMGLBCENKA, T7 NIEGEJPKHEH, T8 EMGLEAGCDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x39144B0", Offset = "0x3912EB0", VA = "0x1839144B0", Slot = "4")]
	public int CompareTo(global::FIGMLOCBGGD<T1, T2, T3, T4, T5, T6, T7, T8> KKPJJILPNAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3914700", Offset = "0x3913100", VA = "0x183914700", Slot = "0")]
	public override bool Equals(object KKPJJILPNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x39148C0", Offset = "0x39132C0", VA = "0x1839148C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3914A30", Offset = "0x3913430", VA = "0x183914A30", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x563A10", Offset = "0x562410", VA = "0x180563A10")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x638A00", Offset = "0x637400", VA = "0x180638A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float FEKFKICLHID
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x98E8A0", Offset = "0x98D2A0", VA = "0x18098E8A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3F9E3E0", Offset = "0x3F9CDE0", VA = "0x183F9E3E0")]
	public T FNOAEHJLKJE(float LIKLFJCOLDP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3F9E580", Offset = "0x3F9CF80", VA = "0x183F9E580")]
	public T HAMJADEJKJG(float LIKLFJCOLDP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T FFBJENIJDLH(T JINPLGIOFKM, T LFEBODKGKDF, float LIKLFJCOLDP);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4E44140", Offset = "0x4E42B40", VA = "0x184E44140", Slot = "4")]
	protected override float FFBJENIJDLH(float JINPLGIOFKM, float LFEBODKGKDF, float LIKLFJCOLDP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4E441C0", Offset = "0x4E42BC0", VA = "0x184E441C0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4E49970", Offset = "0x4E48370", VA = "0x184E49970", Slot = "4")]
	protected override Vector3 FFBJENIJDLH(Vector3 JINPLGIOFKM, Vector3 LFEBODKGKDF, float LIKLFJCOLDP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4E49A30", Offset = "0x4E48430", VA = "0x184E49A30")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4E43240", Offset = "0x4E41C40", VA = "0x184E43240", Slot = "4")]
	protected override Color FFBJENIJDLH(Color JINPLGIOFKM, Color LFEBODKGKDF, float LIKLFJCOLDP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4E43290", Offset = "0x4E41C90", VA = "0x184E43290")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class HDJKPDDGDEE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly IDisposable JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	public HDJKPDDGDEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[DefaultMember("Item")]
public sealed class AHBHFGACMJH<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly MNJOJABCHIF IBEADABEDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private T[] CJNEAIJOKBO;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int HEBEBONJJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5889B0", Offset = "0x5873B0", VA = "0x1805889B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6974A0", Offset = "0x695EA0", VA = "0x1806974A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x29F1E20", Offset = "0x29F0820", VA = "0x1829F1E20")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x29F1EA0", Offset = "0x29F08A0", VA = "0x1829F1EA0")]
	public static global::AHBHFGACMJH<T> IHEMFNLEEFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x29F2070", Offset = "0x29F0A70", VA = "0x1829F2070")]
	public static global::AHBHFGACMJH<T> OAMDHNFPPAC(int POIIDIEGIKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x29F2510", Offset = "0x29F0F10", VA = "0x1829F2510")]
	private AHBHFGACMJH(T[] HCJBDDKLCHE, int POIIDIEGIKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x29F1CE0", Offset = "0x29F06E0", VA = "0x1829F1CE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x29F0F30", Offset = "0x29EF930", VA = "0x1829F0F30")]
	public void CEGAKGBDODP(in T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x29F1FD0", Offset = "0x29F09D0", VA = "0x1829F1FD0")]
	public void LLGMOJMHILP(int LGBFGOJBLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x29F13B0", Offset = "0x29EFDB0", VA = "0x1829F13B0")]
	public void COGGGHKGHDA(int OCEBHFCGEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x29F21B0", Offset = "0x29F0BB0", VA = "0x1829F21B0")]
	private void PJBHCHFGCIP(int POIIDIEGIKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class HMNBNIBPKIB
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2B9BD10", Offset = "0x2B9A710", VA = "0x182B9BD10")]
	public static global::AHBHFGACMJH<T> IHEMFNLEEFI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x234A470", Offset = "0x2348E70", VA = "0x18234A470")]
	public static global::AHBHFGACMJH<T> OAMDHNFPPAC<T>(int POIIDIEGIKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct JNDLBBMPEGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<ADCKJAHNEMI>> BFOKGHDJJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int NHGHBGICDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private int DPBCGDFIDNN;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0xCE83E0", Offset = "0xCE6DE0", VA = "0x180CE83E0")]
	private JNDLBBMPEGP(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<ADCKJAHNEMI>> MBHDBPMFIMN, int JEDNHHHPONP, int CEIPHPMCIKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4E45AD0", Offset = "0x4E444D0", VA = "0x184E45AD0")]
	public static JNDLBBMPEGP IHEMFNLEEFI()
	{
		return default(JNDLBBMPEGP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4E45860", Offset = "0x4E44260", VA = "0x184E45860")]
	public (int, int, Task) FIDFDMNAOMJ(int MFEJPJDDMMA)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4E457B0", Offset = "0x4E441B0", VA = "0x184E457B0")]
	public void AGNPANHEADC(int MFEJPJDDMMA, int CEIPHPMCIKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DefaultMember("Item")]
public class JILGKPBMAJO<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Dictionary<TKey, TVal> KLPHHKKKNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Dictionary<TVal, TKey> CBEBJAGALGB;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int HEBEBONJJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2A81630", Offset = "0x2A80030", VA = "0x182A81630", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool GLELDCPAEJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x588B90", Offset = "0x587590", VA = "0x180588B90", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public ICollection<TKey> FIMGPPJIOLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2DFE620", Offset = "0x2DFD020", VA = "0x182DFE620", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TVal> NAJHJDNPGBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2E0C3C0", Offset = "0x2E0ADC0", VA = "0x182E0C3C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public TVal INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x32C3380", Offset = "0x32C1D80", VA = "0x1832C3380", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3739530", Offset = "0x3737F30", VA = "0x183739530", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TKey INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3738F20", Offset = "0x3737920", VA = "0x183738F20")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x37391A0", Offset = "0x3737BA0", VA = "0x1837391A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3738C30", Offset = "0x3737630", VA = "0x183738C30", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x37393D0", Offset = "0x3737DD0", VA = "0x1837393D0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2CABA50", Offset = "0x2CAA450", VA = "0x182CABA50", Slot = "9")]
	public void Add(TKey IPKOPOLJGIA, TVal HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3738AE0", Offset = "0x37374E0", VA = "0x183738AE0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> LHLOAJPGJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3738C90", Offset = "0x3737690", VA = "0x183738C90", Slot = "8")]
	public bool ContainsKey(TKey IPKOPOLJGIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3738CC0", Offset = "0x37376C0", VA = "0x183738CC0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> LHLOAJPGJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3739320", Offset = "0x3737D20", VA = "0x183739320", Slot = "10")]
	public bool Remove(TKey IPKOPOLJGIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3739320", Offset = "0x3737D20", VA = "0x183739320", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> LHLOAJPGJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3739420", Offset = "0x3737E20", VA = "0x183739420", Slot = "11")]
	public bool TryGetValue(TKey IPKOPOLJGIA, out TVal HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3738F50", Offset = "0x3737950", VA = "0x183738F50", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3738D20", Offset = "0x3737720", VA = "0x183738D20", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] OBKDNKHGCJN, int MPFHIKENPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3738B40", Offset = "0x3737540", VA = "0x183738B40")]
	public void CEGAKGBDODP(TVal LFNNMJBIDMK, TKey IPKOPOLJGIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3738BF0", Offset = "0x37375F0", VA = "0x183738BF0")]
	public void CEGAKGBDODP(KeyValuePair<TVal, TKey> LHLOAJPGJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3738DB0", Offset = "0x37377B0", VA = "0x183738DB0")]
	public bool DHHOKDEFFJG(TVal IPKOPOLJGIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x328A270", Offset = "0x3288C70", VA = "0x18328A270")]
	public bool PNJHNNLCLCE(KeyValuePair<TVal, TKey> LHLOAJPGJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x32C6050", Offset = "0x32C4A50", VA = "0x1832C6050")]
	public bool DFDJPGANONL(TVal IPKOPOLJGIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x32C6050", Offset = "0x32C4A50", VA = "0x1832C6050")]
	public bool DFDJPGANONL(KeyValuePair<TVal, TKey> LHLOAJPGJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3738EF0", Offset = "0x37378F0", VA = "0x183738EF0")]
	public bool FIJKPMMFIIC(TVal IPKOPOLJGIA, out TKey HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3739270", Offset = "0x3737C70", VA = "0x183739270")]
	public IEnumerator<KeyValuePair<TVal, TKey>> PHLDJJFJBPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3739050", Offset = "0x3737A50", VA = "0x183739050")]
	private void KGHLNDLOLKI(TKey IPKOPOLJGIA, TVal LFNNMJBIDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3738DE0", Offset = "0x37377E0", VA = "0x183738DE0")]
	private void EFNMKJJJOOF(TKey IPKOPOLJGIA, TVal LFNNMJBIDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3738960", Offset = "0x3737360", VA = "0x183738960")]
	private bool AHJGLOGLDGK(TKey IPKOPOLJGIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x37388A0", Offset = "0x37372A0", VA = "0x1837388A0")]
	private bool AHJGLOGLDGK(TVal LFNNMJBIDMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3739450", Offset = "0x3737E50", VA = "0x183739450")]
	public JILGKPBMAJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class NJCCFCAFAEN<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private global::NJCCFCAFAEN<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x774550", Offset = "0x772F50", VA = "0x180774550", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x3DFD5E0", Offset = "0x3DFBFE0", VA = "0x183DFD5E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3DFD840", Offset = "0x3DFC240", VA = "0x183DFD840")]
		public Enumerator(global::NJCCFCAFAEN<T> HKIDJJNOKDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3DFD0C0", Offset = "0x3DFBAC0", VA = "0x183DFD0C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3DFD240", Offset = "0x3DFBC40", VA = "0x183DFD240", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3DFCB90", Offset = "0x3DFB590", VA = "0x183DFCB90")]
		private void JLLKHMLEHLM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private T[] OEKOKLAIABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private int KLJIMEJKFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int LAPEEJFJAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int NAGACMCOIBH;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int HEBEBONJJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3E0A770", Offset = "0x3E09170", VA = "0x183E0A770")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public T INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3E09810", Offset = "0x3E08210", VA = "0x183E09810")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3E0A6D0", Offset = "0x3E090D0", VA = "0x183E0A6D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3E0ABC0", Offset = "0x3E095C0", VA = "0x183E0ABC0")]
	public NJCCFCAFAEN(int POIIDIEGIKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3E09110", Offset = "0x3E07B10", VA = "0x183E09110")]
	public void CEGAKGBDODP(T LIKLFJCOLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3E09940", Offset = "0x3E08340", VA = "0x183E09940")]
	public void KFNDGCHILFO(IEnumerable<T> EDBHCCMMIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3E0A750", Offset = "0x3E09150", VA = "0x183E0A750")]
	public void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3E08B40", Offset = "0x3E07540", VA = "0x183E08B40")]
	public void BACKBAAEHPM(int LKEJFKMJCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3E0A910", Offset = "0x3E09310", VA = "0x183E0A910")]
	public void OOECKNIPCPL(int LKEJFKMJCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3E093D0", Offset = "0x3E07DD0", VA = "0x183E093D0")]
	public void GHNEPOMHABF(T[] OBKDNKHGCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3E0A8A0", Offset = "0x3E092A0", VA = "0x183E0A8A0")]
	public Enumerator OIGPEBHIBKC()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3E0AB20", Offset = "0x3E09520", VA = "0x183E0AB20", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3E0AB20", Offset = "0x3E09520", VA = "0x183E0AB20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3E08CC0", Offset = "0x3E076C0", VA = "0x183E08CC0")]
	private int BCDGLMHPBGM(int LGBFGOJBLFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3E0A9A0", Offset = "0x3E093A0", VA = "0x183E0A9A0")]
	private int PCEKCHLLGDG(int LGBFGOJBLFK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct JMJLIJNCAMJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly IDisposable[] CJNEAIJOKBO;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x709280", Offset = "0x707C80", VA = "0x180709280")]
	public JMJLIJNCAMJ(params IDisposable[] HCJBDDKLCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1257DC0", Offset = "0x12567C0", VA = "0x181257DC0")]
	public static JMJLIJNCAMJ IHEMFNLEEFI(params IDisposable[] HCJBDDKLCHE)
	{
		return default(JMJLIJNCAMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4E45690", Offset = "0x4E44090", VA = "0x184E45690", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct BMNIGFIILMA<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly IDisposable AKDBJOGFAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public T CKLNJLLILCL;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x29F3F70", Offset = "0x29F2970", VA = "0x1829F3F70")]
	public BMNIGFIILMA(IDisposable DADDDHJHLLC, in T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2B94D80", Offset = "0x2B93780", VA = "0x182B94D80")]
	public static global::BMNIGFIILMA<U> AIEILCDBPIK<U>(in global::BMNIGFIILMA<T> DADDDHJHLLC, in U HPIAFNBPEPC)
	{
		return default(global::BMNIGFIILMA<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x27C7380", Offset = "0x27C5D80", VA = "0x1827C7380")]
	public global::BMNIGFIILMA<U> HMKLBEBOLAK<U>(in U HPIAFNBPEPC)
	{
		return default(global::BMNIGFIILMA<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2B94DC0", Offset = "0x2B937C0", VA = "0x182B94DC0")]
	public static global::BMNIGFIILMA<(T, U)> PBNCMBAAHCI<U>(in global::BMNIGFIILMA<T> MMADIBJKHHM, in global::BMNIGFIILMA<U> ODMIEFIFOGP)
	{
		return default(global::BMNIGFIILMA<(T, U)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9100", Offset = "0x2CE7B00", VA = "0x182CE9100", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class KFKNLDALKIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2B9E110", Offset = "0x2B9CB10", VA = "0x182B9E110")]
	public static global::BMNIGFIILMA<T> IHEMFNLEEFI<T>(IDisposable DADDDHJHLLC, in T HPIAFNBPEPC)
	{
		return default(global::BMNIGFIILMA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x27C7380", Offset = "0x27C5D80", VA = "0x1827C7380")]
	public static global::BMNIGFIILMA<U> AIEILCDBPIK<U, T>(in global::BMNIGFIILMA<T> IDFCIBCAHOM, in U HPIAFNBPEPC)
	{
		return default(global::BMNIGFIILMA<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2B9E160", Offset = "0x2B9CB60", VA = "0x182B9E160")]
	public static global::BMNIGFIILMA<(T, U)> PBNCMBAAHCI<T, U>(in global::BMNIGFIILMA<T> MMADIBJKHHM, in global::BMNIGFIILMA<U> ODMIEFIFOGP)
	{
		return default(global::BMNIGFIILMA<(T, U)>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct MNJOJABCHIF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x588B90", Offset = "0x587590", VA = "0x180588B90")]
	public static MNJOJABCHIF LOLOAKHPFFF<T>([Optional] string AJECLBDJOME, [Optional] string HPPKBEOKBOH, bool NKHEFGHCICL = false)
	{
		return default(MNJOJABCHIF);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public class LLPDFMMJLIL<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Func<Internal, External> EBJJNPLJGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Func<External, Internal> OHOJALAJBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private IList<Internal> NIHCHNNEJAD;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public IList<Internal> PGIOLLNBJLM
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5644B0", Offset = "0x562EB0", VA = "0x1805644B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x567540", Offset = "0x565F40", VA = "0x180567540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool GLELDCPAEJH
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x697420", Offset = "0x695E20", VA = "0x180697420", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x92F010", Offset = "0x92DA10", VA = "0x18092F010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public External INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x32BFC60", Offset = "0x32BE660", VA = "0x1832BFC60", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x32BFD00", Offset = "0x32BE700", VA = "0x1832BFD00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int HEBEBONJJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x32BFC00", Offset = "0x32BE600", VA = "0x1832BFC00", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x32BFB70", Offset = "0x32BE570", VA = "0x1832BFB70")]
	public LLPDFMMJLIL(Func<Internal, External> EBJJNPLJGHL, Func<External, Internal> OHOJALAJBFP, bool PBLMIOJCCCI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x32BF880", Offset = "0x32BE280", VA = "0x1832BF880", Slot = "6")]
	public int IndexOf(External LHLOAJPGJBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x32BF500", Offset = "0x32BDF00", VA = "0x1832BF500", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x32BF560", Offset = "0x32BDF60", VA = "0x1832BF560", Slot = "13")]
	public bool Contains(External LHLOAJPGJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x32BF5F0", Offset = "0x32BDFF0", VA = "0x1832BF5F0", Slot = "14")]
	public void CopyTo(External[] OBKDNKHGCJN, int MPFHIKENPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x32BF410", Offset = "0x32BDE10", VA = "0x1832BF410", Slot = "11")]
	public void Add(External LHLOAJPGJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x32BF970", Offset = "0x32BE370", VA = "0x1832BF970", Slot = "7")]
	public void Insert(int LGBFGOJBLFK, External LHLOAJPGJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x32BFAE0", Offset = "0x32BE4E0", VA = "0x1832BFAE0", Slot = "15")]
	public bool Remove(External LHLOAJPGJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x32BFA10", Offset = "0x32BE410", VA = "0x1832BFA10", Slot = "8")]
	public void RemoveAt(int LGBFGOJBLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x32BF810", Offset = "0x32BE210", VA = "0x1832BF810", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2751A30", Offset = "0x2750430", VA = "0x182751A30", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class BFGCFOAHEJP<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly Func<Internal, External> EBJJNPLJGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private IReadOnlyList<Internal> NIHCHNNEJAD;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IReadOnlyList<Internal> PGIOLLNBJLM
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x567460", Offset = "0x565E60", VA = "0x180567460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool GLELDCPAEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x588CA0", Offset = "0x5876A0", VA = "0x180588CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public External INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x3BF6FC0", Offset = "0x3BF59C0", VA = "0x183BF6FC0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int HEBEBONJJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x3BF6F60", Offset = "0x3BF5960", VA = "0x183BF6F60", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x178A0C0", Offset = "0x1788AC0", VA = "0x18178A0C0")]
	public BFGCFOAHEJP(Func<Internal, External> EBJJNPLJGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3BF6F10", Offset = "0x3BF5910", VA = "0x183BF6F10")]
	public BFGCFOAHEJP(IReadOnlyList<Internal> NIHCHNNEJAD, Func<Internal, External> EBJJNPLJGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3BF6C20", Offset = "0x3BF5620", VA = "0x183BF6C20")]
	public void GHNEPOMHABF(External[] OBKDNKHGCJN, int MPFHIKENPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3BF6E40", Offset = "0x3BF5840", VA = "0x183BF6E40", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2759520", Offset = "0x2757F20", VA = "0x182759520", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[DefaultMember("Item")]
public class GIMABIOHNJM<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private IReadOnlyList<Internal> NIHCHNNEJAD;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IReadOnlyList<Internal> PGIOLLNBJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x564480", Offset = "0x562E80", VA = "0x180564480")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x588180", Offset = "0x586B80", VA = "0x180588180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool GLELDCPAEJH
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x588CA0", Offset = "0x5876A0", VA = "0x180588CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public External INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x38B3510", Offset = "0x38B1F10", VA = "0x1838B3510", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int HEBEBONJJIP
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x38B34B0", Offset = "0x38B1EB0", VA = "0x1838B34B0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x178A0C0", Offset = "0x1788AC0", VA = "0x18178A0C0")]
	public GIMABIOHNJM(IReadOnlyList<Internal> NIHCHNNEJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x38B3410", Offset = "0x38B1E10", VA = "0x1838B3410")]
	public bool PNJHNNLCLCE(External LHLOAJPGJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x38B3170", Offset = "0x38B1B70", VA = "0x1838B3170")]
	public void GHNEPOMHABF(External[] OBKDNKHGCJN, int MPFHIKENPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x38B33A0", Offset = "0x38B1DA0", VA = "0x1838B33A0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2751A30", Offset = "0x2750430", VA = "0x182751A30", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public abstract class OAGHJEALHBP
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void AFPAFNCPPJC(object[] MDAKEHNEFOP);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	protected OAGHJEALHBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public abstract class FOPPJNMOPMA<T> : OAGHJEALHBP
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	protected struct NGBFPLCLLCD
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public enum HENIEDLGEPJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public HENIEDLGEPJ IEADHAAGEDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public T APBFEHIGAIL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private int GOLHMLPFEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly bool AMILABFIICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	protected readonly bool ANANKCHONON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	protected List<T> EGBAHAAMKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private List<NGBFPLCLLCD> EBBBPJHKBFI;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool AOCNFPCEACC
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x391AC70", Offset = "0x3919670", VA = "0x18391AC70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x391ACB0", Offset = "0x39196B0", VA = "0x18391ACB0")]
	protected FOPPJNMOPMA(bool ANANKCHONON, bool AMILABFIICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x391A6B0", Offset = "0x39190B0", VA = "0x18391A6B0")]
	protected bool DCKMIAAAKEH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x391AA60", Offset = "0x3919460", VA = "0x18391AA60")]
	protected void HCLLKBIFEHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x391A8B0", Offset = "0x39192B0", VA = "0x18391A8B0")]
	protected void DKPJDNFMGOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2EE48F0", Offset = "0x2EE32F0", VA = "0x182EE48F0")]
	private static void IANCMNNBLOG<U>(ref List<U> NIHCHNNEJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x391A530", Offset = "0x3918F30", VA = "0x18391A530", Slot = "5")]
	public void CEGAKGBDODP(T APBFEHIGAIL, bool LGNKOGCKIDP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x391A750", Offset = "0x3919150", VA = "0x18391A750", Slot = "6")]
	public void DFDJPGANONL(T APBFEHIGAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x391AB40", Offset = "0x3919540", VA = "0x18391AB40")]
	public void KOBBDDIILEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface MMEFPGHPAAE
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEGAKGBDODP(Action APBFEHIGAIL, bool LGNKOGCKIDP = false);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFDJPGANONL(Action APBFEHIGAIL);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class HDFEEIPOLMP : global::FOPPJNMOPMA<Action>, MMEFPGHPAAE
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x4E45310", Offset = "0x4E43D10", VA = "0x184E45310")]
	public HDFEEIPOLMP(bool ANANKCHONON = false, bool AMILABFIICD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x4E45090", Offset = "0x4E43A90", VA = "0x184E45090")]
	public void DAJKIBHPPOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x4E45010", Offset = "0x4E43A10", VA = "0x184E45010", Slot = "4")]
	public override void AFPAFNCPPJC(object[] MDAKEHNEFOP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x4E45250", Offset = "0x4E43C50", VA = "0x184E45250")]
	public static HDFEEIPOLMP EKHKEPKDEBI(HDFEEIPOLMP LLHFMAEOJED, Action APBFEHIGAIL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x4E452B0", Offset = "0x4E43CB0", VA = "0x184E452B0")]
	public static HDFEEIPOLMP LOLOPLNMBHA(HDFEEIPOLMP LLHFMAEOJED, Action APBFEHIGAIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface EEPIKJDCGCN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEGAKGBDODP(Action<T> APBFEHIGAIL, bool LGNKOGCKIDP = false);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFDJPGANONL(Action<T> APBFEHIGAIL);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class EFMFOCNIOPF<T> : global::FOPPJNMOPMA<Action<T>>, global::EEPIKJDCGCN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC600", Offset = "0x2CEB000", VA = "0x182CEC600")]
	public EFMFOCNIOPF(bool ANANKCHONON = false, bool AMILABFIICD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x3AC3470", Offset = "0x3AC1E70", VA = "0x183AC3470")]
	public void DAJKIBHPPOA(T LIKLFJCOLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3AC1E50", Offset = "0x3AC0850", VA = "0x183AC1E50", Slot = "4")]
	public override void AFPAFNCPPJC(object[] MDAKEHNEFOP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3AC6110", Offset = "0x3AC4B10", VA = "0x183AC6110")]
	public static global::EFMFOCNIOPF<T> EKHKEPKDEBI(global::EFMFOCNIOPF<T> LLHFMAEOJED, Action<T> APBFEHIGAIL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3AC61B0", Offset = "0x3AC4BB0", VA = "0x183AC61B0")]
	public static global::EFMFOCNIOPF<T> LOLOPLNMBHA(global::EFMFOCNIOPF<T> LLHFMAEOJED, Action<T> APBFEHIGAIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface BAGPEALCKJE<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEGAKGBDODP(Action<T, U> APBFEHIGAIL, bool LGNKOGCKIDP = false);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFDJPGANONL(Action<T, U> APBFEHIGAIL);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class CJGBOLGJMCH<T, U> : global::FOPPJNMOPMA<Action<T, U>>, global::BAGPEALCKJE<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC600", Offset = "0x2CEB000", VA = "0x182CEC600")]
	public CJGBOLGJMCH(bool ANANKCHONON = false, bool AMILABFIICD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3E4E3E0", Offset = "0x3E4CDE0", VA = "0x183E4E3E0")]
	public void DAJKIBHPPOA(T LIKLFJCOLDP, U MCMCJFLBICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3E4BA70", Offset = "0x3E4A470", VA = "0x183E4BA70", Slot = "4")]
	public override void AFPAFNCPPJC(object[] MDAKEHNEFOP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3E50A00", Offset = "0x3E4F400", VA = "0x183E50A00")]
	public static global::CJGBOLGJMCH<T, U> EKHKEPKDEBI(global::CJGBOLGJMCH<T, U> LLHFMAEOJED, Action<T, U> APBFEHIGAIL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x3E50AA0", Offset = "0x3E4F4A0", VA = "0x183E50AA0")]
	public static global::CJGBOLGJMCH<T, U> LOLOPLNMBHA(global::CJGBOLGJMCH<T, U> LLHFMAEOJED, Action<T, U> APBFEHIGAIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface APDHOFAMAJN<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEGAKGBDODP(Action<T, U, V> APBFEHIGAIL, bool LGNKOGCKIDP = false);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFDJPGANONL(Action<T, U, V> APBFEHIGAIL);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class EDJDGMIOKFD<T, U, V> : global::FOPPJNMOPMA<Action<T, U, V>>, global::APDHOFAMAJN<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC600", Offset = "0x2CEB000", VA = "0x182CEC600")]
	public EDJDGMIOKFD(bool ANANKCHONON = false, bool AMILABFIICD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x3A1E810", Offset = "0x3A1D210", VA = "0x183A1E810")]
	public void DAJKIBHPPOA(T LIKLFJCOLDP, U MCMCJFLBICH, V MEFNHMKKCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3A1C6B0", Offset = "0x3A1B0B0", VA = "0x183A1C6B0", Slot = "4")]
	public override void AFPAFNCPPJC(object[] MDAKEHNEFOP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3A1F4E0", Offset = "0x3A1DEE0", VA = "0x183A1F4E0")]
	public static global::EDJDGMIOKFD<T, U, V> EKHKEPKDEBI(global::EDJDGMIOKFD<T, U, V> LLHFMAEOJED, Action<T, U, V> APBFEHIGAIL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3A1F580", Offset = "0x3A1DF80", VA = "0x183A1F580")]
	public static global::EDJDGMIOKFD<T, U, V> LOLOPLNMBHA(global::EDJDGMIOKFD<T, U, V> LLHFMAEOJED, Action<T, U, V> APBFEHIGAIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface KMCEOBKPJEJ<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEGAKGBDODP(Action<T, U, V, W> APBFEHIGAIL, bool LGNKOGCKIDP = false);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFDJPGANONL(Action<T, U, V, W> APBFEHIGAIL);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class MPOGAFMLBCJ<T, U, V, W> : global::FOPPJNMOPMA<Action<T, U, V, W>>, global::KMCEOBKPJEJ<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC600", Offset = "0x2CEB000", VA = "0x182CEC600")]
	public MPOGAFMLBCJ(bool ANANKCHONON = false, bool AMILABFIICD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3DDB640", Offset = "0x3DDA040", VA = "0x183DDB640")]
	public void DAJKIBHPPOA(T LIKLFJCOLDP, U MCMCJFLBICH, V MEFNHMKKCJN, W DECECNMMIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3DD9940", Offset = "0x3DD8340", VA = "0x183DD9940", Slot = "4")]
	public override void AFPAFNCPPJC(object[] MDAKEHNEFOP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x3DDBB70", Offset = "0x3DDA570", VA = "0x183DDBB70")]
	public static global::MPOGAFMLBCJ<T, U, V, W> EKHKEPKDEBI(global::MPOGAFMLBCJ<T, U, V, W> LLHFMAEOJED, Action<T, U, V, W> APBFEHIGAIL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3DDBC10", Offset = "0x3DDA610", VA = "0x183DDBC10")]
	public static global::MPOGAFMLBCJ<T, U, V, W> LOLOPLNMBHA(global::MPOGAFMLBCJ<T, U, V, W> LLHFMAEOJED, Action<T, U, V, W> APBFEHIGAIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface LKGLMFHDMBB<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEGAKGBDODP(Action<T, U, V, W, X> APBFEHIGAIL, bool LGNKOGCKIDP = false);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFDJPGANONL(Action<T, U, V, W, X> APBFEHIGAIL);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class FNENIKKGMKH<T, U, V, W, X> : global::FOPPJNMOPMA<Action<T, U, V, W, X>>, global::LKGLMFHDMBB<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC600", Offset = "0x2CEB000", VA = "0x182CEC600")]
	public FNENIKKGMKH(bool ANANKCHONON = false, bool AMILABFIICD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x39179A0", Offset = "0x39163A0", VA = "0x1839179A0")]
	public void DAJKIBHPPOA(T LIKLFJCOLDP, U MCMCJFLBICH, V MEFNHMKKCJN, W DECECNMMIBM, X EDIMMNEBDAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3917390", Offset = "0x3915D90", VA = "0x183917390", Slot = "4")]
	public override void AFPAFNCPPJC(object[] MDAKEHNEFOP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3917F50", Offset = "0x3916950", VA = "0x183917F50")]
	public static global::FNENIKKGMKH<T, U, V, W, X> EKHKEPKDEBI(global::FNENIKKGMKH<T, U, V, W, X> LLHFMAEOJED, Action<T, U, V, W, X> APBFEHIGAIL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3917FF0", Offset = "0x39169F0", VA = "0x183917FF0")]
	public static global::FNENIKKGMKH<T, U, V, W, X> LOLOPLNMBHA(global::FNENIKKGMKH<T, U, V, W, X> LLHFMAEOJED, Action<T, U, V, W, X> APBFEHIGAIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface BPHECDOJFPE<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEGAKGBDODP(Action<T, U, V, W, X, Y> APBFEHIGAIL, bool LGNKOGCKIDP = false);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFDJPGANONL(Action<T, U, V, W, X, Y> APBFEHIGAIL);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public sealed class KLMHJBGLJFM<T, U, V, W, X, Y> : global::FOPPJNMOPMA<Action<T, U, V, W, X, Y>>, global::BPHECDOJFPE<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC600", Offset = "0x2CEB000", VA = "0x182CEC600")]
	public KLMHJBGLJFM(bool ANANKCHONON = false, bool AMILABFIICD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x4054700", Offset = "0x4053100", VA = "0x184054700")]
	public void DAJKIBHPPOA(T LIKLFJCOLDP, U MCMCJFLBICH, V MEFNHMKKCJN, W DECECNMMIBM, X EDIMMNEBDAA, Y MLMOIBACOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x4053730", Offset = "0x4052130", VA = "0x184053730", Slot = "4")]
	public override void AFPAFNCPPJC(object[] MDAKEHNEFOP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x40549C0", Offset = "0x40533C0", VA = "0x1840549C0")]
	public static global::KLMHJBGLJFM<T, U, V, W, X, Y> EKHKEPKDEBI(global::KLMHJBGLJFM<T, U, V, W, X, Y> LLHFMAEOJED, Action<T, U, V, W, X, Y> APBFEHIGAIL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x4054A60", Offset = "0x4053460", VA = "0x184054A60")]
	public static global::KLMHJBGLJFM<T, U, V, W, X, Y> LOLOPLNMBHA(global::KLMHJBGLJFM<T, U, V, W, X, Y> LLHFMAEOJED, Action<T, U, V, W, X, Y> APBFEHIGAIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class BMFIIMFMLBD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public readonly struct HJGNGLJGBNL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly global::BMFIIMFMLBD<T> MDPHHLLBPNL;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public T CKLNJLLILCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x2CF2470", Offset = "0x2CF0E70", VA = "0x182CF2470")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x2CF2440", Offset = "0x2CF0E40", VA = "0x182CF2440", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x709280", Offset = "0x707C80", VA = "0x180709280")]
		public HJGNGLJGBNL(global::BMFIIMFMLBD<T> MDPHHLLBPNL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct BFBOLLBICHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder<HJGNGLJGBNL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public global::BMFIIMFMLBD<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2CE31C0", Offset = "0x2CE1BC0", VA = "0x182CE31C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2CE3390", Offset = "0x2CE1D90", VA = "0x182CE3390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct MBEOPKINLKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder<HJGNGLJGBNL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public global::BMFIIMFMLBD<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2CF39B0", Offset = "0x2CF23B0", VA = "0x182CF39B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2CE3390", Offset = "0x2CE1D90", VA = "0x182CE3390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly SemaphoreSlim LDANPPGPHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private T HFHPPKKIGDG;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int DDGAHPACBGA
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x2CE87A0", Offset = "0x2CE71A0", VA = "0x182CE87A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2CE8EA0", Offset = "0x2CE78A0", VA = "0x182CE8EA0")]
	public BMFIIMFMLBD(in T HFHPPKKIGDG, int FNGIIPOFJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2CE8F40", Offset = "0x2CE7940", VA = "0x182CE8F40")]
	public BMFIIMFMLBD(in T HFHPPKKIGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2CE8DC0", Offset = "0x2CE77C0", VA = "0x182CE8DC0")]
	public HJGNGLJGBNL LIKAINBBJEA()
	{
		return default(HJGNGLJGBNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2CE8D80", Offset = "0x2CE7780", VA = "0x182CE8D80")]
	public HJGNGLJGBNL LIKAINBBJEA(CancellationToken PKFOPLIPJOL)
	{
		return default(HJGNGLJGBNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2CE8940", Offset = "0x2CE7340", VA = "0x182CE8940")]
	[AsyncStateMachine(typeof(global::BMFIIMFMLBD<>.BFBOLLBICHB))]
	public Task<HJGNGLJGBNL> KFOPKMNGNFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2CE87C0", Offset = "0x2CE71C0", VA = "0x182CE87C0")]
	[AsyncStateMachine(typeof(global::BMFIIMFMLBD<>.MBEOPKINLKA))]
	public Task<HJGNGLJGBNL> KFOPKMNGNFO(CancellationToken PKFOPLIPJOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class NFDADLDEDBL
{
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x4E46D10", Offset = "0x4E45710", VA = "0x184E46D10")]
	public static global::BMFIIMFMLBD<ADCKJAHNEMI> IHEMFNLEEFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x4E46D70", Offset = "0x4E45770", VA = "0x184E46D70")]
	public static global::BMFIIMFMLBD<ADCKJAHNEMI> IHEMFNLEEFI(int FNGIIPOFJMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x26951A0", Offset = "0x2693BA0", VA = "0x1826951A0")]
	public static global::BMFIIMFMLBD<T> IHEMFNLEEFI<T>(in T HFHPPKKIGDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x29A6660", Offset = "0x29A5060", VA = "0x1829A6660")]
	public static global::BMFIIMFMLBD<T> IHEMFNLEEFI<T>(in T HFHPPKKIGDG, int FNGIIPOFJMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class FKMDDFOMGEN<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public delegate bool FONNDHCCJGC(global::FKMDDFOMGEN<T> DAMODCEKDNG);

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class JOEEJKDNOCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public global::FKMDDFOMGEN<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
		public JOEEJKDNOCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3920830", Offset = "0x391F230", VA = "0x183920830")]
		internal bool <FindNode>b__0(global::FKMDDFOMGEN<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public T AGKFJNOJGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public LinkedList<global::FKMDDFOMGEN<T>> OHMPKMLMHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public global::FKMDDFOMGEN<T> NLPIICDKEMF;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public global::FKMDDFOMGEN<T> OOLIINHPLCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x61EF90", Offset = "0x61D990", VA = "0x18061EF90")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3917160", Offset = "0x3915B60", VA = "0x183917160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool HPJALCGKKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3916550", Offset = "0x3914F50", VA = "0x183916550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool LGMHDKHGJJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3916170", Offset = "0x3914B70", VA = "0x183916170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public global::FKMDDFOMGEN<T> OOHCCBDKGIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x39164D0", Offset = "0x3914ED0", VA = "0x1839164D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x3917240", Offset = "0x3915C40", VA = "0x183917240")]
	public FKMDDFOMGEN(T COOFMNDPHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x3916F60", Offset = "0x3915960", VA = "0x183916F60")]
	public global::FKMDDFOMGEN<T> OJNFEAIHKBO(T PFBOKDIKPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x3915DA0", Offset = "0x39147A0", VA = "0x183915DA0")]
	public global::FKMDDFOMGEN<T> BFPHDILCMGH(T NPCOJEPOIJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x39161B0", Offset = "0x3914BB0", VA = "0x1839161B0")]
	public global::FKMDDFOMGEN<T> DFDJPGANONL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x3916580", Offset = "0x3914F80", VA = "0x183916580")]
	public void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x39163C0", Offset = "0x3914DC0", VA = "0x1839163C0")]
	public global::FKMDDFOMGEN<T> FAMNLOCJADO(T IPLMPKBGGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x3915A60", Offset = "0x3914460", VA = "0x183915A60")]
	public static void BBLKKMBKNOG(global::FKMDDFOMGEN<T> KOPEBHECHDF, FONNDHCCJGC BIENEBJDHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x2EE44D0", Offset = "0x2EE2ED0", VA = "0x182EE44D0")]
	public static void BBLKKMBKNOG<A>(global::FKMDDFOMGEN<T> KOPEBHECHDF, Func<global::FKMDDFOMGEN<T>, A, bool> BIENEBJDHDJ, A MANGGNPAMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x3914C90", Offset = "0x3913690", VA = "0x183914C90")]
	public static string ALBLECODCEA(global::FKMDDFOMGEN<T> KOPEBHECHDF, int FBHGCDEDLKH = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3916C50", Offset = "0x3915650", VA = "0x183916C50")]
	public static global::FKMDDFOMGEN<T> LPIBNCMAENB(global::FKMDDFOMGEN<T> KOPEBHECHDF, T CNHNGKDBGCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class JAAJCBFBODG<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public delegate Task<TResult> GNIIPNECIDE(TRequest LKGBFLLCPJC, CancellationToken PKFOPLIPJOL);

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public enum DJIIHAHOPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class MALAAOOGFMO
	{
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private const float PGCOKMDKPDE = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private TimeSpan OBFCOLELJMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int NDIJAAEPJNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public DJIIHAHOPGJ BNILFIMBNJH;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public static readonly MALAAOOGFMO GMBIDLIPEPB;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float KDFDCHGCFIL
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x2CAFB00", Offset = "0x2CAE500", VA = "0x182CAFB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public TimeSpan HDGHKJKBEGE
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x564480", Offset = "0x562E80", VA = "0x180564480")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x2CAFBE0", Offset = "0x2CAE5E0", VA = "0x182CAFBE0")]
		public MALAAOOGFMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private readonly struct FLAJFNJAMOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public readonly TRequest LKGBFLLCPJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public readonly CancellationToken PKFOPLIPJOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public readonly TaskCompletionSource<TResult> NDMLPENIOHC;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E870", Offset = "0x2C9D270", VA = "0x182C9E870")]
		public FLAJFNJAMOH(TRequest LKGBFLLCPJC, TaskCompletionSource<TResult> NDMLPENIOHC, CancellationToken PKFOPLIPJOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class CACPFEPPHIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
		public CACPFEPPHIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x2A81630", Offset = "0x2A80030", VA = "0x182A81630")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct DCLIEAFOAKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public global::JAAJCBFBODG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D180", Offset = "0x2C9BB80", VA = "0x182C9D180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class KHJOPGKGDMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public FLAJFNJAMOH req;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public global::JAAJCBFBODG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
		public KHJOPGKGDMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x2CAF720", Offset = "0x2CAE120", VA = "0x182CAF720")]
		internal void <ProcessQueue>b__0(Task<TResult> task)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly CancellationTokenSource JLIFOCMCFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<FLAJFNJAMOH> FDAPDKAHHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly MALAAOOGFMO AANBJHIBLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly GNIIPNECIDE KBAPMLFKIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Task DKOPKHNEICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int DJAEGBGILHI;

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8B20", Offset = "0x2CA7520", VA = "0x182CA8B20")]
	public JAAJCBFBODG(GNIIPNECIDE KBAPMLFKIFM, [Optional] MALAAOOGFMO AANBJHIBLKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x2CA70F0", Offset = "0x2CA5AF0", VA = "0x182CA70F0")]
	public Task<TResult> EOFLNMMKGAL(TRequest LKGBFLLCPJC, CancellationToken PKFOPLIPJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8730", Offset = "0x2CA7130", VA = "0x182CA8730")]
	private void PNGEEEOCHEJ(FLAJFNJAMOH CHMGJPIIMAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2CA7D00", Offset = "0x2CA6700", VA = "0x182CA7D00")]
	[AsyncStateMachine(typeof(global::JAAJCBFBODG<, >.DCLIEAFOAKB))]
	private Task OKILANIGHJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x2CA7810", Offset = "0x2CA6210", VA = "0x182CA7810")]
	private FLAJFNJAMOH IEDOEIGPOID()
	{
		return default(FLAJFNJAMOH);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8030", Offset = "0x2CA6A30", VA = "0x182CA8030")]
	private void PFJBOLDEICN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x2CA6E60", Offset = "0x2CA5860", VA = "0x182CA6E60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class CNMLKNGBCKF<TKey, TVal> : global::EHOMHFNHPNI<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int DMNEKGGEFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	internal Dictionary<TKey, (TVal value, int size)> EJPHIKLHEPO;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	internal override int NNOCMNOEDFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x34EDCA0", Offset = "0x34EC6A0", VA = "0x1834EDCA0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	internal int BMCHNAGKFCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x34EDCD0", Offset = "0x34EC6D0", VA = "0x1834EDCD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public override int HEBEBONJJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x34EDE90", Offset = "0x34EC890", VA = "0x1834EDE90", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x34EDEF0", Offset = "0x34EC8F0", VA = "0x1834EDEF0")]
	public CNMLKNGBCKF(int POIIDIEGIKN, [Optional] ONEALEOBFDM HLOIHOCJLCG, [Optional] IEqualityComparer<TKey> ANAKMAIDCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x34EDD70", Offset = "0x34EC770", VA = "0x1834EDD70")]
	public void NBJMDEHHCON(TKey IPKOPOLJGIA, TVal HPIAFNBPEPC, bool HPDLFBACPAH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x34EDE10", Offset = "0x34EC810", VA = "0x1834EDE10")]
	public bool NOCAHOFDGBI(TKey IPKOPOLJGIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x34ED8B0", Offset = "0x34EC2B0", VA = "0x1834ED8B0", Slot = "6")]
	public override bool FIJKPMMFIIC(TKey OAOOMIMNANF, out TVal HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x34EDA70", Offset = "0x34EC470", VA = "0x1834EDA70")]
	public bool JHGGAHLGFEA(TKey IPKOPOLJGIA, TVal HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x34ED960", Offset = "0x34EC360", VA = "0x1834ED960")]
	public bool HBMOJKIDMHB(TKey IPKOPOLJGIA, TVal HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x34EDD00", Offset = "0x34EC700", VA = "0x1834EDD00", Slot = "7")]
	public override void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x34ED810", Offset = "0x34EC210", VA = "0x1834ED810")]
	private bool CMAICGFNKAP(TKey IPKOPOLJGIA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[DefaultMember("Item")]
public class EHOMHFNHPNI<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public delegate int ONEALEOBFDM(TKey IPKOPOLJGIA, TVal HPIAFNBPEPC);

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class BEJOFLDGHMN
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public TKey OBDCJIABNIN
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x564480", Offset = "0x562E80", VA = "0x180564480")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public TVal CKLNJLLILCL
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x82D430", Offset = "0x82BE30", VA = "0x18082D430")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x927070", Offset = "0x925A70", VA = "0x180927070")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public int PFFOPFIKBNG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x86C660", Offset = "0x86B060", VA = "0x18086C660")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public DateTime BKGAMKIAOKB
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x5644B0", Offset = "0x562EB0", VA = "0x1805644B0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x8CF470", Offset = "0x8CDE70", VA = "0x1808CF470")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3AC0CC0", Offset = "0x3ABF6C0", VA = "0x183AC0CC0")]
		public BEJOFLDGHMN(TKey IPKOPOLJGIA, TVal LFNNMJBIDMK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public const int HCGKEAJGEDI = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly Dictionary<TKey, LinkedListNode<BEJOFLDGHMN>> NKMJGHAKGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly LinkedList<BEJOFLDGHMN> FFHOCBMIKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	protected readonly ONEALEOBFDM HLOIHOCJLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly TimeSpan CMKGOEEMHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly MJDCPLJHNAK EHMANLPBDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int OOKHCKJPCAE;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int ILJLAIEKJNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x563A00", Offset = "0x562400", VA = "0x180563A00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private bool DKOIPFMOBBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3AC9440", Offset = "0x3AC7E40", VA = "0x183AC9440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	internal virtual int NNOCMNOEDFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7A8830", Offset = "0x7A7230", VA = "0x1807A8830", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private int LKEJFKMJCND
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x29F2890", Offset = "0x29F1290", VA = "0x1829F2890")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public virtual int HEBEBONJJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2751B20", Offset = "0x2750520", VA = "0x182751B20", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<TKey> FIMGPPJIOLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3AC8530", Offset = "0x3AC6F30", VA = "0x183AC8530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public TVal INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x31E9640", Offset = "0x31E8040", VA = "0x1831E9640")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3A16A50", Offset = "0x3A15450", VA = "0x183A16A50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3AC9B20", Offset = "0x3AC8520", VA = "0x183AC9B20")]
	public EHOMHFNHPNI(int POIIDIEGIKN, [Optional] ONEALEOBFDM HLOIHOCJLCG, [Optional] IEqualityComparer<TKey> ANAKMAIDCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3AC9630", Offset = "0x3AC8030", VA = "0x183AC9630")]
	public EHOMHFNHPNI(TimeSpan CMKGOEEMHHN, [Optional] IEqualityComparer<TKey> ANAKMAIDCCF, [Optional] MJDCPLJHNAK EHMANLPBDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3AC9BF0", Offset = "0x3AC85F0", VA = "0x183AC9BF0")]
	public EHOMHFNHPNI(int POIIDIEGIKN, TimeSpan CMKGOEEMHHN, [Optional] IEqualityComparer<TKey> ANAKMAIDCCF, [Optional] MJDCPLJHNAK EHMANLPBDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3AC98D0", Offset = "0x3AC82D0", VA = "0x183AC98D0")]
	public EHOMHFNHPNI(int POIIDIEGIKN, ONEALEOBFDM HLOIHOCJLCG, TimeSpan CMKGOEEMHHN, [Optional] IEqualityComparer<TKey> ANAKMAIDCCF, [Optional] MJDCPLJHNAK EHMANLPBDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3AC9150", Offset = "0x3AC7B50", VA = "0x183AC9150")]
	public void NCCPJCEHNKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3AC8250", Offset = "0x3AC6C50", VA = "0x183AC8250")]
	public void DDDJGAONDCK(TKey IPKOPOLJGIA, TVal HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x3AC83D0", Offset = "0x3AC6DD0", VA = "0x183AC83D0")]
	public bool DFDJPGANONL(TKey IPKOPOLJGIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x3AC9580", Offset = "0x3AC7F80", VA = "0x183AC9580")]
	private TVal POIAOKDLGFC(TKey OAOOMIMNANF)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3AC8BF0", Offset = "0x3AC75F0", VA = "0x183AC8BF0", Slot = "6")]
	public virtual bool FIJKPMMFIIC(TKey OAOOMIMNANF, out TVal HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3AC90E0", Offset = "0x3AC7AE0", VA = "0x183AC90E0", Slot = "7")]
	public virtual void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x3AC9380", Offset = "0x3AC7D80", VA = "0x183AC9380")]
	private bool OFFKEHMMALG(BEJOFLDGHMN HLAAHLMNEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x3AC8020", Offset = "0x3AC6A20", VA = "0x183AC8020")]
	private void CMEGALEBIDI(LinkedListNode<BEJOFLDGHMN> PGGKCJCJBKK, TVal ILHPBMJBADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x3AC8D40", Offset = "0x3AC7740", VA = "0x183AC8D40")]
	private void FJPEKBFHMIJ(TKey IPKOPOLJGIA, TVal HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x3AC8750", Offset = "0x3AC7150", VA = "0x183AC8750")]
	private void FCJHJCAGDKA(BEJOFLDGHMN HLAAHLMNEHK, TVal ILHPBMJBADK, int EFBBJJEALLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[DefaultMember("Item")]
public class IKDDBLPOFHI<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly List<T> NIHCHNNEJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private HashSet<T> LLLAJNBPKPH;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int HEBEBONJJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x2A81630", Offset = "0x2A80030", VA = "0x182A81630", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool GLELDCPAEJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x588B90", Offset = "0x587590", VA = "0x180588B90", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public T INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x320FFB0", Offset = "0x320E9B0", VA = "0x18320FFB0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x33C8EE0", Offset = "0x33C78E0", VA = "0x1833C8EE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x32C6960", Offset = "0x32C5360", VA = "0x1832C6960", Slot = "11")]
	public void Add(T LHLOAJPGJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x33C8A80", Offset = "0x33C7480", VA = "0x1833C8A80")]
	public bool JPOPBPNIDEA(T LHLOAJPGJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x33C8D80", Offset = "0x33C7780", VA = "0x1833C8D80", Slot = "15")]
	public bool Remove(T LHLOAJPGJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x33C87C0", Offset = "0x33C71C0", VA = "0x1833C87C0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x274B380", Offset = "0x2749D80", VA = "0x18274B380", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x33C8590", Offset = "0x33C6F90", VA = "0x1833C8590", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x17066D0", Offset = "0x17050D0", VA = "0x1817066D0", Slot = "13")]
	public bool Contains(T LHLOAJPGJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x33C85F0", Offset = "0x33C6FF0", VA = "0x1833C85F0", Slot = "14")]
	public void CopyTo(T[] OBKDNKHGCJN, int MPFHIKENPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x32C3380", Offset = "0x32C1D80", VA = "0x1832C3380", Slot = "6")]
	public int IndexOf(T LHLOAJPGJBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x33C8910", Offset = "0x33C7310", VA = "0x1833C8910", Slot = "7")]
	public void Insert(int LGBFGOJBLFK, T LHLOAJPGJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x33C8C20", Offset = "0x33C7620", VA = "0x1833C8C20", Slot = "8")]
	public void RemoveAt(int LGBFGOJBLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x33C8620", Offset = "0x33C7020", VA = "0x1833C8620")]
	public void FFEHNBFGLLA(Predicate<T> CGPELKGLDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x33C8B20", Offset = "0x33C7520", VA = "0x1833C8B20")]
	public void LGPDEMIOEJH(Comparison<T> LGKIPMEPCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x33C8E00", Offset = "0x33C7800", VA = "0x1833C8E00")]
	public IKDDBLPOFHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class NCHFFAENNCI
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x4E46A80", Offset = "0x4E45480", VA = "0x184E46A80")]
	public static Vector3 IEPBPNLNDEK(this GameObject BHNNPCJCNFB, float FIPIOFKIBPB)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x645310", Offset = "0x643D10", VA = "0x180645310")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x4E48F50", Offset = "0x4E47950", VA = "0x184E48F50")]
		public SerializedGuid(in Guid IJPINJFFNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x4E48AA0", Offset = "0x4E474A0", VA = "0x184E48AA0")]
		public static SerializedGuid ACIEFMALEED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4E48B50", Offset = "0x4E47550", VA = "0x184E48B50")]
		public static SerializedGuid DONNEDEOHHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4E48D60", Offset = "0x4E47760", VA = "0x184E48D60")]
		public bool HKNLOOJMFOE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x4E48F20", Offset = "0x4E47920", VA = "0x184E48F20", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x4E48E80", Offset = "0x4E47880", VA = "0x184E48E80", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x4E48DF0", Offset = "0x4E477F0", VA = "0x184E48DF0")]
		public bool IAMAEONCFGH(in Guid IJPINJFFNJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x4E48BD0", Offset = "0x4E475D0", VA = "0x184E48BD0", Slot = "7")]
		public bool Equals(SerializedGuid KKPJJILPNAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x4E48C70", Offset = "0x4E47670", VA = "0x184E48C70", Slot = "0")]
		public override bool Equals(object FBOGCDJOCBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x4E48D50", Offset = "0x4E47750", VA = "0x184E48D50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x4E48B20", Offset = "0x4E47520", VA = "0x184E48B20", Slot = "6")]
		public int CompareTo(SerializedGuid KKPJJILPNAL)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class HEIEJPMKMBB : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly Type EHFELMDBEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly string FOKCFDOMJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly bool EOJAHGJOGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly bool DHCACCHAFNO;

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x4E453D0", Offset = "0x4E43DD0", VA = "0x184E453D0")]
	public HEIEJPMKMBB(Type LKCENAOIOHO, string HCMHMEJDPIG, bool JFHKOLGCPCE = false, bool MGCENBNJHEG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface HMLPCDLPGDP
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface AJDDGEMIOCA<T> : HMLPCDLPGDP
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	T CKLNJLLILCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool EOIOGMFEFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string CIPMJFEKLJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::AJDDGEMIOCA<T> NCKBIGIMKDH(Action<T> PDEOFMMKBJH);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::AJDDGEMIOCA<T> BBABFNPDLEB(Action<T> PDEOFMMKBJH);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::AJDDGEMIOCA<T> KCDNCIPKEIA(Action<T, T> PKHOIKPNDLP);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::AJDDGEMIOCA<T> EFHNBPIIHGA(Action<T, T> PKHOIKPNDLP);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::AJDDGEMIOCA<T> JNIFGHJLPCA(Action<string> FALGENLGNBH);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::AJDDGEMIOCA<T> DJHBAHMPKGK(Action<string> FALGENLGNBH);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class EHLDODKPGJO<T> : global::AJDDGEMIOCA<T>, HMLPCDLPGDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private global::CJGBOLGJMCH<T, T> EOGDHEELMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private global::EFMFOCNIOPF<T> PHLHMAAFAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private global::EFMFOCNIOPF<string> LFJMGPOHBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private string EPHLCEKHMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private T HEMKPPOPDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private bool MOJEPLADPIO;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public T CKLNJLLILCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x563A10", Offset = "0x562410", VA = "0x180563A10", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x31EA3E0", Offset = "0x31E8DE0", VA = "0x1831EA3E0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool EOIOGMFEFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x698340", Offset = "0x696D40", VA = "0x180698340", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public string CIPMJFEKLJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x564490", Offset = "0x562E90", VA = "0x180564490", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x2CAB580", Offset = "0x2CA9F80", VA = "0x182CAB580", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x3AC7B80", Offset = "0x3AC6580", VA = "0x183AC7B80")]
	private void LGLLPEPAAFA(T KJNOHPBJPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x3AC7AE0", Offset = "0x3AC64E0", VA = "0x183AC7AE0")]
	private void KDLEFNHLIPC(string OLLHPIFFHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x3AC78E0", Offset = "0x3AC62E0", VA = "0x183AC78E0")]
	public void HEPELHGAALN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x3AC7A90", Offset = "0x3AC6490", VA = "0x183AC7A90", Slot = "6")]
	public global::AJDDGEMIOCA<T> KCDNCIPKEIA(Action<T, T> PKHOIKPNDLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x3AC7890", Offset = "0x3AC6290", VA = "0x183AC7890", Slot = "7")]
	public global::AJDDGEMIOCA<T> EFHNBPIIHGA(Action<T, T> PKHOIKPNDLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x3AC7C20", Offset = "0x3AC6620", VA = "0x183AC7C20", Slot = "4")]
	public global::AJDDGEMIOCA<T> NCKBIGIMKDH(Action<T> PKHOIKPNDLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x3AC7760", Offset = "0x3AC6160", VA = "0x183AC7760", Slot = "5")]
	public global::AJDDGEMIOCA<T> BBABFNPDLEB(Action<T> PDEOFMMKBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x3AC7990", Offset = "0x3AC6390", VA = "0x183AC7990", Slot = "8")]
	public global::AJDDGEMIOCA<T> JNIFGHJLPCA(Action<string> FALGENLGNBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x3AC77B0", Offset = "0x3AC61B0", VA = "0x183AC77B0", Slot = "9")]
	public global::AJDDGEMIOCA<T> DJHBAHMPKGK(Action<string> FALGENLGNBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x3AC7CB0", Offset = "0x3AC66B0", VA = "0x183AC7CB0")]
	public EHLDODKPGJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class DPNNEEOOHJB
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class MAAEPAFBMII<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public global::AJDDGEMIOCA<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public global::EJMKJFHGFHJ<T> promise;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
		public MAAEPAFBMII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3A20F40", Offset = "0x3A1F940", VA = "0x183A20F40")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x27C1820", Offset = "0x27C0220", VA = "0x1827C1820")]
	public static global::HJGFLNHHJHD<T> DKBJHMNMNDE<T>(this global::AJDDGEMIOCA<T> KNDDGGHPOPB, Action<T> JJBCELLHKLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public sealed class BDMELKPFPFB : global::CIKPINAHPPA<string>
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class ICOOCJODALO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public Action<BDMELKPFPFB> callback;

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public ICOOCJODALO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x4E45560", Offset = "0x4E43F60", VA = "0x184E45560")]
		internal void <Wrap>b__0(global::CIKPINAHPPA<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x4E42F10", Offset = "0x4E41910", VA = "0x184E42F10")]
	public BDMELKPFPFB([Optional] int? CKKEAPFCOIE, [Optional] Stopwatch EIKNFKKDNND, [Optional] Action<string, KMPLHNMKPLC> FCBGEGMPBKK, [Optional] Action<string, KMPLHNMKPLC> ACBJDCLEHDD, [Optional] Action<BDMELKPFPFB> BFHJIKIPKNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x4E42CE0", Offset = "0x4E416E0", VA = "0x184E42CE0")]
	private static Action<global::CIKPINAHPPA<string>> BOIGEHOOIIL(Action<BDMELKPFPFB> JJBCELLHKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x4E42DA0", Offset = "0x4E417A0", VA = "0x184E42DA0")]
	public static global::ELGBDNPDGLF<BDMELKPFPFB, string> MPOEGGNDFEJ(BDMELKPFPFB IHHDBHELEOM, [Optional] Action<BDMELKPFPFB> NEEKHBHNCAG)
	{
		return default(global::ELGBDNPDGLF<BDMELKPFPFB, string>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class CIKPINAHPPA<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private class FFMEPJFKDIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public TKey OBDCJIABNIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public KMPLHNMKPLC EDCGFIBMAHJ;

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
		public FFMEPJFKDIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public readonly struct KMPLHNMKPLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public readonly long GPINJOAMPBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public readonly long IJBOCKEINAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public readonly int CKKEAPFCOIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public readonly int DEFDEPBOKGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public readonly bool LFOKCGBAGCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly string IENHHCKNEID;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3E5A210", Offset = "0x3E58C10", VA = "0x183E5A210")]
		public KMPLHNMKPLC(long GPINJOAMPBN, int CKKEAPFCOIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3E5A280", Offset = "0x3E58C80", VA = "0x183E5A280")]
		public KMPLHNMKPLC(long GPINJOAMPBN, long IJBOCKEINAM, int CKKEAPFCOIE, int DEFDEPBOKGO, bool LFOKCGBAGCN, string IENHHCKNEID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3E5A0E0", Offset = "0x3E58AE0", VA = "0x183E5A0E0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void JJLAPKIHBPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3E5A1C0", Offset = "0x3E58BC0", VA = "0x183E5A1C0")]
		public int MBCIHMCEHEP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x3E5A0C0", Offset = "0x3E58AC0", VA = "0x183E5A0C0")]
		public int FDLJKABBAKE(int PINIDMLAFGJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3E5A150", Offset = "0x3E58B50", VA = "0x183E5A150")]
		public double KELCKDEJCPG()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x3E5A000", Offset = "0x3E58A00", VA = "0x183E5A000")]
		public KMPLHNMKPLC BDACELIKFNL(long IJBOCKEINAM, int DEFDEPBOKGO)
		{
			return default(KMPLHNMKPLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public readonly struct NGLMAFJFDEM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly global::CIKPINAHPPA<TKey> IHHDBHELEOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly TKey IPKOPOLJGIA;

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x3E5BCA0", Offset = "0x3E5A6A0", VA = "0x183E5BCA0")]
		internal NGLMAFJFDEM(global::CIKPINAHPPA<TKey> IHHDBHELEOM, TKey IPKOPOLJGIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3E5BC00", Offset = "0x3E5A600", VA = "0x183E5BC00", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class FAKLOJMMOFD : IEnumerable<(TKey, List<TKey>, KMPLHNMKPLC)>, IEnumerable, IEnumerator<(TKey, List<TKey>, KMPLHNMKPLC)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private (TKey key, List<TKey> path, KMPLHNMKPLC timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::CIKPINAHPPA<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private HashSet<FFMEPJFKDIE>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private IEnumerator<(TKey key, List<TKey> path, KMPLHNMKPLC timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		private (TKey, List<TKey>, KMPLHNMKPLC) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x3C44040", Offset = "0x3C42A40", VA = "0x183C44040", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, KMPLHNMKPLC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x3E58940", Offset = "0x3E57340", VA = "0x183E58940", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x3E497B0", Offset = "0x3E481B0", VA = "0x183E497B0")]
		[DebuggerHidden]
		public FAKLOJMMOFD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x3E589A0", Offset = "0x3E573A0", VA = "0x183E589A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3E58520", Offset = "0x3E56F20", VA = "0x183E58520", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3E58A70", Offset = "0x3E57470", VA = "0x183E58A70")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3E58B70", Offset = "0x3E57570", VA = "0x183E58B70")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x3E588F0", Offset = "0x3E572F0", VA = "0x183E588F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x3E58830", Offset = "0x3E57230", VA = "0x183E58830", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, KMPLHNMKPLC)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3B45C60", Offset = "0x3B44660", VA = "0x183B45C60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class BIEMIDPILOG : IEnumerable<(TKey, List<TKey>, KMPLHNMKPLC)>, IEnumerable, IEnumerator<(TKey, List<TKey>, KMPLHNMKPLC)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private (TKey key, List<TKey> path, KMPLHNMKPLC timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private FFMEPJFKDIE timerStackEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public FFMEPJFKDIE <>3__timerStackEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public global::CIKPINAHPPA<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private HashSet<FFMEPJFKDIE>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private IEnumerator<(TKey key, List<TKey> path, KMPLHNMKPLC timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		private (TKey, List<TKey>, KMPLHNMKPLC) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x3C44040", Offset = "0x3C42A40", VA = "0x183C44040", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, KMPLHNMKPLC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x3E49520", Offset = "0x3E47F20", VA = "0x183E49520", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3E497B0", Offset = "0x3E481B0", VA = "0x183E497B0")]
		[DebuggerHidden]
		public BIEMIDPILOG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x3E49580", Offset = "0x3E47F80", VA = "0x183E49580", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x3E48F40", Offset = "0x3E47940", VA = "0x183E48F40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x3E49650", Offset = "0x3E48050", VA = "0x183E49650")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x3E49760", Offset = "0x3E48160", VA = "0x183E49760")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x3E494D0", Offset = "0x3E47ED0", VA = "0x183E494D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x3E493F0", Offset = "0x3E47DF0", VA = "0x183E493F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, KMPLHNMKPLC)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x31FD170", Offset = "0x31FBB70", VA = "0x1831FD170", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly Action<TKey, KMPLHNMKPLC> FCBGEGMPBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly Action<TKey, KMPLHNMKPLC> ACBJDCLEHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Action<global::CIKPINAHPPA<TKey>> BFHJIKIPKNA;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private const string CBBFGCPMILK = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly HashSet<FFMEPJFKDIE> MLNDNICGMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly Dictionary<FFMEPJFKDIE, HashSet<FFMEPJFKDIE>> EFMPCAFJHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly Stack<FFMEPJFKDIE> IDCKHBCOOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private bool NPBJPMMAPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private int OMJAGCLGKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly Stopwatch EIKNFKKDNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public readonly int APDDIOCPMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private string KAGNILJHNJL;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[NotNull]
	public string CCEHGJJCCIE
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x599EB0", Offset = "0x5988B0", VA = "0x180599EB0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x3E4A2F0", Offset = "0x3E48CF0", VA = "0x183E4A2F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public long AKBFAGMAPGH
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3E4A000", Offset = "0x3E48A00", VA = "0x183E4A000")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public int BDDILHKFDFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3E49B00", Offset = "0x3E48500", VA = "0x183E49B00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x3E4A350", Offset = "0x3E48D50", VA = "0x183E4A350")]
	public CIKPINAHPPA([Optional] int? CKKEAPFCOIE, [Optional][CanBeNull] Stopwatch EIKNFKKDNND, [Optional] Action<TKey, KMPLHNMKPLC> FCBGEGMPBKK, [Optional] Action<TKey, KMPLHNMKPLC> ACBJDCLEHDD, [Optional] Action<global::CIKPINAHPPA<TKey>> BFHJIKIPKNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x3E49E40", Offset = "0x3E48840", VA = "0x183E49E40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x3E4A180", Offset = "0x3E48B80", VA = "0x183E4A180")]
	public void MLNBNOFGFDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x3E49EB0", Offset = "0x3E488B0", VA = "0x183E49EB0")]
	public void GKHGIBGCNLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x3E4A1A0", Offset = "0x3E48BA0", VA = "0x183E4A1A0")]
	public static global::ELGBDNPDGLF<global::CIKPINAHPPA<TKey>, TKey> MPOEGGNDFEJ(global::CIKPINAHPPA<TKey> IHHDBHELEOM, [Optional] Action<global::CIKPINAHPPA<TKey>> NEEKHBHNCAG)
	{
		return default(global::ELGBDNPDGLF<global::CIKPINAHPPA<TKey>, TKey>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x3E4A020", Offset = "0x3E48A20", VA = "0x183E4A020")]
	[IteratorStateMachine(typeof(global::CIKPINAHPPA<>.FAKLOJMMOFD))]
	public IEnumerable<(TKey, List<TKey>, KMPLHNMKPLC)> MBOHMHNDMJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x3E4A0B0", Offset = "0x3E48AB0", VA = "0x183E4A0B0")]
	[IteratorStateMachine(typeof(global::CIKPINAHPPA<>.BIEMIDPILOG))]
	private IEnumerable<(TKey, List<TKey>, KMPLHNMKPLC)> MBOHMHNDMJF(List<TKey> JAFIMCJAMAD, FFMEPJFKDIE PGKNHLNCDBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x3E498D0", Offset = "0x3E482D0", VA = "0x183E498D0")]
	private (long, int) BGCNGHINFIM()
	{
		return default((long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x3E49B30", Offset = "0x3E48530", VA = "0x183E49B30")]
	public void DJHPELOMNGC(TKey IPKOPOLJGIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x3E49ED0", Offset = "0x3E488D0", VA = "0x183E49ED0")]
	public void LGPMIICFCKN(TKey IPKOPOLJGIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x3E49960", Offset = "0x3E48360", VA = "0x183E49960")]
	public void BOIGEHOOIIL(TKey IPKOPOLJGIA, Action APBFEHIGAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x2933730", Offset = "0x2932130", VA = "0x182933730")]
	public T BOIGEHOOIIL<T>(TKey IPKOPOLJGIA, Func<T> IAMHMHMHKFB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x3070F00", Offset = "0x306F900", VA = "0x183070F00")]
	[AsyncStateMachine(typeof(JJMCMABCPMB))]
	public Task<T> MHILLGIIHPA<T>(TKey IPKOPOLJGIA, Func<Task<T>> IAMHMHMHKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x3E497F0", Offset = "0x3E481F0", VA = "0x183E497F0")]
	public NGLMAFJFDEM AGDFAPGGCIO(TKey IPKOPOLJGIA)
	{
		return default(NGLMAFJFDEM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct ELGBDNPDGLF<T, TKey> : IDisposable where T : global::CIKPINAHPPA<TKey>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly bool JHCMKCODHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly T IHHDBHELEOM;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public T MLFMKCDNDNP
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x764B00", Offset = "0x763500", VA = "0x180764B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x3929260", Offset = "0x3927C60", VA = "0x183929260")]
	internal ELGBDNPDGLF(T IHHDBHELEOM, bool JHCMKCODHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x39291D0", Offset = "0x3927BD0", VA = "0x1839291D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class OCPLHCAGMHH<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut FMPBBBKDFKF(global::CIKPINAHPPA<TKey> IHHDBHELEOM);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
	protected OCPLHCAGMHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class NPMCAFHAEOP<TKey> : global::OCPLHCAGMHH<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public delegate string EMFEADAJKEJ(TKey IPKOPOLJGIA);

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x43B0420", Offset = "0x43AEE20", VA = "0x1843B0420")]
	protected string JBPLDEDDIFM(double IEOCOFCFPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x43B0390", Offset = "0x43AED90", VA = "0x1843B0390")]
	protected string GAGALOJMCGK(int PLHALJEPLKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x43B03E0", Offset = "0x43AEDE0", VA = "0x1843B03E0")]
	private static string GDIFJNCLMGI(TKey IPKOPOLJGIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x43B02E0", Offset = "0x43AECE0", VA = "0x1843B02E0", Slot = "4")]
	public override string FMPBBBKDFKF(global::CIKPINAHPPA<TKey> IHHDBHELEOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x43B01C0", Offset = "0x43AEBC0", VA = "0x1843B01C0")]
	public string FMPBBBKDFKF(global::CIKPINAHPPA<TKey> IHHDBHELEOM, [NotNull] EMFEADAJKEJ DKEFNAPJDHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string PIKNDBAFIBA(global::CIKPINAHPPA<TKey> IHHDBHELEOM, [NotNull] EMFEADAJKEJ DKEFNAPJDHP);

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x2751A30", Offset = "0x2750430", VA = "0x182751A30")]
	protected NPMCAFHAEOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class BMOJLENLFJF<TKey> : global::OCPLHCAGMHH<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public delegate string EOKLMFNGCHL(TKey IPKOPOLJGIA);

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private const int JEAHCNBBGJP = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly string NHGGGNNMHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly double IEAAMPHLLKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly bool EAHEOAAJAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly int MGINLMLMNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly ISet<string> POMCCMKJPFB;

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9BE0", Offset = "0x2CE85E0", VA = "0x182CE9BE0")]
	private static string GDIFJNCLMGI(TKey IPKOPOLJGIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9C20", Offset = "0x2CE8620", VA = "0x182CE9C20")]
	public BMOJLENLFJF(string NHGGGNNMHCI = "F2", double IEAAMPHLLKJ = double.MaxValue, bool EAHEOAAJAHL = false, int MGINLMLMNLC = int.MaxValue, [Optional] ISet<string> POMCCMKJPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9B30", Offset = "0x2CE8530", VA = "0x182CE9B30", Slot = "4")]
	public override Dictionary<string, string> FMPBBBKDFKF(global::CIKPINAHPPA<TKey> IHHDBHELEOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9600", Offset = "0x2CE8000", VA = "0x182CE9600")]
	private bool EMBLLIAIKLP(string DALKDGFLIAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x2CE96E0", Offset = "0x2CE80E0", VA = "0x182CE96E0")]
	public Dictionary<string, string> FMPBBBKDFKF(global::CIKPINAHPPA<TKey> IHHDBHELEOM, EOKLMFNGCHL DKEFNAPJDHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9450", Offset = "0x2CE7E50", VA = "0x182CE9450")]
	private string EFLEPNCNAOF(StringBuilder DHPHDMKONME, List<TKey> KPJLLKKPLPO, EOKLMFNGCHL DKEFNAPJDHP, bool FJBBBGADJGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x2CE92F0", Offset = "0x2CE7CF0", VA = "0x182CE92F0")]
	private static void DCIGFIEMKAO(StringBuilder GFGMEANDODP, string IDDFNIHHNAD, bool OKODPMCACHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class OIDECEHDLIG<TKey> : global::NPMCAFHAEOP<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct KAMCLNNBKFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public EMFEADAJKEJ keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static global::OIDECEHDLIG<TKey> JMMDLCEKNJL;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const int IBGEFHLENFE = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly string[] HIMDKPCFJEK;

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x28F5BA0", Offset = "0x28F45A0", VA = "0x1828F5BA0")]
	private OIDECEHDLIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x28F4C80", Offset = "0x28F3680", VA = "0x1828F4C80", Slot = "5")]
	protected override string PIKNDBAFIBA(global::CIKPINAHPPA<TKey> IHHDBHELEOM, EMFEADAJKEJ DKEFNAPJDHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x28F4BA0", Offset = "0x28F35A0", VA = "0x1828F4BA0")]
	[CompilerGenerated]
	internal static string HDENHKKACIB(string CDNPHMCBJCP, TKey IPKOPOLJGIA, ref KAMCLNNBKFH P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class JPJEOEDLJAP<TKey> : global::NPMCAFHAEOP<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class MHEILMMHKDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public EMFEADAJKEJ keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
		public MHEILMMHKDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x390D000", Offset = "0x390BA00", VA = "0x18390D000")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x46AD2D0", Offset = "0x46ABCD0", VA = "0x1846AD2D0", Slot = "5")]
	protected override string PIKNDBAFIBA(global::CIKPINAHPPA<TKey> IHHDBHELEOM, EMFEADAJKEJ DKEFNAPJDHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x3B45C60", Offset = "0x3B44660", VA = "0x183B45C60")]
	public JPJEOEDLJAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public abstract class MJDCPLJHNAK
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private class BNKGIIAGIFE : MJDCPLJHNAK
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static MJDCPLJHNAK JMMDLCEKNJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x4E43080", Offset = "0x4E41A80", VA = "0x184E43080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public override DateTime MPDMEOHKEAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x4E430E0", Offset = "0x4E41AE0", VA = "0x184E430E0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override float KPLIEDHLNOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x4E43130", Offset = "0x4E41B30", VA = "0x184E43130", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x4E431E0", Offset = "0x4E41BE0", VA = "0x184E431E0")]
		public BNKGIIAGIFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static MJDCPLJHNAK MEIFENPHKBO;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static MJDCPLJHNAK GMBIDLIPEPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x4E46900", Offset = "0x4E45300", VA = "0x184E46900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public abstract DateTime MPDMEOHKEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public abstract float KPLIEDHLNOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	protected MJDCPLJHNAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class HOJOEADGGBA : global::EKFIPGGCHNC<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x4E45440", Offset = "0x4E43E40", VA = "0x184E45440")]
	public HOJOEADGGBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class EKFIPGGCHNC<T> : global::EJNODPAFKHM<T>, FJLFFABKNAJ, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Task<T> MPPMPGNIFOL
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x564480", Offset = "0x562E80", VA = "0x180564480", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private Task BKAMLFEKCMI
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x274BD10", Offset = "0x274A710", VA = "0x18274BD10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::HJGFLNHHJHD<T> CGJIFKLEIDP
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private LCANMJCMFMC MDEJDOKOMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x2751380", Offset = "0x274FD80", VA = "0x182751380", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x3928F70", Offset = "0x3927970", VA = "0x183928F70")]
	public EKFIPGGCHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class FMOEBBMJIAE : global::EBHNEAJOLEN<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x4E440F0", Offset = "0x4E42AF0", VA = "0x184E440F0")]
	public FMOEBBMJIAE(Exception OIFFLJDLBAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class EBHNEAJOLEN<T> : global::EJNODPAFKHM<T>, FJLFFABKNAJ, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Task<T> MPPMPGNIFOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x564480", Offset = "0x562E80", VA = "0x180564480", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private Task BKAMLFEKCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x274BD10", Offset = "0x274A710", VA = "0x18274BD10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::HJGFLNHHJHD<T> CGJIFKLEIDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private LCANMJCMFMC MDEJDOKOMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x2751380", Offset = "0x274FD80", VA = "0x182751380", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x3A1A2A0", Offset = "0x3A18CA0", VA = "0x183A1A2A0")]
	public EBHNEAJOLEN(Exception OIFFLJDLBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface FJLFFABKNAJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000069")]
	[NotNull]
	Task MPPMPGNIFOL
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	[NotNull]
	LCANMJCMFMC CGJIFKLEIDP
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public interface EJNODPAFKHM<T> : FJLFFABKNAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	[NotNull]
	new Task<T> MPPMPGNIFOL
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	[NotNull]
	new global::HJGFLNHHJHD<T> CGJIFKLEIDP
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public abstract class IGNKPDJGAFD<TTask, T> : global::EJNODPAFKHM<T>, FJLFFABKNAJ, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class PMJHIPMMICD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public global::IGNKPDJGAFD<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
		public PMJHIPMMICD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static bool AEAHPKHFCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly Task<T> MLPEOOKMEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	protected readonly CancellationTokenSource LNHBGENCLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private bool NPBJPMMAPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private SynchronizationContext GKGOACIHEAB;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Task<T> MPPMPGNIFOL
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x564480", Offset = "0x562E80", VA = "0x180564480", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Task BKAMLFEKCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x564480", Offset = "0x562E80", VA = "0x180564480", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public global::HJGFLNHHJHD<T> CGJIFKLEIDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	private LCANMJCMFMC MDEJDOKOMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x274BB00", Offset = "0x274A500", VA = "0x18274BB00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool JKILCLMBBEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x697420", Offset = "0x695E20", VA = "0x180697420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x38DB5F0", Offset = "0x38D9FF0", VA = "0x1838DB5F0")]
	static IGNKPDJGAFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x38DB8D0", Offset = "0x38DA2D0", VA = "0x1838DB8D0")]
	protected IGNKPDJGAFD(TTask MLPEOOKMEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x38DB220", Offset = "0x38D9C20", VA = "0x1838DB220", Slot = "1")]
	~IGNKPDJGAFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x38DB150", Offset = "0x38D9B50", VA = "0x1838DB150", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x38DB480", Offset = "0x38D9E80", VA = "0x1838DB480")]
	private void OHNGCEIGACM(bool LEBAAFFLGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T CHBJEJCJPMI(TTask OKDOINGHKFM);

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void JGNCDHFKPAD();

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x38DB2C0", Offset = "0x38D9CC0", VA = "0x1838DB2C0")]
	[CompilerGenerated]
	private void HNDNHGIDMAI(object BGOKFFKFKBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class BEIGBOMJAJE : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public readonly Type EHFELMDBEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public readonly string FOKCFDOMJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public readonly bool EOJAHGJOGCH;

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x4E43020", Offset = "0x4E41A20", VA = "0x184E43020")]
	public BEIGBOMJAJE(Type LKCENAOIOHO, string HCMHMEJDPIG, bool JFHKOLGCPCE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class LMLHOAEMLOJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x4E46770", Offset = "0x4E45170", VA = "0x184E46770")]
	public LMLHOAEMLOJ(string OLLHPIFFHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x4E467E0", Offset = "0x4E451E0", VA = "0x184E467E0")]
	public LMLHOAEMLOJ(string OLLHPIFFHKE, Exception PPCNBKCPFIL)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x560010", Offset = "0x55EA10", VA = "0x180560010")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x5AC370", Offset = "0x5AAD70", VA = "0x1805AC370")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public T this[int PFAINNECIEO, int CDJDGMLGNGN]
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x2A76F50", Offset = "0x2A75950", VA = "0x182A76F50")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x2A76FF0", Offset = "0x2A759F0", VA = "0x182A76FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2A76EC0", Offset = "0x2A758C0", VA = "0x182A76EC0")]
		public Array2D(uint IHCNDPNEGKP, uint CNICIJGDLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x2A76E40", Offset = "0x2A75840", VA = "0x182A76E40")]
		public void KOBBDDIILEP()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x4E42C80", Offset = "0x4E41680", VA = "0x184E42C80")]
		public Array2DVector3(uint IHCNDPNEGKP, uint CNICIJGDLJM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal static class GCFKBMDONDA
{
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public const int EDDINCLIKIM = -1;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public const int NKKDLADIMFM = 0;
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DefaultMember("Item")]
public class MFPGGCIEKBM<THandle, TValue> : IDisposable where THandle : struct, JPKBKOFGKDG where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly List<THandle> GFNEMBHFGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly List<TValue> BNGLGDLKMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly Func<TValue> HHFMDMALFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly Action<TValue> NJAPBBEDMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private int FPCMJMNMBFD;

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public TValue INJBIAGENON
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x32C6050", Offset = "0x32C4A50", VA = "0x1832C6050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x32C6670", Offset = "0x32C5070", VA = "0x1832C6670")]
	public MFPGGCIEKBM(Action<TValue> NJAPBBEDMLD, [Optional] Func<TValue> HHFMDMALFKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x32C5DD0", Offset = "0x32C47D0", VA = "0x1832C5DD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x32C5B40", Offset = "0x32C4540", VA = "0x1832C5B40")]
	public THandle AEEGCHIFHAD()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x32C5C80", Offset = "0x32C4680", VA = "0x1832C5C80")]
	public THandle CEGAKGBDODP(TValue HPIAFNBPEPC)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x32C5CF0", Offset = "0x32C46F0", VA = "0x1832C5CF0")]
	public bool DFDJPGANONL(THandle ANNMBFABHDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x32C5F70", Offset = "0x32C4970", VA = "0x1832C5F70")]
	public bool GFMJBBHLHOA(THandle ANNMBFABHDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x32C5ED0", Offset = "0x32C48D0", VA = "0x1832C5ED0")]
	public bool FHLLGNFGHGE(THandle ANNMBFABHDN, out TValue HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x32C6620", Offset = "0x32C5020", VA = "0x1832C6620")]
	public TValue POIAOKDLGFC(THandle ANNMBFABHDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x32C6080", Offset = "0x32C4A80", VA = "0x1832C6080")]
	public bool GKBEBLCBCBI(THandle ANNMBFABHDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x32C63E0", Offset = "0x32C4DE0", VA = "0x1832C63E0")]
	private THandle LCPPMDJJDGK(int LGBFGOJBLFK)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x32C5DA0", Offset = "0x32C47A0", VA = "0x1832C5DA0")]
	private TValue DKBJHMNMNDE(int LGBFGOJBLFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x32C65E0", Offset = "0x32C4FE0", VA = "0x1832C65E0")]
	private void OCNHPLLAJKD(int LGBFGOJBLFK, in THandle ANNMBFABHDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x32C6410", Offset = "0x32C4E10", VA = "0x1832C6410")]
	private void LGLLPEPAAFA(int LGBFGOJBLFK, in TValue HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x32C64D0", Offset = "0x32C4ED0", VA = "0x1832C64D0")]
	private THandle NOJNIHGPMCA()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x32C6320", Offset = "0x32C4D20", VA = "0x1832C6320")]
	private void JNCGECHLMKO(THandle ANNMBFABHDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x32C6450", Offset = "0x32C4E50", VA = "0x1832C6450")]
	private int LMCFDMDAOOM(int NAGACMCOIBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x32C64C0", Offset = "0x32C4EC0", VA = "0x1832C64C0")]
	private bool NJGHNFDGOKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x5D9590", Offset = "0x5D7F90", VA = "0x1805D9590")]
	private void JGBJAPHBLKB(THandle ANNMBFABHDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x32C5E50", Offset = "0x32C4850", VA = "0x1832C5E50")]
	private bool FABIJJHMFAH(out THandle ANNMBFABHDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x32C6130", Offset = "0x32C4B30", VA = "0x1832C6130")]
	private bool HJMIHMAIENG(out THandle ANNMBFABHDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x32C6460", Offset = "0x32C4E60", VA = "0x1832C6460")]
	private void NHCMDPNILCM(THandle ANNMBFABHDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x32C6200", Offset = "0x32C4C00", VA = "0x1832C6200")]
	private void JDCCECFBNOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface JPKBKOFGKDG
{
	[Cpp2IlInjected.Token(Token = "0x17000076")]
	int LJFCMJHPBPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	int AJBHNBBCJNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public interface ICODKHMKNJJ<T> : JPKBKOFGKDG, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class JFKIOEGBNBI
{
	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x2D0C080", Offset = "0x2D0AA80", VA = "0x182D0C080")]
	public static bool PINGKOBKAOL<T>(this T ANNMBFABHDN) where T : struct, JPKBKOFGKDG
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class HCDLABNIPAK
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private enum NJKLIHJEJHH : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private int JGDFFEGEHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private bool PHNNCDMBMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private NJKLIHJEJHH BEGCHMBIIJM;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public bool FKDJNNEDMJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x4E443B0", Offset = "0x4E42DB0", VA = "0x184E443B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool CBJNOCMDFGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x4E44AF0", Offset = "0x4E434F0", VA = "0x184E44AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x4E44FE0", Offset = "0x4E439E0", VA = "0x184E44FE0")]
	public HCDLABNIPAK(bool PHNNCDMBMJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x4E44560", Offset = "0x4E42F60", VA = "0x184E44560")]
	public void LCMEMBHOLAI(object FBOGCDJOCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x4E44200", Offset = "0x4E42C00", VA = "0x184E44200")]
	public void DGKAPGGDIGD(int HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x4E443C0", Offset = "0x4E42DC0", VA = "0x184E443C0")]
	public void GJCPJDDOACF(uint GMANDLKCDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x4E444F0", Offset = "0x4E42EF0", VA = "0x184E444F0")]
	public void JIIJHONKMMK(bool CODFIBCBHCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x4E44510", Offset = "0x4E42F10", VA = "0x184E44510")]
	public void KLOFIBCJNFE(long LDALNAELKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x4E444B0", Offset = "0x4E42EB0", VA = "0x184E444B0")]
	public void IPIJCJFOFCF(ulong FCPCOFJHBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x4E443D0", Offset = "0x4E42DD0", VA = "0x184E443D0")]
	public void GKBFGBBGLDP(string CDKMLIMBHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x4E442B0", Offset = "0x4E42CB0", VA = "0x184E442B0")]
	public void DJIECPJKMPK(Enum OIFFLJDLBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x4E44EC0", Offset = "0x4E438C0", VA = "0x184E44EC0")]
	public void OAJAJLEPAOM(IList NIHCHNNEJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x2BC4D70", Offset = "0x2BC3770", VA = "0x182BC4D70")]
	public void DKONCJIDABP<T, U>(Dictionary<T, U> CPLFDNIMMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x4E44B00", Offset = "0x4E43500", VA = "0x184E44B00")]
	private void MOMFEPCKCMH(IDictionary CPLFDNIMMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x4E44440", Offset = "0x4E42E40", VA = "0x184E44440")]
	public int IAHBFLPMHIN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x4E44A80", Offset = "0x4E43480", VA = "0x184E44A80")]
	public short LHFGCMIENKF()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x4E44550", Offset = "0x4E42F50", VA = "0x184E44550")]
	public void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x4E44340", Offset = "0x4E42D40", VA = "0x184E44340")]
	private void DKMMFIFBCBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public abstract class MHHNHKEPKOI<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	internal class BJEDOMLGCDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public TNode NPNHPOMDOAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public TNode MMEAACHMALE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public GDHEMPKOKMI DADDDHJHLLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public List<GDHEMPKOKMI> PEIANJJJFKF;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
		public BJEDOMLGCDN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	internal struct GDHEMPKOKMI : IComparable<GDHEMPKOKMI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int KGEFLFECBIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public TClaimant EBODDCDHOFG;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x590980", Offset = "0x58F380", VA = "0x180590980")]
		public GDHEMPKOKMI(int KGEFLFECBIL, TClaimant EBODDCDHOFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x32B8200", Offset = "0x32B6C00", VA = "0x1832B8200")]
		public bool PNCFKNMKGEK(in GDHEMPKOKMI KKPJJILPNAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x32B81F0", Offset = "0x32B6BF0", VA = "0x1832B81F0")]
		public bool GOFKMAOLFPB(in GDHEMPKOKMI KKPJJILPNAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x32B81E0", Offset = "0x32B6BE0", VA = "0x1832B81E0", Slot = "4")]
		public int CompareTo(GDHEMPKOKMI KKPJJILPNAL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x32B8260", Offset = "0x32B6C60", VA = "0x1832B8260", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public enum CPFHFFCMLFL
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class AJDEEKDJBNC : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public global::MHHNHKEPKOI<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x28E9030", Offset = "0x28E7A30", VA = "0x1828E9030")]
		[DebuggerHidden]
		public AJDEEKDJBNC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x32B3E20", Offset = "0x32B2820", VA = "0x1832B3E20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x32B3FE0", Offset = "0x32B29E0", VA = "0x1832B3FE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x32B3F00", Offset = "0x32B2900", VA = "0x1832B3F00", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x2752500", Offset = "0x2750F00", VA = "0x182752500", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly global::MLKGFJJLMOH<BJEDOMLGCDN> HCDBAFNOCDH;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly global::MLKGFJJLMOH<List<GDHEMPKOKMI>> CHFBMIADJLJ;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static int PJKGFEEOBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	internal readonly Dictionary<TClaimant, TNode> DGJFGDLJKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	internal readonly Dictionary<TNode, BJEDOMLGCDN> HDEKDNBGEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private CPFHFFCMLFL OMMBLABNACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private bool KIHCNAMPEGA;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode PMGPECBBCKO(TNode DAMODCEKDNG);

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void AAMJBNJLMAP(TNode DAMODCEKDNG, TClaimant NHLNKGDIGIJ, TClaimant IEEINCGKHDC);

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x32C8600", Offset = "0x32C7000", VA = "0x1832C8600")]
	public MHHNHKEPKOI(CPFHFFCMLFL OMMBLABNACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x32C8390", Offset = "0x32C6D90", VA = "0x1832C8390")]
	public void PGLKAALDBLH(TNode DAMODCEKDNG, TNode IPLMPKBGGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x32C72D0", Offset = "0x32C5CD0", VA = "0x1832C72D0")]
	public void GPKKKACNKFG(TClaimant EBODDCDHOFG, TNode GAGGCAGLEJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x32C6EE0", Offset = "0x32C58E0", VA = "0x1832C6EE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x32C7FF0", Offset = "0x32C69F0", VA = "0x1832C7FF0")]
	private void MLICLCBABJF(TClaimant EBODDCDHOFG, TNode FCGDBKJFKOE, TNode GAGGCAGLEJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x32C8090", Offset = "0x32C6A90", VA = "0x1832C8090")]
	private int MLMNFECMKCA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x32C7740", Offset = "0x32C6140", VA = "0x1832C7740")]
	private void JANEBJMLJID(TClaimant EBODDCDHOFG, TNode AFCDKCMJHAD, TNode BAAONIKBBCB, int BHDKGGJEJGM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x32C8410", Offset = "0x32C6E10", VA = "0x1832C8410")]
	private void PKHFDKLDHPP(GDHEMPKOKMI HFFFFIDDKJK, BJEDOMLGCDN AJAKEIHKFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x32C74D0", Offset = "0x32C5ED0", VA = "0x1832C74D0")]
	private void IGFDMMGOGFK(TClaimant EBODDCDHOFG, TNode AFCDKCMJHAD, TNode BAAONIKBBCB, int BHDKGGJEJGM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x32C73D0", Offset = "0x32C5DD0", VA = "0x1832C73D0")]
	private void HNPLOJJDKCA(GDHEMPKOKMI HFFFFIDDKJK, TNode DAMODCEKDNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x32C8290", Offset = "0x32C6C90", VA = "0x1832C8290")]
	private void PBJBLDBKHGL(GDHEMPKOKMI HFFFFIDDKJK, BJEDOMLGCDN AJAKEIHKFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x32C6DA0", Offset = "0x32C57A0", VA = "0x1832C6DA0")]
	private void CLDIGAHKNNH(BJEDOMLGCDN AJAKEIHKFGB, bool PIGMBODBEGD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x32C79F0", Offset = "0x32C63F0", VA = "0x1832C79F0")]
	private void KIKEIHBPNPD(BJEDOMLGCDN AJAKEIHKFGB, TNode IPLMPKBGGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x32C7200", Offset = "0x32C5C00", VA = "0x1832C7200")]
	[IteratorStateMachine(typeof(global::MHHNHKEPKOI<, >.AJDEEKDJBNC))]
	private IEnumerable<TNode> EIOIIGEMEEM(TNode AFCDKCMJHAD, TNode BAAONIKBBCB, bool KAPNKPEMFLM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x32C7140", Offset = "0x32C5B40", VA = "0x1832C7140")]
	private BJEDOMLGCDN EDLBDMAGHMJ(TNode DAMODCEKDNG, TNode MMEAACHMALE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x32C8100", Offset = "0x32C6B00", VA = "0x1832C8100")]
	private BJEDOMLGCDN MNGKNNAIKIN(TNode DAMODCEKDNG, TNode MMEAACHMALE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x32C7E30", Offset = "0x32C6830", VA = "0x1832C7E30")]
	private void MKBDIDGKDNM(BJEDOMLGCDN AJAKEIHKFGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class NJNOOENDDGM<T> : IEnumerable<global::NJNOOENDDGM<T>.KJNABALACNK>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public struct KJNABALACNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public T HPIAFNBPEPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public int LGBFGOJBLFK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class IEAAMLAKGCN : IEnumerator<KJNABALACNK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private global::NJNOOENDDGM<T> PLJLJLMPKME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private int LGBFGOJBLFK;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x2DFCAC0", Offset = "0x2DFB4C0", VA = "0x182DFCAC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public KJNABALACNK CJFECBEGNFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x2DFCB30", Offset = "0x2DFB530", VA = "0x182DFCB30", Slot = "4")]
			get
			{
				return default(KJNABALACNK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x5E26A0", Offset = "0x5E10A0", VA = "0x1805E26A0")]
		public IEAAMLAKGCN(global::NJNOOENDDGM<T> PLJLJLMPKME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x2DFCA30", Offset = "0x2DFB430", VA = "0x182DFCA30", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x5E2690", Offset = "0x5E1090", VA = "0x1805E2690", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xCBA6D0", Offset = "0xCB90D0", VA = "0x180CBA6D0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private struct AFKHPJKDAPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public bool LAEMEOPIMPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public T HPIAFNBPEPC;
	}

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private const int EDOKLIHEDHK = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private Dictionary<T, int> HGIEMOJPOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private AFKHPJKDAPG[] BNBCDPBPKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private int HBCNDILFLFC;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public int HEBEBONJJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x2DFE620", Offset = "0x2DFD020", VA = "0x182DFE620")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x2DFE240", Offset = "0x2DFCC40", VA = "0x182DFE240")]
	public static global::NJNOOENDDGM<T> NAKJNHOGGFD(KJNABALACNK[] IGKAIJBHEFK, bool KAOFNMPACGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x2DFE780", Offset = "0x2DFD180", VA = "0x182DFE780")]
	public NJNOOENDDGM(int POIIDIEGIKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x2DFE170", Offset = "0x2DFCB70", VA = "0x182DFE170")]
	public bool KIANONFEMIL(T HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x2DFDCB0", Offset = "0x2DFC6B0", VA = "0x182DFDCB0")]
	public bool EBGIIJKHJJI(int LGBFGOJBLFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x2DFE650", Offset = "0x2DFD050", VA = "0x182DFE650")]
	public bool PNJHNNLCLCE(Func<T, bool> IEGOIPJCKEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x2DFDD10", Offset = "0x2DFC710", VA = "0x182DFDD10")]
	public int FPPJIFIPCNC(T HPIAFNBPEPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x2DFDC40", Offset = "0x2DFC640", VA = "0x182DFDC40")]
	public T DKBJHMNMNDE(int LGBFGOJBLFK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x2DFE1A0", Offset = "0x2DFCBA0", VA = "0x182DFE1A0")]
	public void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x2DFDF20", Offset = "0x2DFC920", VA = "0x182DFDF20")]
	public bool JPOPBPNIDEA(T HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x2DFDF40", Offset = "0x2DFC940", VA = "0x182DFDF40")]
	public bool JPOPBPNIDEA(T HPIAFNBPEPC, int LGBFGOJBLFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x2DFDBC0", Offset = "0x2DFC5C0", VA = "0x182DFDBC0")]
	public bool DFDJPGANONL(T HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x2DFE1F0", Offset = "0x2DFCBF0", VA = "0x182DFE1F0")]
	public bool LLGMOJMHILP(int LGBFGOJBLFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x2DFDB10", Offset = "0x2DFC510", VA = "0x182DFDB10")]
	private void AHJGLOGLDGK(int LGBFGOJBLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x2DFDDB0", Offset = "0x2DFC7B0", VA = "0x182DFDDB0")]
	public KJNABALACNK[] JKAPMNMJCMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x2DFDD60", Offset = "0x2DFC760", VA = "0x182DFDD60")]
	private int GGOHHOLFLME(int KLJIMEJKFHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x2DFE700", Offset = "0x2DFD100", VA = "0x182DFE700", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x2DFE700", Offset = "0x2DFD100", VA = "0x182DFE700", Slot = "4")]
	private IEnumerator<KJNABALACNK> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class MLKGFJJLMOH<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private readonly Stack<T> GMBNIDCEFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly List<T> KKHEMNACCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly int OFCFHBOCLFM;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public int IGDGOHNMJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x2A769E0", Offset = "0x2A753E0", VA = "0x182A769E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public int AEOEPIJIEON
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x2A81B30", Offset = "0x2A80530", VA = "0x182A81B30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x3DD4E40", Offset = "0x3DD3840", VA = "0x183DD4E40")]
	public static global::MLKGFJJLMOH<T> AAAEEDNIJPD(int POIIDIEGIKN = 0, int OFCFHBOCLFM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x3DD5410", Offset = "0x3DD3E10", VA = "0x183DD5410")]
	public static global::MLKGFJJLMOH<T> NOFAIKILKMH(int POIIDIEGIKN = 0, int OFCFHBOCLFM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x3DD5860", Offset = "0x3DD4260", VA = "0x183DD5860")]
	public MLKGFJJLMOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x3DD56D0", Offset = "0x3DD40D0", VA = "0x183DD56D0")]
	public MLKGFJJLMOH(int POIIDIEGIKN, int OFCFHBOCLFM = int.MaxValue, bool FOPIKMJDGMD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x3DD55A0", Offset = "0x3DD3FA0", VA = "0x183DD55A0")]
	public T PFBILCOMHNF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x3DD54E0", Offset = "0x3DD3EE0", VA = "0x183DD54E0")]
	public void PEADAJPCKBB(T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x3DD4FC0", Offset = "0x3DD39C0", VA = "0x183DD4FC0")]
	private void BMBDAOIMLIC(T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x3DD53F0", Offset = "0x3DD3DF0", VA = "0x183DD53F0")]
	private void MCOHLGEHCMF(T HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x3DD5350", Offset = "0x3DD3D50", VA = "0x183DD5350")]
	[Conditional("DEBUG_BUILD")]
	private void KJBNMKAHPFD(T AFPBKKGAKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x3DD4F10", Offset = "0x3DD3910", VA = "0x183DD4F10")]
	[Conditional("DEBUG_BUILD")]
	private void AOEHIGMJJHK(T AFPBKKGAKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x3DD5240", Offset = "0x3DD3C40", VA = "0x183DD5240", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x3DD5080", Offset = "0x3DD3A80", VA = "0x183DD5080")]
	private void COFGEHJMBDI(IEnumerable<T> BNGLGDLKMIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class CPOLPPGHMMP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private Dictionary<int, T> DKPIEMGLOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private T PJPPOOFFKAH;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public virtual T CJFOCCFLMIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x567460", Offset = "0x565E60", VA = "0x180567460", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public bool JIIEKEKCLDM
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x34EEA30", Offset = "0x34ED430", VA = "0x1834EEA30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x34EE3E0", Offset = "0x34ECDE0", VA = "0x1834EE3E0")]
	public bool FJPEKBFHMIJ(T HPIAFNBPEPC, int KGEFLFECBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x34EE4A0", Offset = "0x34ECEA0", VA = "0x1834EE4A0")]
	public bool JBHAMDMNDIL(int KGEFLFECBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x34EE7D0", Offset = "0x34ED1D0", VA = "0x1834EE7D0")]
	public T MIJAEKMFDBA(int DGLEFEIFMKA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x34EE500", Offset = "0x34ECF00", VA = "0x1834EE500")]
	public void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x34EE210", Offset = "0x34ECC10", VA = "0x1834EE210")]
	private bool CKDLHPDFMHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x34EE3B0", Offset = "0x34ECDB0", VA = "0x1834EE3B0")]
	public bool FIJKPMMFIIC(int KGEFLFECBIL, out T HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x2E0BF20", Offset = "0x2E0A920", VA = "0x182E0BF20")]
	public CPOLPPGHMMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public class APOLOFCJDHM<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	protected struct IJLMBDBABED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public T CKLNJLLILCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public int KAFHPNHLOLA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	protected readonly List<IJLMBDBABED> OEKOKLAIABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private T NJFBNEODIFC;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public int HEBEBONJJIP
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x2A81630", Offset = "0x2A80030", VA = "0x182A81630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x3D5ED70", Offset = "0x3D5D770", VA = "0x183D5ED70")]
	public bool PNJHNNLCLCE(T HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x3D5E840", Offset = "0x3D5D240", VA = "0x183D5E840")]
	public void CEGAKGBDODP(T HPIAFNBPEPC, int KGEFLFECBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x3D5E8E0", Offset = "0x3D5D2E0", VA = "0x183D5E8E0")]
	public bool DFDJPGANONL(T HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x3D5EB00", Offset = "0x3D5D500", VA = "0x183D5EB00")]
	public void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x3D5EA00", Offset = "0x3D5D400", VA = "0x183D5EA00")]
	public T DPGIJOAGMLD()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x3D5EA90", Offset = "0x3D5D490", VA = "0x183D5EA90")]
	public T IEDOEIGPOID()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x3D5EB60", Offset = "0x3D5D560", VA = "0x183D5EB60")]
	private void MOBCLMJPFEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x3D5EFC0", Offset = "0x3D5D9C0", VA = "0x183D5EFC0")]
	public APOLOFCJDHM()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		[LJOCGMMGCIH(JAJEGMAJLMP.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x4E474B0", Offset = "0x4E45EB0", VA = "0x184E474B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x4E47980", Offset = "0x4E46380", VA = "0x184E47980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x4E477A0", Offset = "0x4E461A0", VA = "0x184E477A0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x4E47B20", Offset = "0x4E46520", VA = "0x184E47B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x4E47370", Offset = "0x4E45D70", VA = "0x184E47370")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x4E47840", Offset = "0x4E46240", VA = "0x184E47840")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x4E47660", Offset = "0x4E46060", VA = "0x184E47660")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x4E472D0", Offset = "0x4E45CD0", VA = "0x184E472D0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public interface HCNAELDHKIM
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public abstract class ResourcePrefabReference<T> : HCNAELDHKIM where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x2A8B3E0", Offset = "0x2A89DE0", VA = "0x182A8B3E0", Slot = "4")]
		public virtual T GMHHAFBJHFI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public class DNCACFIONHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly Dictionary<byte, NMMNGOKIPCK> EGKKFFOGCIC;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public NMMNGOKIPCK CFOCDAOBNHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x564480", Offset = "0x562E80", VA = "0x180564480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x588180", Offset = "0x586B80", VA = "0x180588180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public Vector2 NINJEFGAEEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xDFB5C0", Offset = "0xDF9FC0", VA = "0x180DFB5C0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x16EA500", Offset = "0x16E8F00", VA = "0x1816EA500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public Vector2 CJODKLACJPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xC9A6F0", Offset = "0xC990F0", VA = "0x180C9A6F0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xC9A710", Offset = "0xC99110", VA = "0x180C9A710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public Vector2 IKCKMNKBEJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x4E43980", Offset = "0x4E42380", VA = "0x184E43980")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x4E437F0", Offset = "0x4E421F0", VA = "0x184E437F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public int HILNNHNFBAN
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x5B3410", Offset = "0x5B1E10", VA = "0x1805B3410")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x5D9590", Offset = "0x5D7F90", VA = "0x1805D9590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x4E43AD0", Offset = "0x4E424D0", VA = "0x184E43AD0")]
	public DNCACFIONHP(Bounds BMNAABEIKCK, Vector2[] EMDPMENBBAP, int DNKBNINPIAN, byte KLJIMEJKFHH, float LFDABNFJPIJ = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x4E43900", Offset = "0x4E42300", VA = "0x184E43900")]
	public NMMNGOKIPCK DPKJGJNIMOA(byte LGBFGOJBLFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x4E43810", Offset = "0x4E42210", VA = "0x184E43810")]
	public void BGDENAMBGIK(Vector3 BJMMNGJKEHP, float CEGMHBPNKJJ, float EHHNNNKFDKE, ref List<byte> AADODEFOPOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x4E43960", Offset = "0x4E42360", VA = "0x184E43960")]
	public void EFJBKCAJMEB(NMMNGOKIPCK.MOHEDMFNOLD NLLJNIEDKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x4E439A0", Offset = "0x4E423A0", VA = "0x184E439A0")]
	private NMMNGOKIPCK LDMFEADCLAN(byte LGBFGOJBLFK, NMMNGOKIPCK.PIALDEDLJFJ HNNELBOHPPO, NMMNGOKIPCK MMEAACHMALE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x4E432D0", Offset = "0x4E41CD0", VA = "0x184E432D0")]
	private void ACHBJFIOBAL(NMMNGOKIPCK MMEAACHMALE, Vector2[] EMDPMENBBAP, int GOLBBAMMCOP, int NCIIJPJJBMP, int ONJIFDBNIHD, int NFBBNFAHGCK, float LFDABNFJPIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public class NMMNGOKIPCK
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public enum PIALDEDLJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public enum MOHEDMFNOLD
	{
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public byte IBOPELBHDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public Vector3 GHFIHJEGBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	public Vector3 PFFOPFIKBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	public Vector3 JNJNKFAEKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public Vector3 KNJFFAMGHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public PIALDEDLJFJ JPHDCOGHOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public NMMNGOKIPCK OOLIINHPLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public List<NMMNGOKIPCK> AHLHNHJACHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public bool AJHGEHFGIBO;

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x4E47210", Offset = "0x4E45C10", VA = "0x184E47210")]
	public NMMNGOKIPCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x4E471B0", Offset = "0x4E45BB0", VA = "0x184E471B0")]
	public NMMNGOKIPCK(byte AKGOJHKMAIK, PIALDEDLJFJ HNNELBOHPPO, NMMNGOKIPCK MMEAACHMALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x4E47110", Offset = "0x4E45B10", VA = "0x184E47110")]
	public void OJNFEAIHKBO(NMMNGOKIPCK KIBPPDMNMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30")]
	public void EFJBKCAJMEB(int HKOGLPJBHEB, MOHEDMFNOLD NLLJNIEDKGN, int CLFOLDNFMFA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x4E46DE0", Offset = "0x4E457E0", VA = "0x184E46DE0")]
	public void BGDENAMBGIK(List<byte> AADODEFOPOL, Vector3 BJMMNGJKEHP, float CEGMHBPNKJJ, float EHHNNNKFDKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x4E470B0", Offset = "0x4E45AB0", VA = "0x184E470B0")]
	public bool FDPCGKPNIGN(Vector3 BAMBIPKOPOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x4E47070", Offset = "0x4E45A70", VA = "0x184E47070")]
	public bool BNNHGEKPCAN(Vector3 BAMBIPKOPOH, float LMKBLILGPFA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public class LLELPLGOPIH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly Dictionary<T, object> BAKHIEGCDJI;

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x390D000", Offset = "0x390BA00", VA = "0x18390D000")]
	public bool POBJGGCIPJD(T LGGHLCFHBPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E5D0", Offset = "0x3B6CFD0", VA = "0x183B6E5D0")]
	public bool POBJGGCIPJD(T LGGHLCFHBPF, object LBAGELALLHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E610", Offset = "0x3B6D010", VA = "0x183B6E610")]
	public bool POBJGGCIPJD(T LGGHLCFHBPF, object LBAGELALLHA, out object LNCFIGGAAMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E590", Offset = "0x3B6CF90", VA = "0x183B6E590")]
	public bool FCBEACEDNJE(T LGGHLCFHBPF, object LBAGELALLHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E420", Offset = "0x3B6CE20", VA = "0x183B6E420")]
	public bool EAEBBJMIMNJ(T LGGHLCFHBPF, object LBAGELALLHA, out object LNCFIGGAAMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E500", Offset = "0x3B6CF00", VA = "0x183B6E500")]
	public bool FCBEACEDNJE(T LGGHLCFHBPF, object LBAGELALLHA, out object LNCFIGGAAMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x3A74170", Offset = "0x3A72B70", VA = "0x183A74170")]
	public void OEBFADBNNOL(T LGGHLCFHBPF, object LBAGELALLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E460", Offset = "0x3B6CE60", VA = "0x183B6E460")]
	public void EBHKKPBODGI(T LGGHLCFHBPF, object LBAGELALLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x3B6E670", Offset = "0x3B6D070", VA = "0x183B6E670")]
	public LLELPLGOPIH()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200009F")]
		public struct IOHBDFACHAD<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			private readonly List<Component> NIHCHNNEJAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			private readonly bool CEOKFKILCAL;

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0xA685F0", Offset = "0xA66FF0", VA = "0x180A685F0")]
			public IOHBDFACHAD(List<Component> NIHCHNNEJAD, bool CEOKFKILCAL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x2A7CC10", Offset = "0x2A7B610", VA = "0x182A7CC10")]
			public ILOCMFKLFJF<T> OIGPEBHIBKC()
			{
				return default(ILOCMFKLFJF<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x2A7CC80", Offset = "0x2A7B680", VA = "0x182A7CC80", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x2A7CC80", Offset = "0x2A7B680", VA = "0x182A7CC80", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A0")]
		public struct ILOCMFKLFJF<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			private readonly List<Component> NIHCHNNEJAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private readonly bool CEOKFKILCAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			private int LGBFGOJBLFK;

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public T CJFECBEGNFF
			{
				[Cpp2IlInjected.Token(Token = "0x6000377")]
				[Cpp2IlInjected.Address(RVA = "0x2A7CB00", Offset = "0x2A7B500", VA = "0x182A7CB00", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000378")]
				[Cpp2IlInjected.Address(RVA = "0x2A7CA90", Offset = "0x2A7B490", VA = "0x182A7CA90", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x2A7CAD0", Offset = "0x2A7B4D0", VA = "0x182A7CAD0")]
			public ILOCMFKLFJF(List<Component> NIHCHNNEJAD, bool CEOKFKILCAL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x2A7C9C0", Offset = "0x2A7B3C0", VA = "0x182A7C9C0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x2A7C9D0", Offset = "0x2A7B3D0", VA = "0x182A7C9D0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x2A7CA80", Offset = "0x2A7B480", VA = "0x182A7CA80", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x4E497E0", Offset = "0x4E481E0", VA = "0x184E497E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x4E497A0", Offset = "0x4E481A0", VA = "0x184E497A0")]
		public ToolHierarchyCache(GameObject JJNIJCDCCFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x4E49500", Offset = "0x4E47F00", VA = "0x184E49500")]
		private void LPDEJFLNIEO(GameObject JJNIJCDCCFE, bool BKLDBHLOPOM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x4E49620", Offset = "0x4E48020", VA = "0x184E49620")]
		public static void LPDEJFLNIEO(GameObject JJNIJCDCCFE, ref ToolHierarchyCache GIJBCGBNLPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x4E490C0", Offset = "0x4E47AC0", VA = "0x184E490C0")]
		public void FFIODHFMBJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x4E494B0", Offset = "0x4E47EB0", VA = "0x184E494B0")]
		public void LLKLANHPIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x25E8AB0", Offset = "0x25E74B0", VA = "0x1825E8AB0")]
		public void LBEJIPOGBCO<T>(Action<T> APBFEHIGAIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x4E48F80", Offset = "0x4E47980", VA = "0x184E48F80")]
		public Component DAKLCEIBKLD(Type IEADHAAGEDA, bool CEOKFKILCAL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x2943BE0", Offset = "0x29425E0", VA = "0x182943BE0")]
		public T DAKLCEIBKLD<T>(bool CEOKFKILCAL = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x4E496B0", Offset = "0x4E480B0", VA = "0x184E496B0")]
		public IOHBDFACHAD<Component> OJHGLKGBFAE(Type IEADHAAGEDA, bool CEOKFKILCAL = false)
		{
			return default(IOHBDFACHAD<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x29ABBF0", Offset = "0x29AA5F0", VA = "0x1829ABBF0")]
		public IOHBDFACHAD<T> OJHGLKGBFAE<T>(bool CEOKFKILCAL = false) where T : class
		{
			return default(IOHBDFACHAD<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x4E49200", Offset = "0x4E47C00", VA = "0x184E49200")]
		public List<Component> KFBJBMBIGFG(Type IEADHAAGEDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x4E49040", Offset = "0x4E47A40", VA = "0x184E49040", Slot = "4")]
		public bool Equals(ToolHierarchyCache EDIMMNEBDAA, ToolHierarchyCache MLMOIBACOIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x4E49190", Offset = "0x4E47B90", VA = "0x184E49190", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache FBOGCDJOCBP)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public class IMBJPCKJEDI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private int POIIDIEGIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private int NMFPCOAIFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private List<T> GGFOIHJNMKM;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public int HEBEBONJJIP
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x2A769E0", Offset = "0x2A753E0", VA = "0x182A769E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public T GOMEMKPKNPB
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x2CA1420", Offset = "0x2C9FE20", VA = "0x182CA1420")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public T MLIBEHMPINM
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x2CA1270", Offset = "0x2C9FC70", VA = "0x182CA1270")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public T PNBJALMDDLF
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x2CA1390", Offset = "0x2C9FD90", VA = "0x182CA1390")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x2CA15A0", Offset = "0x2C9FFA0", VA = "0x182CA15A0")]
	public IMBJPCKJEDI(int POIIDIEGIKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1020", Offset = "0x2C9FA20", VA = "0x182CA1020")]
	public void CEGAKGBDODP(T MLFFAKCCJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x2CA13E0", Offset = "0x2C9FDE0", VA = "0x182CA13E0")]
	public void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x2CA11D0", Offset = "0x2C9FBD0", VA = "0x182CA11D0")]
	public void CHKLFMAIKJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1550", Offset = "0x2C9FF50", VA = "0x182CA1550")]
	public void NBMNHOPKPGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1540", Offset = "0x2C9FF40", VA = "0x182CA1540")]
	public void LPKIMBJODCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public class OKJCMMNOBKI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private bool PCFLFDONLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private Action APBFEHIGAIL;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public static OKJCMMNOBKI LOMFLOMAKPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x4E47250", Offset = "0x4E45C50", VA = "0x184E47250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool LBBAFOKHDHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x5B33E0", Offset = "0x5B1DE0", VA = "0x1805B33E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x776CC0", Offset = "0x7756C0", VA = "0x180776CC0")]
	public OKJCMMNOBKI(Action APBFEHIGAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x4E47230", Offset = "0x4E45C30", VA = "0x184E47230")]
	public void DCGILHLCDMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x4E47230", Offset = "0x4E45C30", VA = "0x184E47230", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class POLBABBDHLC
{
	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30")]
	public static void AKAHJEOPMPK(LLIMNFKAHGO BJMHHJCFFEB, string DEIBMNKNJEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public class NNCJMFIPMAD<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private struct BIAFNOAKGAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public int KAFHPNHLOLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public T CKLNJLLILCL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly Dictionary<object, BIAFNOAKGAK> DKPIEMGLOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private T PJPPOOFFKAH;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public virtual T CJFOCCFLMIE
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xDFB5C0", Offset = "0xDF9FC0", VA = "0x180DFB5C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x16EA500", Offset = "0x16E8F00", VA = "0x1816EA500", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool JIIEKEKCLDM
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x2E0BEF0", Offset = "0x2E0A8F0", VA = "0x182E0BEF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public object CLBGFENDAOB
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x5644B0", Offset = "0x562EB0", VA = "0x1805644B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x567540", Offset = "0x565F40", VA = "0x180567540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x2E0BC70", Offset = "0x2E0A670", VA = "0x182E0BC70")]
	public bool FJPEKBFHMIJ(T HPIAFNBPEPC, object LBAGELALLHA, int KGEFLFECBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2E0BE20", Offset = "0x2E0A820", VA = "0x182E0BE20")]
	public bool JBHAMDMNDIL(object LBAGELALLHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x2E0B0D0", Offset = "0x2E09AD0", VA = "0x182E0B0D0")]
	public bool FIJKPMMFIIC(object LBAGELALLHA, out T HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x2E0BEC0", Offset = "0x2E0A8C0", VA = "0x182E0BEC0")]
	public void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x2E07490", Offset = "0x2E05E90", VA = "0x182E07490")]
	private bool CKDLHPDFMHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x2E0BF20", Offset = "0x2E0A920", VA = "0x182E0BF20")]
	public NNCJMFIPMAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public class LKDEAMOGDNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private Dictionary<object, float> DKPIEMGLOOK;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public float NFKICFCDEGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0xDFCEA0", Offset = "0xDFB8A0", VA = "0x180DFCEA0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xDFCEB0", Offset = "0xDFB8B0", VA = "0x180DFCEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x4E46140", Offset = "0x4E44B40", VA = "0x184E46140")]
	public void FJPEKBFHMIJ(float HPIAFNBPEPC, object LBAGELALLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x4E462D0", Offset = "0x4E44CD0", VA = "0x184E462D0")]
	public void JBHAMDMNDIL(object LBAGELALLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x4E461B0", Offset = "0x4E44BB0", VA = "0x184E461B0")]
	private void HHBIFMKFLHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x4E46340", Offset = "0x4E44D40", VA = "0x184E46340")]
	public LKDEAMOGDNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public class EHMHBECLOPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public readonly string GEKNCPGAHAC;

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x5DEFD0", Offset = "0x5DD9D0", VA = "0x1805DEFD0")]
	public EHMHBECLOPG(string JDKNDLHLNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x4E44040", Offset = "0x4E42A40", VA = "0x184E44040")]
	public EHMHBECLOPG(UnityEngine.Object MDGNMLNNNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x4E43FF0", Offset = "0x4E429F0", VA = "0x184E43FF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public sealed class LLIMNFKAHGO
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class JEHAHLMDNIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public JEHAHLMDNIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x4E455E0", Offset = "0x4E43FE0", VA = "0x184E455E0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly HashSet<object> HPAHDKMDFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private int MPBLFJNILIK;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyCollection<object> KDEGKLFIFLO
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x564480", Offset = "0x562E80", VA = "0x180564480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool BMFBMPCPNAP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x4E464C0", Offset = "0x4E44EC0", VA = "0x184E464C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public int HEBEBONJJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x564470", Offset = "0x562E70", VA = "0x180564470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x4E463C0", Offset = "0x4E44DC0", VA = "0x184E463C0")]
	public bool CEGAKGBDODP(object LBAGELALLHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x4E46440", Offset = "0x4E44E40", VA = "0x184E46440")]
	public bool DFDJPGANONL(object LBAGELALLHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x4E46530", Offset = "0x4E44F30", VA = "0x184E46530")]
	public bool PNJHNNLCLCE(object LBAGELALLHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x4E464D0", Offset = "0x4E44ED0", VA = "0x184E464D0")]
	public void JPGOPKOJPPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x4E46590", Offset = "0x4E44F90", VA = "0x184E46590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x4E46700", Offset = "0x4E45100", VA = "0x184E46700")]
	public LLIMNFKAHGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public class IKHDDFHIPAJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	private struct GOCMGCHBFCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public float HGAAJENFOAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public T CKLNJLLILCL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private Dictionary<object, GOCMGCHBFCK> DKPIEMGLOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private T GCLKECKMMEB;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public virtual T DJBEJHEJONF
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x20442D0", Offset = "0x2042CD0", VA = "0x1820442D0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x2043A50", Offset = "0x2042450", VA = "0x182043A50", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public object JHKGKJJHKJH
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x563A10", Offset = "0x562410", VA = "0x180563A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x638A00", Offset = "0x637400", VA = "0x180638A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool JIIEKEKCLDM
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x33CB170", Offset = "0x33C9B70", VA = "0x1833CB170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x33CAF30", Offset = "0x33C9930", VA = "0x1833CAF30")]
	public bool FJPEKBFHMIJ(T HPIAFNBPEPC, object LBAGELALLHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x33CB110", Offset = "0x33C9B10", VA = "0x1833CB110")]
	public bool JBHAMDMNDIL(object LBAGELALLHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x2E0BEC0", Offset = "0x2E0A8C0", VA = "0x182E0BEC0")]
	public void KOBBDDIILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x33CA8C0", Offset = "0x33C92C0", VA = "0x1833CA8C0")]
	public bool FIJKPMMFIIC(object LBAGELALLHA, out T HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x33C9D90", Offset = "0x33C8790", VA = "0x1833C9D90")]
	private bool CKDLHPDFMHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x33CB1B0", Offset = "0x33C9BB0", VA = "0x1833CB1B0")]
	public IKHDDFHIPAJ()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public class LGGEBEFKHFL
{
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private static byte[] BNGJCABJHMJ;

	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private static int DABHOAMPMJG;

	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private static int JKHLNLJIIMI;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private static BigInteger DBPEINBOKAP;

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	public LGGEBEFKHFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x4E45E80", Offset = "0x4E44880", VA = "0x184E45E80")]
	private static string OGKENCFMFPL(byte[] ODMIEFIFOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x4E45B50", Offset = "0x4E44550", VA = "0x184E45B50")]
	public static string KDPIBNPAHEL(byte[] MCBNAPIFOAJ, bool LELELDJDMBB)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x20000AE")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
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
