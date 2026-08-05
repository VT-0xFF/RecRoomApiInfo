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
public class AOLLAGFMDLH : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x76E100", Offset = "0x76CF00", VA = "0x18076E100")]
	public AOLLAGFMDLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, HJIPKKOJMJG, FPEHJGLJFCB, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x760C60", Offset = "0x75FA60", VA = "0x180760C60", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x760C70", Offset = "0x75FA70", VA = "0x180760C70", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA2B7C0", Offset = "0xA2A5C0", VA = "0x180A2B7C0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash CIDGKCAKNGM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x84A0A0", Offset = "0x848EA0", VA = "0x18084A0A0")]
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
	[HKPPDDBIGAE]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	[HideInInspector]
	[HKPPDDBIGAE]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5C55E70", Offset = "0x5C54C70", VA = "0x185C55E70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5C55E30", Offset = "0x5C54C30", VA = "0x185C55E30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5C55EB0", Offset = "0x5C54CB0", VA = "0x185C55EB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5C56060", Offset = "0x5C54E60", VA = "0x185C56060")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5C55FD0", Offset = "0x5C54DD0", VA = "0x185C55FD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7EA2A0", Offset = "0x7E90A0", VA = "0x1807EA2A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x88CF80", Offset = "0x88BD80", VA = "0x18088CF80")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5C55DF0", Offset = "0x5C54BF0", VA = "0x185C55DF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5C55F40", Offset = "0x5C54D40", VA = "0x185C55F40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5C55860", Offset = "0x5C54660", VA = "0x185C55860")]
	public void CopyBounds(SavedExtents LKMMHIOOCMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5C55D40", Offset = "0x5C54B40", VA = "0x185C55D40")]
	public void SetLocalSpaceBounds(Bounds LPFMEONGJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8BC2C0", Offset = "0x8BB0C0", VA = "0x1808BC2C0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5C55C70", Offset = "0x5C54A70", VA = "0x185C55C70")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5C55890", Offset = "0x5C54690", VA = "0x185C55890")]
	private void LEEKFBGFIIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5C55A50", Offset = "0x5C54850", VA = "0x185C55A50")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5C551F0", Offset = "0x5C53FF0", VA = "0x185C551F0")]
	public static void CalculateLocalBoundsFor(GameObject LEMKPNELLPI, [Out] Bounds LPFMEONGJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5C55C80", Offset = "0x5C54A80", VA = "0x185C55C80")]
	private static void PPJPNGFJEJB(Bounds DFBIFCHBAHF, Color BOGFMIDGHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5C55D60", Offset = "0x5C54B60", VA = "0x185C55D60")]
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
		[Cpp2IlInjected.Address(RVA = "0x75D180", Offset = "0x75BF80", VA = "0x18075D180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x76B340", Offset = "0x76A140", VA = "0x18076B340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xCCE8D0", Offset = "0xCCD6D0", VA = "0x180CCE8D0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3FCE6E0", Offset = "0x3FCD4E0", VA = "0x183FCE6E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "4")]
	public virtual void IHBDAJMPBDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
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
	[AOLLAGFMDLH]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3FCE2C0", Offset = "0x3FCD0C0", VA = "0x183FCE2C0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3FCCF60", Offset = "0x3FCBD60", VA = "0x183FCCF60", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3FCE610", Offset = "0x3FCD410", VA = "0x183FCE610")]
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
	private sealed class BFOOLBBKMDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public BFOOLBBKMDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4441E60", Offset = "0x4440C60", VA = "0x184441E60")]
		internal int MMAANNFJGIE(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[AOLLAGFMDLH]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x305A360", Offset = "0x3059160", VA = "0x18305A360", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x305A3B0", Offset = "0x30591B0", VA = "0x18305A3B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x305A260", Offset = "0x3059060", VA = "0x18305A260", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey GMOPMNAPKBE]
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x305A300", Offset = "0x3059100", VA = "0x18305A300", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x305A140", Offset = "0x3058F40", VA = "0x18305A140", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3059E60", Offset = "0x3058C60", VA = "0x183059E60", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3059300", Offset = "0x3058100", VA = "0x183059300", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x30592D0", Offset = "0x30580D0", VA = "0x1830592D0", Slot = "14")]
	protected virtual string OAGEEGADBGD(TKeyVal ABDFHGDCMAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3059180", Offset = "0x3057F80", VA = "0x183059180", Slot = "4")]
	public bool ContainsKey(TKey GMOPMNAPKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x305A000", Offset = "0x3058E00", VA = "0x18305A000", Slot = "5")]
	public bool TryGetValue(TKey GMOPMNAPKBE, [Out] TVal POACLGOFKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x30591D0", Offset = "0x3057FD0", VA = "0x1830591D0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x30591D0", Offset = "0x3057FD0", VA = "0x1830591D0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x305A050", Offset = "0x3058E50", VA = "0x18305A050")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class BGMAMOFDNKK<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class IMAAHAGJNCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public IMAAHAGJNCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x36A4F40", Offset = "0x36A3D40", VA = "0x1836A4F40")]
		internal bool MDMAEAJCFHB(GNFMGDAHMOJ<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float LKHMOPJGCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float PMNAKDLANMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<GNFMGDAHMOJ<float, T>> FFCCMBIHBAN;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int IDAGMPJPANJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4492F70", Offset = "0x4491D70", VA = "0x184492F70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x44936A0", Offset = "0x44924A0", VA = "0x1844936A0")]
	public BGMAMOFDNKK(float BGNPIAECIMF, float CGKHKJOCLOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4492D00", Offset = "0x4491B00", VA = "0x184492D00")]
	public bool AKDKJHGFEMB(float BGDOPOOMALL, T POACLGOFKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4493080", Offset = "0x4491E80", VA = "0x184493080")]
	public IEnumerable<T> NMFEHJDJEHB(float BGDOPOOMALL, [Optional] float? IFNJPJCKBNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4493050", Offset = "0x4491E50", VA = "0x184493050")]
	public void LHLJEDFLAKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4492E90", Offset = "0x4491C90", VA = "0x184492E90")]
	private void DKCJEAMJKPF(float BGDOPOOMALL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class BKGIJCIFDPM<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct LOLHMJAAOKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T CAGIMKNDHKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float HJIOHHDAIMK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float GGGCIDPJFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> HGCBBIMAEKA;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int IGEPNKDAKHP = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private LOLHMJAAOKE[] OBEMKDLNKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int AMKJPBIDPPO;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float PJNLHFBEKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA92550", Offset = "0xA91350", VA = "0x180A92550")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA92530", Offset = "0xA91330", VA = "0x180A92530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4496950", Offset = "0x4495750", VA = "0x184496950")]
	public BKGIJCIFDPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4496860", Offset = "0x4495660", VA = "0x184496860")]
	public BKGIJCIFDPM(int GINFBCJKIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x44961A0", Offset = "0x4494FA0", VA = "0x1844961A0")]
	public void EJEJBLJEAIN(float BGDOPOOMALL, T POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4496380", Offset = "0x4495180", VA = "0x184496380")]
	public void LHLJEDFLAKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4495C00", Offset = "0x4494A00", VA = "0x184495C00")]
	public bool BNEPMDAEJIN(float AFODOABIHMB, float HNIMBLHPAEI, [Out] T POACLGOFKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4496660", Offset = "0x4495460", VA = "0x184496660")]
	public bool MLGPKGJFFIB(float AFODOABIHMB, float HNIMBLHPAEI, [Out] T POACLGOFKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4495FA0", Offset = "0x4494DA0", VA = "0x184495FA0")]
	public void EDGDFEMJBCM(float AFODOABIHMB, float HNIMBLHPAEI, List<T> BLPPMOBNKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4496260", Offset = "0x4495060", VA = "0x184496260")]
	private int ELPJJINEFMO(int CCBDPKBONOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4495E00", Offset = "0x4494C00", VA = "0x184495E00")]
	private void BPFDGGMCJBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T ICGAPFFMBNC();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T FHOABBPIPON(T POACLGOFKAJ, float EGGPNONKPNJ);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T GOKGDIDJJIG(T MNLOCDHFJKE, T CHEKOKJNNFE);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T DHJIOLBHJLN(T MNLOCDHFJKE, T CHEKOKJNNFE);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class NAIOCPHLDGB : BKGIJCIFDPM<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x76E990", Offset = "0x76D790", VA = "0x18076E990", Slot = "4")]
	protected override Vector3 ICGAPFFMBNC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5C54780", Offset = "0x5C53580", VA = "0x185C54780", Slot = "5")]
	protected override Vector3 FHOABBPIPON(Vector3 POACLGOFKAJ, float EGGPNONKPNJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5C547C0", Offset = "0x5C535C0", VA = "0x185C547C0", Slot = "6")]
	protected override Vector3 GOKGDIDJJIG(Vector3 MNLOCDHFJKE, Vector3 CHEKOKJNNFE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5C54700", Offset = "0x5C53500", VA = "0x185C54700", Slot = "7")]
	protected override Vector3 DHJIOLBHJLN(Vector3 MNLOCDHFJKE, Vector3 CHEKOKJNNFE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5C54810", Offset = "0x5C53610", VA = "0x185C54810")]
	public NAIOCPHLDGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LJNABLNILPF
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2457E80", Offset = "0x2456C80", VA = "0x182457E80")]
	public static GNFMGDAHMOJ<T1, T2> FLMMCOJOBIA<T1, T2>(T1 MIGNPFGMMFN, T2 MLPNKOOEJPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2457F00", Offset = "0x2456D00", VA = "0x182457F00")]
	public static HJDHKNPIMBB<T1, T2, T3> FLMMCOJOBIA<T1, T2, T3>(T1 MIGNPFGMMFN, T2 MLPNKOOEJPM, T3 JNOJPINEFCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3BC0600", Offset = "0x3BBF400", VA = "0x183BC0600")]
	internal static int BNLMFONMJPP(int FLKIKDOINOP, int FHPPHCBKHAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5133710", Offset = "0x5132510", VA = "0x185133710")]
	internal static int BNLMFONMJPP(int FLKIKDOINOP, int FHPPHCBKHAN, int JMEEKHDLINM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GNFMGDAHMOJ<T1, T2> : IComparable<GNFMGDAHMOJ<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T1 AMNMBDFGIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T2 DIJDEJPPFIM;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x353AAD0", Offset = "0x35398D0", VA = "0x18353AAD0")]
	public GNFMGDAHMOJ(T1 MIGNPFGMMFN, T2 MLPNKOOEJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3538F40", Offset = "0x3537D40", VA = "0x183538F40", Slot = "4")]
	public int CompareTo(GNFMGDAHMOJ<T1, T2> LKMMHIOOCMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3539890", Offset = "0x3538690", VA = "0x183539890", Slot = "0")]
	public override bool Equals(object LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3539DF0", Offset = "0x3538BF0", VA = "0x183539DF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3539FB0", Offset = "0x3538DB0", VA = "0x183539FB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HJDHKNPIMBB<T1, T2, T3> : IComparable<HJDHKNPIMBB<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T1 AMNMBDFGIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T2 DIJDEJPPFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly T3 BODEMLDDCHB;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x35E2120", Offset = "0x35E0F20", VA = "0x1835E2120")]
	public HJDHKNPIMBB(T1 MIGNPFGMMFN, T2 MLPNKOOEJPM, T3 JNOJPINEFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x35E1920", Offset = "0x35E0720", VA = "0x1835E1920", Slot = "4")]
	public int CompareTo(HJDHKNPIMBB<T1, T2, T3> LKMMHIOOCMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x35E1B70", Offset = "0x35E0970", VA = "0x1835E1B70", Slot = "0")]
	public override bool Equals(object LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x35E1D20", Offset = "0x35E0B20", VA = "0x1835E1D20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x35E1E50", Offset = "0x35E0C50", VA = "0x1835E1E50", Slot = "3")]
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
	public T CAGIMKNDHKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1E7E2F0", Offset = "0x1E7D0F0", VA = "0x181E7E2F0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1E7E240", Offset = "0x1E7D040", VA = "0x181E7E240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float CALBJLLCFPD
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA3DDA0", Offset = "0xA3CBA0", VA = "0x180A3DDA0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x41D18E0", Offset = "0x41D06E0", VA = "0x1841D18E0")]
	public T LEEFPGGHNAO(float EGGPNONKPNJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x41D1D20", Offset = "0x41D0B20", VA = "0x1841D1D20")]
	public T NIAFBKHHBPB(float EGGPNONKPNJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T OBHECMNIAJH(T MNLOCDHFJKE, T CHEKOKJNNFE, float EGGPNONKPNJ);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5C53090", Offset = "0x5C51E90", VA = "0x185C53090", Slot = "4")]
	protected override float OBHECMNIAJH(float MNLOCDHFJKE, float CHEKOKJNNFE, float EGGPNONKPNJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5C530D0", Offset = "0x5C51ED0", VA = "0x185C530D0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xB75AE0", Offset = "0xB748E0", VA = "0x180B75AE0", Slot = "4")]
	protected override Vector3 OBHECMNIAJH(Vector3 MNLOCDHFJKE, Vector3 CHEKOKJNNFE, float EGGPNONKPNJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5C56E80", Offset = "0x5C55C80", VA = "0x185C56E80")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5C52480", Offset = "0x5C51280", VA = "0x185C52480", Slot = "4")]
	protected override Color OBHECMNIAJH(Color MNLOCDHFJKE, Color CHEKOKJNNFE, float EGGPNONKPNJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5C52540", Offset = "0x5C51340", VA = "0x185C52540")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class DIAAIPJOGPD : JLJOHDBDOFK<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5C525F0", Offset = "0x5C513F0", VA = "0x185C525F0")]
	public DIAAIPJOGPD(int LCFOKPAENOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5C52580", Offset = "0x5C51380", VA = "0x185C52580", Slot = "6")]
	protected override uint JCCFFPKBDIO(uint CIDGKCAKNGM, string POACLGOFKAJ)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class HKFLJKMIAPB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly IDisposable IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public HKFLJKMIAPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct FLIBJDHFIOC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> HLEPJNILBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int LKENELBENMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int FBCFFOKMINL;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x33C23B0", Offset = "0x33C11B0", VA = "0x1833C23B0")]
	private FLIBJDHFIOC(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> LAOFPJMAKNB, int JNDGOIJAMPI, int CFNCLHKMJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x33C0ED0", Offset = "0x33BFCD0", VA = "0x1833C0ED0")]
	public static FLIBJDHFIOC<T> IGHHFGMBDIH()
	{
		return default(FLIBJDHFIOC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x33C1670", Offset = "0x33C0470", VA = "0x1833C1670")]
	public (int, int, Task<T>) OHIGDHHDPGP(int MOOEDMEIHIK, [Optional] CancellationToken BCCDJHNACKO, double NNDFFBJHCAM = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x33C0990", Offset = "0x33BF790", VA = "0x1833C0990")]
	public void FCHJAGBFDLM(int MOOEDMEIHIK, int CFNCLHKMJJM, [In] T CGIMAKAECOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class NAKOBOLJLLH
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5C548F0", Offset = "0x5C536F0", VA = "0x185C548F0")]
	public static FLIBJDHFIOC<NENNLMOAGAP> IGHHFGMBDIH()
	{
		return default(FLIBJDHFIOC<NENNLMOAGAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5C54870", Offset = "0x5C53670", VA = "0x185C54870")]
	public static void FCHJAGBFDLM([In] this FLIBJDHFIOC<NENNLMOAGAP> PECKHAMCEFO, int MOOEDMEIHIK, int CFNCLHKMJJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[DefaultMember("Item")]
public class HJCMHKCOKPC<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TKey, TVal> ODHBKFDEEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly Dictionary<TVal, TKey> DDCDOHOHHBA;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int GJPDNICHPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2EC8160", Offset = "0x2EC6F60", VA = "0x182EC8160", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool LOLLACKIPEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> JAHMJDBHFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x33D6130", Offset = "0x33D4F30", VA = "0x1833D6130", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> OCBGEIAFOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x35E1750", Offset = "0x35E0550", VA = "0x1835E1750", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal CNLGKPLLPHE
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x35E16F0", Offset = "0x35E04F0", VA = "0x1835E16F0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x35E17B0", Offset = "0x35E05B0", VA = "0x1835E17B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey CNLGKPLLPHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x35E0D90", Offset = "0x35DFB90", VA = "0x1835E0D90")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x35E0A10", Offset = "0x35DF810", VA = "0x1835E0A10", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x35E1480", Offset = "0x35E0280", VA = "0x1835E1480", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x35E09C0", Offset = "0x35DF7C0", VA = "0x1835E09C0", Slot = "9")]
	public void Add(TKey GMOPMNAPKBE, TVal POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x35E0970", Offset = "0x35DF770", VA = "0x1835E0970", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> LCDPCJGMPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3055440", Offset = "0x3054240", VA = "0x183055440", Slot = "8")]
	public bool ContainsKey(TKey GMOPMNAPKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x35E0AD0", Offset = "0x35DF8D0", VA = "0x1835E0AD0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> LCDPCJGMPFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x35E13F0", Offset = "0x35E01F0", VA = "0x1835E13F0", Slot = "10")]
	public bool Remove(TKey GMOPMNAPKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x35E1450", Offset = "0x35E0250", VA = "0x1835E1450", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> LCDPCJGMPFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x35E1570", Offset = "0x35E0370", VA = "0x1835E1570", Slot = "11")]
	public bool TryGetValue(TKey GMOPMNAPKBE, [Out] TVal POACLGOFKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x35E0DE0", Offset = "0x35DFBE0", VA = "0x1835E0DE0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x35E0B00", Offset = "0x35DF900", VA = "0x1835E0B00", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] OBEMKDLNKLE, int EMKJLDKBBHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x35E11E0", Offset = "0x35DFFE0", VA = "0x1835E11E0")]
	public bool HOKMFLFGDOM(TVal GMOPMNAPKBE, [Out] TKey POACLGOFKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x35E1350", Offset = "0x35E0150", VA = "0x1835E1350")]
	private void PEGEFCBHCPC(TKey GMOPMNAPKBE, TVal OBPGGDPOOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x35E0CA0", Offset = "0x35DFAA0", VA = "0x1835E0CA0")]
	private void EEMJHEPMMEC(TKey GMOPMNAPKBE, TVal OBPGGDPOOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x35E10B0", Offset = "0x35DFEB0", VA = "0x1835E10B0")]
	private bool HMGJHFEKDGJ(TKey GMOPMNAPKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x35E15B0", Offset = "0x35E03B0", VA = "0x1835E15B0")]
	public HJCMHKCOKPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public class HEOCCIOJFCO<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private HEOCCIOJFCO<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x30B3D90", Offset = "0x30B2B90", VA = "0x1830B3D90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x30B4B80", Offset = "0x30B3980", VA = "0x1830B4B80")]
		public Enumerator(HEOCCIOJFCO<T> BLPPMOBNKNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x30B08C0", Offset = "0x30AF6C0", VA = "0x1830B08C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x30B2670", Offset = "0x30B1470", VA = "0x1830B2670", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x30B0240", Offset = "0x30AF040", VA = "0x1830B0240")]
		private void AHCFFIDHHDL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private T[] FHKOMJCFLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int IJBCLDGENAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int GGMHGLCHIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int FBJEHMGCPKI;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int GJPDNICHPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x35DAF70", Offset = "0x35D9D70", VA = "0x1835DAF70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T CNLGKPLLPHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x35DAD20", Offset = "0x35D9B20", VA = "0x1835DAD20")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x35DB080", Offset = "0x35D9E80", VA = "0x1835DB080")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x35DB2E0", Offset = "0x35DA0E0", VA = "0x1835DB2E0")]
	public HEOCCIOJFCO(int LCFOKPAENOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x35DA180", Offset = "0x35D8F80", VA = "0x1835DA180")]
	public void EJEJBLJEAIN(T EGGPNONKPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x35DAEA0", Offset = "0x35D9CA0", VA = "0x1835DAEA0")]
	public void LHLJEDFLAKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x35D9F40", Offset = "0x35D8D40", VA = "0x1835D9F40")]
	public void DMNMINEBAPJ(int NENAAIFMEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x35DA600", Offset = "0x35D9400", VA = "0x1835DA600")]
	public void FFCMMKNEENJ(T[] OBEMKDLNKLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x35DAF30", Offset = "0x35D9D30", VA = "0x1835DAF30")]
	public Enumerator LMOHIMMBLMJ()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x35DB160", Offset = "0x35D9F60", VA = "0x1835DB160", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x35DB160", Offset = "0x35D9F60", VA = "0x1835DB160", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x35DAB00", Offset = "0x35D9900", VA = "0x1835DAB00")]
	private int FMNIMPPAIBD(int OCMJNDDMDAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x35D9F10", Offset = "0x35D8D10", VA = "0x1835D9F10")]
	private int DMHDEFIDNJE(int OCMJNDDMDAL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class NOABFLALLDO<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Func<Internal, External> DBKIMCIFFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private IReadOnlyList<Internal> MJLHCFFNENL;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public External CNLGKPLLPHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3BF78D0", Offset = "0x3BF66D0", VA = "0x183BF78D0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int GJPDNICHPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3BF7880", Offset = "0x3BF6680", VA = "0x183BF7880", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x761AA0", Offset = "0x7608A0", VA = "0x180761AA0")]
	public NOABFLALLDO(Func<Internal, External> DBKIMCIFFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3BF7830", Offset = "0x3BF6630", VA = "0x183BF7830")]
	public NOABFLALLDO(IReadOnlyList<Internal> MJLHCFFNENL, Func<Internal, External> DBKIMCIFFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3BF77B0", Offset = "0x3BF65B0", VA = "0x183BF77B0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x33019A0", Offset = "0x33007A0", VA = "0x1833019A0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class EAHINCLEHCK<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate Task<TResult> LAKEAJLFIBJ(TRequest BHMKONDNBED, CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public enum JGLMOCFFPLD
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class OIHGHOKDLBH
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private const float FIIOFPAPLFI = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TimeSpan HNNCCNJJCOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int FDNKCFCIIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public JGLMOCFFPLD CGHJKGGKJOC;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly OIHGHOKDLBH IKMLLOOIGKE;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float OPONADNINBK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x3CD9EE0", Offset = "0x3CD8CE0", VA = "0x183CD9EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan FHHEHAHPCLF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3CDA030", Offset = "0x3CD8E30", VA = "0x183CDA030")]
		public OIHGHOKDLBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private readonly struct CMBLMODDMCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public readonly TRequest BHMKONDNBED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public readonly CancellationToken BCCDJHNACKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly TaskCompletionSource<TResult> JFBLGHIEAAF;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4A34C70", Offset = "0x4A33A70", VA = "0x184A34C70")]
		public CMBLMODDMCF(TRequest BHMKONDNBED, TaskCompletionSource<TResult> JFBLGHIEAAF, CancellationToken BCCDJHNACKO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct CHDAHIHKMJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EAHINCLEHCK<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4790C30", Offset = "0x478FA30", VA = "0x184790C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x4791830", Offset = "0x4790630", VA = "0x184791830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct PDAJAOCCPOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public EAHINCLEHCK<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private CMBLMODDMCF <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3D90BE0", Offset = "0x3D8F9E0", VA = "0x183D90BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3D91240", Offset = "0x3D90040", VA = "0x183D91240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly CancellationTokenSource LIMGNMMODCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<CMBLMODDMCF> DAPNIMADCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly OIHGHOKDLBH MOEEEKPJJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly LAKEAJLFIBJ NDFNBAIKKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Task JNIBMPAILIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private int BEDPBHLIFNN;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3007E70", Offset = "0x3006C70", VA = "0x183007E70")]
	public EAHINCLEHCK(LAKEAJLFIBJ NDFNBAIKKMB, [Optional] OIHGHOKDLBH MOEEEKPJJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3006B70", Offset = "0x3005970", VA = "0x183006B70")]
	public Task<TResult> DODKGANKGKA(TRequest BHMKONDNBED, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3006D40", Offset = "0x3005B40", VA = "0x183006D40")]
	private void DPHPEAOMAJI(CMBLMODDMCF NBGGJPMKALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3006690", Offset = "0x3005490", VA = "0x183006690")]
	[AsyncStateMachine(typeof(EAHINCLEHCK<, >.CHDAHIHKMJL))]
	private Task CNMGCKLLADK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3007240", Offset = "0x3006040", VA = "0x183007240")]
	private CMBLMODDMCF IPGEPEDFBPC()
	{
		return default(CMBLMODDMCF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3007C00", Offset = "0x3006A00", VA = "0x183007C00")]
	[AsyncStateMachine(typeof(EAHINCLEHCK<, >.PDAJAOCCPOH))]
	private Task JPFKMPIELCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3006F70", Offset = "0x3005D70", VA = "0x183006F70")]
	private void INGGHLCJIPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3006F30", Offset = "0x3005D30", VA = "0x183006F30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class AMAEKPNCNEJ<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly List<T> MJLHCFFNENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private HashSet<T> CJBJLEHCKAJ;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int GJPDNICHPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2EC8160", Offset = "0x2EC6F60", VA = "0x182EC8160", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool LOLLACKIPEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T CNLGKPLLPHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x34BBD90", Offset = "0x34BAB90", VA = "0x1834BBD90", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x34BBDD0", Offset = "0x34BABD0", VA = "0x1834BBDD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3044FF0", Offset = "0x3043DF0", VA = "0x183044FF0", Slot = "11")]
	public void Add(T LCDPCJGMPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x34BB7F0", Offset = "0x34BA5F0", VA = "0x1834BB7F0")]
	public bool LIKNKLMMDGB(T LCDPCJGMPFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x34BBB60", Offset = "0x34BA960", VA = "0x1834BBB60", Slot = "15")]
	public bool Remove(T LCDPCJGMPFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x34BB550", Offset = "0x34BA350", VA = "0x1834BB550", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3405310", Offset = "0x3404110", VA = "0x183405310", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x34BB480", Offset = "0x34BA280", VA = "0x1834BB480", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x34BB4E0", Offset = "0x34BA2E0", VA = "0x1834BB4E0", Slot = "13")]
	public bool Contains(T LCDPCJGMPFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x34BB520", Offset = "0x34BA320", VA = "0x1834BB520", Slot = "14")]
	public void CopyTo(T[] OBEMKDLNKLE, int EMKJLDKBBHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x34BB5E0", Offset = "0x34BA3E0", VA = "0x1834BB5E0", Slot = "6")]
	public int IndexOf(T LCDPCJGMPFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x34BB630", Offset = "0x34BA430", VA = "0x1834BB630", Slot = "7")]
	public void Insert(int OCMJNDDMDAL, T LCDPCJGMPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x34BB970", Offset = "0x34BA770", VA = "0x1834BB970", Slot = "8")]
	public void RemoveAt(int OCMJNDDMDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x34BBCA0", Offset = "0x34BAAA0", VA = "0x1834BBCA0")]
	public AMAEKPNCNEJ()
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
			[Cpp2IlInjected.Address(RVA = "0x1F730D0", Offset = "0x1F71ED0", VA = "0x181F730D0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5C56400", Offset = "0x5C55200", VA = "0x185C56400")]
		public SerializedGuid([In] Guid EIODILKIKCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5C56190", Offset = "0x5C54F90", VA = "0x185C56190")]
		public static SerializedGuid ENBPJEOAOCL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5C560F0", Offset = "0x5C54EF0", VA = "0x185C560F0")]
		public static SerializedGuid BGBLODKMDEI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5C562F0", Offset = "0x5C550F0", VA = "0x185C562F0")]
		public bool LOJCLMPHFKJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5C563D0", Offset = "0x5C551D0", VA = "0x185C563D0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5C56350", Offset = "0x5C55150", VA = "0x185C56350", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5C56210", Offset = "0x5C55010", VA = "0x185C56210", Slot = "7")]
		public bool Equals(SerializedGuid LKMMHIOOCMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5C56250", Offset = "0x5C55050", VA = "0x185C56250", Slot = "0")]
		public override bool Equals(object DGPHOMINFCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5C562E0", Offset = "0x5C550E0", VA = "0x185C562E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5C56160", Offset = "0x5C54F60", VA = "0x185C56160", Slot = "6")]
		public int CompareTo(SerializedGuid LKMMHIOOCMN)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class MNMNBOLCDMJ : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly Type AJIEPCPFLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly string NMNILJHOFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly bool LGHACHBHBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly bool IEOKMIAMLFA;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5C54690", Offset = "0x5C53490", VA = "0x185C54690")]
	public MNMNBOLCDMJ(Type FDDFJPBJNEM, string GEHNMOGPGFA, bool AOHHFMBOBCB = false, bool IDEIBNCIADD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class AEMIIEBAFHL<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public readonly struct CDEPPPFANNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public readonly long BFEFOIOIGCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public readonly long MIOKOBIPLAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly int FAAKPDDKCCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly int CMMJPCHEOGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly bool DIKFALDCFHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly string BPBBCOHPKPM;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x477FD10", Offset = "0x477EB10", VA = "0x18477FD10")]
		public CDEPPPFANNM(long BFEFOIOIGCH, int FAAKPDDKCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x477FD80", Offset = "0x477EB80", VA = "0x18477FD80")]
		public CDEPPPFANNM(long BFEFOIOIGCH, long MIOKOBIPLAI, int FAAKPDDKCCI, int CMMJPCHEOGO, bool DIKFALDCFHC, string BPBBCOHPKPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x477FCC0", Offset = "0x477EAC0", VA = "0x18477FCC0")]
		public int IDKJFLNEHAM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x477FCA0", Offset = "0x477EAA0", VA = "0x18477FCA0")]
		public int GLOAHOEGELN(int GJDPFAMJHLH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x477FC40", Offset = "0x477EA40", VA = "0x18477FC40")]
		public double EMAJEMKMIPG()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x477FBA0", Offset = "0x477E9A0", VA = "0x18477FBA0")]
		public CDEPPPFANNM BKMPGNMGPGH(long MIOKOBIPLAI, int CMMJPCHEOGO)
		{
			return default(CDEPPPFANNM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class GMENFEPMDPA : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct OLDKFBAJAMB<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public GMENFEPMDPA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public Func<GMENFEPMDPA, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private GMENFEPMDPA <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x3CDCB50", Offset = "0x3CDB950", VA = "0x183CDCB50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x3B65840", Offset = "0x3B64640", VA = "0x183B65840", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly TKey OBPJFFDCAMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly AEMIIEBAFHL<TKey> DNLFOGHCHDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly HICMFDICNOL DFCBIKLJFPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private List<GMENFEPMDPA> CBGJGKCCONB;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string GMFGEKBFBON
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x3537D60", Offset = "0x3536B60", VA = "0x183537D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<GMENFEPMDPA> FCCDIADKJDE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x3537D90", Offset = "0x3536B90", VA = "0x183537D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public CDEPPPFANNM ABHMGECOPOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x3537D40", Offset = "0x3536B40", VA = "0x183537D40")]
			[CompilerGenerated]
			get
			{
				return default(CDEPPPFANNM);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x3537D10", Offset = "0x3536B10", VA = "0x183537D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3537DD0", Offset = "0x3536BD0", VA = "0x183537DD0")]
		internal GMENFEPMDPA(AEMIIEBAFHL<TKey> DNLFOGHCHDI, TKey GMOPMNAPKBE, HICMFDICNOL DFCBIKLJFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x35379B0", Offset = "0x35367B0", VA = "0x1835379B0")]
		public GMENFEPMDPA CEEHAFMBHBO(TKey GMOPMNAPKBE, [Optional] HICMFDICNOL? KDPLCABNLJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x22A6CF0", Offset = "0x22A5AF0", VA = "0x1822A6CF0")]
		[AsyncStateMachine(typeof(OLDKFBAJAMB<>))]
		public Task<T> MGODJBEOPHJ<T>(TKey GMOPMNAPKBE, Func<GMENFEPMDPA, Task<T>> LMMNIDGGPKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3537B10", Offset = "0x3536910", VA = "0x183537B10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class KACPIGBBPMG : IEnumerable<(TKey, List<TKey>, CDEPPPFANNM)>, IEnumerable, IEnumerator<(TKey, List<TKey>, CDEPPPFANNM)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private (TKey key, List<TKey> path, CDEPPPFANNM timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public AEMIIEBAFHL<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private IEnumerator<(TKey key, List<TKey> path, CDEPPPFANNM timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, CDEPPPFANNM) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x382A820", Offset = "0x3829620", VA = "0x18382A820", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, CDEPPPFANNM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x388E2E0", Offset = "0x388D0E0", VA = "0x18388E2E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x388E340", Offset = "0x388D140", VA = "0x18388E340")]
		[DebuggerHidden]
		public KACPIGBBPMG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3053A50", Offset = "0x3052850", VA = "0x183053A50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x388DE30", Offset = "0x388CC30", VA = "0x18388DE30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x388DDE0", Offset = "0x388CBE0", VA = "0x18388DDE0")]
		private void LAJOCHINEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x388E290", Offset = "0x388D090", VA = "0x18388E290", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x388E1D0", Offset = "0x388CFD0", VA = "0x18388E1D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, CDEPPPFANNM)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3305290", Offset = "0x3304090", VA = "0x183305290", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class DKDOPLECEKK : IEnumerable<(TKey, List<TKey>, CDEPPPFANNM)>, IEnumerable, IEnumerator<(TKey, List<TKey>, CDEPPPFANNM)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private (TKey key, List<TKey> path, CDEPPPFANNM timerEntry) <>2__current;

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
		private GMENFEPMDPA timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public GMENFEPMDPA <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public AEMIIEBAFHL<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private IEnumerator<GMENFEPMDPA> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private IEnumerator<(TKey key, List<TKey> path, CDEPPPFANNM timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, CDEPPPFANNM) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x382A820", Offset = "0x3829620", VA = "0x18382A820", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, CDEPPPFANNM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x4C805B0", Offset = "0x4C7F3B0", VA = "0x184C805B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x388E340", Offset = "0x388D140", VA = "0x18388E340")]
		[DebuggerHidden]
		public DKDOPLECEKK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4C80610", Offset = "0x4C7F410", VA = "0x184C80610", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4C7FCD0", Offset = "0x4C7EAD0", VA = "0x184C7FCD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4C7FC70", Offset = "0x4C7EA70", VA = "0x184C7FC70")]
		private void LAJOCHINEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4C7FC10", Offset = "0x4C7EA10", VA = "0x184C7FC10")]
		private void KMKNJEPJJNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4C80560", Offset = "0x4C7F360", VA = "0x184C80560", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4C80480", Offset = "0x4C7F280", VA = "0x184C80480", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, CDEPPPFANNM)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3FFA1E0", Offset = "0x3FF8FE0", VA = "0x183FFA1E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly Action<TKey, CDEPPPFANNM, HICMFDICNOL> HMLODNHBDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Action<TKey, CDEPPPFANNM, HICMFDICNOL> EFKIFAHPCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly Action<AEMIIEBAFHL<TKey>, HICMFDICNOL> CBKECLBCEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly GMENFEPMDPA PMOJKDCBBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private bool ICPHJFMOKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private int CHJDFPECPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Stopwatch HHDDCDMHCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly int JFDOIBBKCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private string HDLGLBBGENF;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public GMENFEPMDPA FEDMHEIGLME
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x763870", Offset = "0x762670", VA = "0x180763870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string GMFGEKBFBON
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x760F10", Offset = "0x75FD10", VA = "0x180760F10")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3448C90", Offset = "0x3447A90", VA = "0x183448C90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3448CF0", Offset = "0x3447AF0", VA = "0x183448CF0")]
	public AEMIIEBAFHL(TKey KEKOHBNOEHI, HICMFDICNOL DFCBIKLJFPD, [Optional] int? FAAKPDDKCCI, [Optional][CanBeNull] Stopwatch HHDDCDMHCPM, [Optional] Action<TKey, CDEPPPFANNM, HICMFDICNOL> HMLODNHBDGK, [Optional] Action<TKey, CDEPPPFANNM, HICMFDICNOL> EFKIFAHPCHG, [Optional] Action<AEMIIEBAFHL<TKey>, HICMFDICNOL> CBKECLBCEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3448A20", Offset = "0x3447820", VA = "0x183448A20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3448B80", Offset = "0x3447980", VA = "0x183448B80")]
	[IteratorStateMachine(typeof(AEMIIEBAFHL<>.KACPIGBBPMG))]
	public IEnumerable<(TKey, List<TKey>, CDEPPPFANNM)> GGBHHJPAMHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3448AB0", Offset = "0x34478B0", VA = "0x183448AB0")]
	[IteratorStateMachine(typeof(AEMIIEBAFHL<>.DKDOPLECEKK))]
	private IEnumerable<(TKey, List<TKey>, CDEPPPFANNM)> GGBHHJPAMHB(List<TKey> MCGLDNPFLND, GMENFEPMDPA CALJEHKIBGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3448C10", Offset = "0x3447A10", VA = "0x183448C10")]
	private (long, int) IPJKKIEJKHJ()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public abstract class DOFKEAFGJMP<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut KHEMJCIGBMA(AEMIIEBAFHL<TKey> DNLFOGHCHDI);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	protected DOFKEAFGJMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public abstract class LFKEMIDGDMB<TKey> : DOFKEAFGJMP<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate string DLBJJIEOCFD(TKey GMOPMNAPKBE);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3983460", Offset = "0x3982260", VA = "0x183983460")]
	private static string FNFKJKLMILB(TKey GMOPMNAPKBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x39834A0", Offset = "0x39822A0", VA = "0x1839834A0", Slot = "4")]
	public override string KHEMJCIGBMA(AEMIIEBAFHL<TKey> DNLFOGHCHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3983560", Offset = "0x3982360", VA = "0x183983560")]
	public string KHEMJCIGBMA(AEMIIEBAFHL<TKey> DNLFOGHCHDI, [NotNull] DLBJJIEOCFD CJLIBEPCJPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string NMLCGGFPMJA(AEMIIEBAFHL<TKey> DNLFOGHCHDI, [NotNull] DLBJJIEOCFD CJLIBEPCJPN);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3029D10", Offset = "0x3028B10", VA = "0x183029D10")]
	protected LFKEMIDGDMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class GDJBONNPLKA<TKey> : DOFKEAFGJMP<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate string FNCCPGMNJDB(TKey GMOPMNAPKBE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly string DAJIKHCIBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly double NFMGEDOGDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly bool HGKOLHOBMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly int FAKDODFAODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly ISet<string> PKIFOOMLJPM;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3481310", Offset = "0x3480110", VA = "0x183481310")]
	private static string FNFKJKLMILB(TKey GMOPMNAPKBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3481AE0", Offset = "0x34808E0", VA = "0x183481AE0")]
	public GDJBONNPLKA(string DAJIKHCIBOK = "F2", double NFMGEDOGDHG = double.MaxValue, bool HGKOLHOBMOG = false, int FAKDODFAODN = int.MaxValue, [Optional] ISet<string> PKIFOOMLJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3481A20", Offset = "0x3480820", VA = "0x183481A20", Slot = "4")]
	public override Dictionary<string, string> KHEMJCIGBMA(AEMIIEBAFHL<TKey> DNLFOGHCHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3481350", Offset = "0x3480150", VA = "0x183481350")]
	private bool KCNLPIAMCOD(string LDPJPDPMNDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3481430", Offset = "0x3480230", VA = "0x183481430")]
	public Dictionary<string, string> KHEMJCIGBMA(AEMIIEBAFHL<TKey> DNLFOGHCHDI, FNCCPGMNJDB CJLIBEPCJPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x34810D0", Offset = "0x347FED0", VA = "0x1834810D0")]
	private string CMDHGOBMEOC(StringBuilder DBLJLDKDCJD, List<TKey> EKPAJMBDCIE, FNCCPGMNJDB CJLIBEPCJPN, bool FNBPJAJGMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3480F70", Offset = "0x347FD70", VA = "0x183480F70")]
	private static void ALIOBGJHMLP(StringBuilder ANPOIPEFCLM, string GLLIKAMKENL, bool GMMCHBIFCGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class GBFCJMKBDAI<TKey> : LFKEMIDGDMB<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct IJCBGMOFKNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public DLBJJIEOCFD keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static GBFCJMKBDAI<TKey> IFFGEIGBEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string[] BCDHPEFFAPE;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x347A1D0", Offset = "0x3478FD0", VA = "0x18347A1D0")]
	private GBFCJMKBDAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3479260", Offset = "0x3478060", VA = "0x183479260", Slot = "5")]
	protected override string NMLCGGFPMJA(AEMIIEBAFHL<TKey> DNLFOGHCHDI, DLBJJIEOCFD CJLIBEPCJPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3479170", Offset = "0x3477F70", VA = "0x183479170")]
	[CompilerGenerated]
	internal static string NGELKFODPMD(string HAPCBGKDJKE, TKey GMOPMNAPKBE, IJCBGMOFKNN P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class NLBJOFPIGAC : AEMIIEBAFHL<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class DMLBBNPIIPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Action<NLBJOFPIGAC, HICMFDICNOL> callback;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public DMLBBNPIIPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5C52640", Offset = "0x5C51440", VA = "0x185C52640")]
		internal void ADFCAKPDEDB(AEMIIEBAFHL<string> timer, HICMFDICNOL log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5C54A00", Offset = "0x5C53800", VA = "0x185C54A00")]
	public NLBJOFPIGAC(HICMFDICNOL DFCBIKLJFPD, [Optional] string EMAGCFBLBCC, [Optional] int? FAAKPDDKCCI, [Optional] Stopwatch HHDDCDMHCPM, [Optional] Action<string, CDEPPPFANNM, HICMFDICNOL> HMLODNHBDGK, [Optional] Action<string, CDEPPPFANNM, HICMFDICNOL> EFKIFAHPCHG, [Optional] Action<NLBJOFPIGAC, HICMFDICNOL> CBKECLBCEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5C54940", Offset = "0x5C53740", VA = "0x185C54940")]
	private static Action<AEMIIEBAFHL<string>, HICMFDICNOL> NBLCGKHIAJG(Action<NLBJOFPIGAC, HICMFDICNOL> PMOMGAGBHKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public abstract class IMAEKOCLLAH
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private class KNEOPIKJJIB : IMAEKOCLLAH
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static IMAEKOCLLAH IFFGEIGBEEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x5C54300", Offset = "0x5C53100", VA = "0x185C54300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float NIEHKCGFBBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x1C3BC80", Offset = "0x1C3AA80", VA = "0x181C3BC80", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5C54400", Offset = "0x5C53200", VA = "0x185C54400")]
		public KNEOPIKJJIB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static IMAEKOCLLAH FACOHPGINEM;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static IMAEKOCLLAH IKMLLOOIGKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5C54190", Offset = "0x5C52F90", VA = "0x185C54190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float NIEHKCGFBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	protected IMAEKOCLLAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class GOAIBGHILAM : FHEJJANLJEF<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5C54070", Offset = "0x5C52E70", VA = "0x185C54070")]
	public GOAIBGHILAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class FHEJJANLJEF<T> : FBMLADGOGPH<T>, ADANMMDOODE, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task<T> PHPPCBHMGHC
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public MIDEJKJPMAF<T> BIICJKKNKMI
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x33A57A0", Offset = "0x33A45A0", VA = "0x1833A57A0")]
	public FHEJJANLJEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class FGDBOGIDKEJ<T> : FBMLADGOGPH<T>, ADANMMDOODE, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Task<T> PHPPCBHMGHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public MIDEJKJPMAF<T> BIICJKKNKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x33A44D0", Offset = "0x33A32D0", VA = "0x1833A44D0")]
	public FGDBOGIDKEJ(Exception KHAMCNNBIHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface ADANMMDOODE : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface FBMLADGOGPH<T> : ADANMMDOODE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	[NotNull]
	Task<T> PHPPCBHMGHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[NotNull]
	MIDEJKJPMAF<T> BIICJKKNKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public abstract class OABGCOGNAKF
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	protected static bool NBEEGIEADEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5C54B50", Offset = "0x5C53950", VA = "0x185C54B50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5C54BA0", Offset = "0x5C539A0", VA = "0x185C54BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5C54C00", Offset = "0x5C53A00", VA = "0x185C54C00")]
	static OABGCOGNAKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	protected OABGCOGNAKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public abstract class NEKCPMFMEME<TTask, T> : OABGCOGNAKF, FBMLADGOGPH<T>, ADANMMDOODE, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class OAGAOOJHIJF
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
			public OAGAOOJHIJF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x2EB8700", Offset = "0x2EB7500", VA = "0x182EB8700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x2EB89D0", Offset = "0x2EB77D0", VA = "0x182EB89D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public NEKCPMFMEME<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public OAGAOOJHIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3CC2D60", Offset = "0x3CC1B60", VA = "0x183CC2D60")]
		[AsyncStateMachine(typeof(NEKCPMFMEME<, >.OAGAOOJHIJF.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> JJMHDEMJECD(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly Task<T> DPNKBPFBJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	protected readonly CancellationTokenSource AJBHEMPONAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool ICPHJFMOKBC;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Task<T> PHPPCBHMGHC
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public MIDEJKJPMAF<T> BIICJKKNKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool LIODFMEFOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7CDAC0", Offset = "0x7CC8C0", VA = "0x1807CDAC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3BDEEB0", Offset = "0x3BDDCB0", VA = "0x183BDEEB0")]
	protected NEKCPMFMEME(TTask DPNKBPFBJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3BDEB40", Offset = "0x3BDD940", VA = "0x183BDEB40", Slot = "1")]
	~NEKCPMFMEME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x39AE6A0", Offset = "0x39AD4A0", VA = "0x1839AE6A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x3BDEBD0", Offset = "0x3BDD9D0", VA = "0x183BDEBD0")]
	private void OGJJNAJKDPN(bool DFIEBFAMJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T LCCDHDNHJDA(TTask PEBJFBMAFCG);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void DDPDECLPLFL();
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class ECGBHPPIAOK
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5C52B20", Offset = "0x5C51920", VA = "0x185C52B20")]
	[NotNull]
	public static byte[] LMGINMOGDNC(this HJIPKKOJMJG PCLBKLPCCEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5C52B90", Offset = "0x5C51990", VA = "0x185C52B90")]
	[NotNull]
	public static byte[] LMGINMOGDNC(this HJIPKKOJMJG PCLBKLPCCEF, HashAlgorithmName EIDOHEPIDCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5C52990", Offset = "0x5C51790", VA = "0x185C52990")]
	public static bool JBFKOJOGFBL([CanBeNull] this HJIPKKOJMJG PCLBKLPCCEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5C527F0", Offset = "0x5C515F0", VA = "0x185C527F0")]
	public static bool JBFKOJOGFBL([CanBeNull] this HJIPKKOJMJG PCLBKLPCCEF, [Out] string HIFPPFEDDLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5C526D0", Offset = "0x5C514D0", VA = "0x185C526D0")]
	private static bool DFKJONMNIOJ([NotNull] HJIPKKOJMJG PCLBKLPCCEF, [Out][CanBeNull] byte[] ILJOJGJNMPJ, [Out][CanBeNull] byte[] PKGGDIFOFMF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class LGOANPCIEEP
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5C54450", Offset = "0x5C53250", VA = "0x185C54450")]
	[NotNull]
	public static byte[] LMGINMOGDNC(this FPEHJGLJFCB INELNBGHDMD, HashAlgorithmName EIDOHEPIDCD, byte[] GLENEFBHLHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface FPEHJGLJFCB
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash CIDGKCAKNGM);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface HJIPKKOJMJG : FPEHJGLJFCB
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[CanBeNull]
	byte[] MAACHPFOLCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	[CanBeNull]
	byte[] LPPELELIONC
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class CODLIABDJOB
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static readonly ArrayPool<byte> DFLHALNKMGI;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static bool PLBMKIDFHCP;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5C51700", Offset = "0x5C50500", VA = "0x185C51700")]
	public static void ALEHOJABENK(this IncrementalHash CAEDFOFBGIN, [CanBeNull] GameObject LEMKPNELLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x21F2A70", Offset = "0x21F1870", VA = "0x1821F2A70")]
	public static void ALEHOJABENK<T>(this IncrementalHash CAEDFOFBGIN, [CanBeNull] T KDELPFFKINA) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x21F2B30", Offset = "0x21F1930", VA = "0x1821F2B30")]
	public static void BEGMHBPGLMH<T>(this IncrementalHash CAEDFOFBGIN, [CanBeNull] T INELNBGHDMD) where T : FPEHJGLJFCB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x21F31F0", Offset = "0x21F1FF0", VA = "0x1821F31F0")]
	public static void LBOGCFGELDB<T>(this IncrementalHash CAEDFOFBGIN, [CanBeNull] IList<T> ELMHEBFOPPG) where T : FPEHJGLJFCB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5C51A10", Offset = "0x5C50810", VA = "0x185C51A10")]
	private static bool JCLICBPOBBJ([CanBeNull] FPEHJGLJFCB INELNBGHDMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5C51AA0", Offset = "0x5C508A0", VA = "0x185C51AA0")]
	public static void JHGIHMOPPON(this IncrementalHash CIDGKCAKNGM, [CanBeNull] string FBNNBIHJFDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5C51D40", Offset = "0x5C50B40", VA = "0x185C51D40")]
	public static void MCNDCNCBIKM(this IncrementalHash CIDGKCAKNGM, long PEDOKOEFJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5C51FD0", Offset = "0x5C50DD0", VA = "0x185C51FD0")]
	public static void NMJKODHFOBO(this IncrementalHash CIDGKCAKNGM, int CBMKOGHMKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5C521A0", Offset = "0x5C50FA0", VA = "0x185C521A0")]
	public static void PFLPGEPNDND(this IncrementalHash CIDGKCAKNGM, short PFHGILHHJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5C51B00", Offset = "0x5C50900", VA = "0x185C51B00")]
	public static void KHGNJFJMNIL(this IncrementalHash CIDGKCAKNGM, byte JPIFDPIIJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5C517E0", Offset = "0x5C505E0", VA = "0x185C517E0")]
	public static void FHCANHKJMFB(this IncrementalHash CIDGKCAKNGM, bool NDAGLKGLKBP, bool HEGAFADIKKD = false, bool KPPECENBGJH = false, bool GBDFNIJIAGF = false, bool AGDLNHJILHN = false, bool MMFGCHACIPO = false, bool ALKFIDJJMKL = false, bool NGDJPKHKJBK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x21F2BC0", Offset = "0x21F19C0", VA = "0x1821F2BC0")]
	public static void DOAHGCKPFLH<T>(this IncrementalHash CIDGKCAKNGM, T JLNEIALFDLF) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5C519B0", Offset = "0x5C507B0", VA = "0x185C519B0")]
	public static void HLJBIODJBOG(this IncrementalHash CIDGKCAKNGM, float KBGLPALCKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5C51F70", Offset = "0x5C50D70", VA = "0x185C51F70")]
	public static void NAMNBFCNFEG(this IncrementalHash CIDGKCAKNGM, ulong JOOECEKEGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5C51F10", Offset = "0x5C50D10", VA = "0x185C51F10")]
	public static void MJNLOAEMPHA(this IncrementalHash CIDGKCAKNGM, uint MFNEIFJINLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5C51950", Offset = "0x5C50750", VA = "0x185C51950")]
	public static void GAMGKAHKJOG(this IncrementalHash CIDGKCAKNGM, ushort CAPKPCNPOPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5C51C10", Offset = "0x5C50A10", VA = "0x185C51C10")]
	public static void LLIBLAAAIAE(this IncrementalHash CIDGKCAKNGM, Vector3 HOLOHIEDGNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class HGJINJHKAEO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5C540B0", Offset = "0x5C52EB0", VA = "0x185C540B0")]
	public HGJINJHKAEO(string BLAOEBOMGGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public abstract class CPHMPNNJBAE<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	internal class NGHOELOHBMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public TNode PECKHAMCEFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public TNode LPDGANJNOMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public FDANKKMBDBF IGCDHDJEOJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public List<FDANKKMBDBF> MGGIFDFDOLF;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public NGHOELOHBMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal struct FDANKKMBDBF : IComparable<FDANKKMBDBF>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int IDDHHGPCFLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public TClaimant FBOMAEDENPB;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xAD8C40", Offset = "0xAD7A40", VA = "0x180AD8C40")]
		public FDANKKMBDBF(int IDDHHGPCFLF, TClaimant FBOMAEDENPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x33946B0", Offset = "0x33934B0", VA = "0x1833946B0")]
		public bool HNCJOBDONKF([In] FDANKKMBDBF LKMMHIOOCMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3394710", Offset = "0x3393510", VA = "0x183394710")]
		public bool OAGGEBAEGAC([In] FDANKKMBDBF LKMMHIOOCMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x33946A0", Offset = "0x33934A0", VA = "0x1833946A0", Slot = "4")]
		public int CompareTo(FDANKKMBDBF LKMMHIOOCMN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3394720", Offset = "0x3393520", VA = "0x183394720", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum CMNACAGPCME
	{
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class HAMAKDBACND : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public CPHMPNNJBAE<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x86F050", Offset = "0x86DE50", VA = "0x18086F050")]
		[DebuggerHidden]
		public HAMAKDBACND(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x35A8A70", Offset = "0x35A7870", VA = "0x1835A8A70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x35A8C30", Offset = "0x35A7A30", VA = "0x1835A8C30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x35A8B50", Offset = "0x35A7950", VA = "0x1835A8B50", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x32FDD00", Offset = "0x32FCB00", VA = "0x1832FDD00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly BHAOCECJMDJ<NGHOELOHBMH> AGHLJFEJJHC;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly BHAOCECJMDJ<List<FDANKKMBDBF>> GINGGDJINPB;

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static int GKOPDOCGKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	internal readonly Dictionary<TClaimant, TNode> AENPIJODOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	internal readonly Dictionary<TNode, NGHOELOHBMH> LFFMLKFDNKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private CMNACAGPCME BPBBIDFIPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private bool FGEBCHHJFIF;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode IJFJAGHBHFC(TNode AHGGOPDAOCA);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void LJPMDGGLOPH(TNode AHGGOPDAOCA, TClaimant AGJOGNIDMKO, TClaimant OFMHFCFCCFH);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C910", Offset = "0x4A3B710", VA = "0x184A3C910")]
	public CPHMPNNJBAE(CMNACAGPCME BPBBIDFIPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x4A3BC30", Offset = "0x4A3AA30", VA = "0x184A3BC30")]
	public void KIKGMJOJBCI(TNode AHGGOPDAOCA, TNode CEBKCILOOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x4A3B6D0", Offset = "0x4A3A4D0", VA = "0x184A3B6D0")]
	public void ECCCHDBIKEG(TClaimant FBOMAEDENPB, TNode EGHEMFHODED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x4A3B3F0", Offset = "0x4A3A1F0", VA = "0x184A3B3F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x4A3B1E0", Offset = "0x4A39FE0", VA = "0x184A3B1E0")]
	private void CONEKBFJPEF(TClaimant FBOMAEDENPB, TNode IPCHJJPADFI, TNode EGHEMFHODED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x4A3BAD0", Offset = "0x4A3A8D0", VA = "0x184A3BAD0")]
	private int JMKAPMCNMHA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x4A3BCC0", Offset = "0x4A3AAC0", VA = "0x184A3BCC0")]
	private void KLDLJIEGKMN(TClaimant FBOMAEDENPB, TNode BIFBKAHGCPK, TNode PJMEKLHJGLI, int PFFJOGIPGMK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x4A3B360", Offset = "0x4A3A160", VA = "0x184A3B360")]
	private void DMLKGMCMLCC(FDANKKMBDBF LONMHHHOFEP, NGHOELOHBMH FIKHAFJHGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x4A3B7F0", Offset = "0x4A3A5F0", VA = "0x184A3B7F0")]
	private void HIPBHDCCKLJ(TClaimant FBOMAEDENPB, TNode BIFBKAHGCPK, TNode PJMEKLHJGLI, int PFFJOGIPGMK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x4A3B5C0", Offset = "0x4A3A3C0", VA = "0x184A3B5C0")]
	private void EAOMBHFGBMO(FDANKKMBDBF LONMHHHOFEP, TNode AHGGOPDAOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x4A3B0F0", Offset = "0x4A39EF0", VA = "0x184A3B0F0")]
	private void ACILLKBJCEI(FDANKKMBDBF LONMHHHOFEP, NGHOELOHBMH FIKHAFJHGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C340", Offset = "0x4A3B140", VA = "0x184A3C340")]
	private void NOHDGKACKML(NGHOELOHBMH FIKHAFJHGBB, bool CHNIENHAJIK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C000", Offset = "0x4A3AE00", VA = "0x184A3C000")]
	private void KLMHFNDKNPM(NGHOELOHBMH FIKHAFJHGBB, TNode CEBKCILOOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x4A3B280", Offset = "0x4A3A080", VA = "0x184A3B280")]
	[IteratorStateMachine(typeof(CPHMPNNJBAE<, >.HAMAKDBACND))]
	private IEnumerable<TNode> CPNGPNHIAHM(TNode BIFBKAHGCPK, TNode PJMEKLHJGLI, bool CKEPEGMIBNO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x4A3BB40", Offset = "0x4A3A940", VA = "0x184A3BB40")]
	private NGHOELOHBMH KAFEIEEGONA(TNode AHGGOPDAOCA, TNode LPDGANJNOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C470", Offset = "0x4A3B270", VA = "0x184A3C470")]
	private NGHOELOHBMH OBOJFDMPGLI(TNode AHGGOPDAOCA, TNode LPDGANJNOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C5E0", Offset = "0x4A3B3E0", VA = "0x184A3C5E0")]
	private void PNOICECOAGJ(NGHOELOHBMH FIKHAFJHGBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class JLJOHDBDOFK<T> : IEnumerable<JLJOHDBDOFK<T>.OOLFDPLCKOK>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct OOLFDPLCKOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public T POACLGOFKAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public int OCMJNDDMDAL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class ALOPPDLCFGM : IEnumerator<OOLFDPLCKOK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private JLJOHDBDOFK<T> OEHHENOKKFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private int OCMJNDDMDAL;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x305ABE0", Offset = "0x30599E0", VA = "0x18305ABE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public OOLFDPLCKOK CPKIHOLEKMC
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x34BB320", Offset = "0x34BA120", VA = "0x1834BB320", Slot = "4")]
			get
			{
				return default(OOLFDPLCKOK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x34BB2E0", Offset = "0x34BA0E0", VA = "0x1834BB2E0")]
		public ALOPPDLCFGM(JLJOHDBDOFK<T> OEHHENOKKFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x34BB1E0", Offset = "0x34B9FE0", VA = "0x1834BB1E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x30AA460", Offset = "0x30A9260", VA = "0x1830AA460", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x1A47640", Offset = "0x1A46440", VA = "0x181A47640", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private struct DKDIPGCJPPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public bool FBPBEKAMMJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public T POACLGOFKAJ;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private const int OCJJAMANAPM = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly Dictionary<T, int> KJPJFDLCEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private DKDIPGCJPPB[] DHOKACNFOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int NJPJOCJNLHC;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int JGPOGGFFIGC
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x79EE70", Offset = "0x79DC70", VA = "0x18079EE70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x79E500", Offset = "0x79D300", VA = "0x18079E500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int GJPDNICHPHI
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2EC8160", Offset = "0x2EC6F60", VA = "0x182EC8160")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x385E330", Offset = "0x385D130", VA = "0x18385E330")]
	public JLJOHDBDOFK(int LCFOKPAENOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x385DF60", Offset = "0x385CD60", VA = "0x18385DF60")]
	public JLJOHDBDOFK(OOLFDPLCKOK[] BJKFCMNAJOK, bool PBJPHPGHHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x385DC50", Offset = "0x385CA50", VA = "0x18385DC50")]
	public int LPEFODDFNJM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x385D230", Offset = "0x385C030", VA = "0x18385D230")]
	private int AFKFHCFJMDK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x385D6E0", Offset = "0x385C4E0", VA = "0x18385D6E0", Slot = "6")]
	protected virtual uint JCCFFPKBDIO(uint CIDGKCAKNGM, T POACLGOFKAJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x385DCE0", Offset = "0x385CAE0", VA = "0x18385DCE0")]
	public bool MBIGBEMMJHF(T POACLGOFKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x385D610", Offset = "0x385C410", VA = "0x18385D610")]
	public int GJAOGCHDKPD(T POACLGOFKAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x385DE20", Offset = "0x385CC20", VA = "0x18385DE20")]
	public T ODPMJGFGKKE(int OCMJNDDMDAL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x385D950", Offset = "0x385C750", VA = "0x18385D950")]
	public bool LIKNKLMMDGB(T POACLGOFKAJ, bool JKLKCGONOJK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x385D740", Offset = "0x385C540", VA = "0x18385D740")]
	public bool LIKNKLMMDGB(T POACLGOFKAJ, int OCMJNDDMDAL, bool JKLKCGONOJK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x385DD80", Offset = "0x385CB80", VA = "0x18385DD80")]
	private int OBFGOHDGIGP(int IJBCLDGENAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x385DEE0", Offset = "0x385CCE0", VA = "0x18385DEE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x385DEE0", Offset = "0x385CCE0", VA = "0x18385DEE0", Slot = "4")]
	private IEnumerator<OOLFDPLCKOK> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class BHAOCECJMDJ<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Stack<T> LAKDFLHDOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly List<T> NEDJCAGJJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly int KPNPMFMEGIJ;

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x4493A30", Offset = "0x4492830", VA = "0x184493A30")]
	public static BHAOCECJMDJ<T> MHBLPMDOOGE(int LCFOKPAENOI = 0, int KPNPMFMEGIJ = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x4494060", Offset = "0x4492E60", VA = "0x184494060")]
	public BHAOCECJMDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x4493EC0", Offset = "0x4492CC0", VA = "0x184493EC0")]
	public BHAOCECJMDJ(int LCFOKPAENOI, int KPNPMFMEGIJ = int.MaxValue, bool AACFECHNALI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x4493890", Offset = "0x4492690", VA = "0x184493890")]
	public T EEOAGFEOHIM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x4493B10", Offset = "0x4492910", VA = "0x184493B10")]
	public void NDCOKDMKIND(T POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x4493DE0", Offset = "0x4492BE0", VA = "0x184493DE0")]
	private void PBDCHBBLLAC(T POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x4493A10", Offset = "0x4492810", VA = "0x184493A10")]
	private void KBBDACFFHJO(T POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x4493750", Offset = "0x4492550", VA = "0x184493750", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x4493BE0", Offset = "0x44929E0", VA = "0x184493BE0")]
	private void NHCFDANIIGG(IEnumerable<T> MFELMHKMEDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class IMJOOFOKFHH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Dictionary<int, T> EKLELFILNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private T OHFCDEDAFBK;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public virtual T HNKKBNKPLMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x760C60", Offset = "0x75FA60", VA = "0x180760C60", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x36A55E0", Offset = "0x36A43E0", VA = "0x1836A55E0")]
	public bool CENAICLMDCB(T POACLGOFKAJ, int IDDHHGPCFLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x36A5CB0", Offset = "0x36A4AB0", VA = "0x1836A5CB0")]
	public bool NEOFPANHMHF(int IDDHHGPCFLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x36A58C0", Offset = "0x36A46C0", VA = "0x1836A58C0")]
	public T FNIFEKGNMMA(int GNHCFLOFNBL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x36A5BC0", Offset = "0x36A49C0", VA = "0x1836A5BC0")]
	private bool HDFPDDDLDDO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x36A5C60", Offset = "0x36A4A60", VA = "0x1836A5C60")]
	public bool HOKMFLFGDOM(int IDDHHGPCFLF, [Out] T POACLGOFKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x36A5D20", Offset = "0x36A4B20", VA = "0x1836A5D20")]
	public IMJOOFOKFHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class HLNCFBMCFJM<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	protected struct IFBHEPIAHOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public T CAGIMKNDHKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int BLLBILPMICK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	protected readonly List<IFBHEPIAHOG> FHKOMJCFLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private T NOIGJPCFDOC;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int GJPDNICHPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2EC8160", Offset = "0x2EC6F60", VA = "0x182EC8160")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x35E8C70", Offset = "0x35E7A70", VA = "0x1835E8C70")]
	public bool PEOEIPDBFBN(T POACLGOFKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x35E8840", Offset = "0x35E7640", VA = "0x1835E8840")]
	public void EJEJBLJEAIN(T POACLGOFKAJ, int IDDHHGPCFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x35E8AC0", Offset = "0x35E78C0", VA = "0x1835E8AC0")]
	public bool KCJHGNBNEJA(T POACLGOFKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x35E8C10", Offset = "0x35E7A10", VA = "0x1835E8C10")]
	public void LHLJEDFLAKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x35E88E0", Offset = "0x35E76E0", VA = "0x1835E88E0")]
	public T JGDLOGJAKPB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x35E8960", Offset = "0x35E7760", VA = "0x1835E8960")]
	private void KCAFGFLLHJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x35E8DF0", Offset = "0x35E7BF0", VA = "0x1835E8DF0")]
	public HLNCFBMCFJM()
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
		[DBHJNHHAHKH(PBHAFHEAPLG.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x5C54DF0", Offset = "0x5C53BF0", VA = "0x185C54DF0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x5C550C0", Offset = "0x5C53EC0", VA = "0x185C550C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x5C54FD0", Offset = "0x5C53DD0", VA = "0x185C54FD0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5C54D40", Offset = "0x5C53B40", VA = "0x185C54D40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x5C55010", Offset = "0x5C53E10", VA = "0x185C55010")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x5C54F20", Offset = "0x5C53D20", VA = "0x185C54F20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5C54CB0", Offset = "0x5C53AB0", VA = "0x185C54CB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F96B80", Offset = "0x3F95980", VA = "0x183F96B80", Slot = "4")]
		public virtual T OEKDMKEGIIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class GBJLKHBIMKO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly Dictionary<byte, FDEAKDHLOIA> IAKGGLGCOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly BHAOCECJMDJ<FDEAKDHLOIA> BJIHIBHHGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly bool AKDHCPNAABC;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public FDEAKDHLOIA PCDCDGAFKEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7619C0", Offset = "0x7607C0", VA = "0x1807619C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public Vector2 HNEENBIFANJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA46E90", Offset = "0xA45C90", VA = "0x180A46E90")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xD2B2B0", Offset = "0xD2A0B0", VA = "0x180D2B2B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	private Vector2 MPAACADGJBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xD78350", Offset = "0xD77150", VA = "0x180D78350")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public Vector2 CFEMHIPJNPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5C538D0", Offset = "0x5C526D0", VA = "0x185C538D0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7654B0", Offset = "0x7642B0", VA = "0x1807654B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int DHCIGINLPIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x769310", Offset = "0x768110", VA = "0x180769310")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x769300", Offset = "0x768100", VA = "0x180769300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5C53BE0", Offset = "0x5C529E0", VA = "0x185C53BE0")]
	public GBJLKHBIMKO(Bounds HHPFBHAFFBJ, Vector2[] NNIIDCHLKHP, int HLAECJPACJL, byte IJBCLDGENAJ, float PEHOCLIOINO = 0f, [Optional] BHAOCECJMDJ<FDEAKDHLOIA> BJIHIBHHGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5C53110", Offset = "0x5C51F10", VA = "0x185C53110")]
	public FDEAKDHLOIA DIMBMIKMGLA(byte OCMJNDDMDAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5C538F0", Offset = "0x5C526F0", VA = "0x185C538F0")]
	public void MHPNKHKJAOK(Vector3 CMKBDFOJBFE, float GDFMPGOGPLF, float KEEDFJEOLHL, List<byte> LNPMJIIFEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1A44710", Offset = "0x1A43510", VA = "0x181A44710")]
	public void EFKHDEEMCJL(FDEAKDHLOIA.PHJJIFIOOGM CHEMOMFKCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5C537E0", Offset = "0x5C525E0", VA = "0x185C537E0")]
	public static int KHBPEOHFFIM(Vector2[] NNIIDCHLKHP, int HLAECJPACJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5C535E0", Offset = "0x5C523E0", VA = "0x185C535E0")]
	private FDEAKDHLOIA GHHEBIHLEGG(byte OCMJNDDMDAL, FDEAKDHLOIA.HAOAEDAFBII CMDJECFBKDI, FDEAKDHLOIA LPDGANJNOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5C531D0", Offset = "0x5C51FD0", VA = "0x185C531D0")]
	private void EJBJDHLDAEJ(FDEAKDHLOIA LPDGANJNOMK, Vector2[] NNIIDCHLKHP, int DLFCMFLGGOI, int BHGPBIMDOEB, int GPDMNNDLCOD, int HIOHJILCLBP, float PEHOCLIOINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5C539C0", Offset = "0x5C527C0", VA = "0x185C539C0")]
	private void OLIIMCFDECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5C53170", Offset = "0x5C51F70", VA = "0x185C53170", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5C53580", Offset = "0x5C52380", VA = "0x185C53580", Slot = "1")]
	~GBJLKHBIMKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class FDEAKDHLOIA
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public enum HAOAEDAFBII
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum PHJJIFIOOGM
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
	public byte IOFNGFNIBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public Vector3 BLNEFBKKEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public Vector3 MGLJLKOIJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public Vector3 IDGHMBDOABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public Vector3 CELLHJCOOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public HAOAEDAFBII FDFMNFKFLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public FDEAKDHLOIA KFKCBBALAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public List<FDEAKDHLOIA> DPJHPGMKBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public bool IDCDGMONMFE;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5C53070", Offset = "0x5C51E70", VA = "0x185C53070")]
	public FDEAKDHLOIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5C52C30", Offset = "0x5C51A30", VA = "0x185C52C30")]
	public void CLPCBEDDCDJ(FDEAKDHLOIA KGAHDFAFPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	public void EFKHDEEMCJL(int EBCIHELEKPH, PHJJIFIOOGM CHEMOMFKCNE, int FAAAOGNJKEE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5C52E10", Offset = "0x5C51C10", VA = "0x185C52E10")]
	public void MHPNKHKJAOK(List<byte> LNPMJIIFEGO, Vector3 CMKBDFOJBFE, float GDFMPGOGPLF, float KEEDFJEOLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5C52DE0", Offset = "0x5C51BE0", VA = "0x185C52DE0")]
	public bool HNMJCEFACPI(Vector3 HPBLMHBHKBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5C52C00", Offset = "0x5C51A00", VA = "0x185C52C00")]
	public bool AAJPJPIJHKN(Vector3 HPBLMHBHKBO, float BGDJOKBEMBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5C52D50", Offset = "0x5C51B50", VA = "0x185C52D50")]
	public void HCKCHEHGBKI()
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
		public struct KICKDLKHFGA<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private readonly List<Component> MJLHCFFNENL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private readonly bool MGEGAKAKPLH;

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x38C1F30", Offset = "0x38C0D30", VA = "0x1838C1F30")]
			public KICKDLKHFGA(List<Component> MJLHCFFNENL, bool MGEGAKAKPLH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x38C1DF0", Offset = "0x38C0BF0", VA = "0x1838C1DF0")]
			public DIBCGDIEONM<T> LMOHIMMBLMJ()
			{
				return default(DIBCGDIEONM<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x38C1E60", Offset = "0x38C0C60", VA = "0x1838C1E60", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x38C1E60", Offset = "0x38C0C60", VA = "0x1838C1E60", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public struct DIBCGDIEONM<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private readonly List<Component> MJLHCFFNENL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private readonly bool MGEGAKAKPLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private int OCMJNDDMDAL;

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public T CPKIHOLEKMC
			{
				[Cpp2IlInjected.Token(Token = "0x60001EB")]
				[Cpp2IlInjected.Address(RVA = "0x4C69180", Offset = "0x4C67F80", VA = "0x184C69180", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001EC")]
				[Cpp2IlInjected.Address(RVA = "0x4C69110", Offset = "0x4C67F10", VA = "0x184C69110", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x4C69150", Offset = "0x4C67F50", VA = "0x184C69150")]
			public DIBCGDIEONM(List<Component> MJLHCFFNENL, bool MGEGAKAKPLH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x4C69050", Offset = "0x4C67E50", VA = "0x184C69050", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x4C69060", Offset = "0x4C67E60", VA = "0x184C69060", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x309C5B0", Offset = "0x309B3B0", VA = "0x18309C5B0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5C56520", Offset = "0x5C55320", VA = "0x185C56520")]
		private void HCKCHEHGBKI(GameObject MFFJMLLGCCG, bool PIOPLCOODHB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5C56690", Offset = "0x5C55490", VA = "0x185C56690")]
		public static void HCKCHEHGBKI(GameObject MFFJMLLGCCG, ToolHierarchyCache GEKHLALBKFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x265CDC0", Offset = "0x265BBC0", VA = "0x18265CDC0")]
		public void ADAHLCKCINA<T>(Action<T> IPGJPNDBCJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x265CFE0", Offset = "0x265BDE0", VA = "0x18265CFE0")]
		public T LNCNEAELDIK<T>(bool MGEGAKAKPLH = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x265D050", Offset = "0x265BE50", VA = "0x18265D050")]
		public KICKDLKHFGA<T> NAJFHHNLDCP<T>(bool MGEGAKAKPLH = false) where T : class
		{
			return default(KICKDLKHFGA<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5C56850", Offset = "0x5C55650", VA = "0x185C56850")]
		public List<Component> MFKMCNCDCPD(Type FLHOFPAHPKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5C56430", Offset = "0x5C55230", VA = "0x185C56430", Slot = "4")]
		public bool Equals(ToolHierarchyCache NPDPLEIHBMM, ToolHierarchyCache CINKHPOEGPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5C564B0", Offset = "0x5C552B0", VA = "0x185C564B0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache DGPHOMINFCK)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class PDBPBCLAGLJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private int LCFOKPAENOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private int DHAGOCMAJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private List<T> KJFBOMAGMGG;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public int GJPDNICHPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x337E8B0", Offset = "0x337D6B0", VA = "0x18337E8B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public T FKIKGLFLOCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3D912A0", Offset = "0x3D900A0", VA = "0x183D912A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public T MHGNHDDPIAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3D91810", Offset = "0x3D90610", VA = "0x183D91810")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public T CCBIODCOKNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3D91410", Offset = "0x3D90210", VA = "0x183D91410")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x3D91930", Offset = "0x3D90730", VA = "0x183D91930")]
	public PDBPBCLAGLJ(int LCFOKPAENOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3D915E0", Offset = "0x3D903E0", VA = "0x183D915E0")]
	public void EJEJBLJEAIN(T OFELIDOHNGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x3D918F0", Offset = "0x3D906F0", VA = "0x183D918F0")]
	public void LHLJEDFLAKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x3D916E0", Offset = "0x3D904E0", VA = "0x183D916E0")]
	public void FMMLHLHEBFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x3D91880", Offset = "0x3D90680", VA = "0x183D91880")]
	public void JHBKNEDLFNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x3D918E0", Offset = "0x3D906E0", VA = "0x183D918E0")]
	public void JKOCKONMALN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class LFNNJFEFECD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private struct EDNAHDHPHAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int BLLBILPMICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public T CAGIMKNDHKH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly Dictionary<object, EDNAHDHPHAG> EKLELFILNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly EqualityComparer<T> LOMODNBEBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private T OHFCDEDAFBK;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public virtual T HNKKBNKPLMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xD63290", Offset = "0xD62090", VA = "0x180D63290", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3987320", Offset = "0x3986120", VA = "0x183987320", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool HDJEELEGJFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x39836B0", Offset = "0x39824B0", VA = "0x1839836B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public object PENCDPNKJMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x763870", Offset = "0x762670", VA = "0x180763870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x763890", Offset = "0x762690", VA = "0x180763890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x3983D90", Offset = "0x3982B90", VA = "0x183983D90")]
	public bool CENAICLMDCB(T POACLGOFKAJ, object EKDHBKMFLGI, int IDDHHGPCFLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x39873C0", Offset = "0x39861C0", VA = "0x1839873C0")]
	public bool NEOFPANHMHF(object EKDHBKMFLGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x3986AB0", Offset = "0x39858B0", VA = "0x183986AB0")]
	public bool HOKMFLFGDOM(object EKDHBKMFLGI, [Out] T POACLGOFKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x39872F0", Offset = "0x39860F0", VA = "0x1839872F0")]
	public void LHLJEDFLAKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x3985010", Offset = "0x3983E10", VA = "0x183985010")]
	private bool HDFPDDDLDDO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x3987450", Offset = "0x3986250", VA = "0x183987450")]
	public LFNNJFEFECD()
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
