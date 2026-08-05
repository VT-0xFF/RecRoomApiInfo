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
public class FPHCABHHLOG : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7CB100", Offset = "0x7CA100", VA = "0x1807CB100")]
	public FPHCABHHLOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, JAABKIBFIHP, LAKEDFNJCFE, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BC240", Offset = "0x7BB240", VA = "0x1807BC240", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1F0", Offset = "0x7BC1F0", VA = "0x1807BD1F0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1D0", Offset = "0x7BC1D0", VA = "0x1807BD1D0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x87BB10", Offset = "0x87AB10", VA = "0x18087BB10", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash NLBCJPBLAOB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8A4C00", Offset = "0x8A3C00", VA = "0x1808A4C00")]
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
	[BOGHKEELHAN]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	[BOGHKEELHAN]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6164CD0", Offset = "0x6163CD0", VA = "0x186164CD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6164C90", Offset = "0x6163C90", VA = "0x186164C90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6164D10", Offset = "0x6163D10", VA = "0x186164D10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6164EC0", Offset = "0x6163EC0", VA = "0x186164EC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6164E30", Offset = "0x6163E30", VA = "0x186164E30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x942690", Offset = "0x941690", VA = "0x180942690")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9F95B0", Offset = "0x9F85B0", VA = "0x1809F95B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6164C50", Offset = "0x6163C50", VA = "0x186164C50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6164DA0", Offset = "0x6163DA0", VA = "0x186164DA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x61646C0", Offset = "0x61636C0", VA = "0x1861646C0")]
	public void CopyBounds(SavedExtents PJNBIAFGNNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6164BA0", Offset = "0x6163BA0", VA = "0x186164BA0")]
	public void SetLocalSpaceBounds(Bounds PLOGPKODNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xA189A0", Offset = "0xA179A0", VA = "0x180A189A0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6164B90", Offset = "0x6163B90", VA = "0x186164B90")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x61646F0", Offset = "0x61636F0", VA = "0x1861646F0")]
	private void FLKHMGDOOON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6164970", Offset = "0x6163970", VA = "0x186164970")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6164050", Offset = "0x6163050", VA = "0x186164050")]
	public static void CalculateLocalBoundsFor(GameObject LNIPGKDIFCK, [Out] Bounds PLOGPKODNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x61648B0", Offset = "0x61638B0", VA = "0x1861648B0")]
	private static void MNODJECIDPF(Bounds AMHEHNHOGFM, Color BKPEEMPJCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6164BC0", Offset = "0x6163BC0", VA = "0x186164BC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BA180", Offset = "0x7B9180", VA = "0x1807BA180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7C8790", Offset = "0x7C7790", VA = "0x1807C8790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xE61170", Offset = "0xE60170", VA = "0x180E61170")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x43347E0", Offset = "0x43337E0", VA = "0x1843347E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "4")]
	public virtual void CNOJKCJAPMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
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
	[FPHCABHHLOG]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x43343C0", Offset = "0x43333C0", VA = "0x1843343C0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4333060", Offset = "0x4332060", VA = "0x184333060", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4334710", Offset = "0x4333710", VA = "0x184334710")]
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
	private sealed class GIOJGOAMJFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public GIOJGOAMJFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3759DA0", Offset = "0x3758DA0", VA = "0x183759DA0")]
		internal int AOKEPNPFDOG(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[FPHCABHHLOG]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3337160", Offset = "0x3336160", VA = "0x183337160", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x33371B0", Offset = "0x33361B0", VA = "0x1833371B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3337060", Offset = "0x3336060", VA = "0x183337060", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey IPAJBJLLPIJ]
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3337100", Offset = "0x3336100", VA = "0x183337100", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3336F40", Offset = "0x3335F40", VA = "0x183336F40", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3336C60", Offset = "0x3335C60", VA = "0x183336C60", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3336100", Offset = "0x3335100", VA = "0x183336100", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x33360D0", Offset = "0x33350D0", VA = "0x1833360D0", Slot = "14")]
	protected virtual string HELFBKEMMPB(TKeyVal OOKMNHBKLHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3335F80", Offset = "0x3334F80", VA = "0x183335F80", Slot = "4")]
	public bool ContainsKey(TKey IPAJBJLLPIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3336E00", Offset = "0x3335E00", VA = "0x183336E00", Slot = "5")]
	public bool TryGetValue(TKey IPAJBJLLPIJ, [Out] TVal CFJDHAGGAJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3335FD0", Offset = "0x3334FD0", VA = "0x183335FD0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3335FD0", Offset = "0x3334FD0", VA = "0x183335FD0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3336E50", Offset = "0x3335E50", VA = "0x183336E50")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class CJENJCGHEDG<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class CGBFKBEJBNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public float EKBJLCMBDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public T ADACBBLDADO;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public CGBFKBEJBNN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class HAJJKKMDGKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public HAJJKKMDGKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x37B30A0", Offset = "0x37B20A0", VA = "0x1837B30A0")]
		internal bool LLGOENIKJFO(CGBFKBEJBNN sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float OMALNAINOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float PGHAIPJPIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<CGBFKBEJBNN> IJJDNLCOIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private MFOEMOFPBGB<CGBFKBEJBNN> HIBLCBMBNPK;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int FBKBLOACIBL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4C97070", Offset = "0x4C96070", VA = "0x184C97070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4C97550", Offset = "0x4C96550", VA = "0x184C97550")]
	public CJENJCGHEDG(float CHHAAPHGMOL, float HIEHGFDIGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4C973C0", Offset = "0x4C963C0", VA = "0x184C973C0")]
	public bool MPJDMBFCDHM(float CJLMIDOLMHB, T CFJDHAGGAJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4C96CD0", Offset = "0x4C95CD0", VA = "0x184C96CD0")]
	public IEnumerable<T> DFAOJIOECNA(float CJLMIDOLMHB, [Optional] float? BJHOPBBKLLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4C96930", Offset = "0x4C95930", VA = "0x184C96930")]
	public void BGPDDONPEEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4C970E0", Offset = "0x4C960E0", VA = "0x184C970E0")]
	private void MELFIDNJNKA(float CJLMIDOLMHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class MDPKAMFNLMI<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct EFGDOMCIOCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public T ADACBBLDADO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public float NCHKEBDJFFN;
	}

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static float EBALOOKPFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private List<T> LAJGJCPDDEF;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private const int OCFBOBHGIJG = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private EFGDOMCIOCB[] IJPOMPNGBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private int KEHGDHNNFLF;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float MGILGMHBLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8508E0", Offset = "0x84F8E0", VA = "0x1808508E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x875510", Offset = "0x874510", VA = "0x180875510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3EC4CF0", Offset = "0x3EC3CF0", VA = "0x183EC4CF0")]
	public MDPKAMFNLMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3EC4C00", Offset = "0x3EC3C00", VA = "0x183EC4C00")]
	public MDPKAMFNLMI(int BEELDCKKFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3EC3FC0", Offset = "0x3EC2FC0", VA = "0x183EC3FC0")]
	public void EMJMPPLJJNE(float CJLMIDOLMHB, T CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3EC3D20", Offset = "0x3EC2D20", VA = "0x183EC3D20")]
	public void BGPDDONPEEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3EC49A0", Offset = "0x3EC39A0", VA = "0x183EC49A0")]
	public bool PGLKMLILEAF(float GBFOIDHNKHH, float DMAAKIMJNKB, [Out] T CFJDHAGGAJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3EC4080", Offset = "0x3EC3080", VA = "0x183EC4080")]
	public bool IOIIALGKKKD(float GBFOIDHNKHH, float DMAAKIMJNKB, [Out] T CFJDHAGGAJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3EC4490", Offset = "0x3EC3490", VA = "0x183EC4490")]
	public void OLGFKNBFBKA(float GBFOIDHNKHH, float DMAAKIMJNKB, List<T> EOOJCJAHOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3EC4410", Offset = "0x3EC3410", VA = "0x183EC4410")]
	private int JBBJDMEAECK(int NNLNCJHKPCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3EC4440", Offset = "0x3EC3440", VA = "0x183EC4440")]
	private void LAANEGNALBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T KKKPLKHFDDJ();

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T HODIAEGDBMN(T CFJDHAGGAJO, float MPLEEKHPBJH);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T JKMCKPLCONM(T JAIIDLBPFND, T ECFHNKKEKBJ);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T GHEEIILMHCP(T JAIIDLBPFND, T ECFHNKKEKBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FCJFIMGGOCN : MDPKAMFNLMI<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7CB990", Offset = "0x7CA990", VA = "0x1807CB990", Slot = "4")]
	protected override Vector3 KKKPLKHFDDJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x61619C0", Offset = "0x61609C0", VA = "0x1861619C0", Slot = "5")]
	protected override Vector3 HODIAEGDBMN(Vector3 CFJDHAGGAJO, float MPLEEKHPBJH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6161A00", Offset = "0x6160A00", VA = "0x186161A00", Slot = "6")]
	protected override Vector3 JKMCKPLCONM(Vector3 JAIIDLBPFND, Vector3 ECFHNKKEKBJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6161940", Offset = "0x6160940", VA = "0x186161940", Slot = "7")]
	protected override Vector3 GHEEIILMHCP(Vector3 JAIIDLBPFND, Vector3 ECFHNKKEKBJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6161A50", Offset = "0x6160A50", VA = "0x186161A50")]
	public FCJFIMGGOCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class AJBHPODICNJ
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2D85D70", Offset = "0x2D84D70", VA = "0x182D85D70")]
	public static IDIOLBIBBGB<T1, T2> OOGKEDOOOJC<T1, T2>(T1 BFJFNJEKGNE, T2 LKOJNOBLAHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2D85DF0", Offset = "0x2D84DF0", VA = "0x182D85DF0")]
	public static LFFDOBNJCHH<T1, T2, T3> OOGKEDOOOJC<T1, T2, T3>(T1 BFJFNJEKGNE, T2 LKOJNOBLAHB, T3 ENGENLOLJNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3F19F90", Offset = "0x3F18F90", VA = "0x183F19F90")]
	internal static int JKLCICAOJIM(int CDNCCPAJNOJ, int BBFAGGFNHEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5587E70", Offset = "0x5586E70", VA = "0x185587E70")]
	internal static int JKLCICAOJIM(int CDNCCPAJNOJ, int BBFAGGFNHEI, int JNMCLLDBCFL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IDIOLBIBBGB<T1, T2> : IComparable<IDIOLBIBBGB<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T1 IABIEGLKPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly T2 CDOFKAJLPON;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3922560", Offset = "0x3921560", VA = "0x183922560")]
	public IDIOLBIBBGB(T1 BFJFNJEKGNE, T2 LKOJNOBLAHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3920C20", Offset = "0x391FC20", VA = "0x183920C20", Slot = "4")]
	public int CompareTo(IDIOLBIBBGB<T1, T2> PJNBIAFGNNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x39215F0", Offset = "0x39205F0", VA = "0x1839215F0", Slot = "0")]
	public override bool Equals(object PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x39219D0", Offset = "0x39209D0", VA = "0x1839219D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3922400", Offset = "0x3921400", VA = "0x183922400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class LFFDOBNJCHH<T1, T2, T3> : IComparable<LFFDOBNJCHH<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly T1 IABIEGLKPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly T2 CDOFKAJLPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly T3 OOGJAKNPBGK;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7380", Offset = "0x3CE6380", VA = "0x183CE7380")]
	public LFFDOBNJCHH(T1 BFJFNJEKGNE, T2 LKOJNOBLAHB, T3 ENGENLOLJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3CE6A40", Offset = "0x3CE5A40", VA = "0x183CE6A40", Slot = "4")]
	public int CompareTo(LFFDOBNJCHH<T1, T2, T3> PJNBIAFGNNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3CE6CC0", Offset = "0x3CE5CC0", VA = "0x183CE6CC0", Slot = "0")]
	public override bool Equals(object PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7010", Offset = "0x3CE6010", VA = "0x183CE7010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3CE71C0", Offset = "0x3CE61C0", VA = "0x183CE71C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T ADACBBLDADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x210E8B0", Offset = "0x210D8B0", VA = "0x18210E8B0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x210E620", Offset = "0x210D620", VA = "0x18210E620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float HDFHJKDEMMF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8BD130", Offset = "0x8BC130", VA = "0x1808BD130")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x45260F0", Offset = "0x45250F0", VA = "0x1845260F0")]
	public T NEMGIHJAIAG(float MPLEEKHPBJH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4526570", Offset = "0x4525570", VA = "0x184526570")]
	public T PDMNCHIPHBE(float MPLEEKHPBJH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T AOKGGJANFGH(T JAIIDLBPFND, T ECFHNKKEKBJ, float MPLEEKHPBJH);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6161AB0", Offset = "0x6160AB0", VA = "0x186161AB0", Slot = "4")]
	protected override float AOKGGJANFGH(float JAIIDLBPFND, float ECFHNKKEKBJ, float MPLEEKHPBJH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6161AF0", Offset = "0x6160AF0", VA = "0x186161AF0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xCF64C0", Offset = "0xCF54C0", VA = "0x180CF64C0", Slot = "4")]
	protected override Vector3 AOKGGJANFGH(Vector3 JAIIDLBPFND, Vector3 ECFHNKKEKBJ, float MPLEEKHPBJH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6165BD0", Offset = "0x6164BD0", VA = "0x186165BD0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x61608D0", Offset = "0x615F8D0", VA = "0x1861608D0", Slot = "4")]
	protected override Color AOKGGJANFGH(Color JAIIDLBPFND, Color ECFHNKKEKBJ, float MPLEEKHPBJH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6160990", Offset = "0x615F990", VA = "0x186160990")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class OPGLENJLFJO : GPCMMICDCNE<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6163AC0", Offset = "0x6162AC0", VA = "0x186163AC0")]
	public OPGLENJLFJO(int CCPFDJOINBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6163A50", Offset = "0x6162A50", VA = "0x186163A50", Slot = "6")]
	protected override uint DPBIGDHGNEN(uint NLBCJPBLAOB, string CFJDHAGGAJO)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class CPKFCPJJGHM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly IDisposable GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public CPKFCPJJGHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct IECPLDPNHGD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> OGPLJDGLEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int NJBIHNCBFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int AHOAFJCDDKH;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3925150", Offset = "0x3924150", VA = "0x183925150")]
	private IECPLDPNHGD(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> KIENLANKNCO, int CEAJBDKKMNM, int MKGJPBKIBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3925050", Offset = "0x3924050", VA = "0x183925050")]
	public static IECPLDPNHGD<T> NAJBLLJFKKI()
	{
		return default(IECPLDPNHGD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x39242D0", Offset = "0x39232D0", VA = "0x1839242D0")]
	public (int, int, Task<T>) LNKALOIBIBD(int PHEFCCOCLHJ, [Optional] CancellationToken JMJKFNJJBHM, double KMADAIPOJJD = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x39236D0", Offset = "0x39226D0", VA = "0x1839236D0")]
	public void AAIMIGGKKOK(int PHEFCCOCLHJ, int MKGJPBKIBBD, [In] T HEOGODCLBDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class MOKHKIHJKFI
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6163A00", Offset = "0x6162A00", VA = "0x186163A00")]
	public static IECPLDPNHGD<EMBFKEMHPML> NAJBLLJFKKI()
	{
		return default(IECPLDPNHGD<EMBFKEMHPML>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6163980", Offset = "0x6162980", VA = "0x186163980")]
	public static void AAIMIGGKKOK([In] this IECPLDPNHGD<EMBFKEMHPML> AOFEPADBPDL, int PHEFCCOCLHJ, int MKGJPBKIBBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public class HJGPAECFMAI<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Dictionary<TKey, TVal> ACFPJGCFJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly Dictionary<TVal, TKey> LGJODDIGNPJ;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int BIBAPHNHGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3111D10", Offset = "0x3110D10", VA = "0x183111D10", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool LMHDAJNCEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> OHDALKNMOFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x332F800", Offset = "0x332E800", VA = "0x18332F800", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> HJJJENCHCKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x37D9B30", Offset = "0x37D8B30", VA = "0x1837D9B30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal EIFMNNJBIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x37D9AD0", Offset = "0x37D8AD0", VA = "0x1837D9AD0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x37D9B90", Offset = "0x37D8B90", VA = "0x1837D9B90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey EIFMNNJBIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x37D95C0", Offset = "0x37D85C0", VA = "0x1837D95C0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x37D8DB0", Offset = "0x37D7DB0", VA = "0x1837D8DB0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x37D9860", Offset = "0x37D8860", VA = "0x1837D9860", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x37D8D60", Offset = "0x37D7D60", VA = "0x1837D8D60", Slot = "9")]
	public void Add(TKey IPAJBJLLPIJ, TVal CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x37D8D10", Offset = "0x37D7D10", VA = "0x1837D8D10", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> OBBILAKFCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x37D8E10", Offset = "0x37D7E10", VA = "0x1837D8E10", Slot = "8")]
	public bool ContainsKey(TKey IPAJBJLLPIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x37D8EB0", Offset = "0x37D7EB0", VA = "0x1837D8EB0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> OBBILAKFCOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x37D97D0", Offset = "0x37D87D0", VA = "0x1837D97D0", Slot = "10")]
	public bool Remove(TKey IPAJBJLLPIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x37D9830", Offset = "0x37D8830", VA = "0x1837D9830", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> OBBILAKFCOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x37D9950", Offset = "0x37D8950", VA = "0x1837D9950", Slot = "11")]
	public bool TryGetValue(TKey IPAJBJLLPIJ, [Out] TVal CFJDHAGGAJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x37D8F60", Offset = "0x37D7F60", VA = "0x1837D8F60", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x37D8EE0", Offset = "0x37D7EE0", VA = "0x1837D8EE0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] IJPOMPNGBEF, int HEBNJPJHHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x37D92A0", Offset = "0x37D82A0", VA = "0x1837D92A0")]
	public bool IJFOADKACJF(TVal IPAJBJLLPIJ, [Out] TKey CFJDHAGGAJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x37D91B0", Offset = "0x37D81B0", VA = "0x1837D91B0")]
	private void HMKNOIFDOKN(TKey IPAJBJLLPIJ, TVal GKDIIMKFCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x37D9610", Offset = "0x37D8610", VA = "0x1837D9610")]
	private void PKDDKHBDDDI(TKey IPAJBJLLPIJ, TVal GKDIIMKFCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x37D93C0", Offset = "0x37D83C0", VA = "0x1837D93C0")]
	private bool KCFKKKNNEBA(TKey IPAJBJLLPIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x37D9990", Offset = "0x37D8990", VA = "0x1837D9990")]
	public HJGPAECFMAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[DefaultMember("Item")]
public class MKDDFLABMAB<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private MKDDFLABMAB<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x33820F0", Offset = "0x33810F0", VA = "0x1833820F0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x3394830", Offset = "0x3393830", VA = "0x183394830", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x33958A0", Offset = "0x33948A0", VA = "0x1833958A0")]
		public Enumerator(MKDDFLABMAB<T> EOOJCJAHOCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3391B00", Offset = "0x3390B00", VA = "0x183391B00", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3393650", Offset = "0x3392650", VA = "0x183393650", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x33910C0", Offset = "0x33900C0", VA = "0x1833910C0")]
		private void EPDPGJPEDHG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private T[] NNECKNPBAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int BMGBMMPKFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int HADODMBICCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private int PENODPCCLDA;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int BIBAPHNHGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2FE0", Offset = "0x3ED1FE0", VA = "0x183ED2FE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T EIFMNNJBIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2F00", Offset = "0x3ED1F00", VA = "0x183ED2F00")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3ED1C80", Offset = "0x3ED0C80", VA = "0x183ED1C80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3ED3BB0", Offset = "0x3ED2BB0", VA = "0x183ED3BB0")]
	public MKDDFLABMAB(int CCPFDJOINBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3ED2440", Offset = "0x3ED1440", VA = "0x183ED2440")]
	public void EMJMPPLJJNE(T MPLEEKHPBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3ED2020", Offset = "0x3ED1020", VA = "0x183ED2020")]
	public void BGPDDONPEEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3ED1F70", Offset = "0x3ED0F70", VA = "0x183ED1F70")]
	public void BEGMJEMHEDK(int FBDNKGNOEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3ED3300", Offset = "0x3ED2300", VA = "0x183ED3300")]
	public void PLDGNADFKDM(T[] IJPOMPNGBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3ED2120", Offset = "0x3ED1120", VA = "0x183ED2120")]
	public Enumerator CJGNNJFLGEE()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3ED3940", Offset = "0x3ED2940", VA = "0x183ED3940", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3ED3940", Offset = "0x3ED2940", VA = "0x183ED3940", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3ED27E0", Offset = "0x3ED17E0", VA = "0x183ED27E0")]
	private int HBKJMGAELIF(int GCDIELAOHNA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3ED2040", Offset = "0x3ED1040", VA = "0x183ED2040")]
	private int BPIGJHHMBGG(int GCDIELAOHNA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class DDFOPLJMNNK<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Func<Internal, External> LOJOALCAKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private IReadOnlyList<Internal> JOAHCODCDPO;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public External EIFMNNJBIIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x50AD4C0", Offset = "0x50AC4C0", VA = "0x1850AD4C0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int BIBAPHNHGKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x50AD470", Offset = "0x50AC470", VA = "0x1850AD470", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	public DDFOPLJMNNK(Func<Internal, External> LOJOALCAKFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x50AD420", Offset = "0x50AC420", VA = "0x1850AD420")]
	public DDFOPLJMNNK(IReadOnlyList<Internal> JOAHCODCDPO, Func<Internal, External> LOJOALCAKFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x50AD3A0", Offset = "0x50AC3A0", VA = "0x1850AD3A0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3689B60", Offset = "0x3688B60", VA = "0x183689B60", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class DIBJJEDMJPI<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate Task<TResult> CLBMDAGCEGD(TRequest LFFEKPPMJHN, CancellationToken JMJKFNJJBHM);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public enum COIGKENLAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class CEGIJEDIHLA
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private const float FGFFJAFPHCE = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TimeSpan JAOPNLPCFAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int DEIKHAHCNAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public COIGKENLAAJ HEPGEFMJFHO;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly CEGIJEDIHLA KOOHNFGMCMF;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float IIIDPLOJGOM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x4C8D830", Offset = "0x4C8C830", VA = "0x184C8D830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan PLGIJLGNHDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4C8D910", Offset = "0x4C8C910", VA = "0x184C8D910")]
		public CEGIJEDIHLA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private readonly struct GHFHPALKPNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly TRequest LFFEKPPMJHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly CancellationToken JMJKFNJJBHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly TaskCompletionSource<TResult> IFEIDNJIJAO;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x374B810", Offset = "0x374A810", VA = "0x18374B810")]
		public GHFHPALKPNA(TRequest LFFEKPPMJHN, TaskCompletionSource<TResult> IFEIDNJIJAO, CancellationToken JMJKFNJJBHM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct EAFKJMPOJDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public DIBJJEDMJPI<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3308FD0", Offset = "0x3307FD0", VA = "0x183308FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3309470", Offset = "0x3308470", VA = "0x183309470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct ONFCDDGMDKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public DIBJJEDMJPI<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private GHFHPALKPNA <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x40875C0", Offset = "0x40865C0", VA = "0x1840875C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4088730", Offset = "0x4087730", VA = "0x184088730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CancellationTokenSource ECLLDDAPDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly List<GHFHPALKPNA> JHLJLHBKJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly CEGIJEDIHLA BBENGKCNHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly CLBMDAGCEGD HIAPKDDEDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Task ILHLFBIMOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int FHMKLPNDLJH;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x50C8500", Offset = "0x50C7500", VA = "0x1850C8500")]
	public DIBJJEDMJPI(CLBMDAGCEGD HIAPKDDEDND, [Optional] CEGIJEDIHLA BBENGKCNHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x50C6ED0", Offset = "0x50C5ED0", VA = "0x1850C6ED0")]
	public Task<TResult> ENFAOGJAOBK(TRequest LFFEKPPMJHN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x50C6D40", Offset = "0x50C5D40", VA = "0x1850C6D40")]
	private void CJCBKKKIDAP(GHFHPALKPNA MHNDOMAOPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x50C75E0", Offset = "0x50C65E0", VA = "0x1850C75E0")]
	[AsyncStateMachine(typeof(DIBJJEDMJPI<, >.EAFKJMPOJDC))]
	private Task GFGKCPJELEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x50C7CE0", Offset = "0x50C6CE0", VA = "0x1850C7CE0")]
	private GHFHPALKPNA ONDDKLDGCBL()
	{
		return default(GHFHPALKPNA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x50C8220", Offset = "0x50C7220", VA = "0x1850C8220")]
	[AsyncStateMachine(typeof(DIBJJEDMJPI<, >.ONFCDDGMDKN))]
	private Task ONMPDLGGJKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x50C7780", Offset = "0x50C6780", VA = "0x1850C7780")]
	private void IOLBMMCHHIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x50C6E90", Offset = "0x50C5E90", VA = "0x1850C6E90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public class HMKBPNKNFDI<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly List<T> JOAHCODCDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HashSet<T> LIKFHPBMHIK;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int BIBAPHNHGKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3111D10", Offset = "0x3110D10", VA = "0x183111D10", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool LMHDAJNCEBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T EIFMNNJBIIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x37EB720", Offset = "0x37EA720", VA = "0x1837EB720", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x37EB840", Offset = "0x37EA840", VA = "0x1837EB840", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x36B3670", Offset = "0x36B2670", VA = "0x1836B3670", Slot = "11")]
	public void Add(T OBBILAKFCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x37EAFA0", Offset = "0x37E9FA0", VA = "0x1837EAFA0")]
	public bool FJICIMHALFB(T OBBILAKFCOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x37EB4F0", Offset = "0x37EA4F0", VA = "0x1837EB4F0", Slot = "15")]
	public bool Remove(T OBBILAKFCOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x37EB060", Offset = "0x37EA060", VA = "0x1837EB060", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x36D98D0", Offset = "0x36D88D0", VA = "0x1836D98D0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x37EAE10", Offset = "0x37E9E10", VA = "0x1837EAE10", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x37EAE70", Offset = "0x37E9E70", VA = "0x1837EAE70", Slot = "13")]
	public bool Contains(T OBBILAKFCOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x37EAEB0", Offset = "0x37E9EB0", VA = "0x1837EAEB0", Slot = "14")]
	public void CopyTo(T[] IJPOMPNGBEF, int HEBNJPJHHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x37EB0F0", Offset = "0x37EA0F0", VA = "0x1837EB0F0", Slot = "6")]
	public int IndexOf(T OBBILAKFCOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x37EB220", Offset = "0x37EA220", VA = "0x1837EB220", Slot = "7")]
	public void Insert(int GCDIELAOHNA, T OBBILAKFCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x37EB400", Offset = "0x37EA400", VA = "0x1837EB400", Slot = "8")]
	public void RemoveAt(int GCDIELAOHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x37EB630", Offset = "0x37EA630", VA = "0x1837EB630")]
	public HMKBPNKNFDI()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x1F6CBD0", Offset = "0x1F6BBD0", VA = "0x181F6CBD0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6165260", Offset = "0x6164260", VA = "0x186165260")]
		public SerializedGuid([In] Guid IECJFMHCKJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6165130", Offset = "0x6164130", VA = "0x186165130")]
		public static SerializedGuid LJCKNCCAHPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x61650C0", Offset = "0x61640C0", VA = "0x1861650C0")]
		public static SerializedGuid LIAJPCPEBJK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6164F80", Offset = "0x6163F80", VA = "0x186164F80")]
		public bool EKAOBJEABNJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6165230", Offset = "0x6164230", VA = "0x186165230", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x61651B0", Offset = "0x61641B0", VA = "0x1861651B0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6164FE0", Offset = "0x6163FE0", VA = "0x186164FE0", Slot = "7")]
		public bool Equals(SerializedGuid PJNBIAFGNNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6165020", Offset = "0x6164020", VA = "0x186165020", Slot = "0")]
		public override bool Equals(object FGOCJODIEMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x61650B0", Offset = "0x61640B0", VA = "0x1861650B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6164F50", Offset = "0x6163F50", VA = "0x186164F50", Slot = "6")]
		public int CompareTo(SerializedGuid PJNBIAFGNNN)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class BHEFGJJJFHD : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly Type LIIPOPJCLEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly string AGEGHPNNPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool GKFMDAFLNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool MPPFHJGGKMC;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x61607E0", Offset = "0x615F7E0", VA = "0x1861607E0")]
	public BHEFGJJJFHD(Type FPLBEHGDHGP, string DKIIJEBAPHD, bool FMEJKCJKEEE = false, bool HOLLAKJEFEI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class MFEMJMGOOCM<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public readonly struct LNGCDMGCKLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly long JLNKLEGNGIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly long HLJADLKBCJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly int AAIOKGLCCNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly int IBGBHHPIFIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly bool KCLMDBMFCAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly string APNBGBBNCNA;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3D00FD0", Offset = "0x3CFFFD0", VA = "0x183D00FD0")]
		public LNGCDMGCKLD(long JLNKLEGNGIG, int AAIOKGLCCNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3D01040", Offset = "0x3D00040", VA = "0x183D01040")]
		public LNGCDMGCKLD(long JLNKLEGNGIG, long HLJADLKBCJC, int AAIOKGLCCNO, int IBGBHHPIFIK, bool KCLMDBMFCAP, string APNBGBBNCNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3D00F80", Offset = "0x3CFFF80", VA = "0x183D00F80")]
		public int MEAHLPBLGEH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3D00F60", Offset = "0x3CFFF60", VA = "0x183D00F60")]
		public int FNCLPLMAFMA(int DAHLHKGEGMC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3D00F00", Offset = "0x3CFFF00", VA = "0x183D00F00")]
		public double CFFEDPECPON()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3D00E60", Offset = "0x3CFFE60", VA = "0x183D00E60")]
		public LNGCDMGCKLD BMGFOFFFHPO(long HLJADLKBCJC, int IBGBHHPIFIK)
		{
			return default(LNGCDMGCKLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class ENJHCLDNEDD : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct IHCHCLCODEI<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public ENJHCLDNEDD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Func<ENJHCLDNEDD, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private ENJHCLDNEDD <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x3932070", Offset = "0x3931070", VA = "0x183932070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x3932590", Offset = "0x3931590", VA = "0x183932590", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly TKey KHCGDDAFALB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly MFEMJMGOOCM<TKey> HKNHNBDNOFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly LPCGADPJIJD IJDHPGKKFNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private List<ENJHCLDNEDD> AGHHDCJDCBF;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string EOEBLBKOOCB
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x332EC70", Offset = "0x332DC70", VA = "0x18332EC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<ENJHCLDNEDD> AEADNLPNBLN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x332E8B0", Offset = "0x332D8B0", VA = "0x18332E8B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public LNGCDMGCKLD PAAHDLHGECK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x332EAF0", Offset = "0x332DAF0", VA = "0x18332EAF0")]
			[CompilerGenerated]
			get
			{
				return default(LNGCDMGCKLD);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x332ECA0", Offset = "0x332DCA0", VA = "0x18332ECA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x332ECD0", Offset = "0x332DCD0", VA = "0x18332ECD0")]
		internal ENJHCLDNEDD(MFEMJMGOOCM<TKey> HKNHNBDNOFH, TKey IPAJBJLLPIJ, LPCGADPJIJD IJDHPGKKFNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x332EB10", Offset = "0x332DB10", VA = "0x18332EB10")]
		public ENJHCLDNEDD GHKNFDHBFEH(TKey IPAJBJLLPIJ, [Optional] LPCGADPJIJD? NBEIIJOPMKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x22D3120", Offset = "0x22D2120", VA = "0x1822D3120")]
		[AsyncStateMachine(typeof(IHCHCLCODEI<>))]
		public Task<T> IAGIHDKGKCG<T>(TKey IPAJBJLLPIJ, Func<ENJHCLDNEDD, Task<T>> MNLLJIAJFCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x332E8F0", Offset = "0x332D8F0", VA = "0x18332E8F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class LKMMMMNPELG : IEnumerable<(TKey, List<TKey>, LNGCDMGCKLD)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LNGCDMGCKLD)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private (TKey key, List<TKey> path, LNGCDMGCKLD timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public MFEMJMGOOCM<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<(TKey key, List<TKey> path, LNGCDMGCKLD timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, LNGCDMGCKLD) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1F79990", Offset = "0x1F78990", VA = "0x181F79990", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LNGCDMGCKLD));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x3CF40C0", Offset = "0x3CF30C0", VA = "0x183CF40C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1F79A80", Offset = "0x1F78A80", VA = "0x181F79A80")]
		[DebuggerHidden]
		public LKMMMMNPELG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3685110", Offset = "0x3684110", VA = "0x183685110", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3CF3C70", Offset = "0x3CF2C70", VA = "0x183CF3C70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3CF3C20", Offset = "0x3CF2C20", VA = "0x183CF3C20")]
		private void GFMFCNEFFMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3CF4070", Offset = "0x3CF3070", VA = "0x183CF4070", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3CF3FB0", Offset = "0x3CF2FB0", VA = "0x183CF3FB0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LNGCDMGCKLD)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x368D260", Offset = "0x368C260", VA = "0x18368D260", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class FCLPCJIMCNB : IEnumerable<(TKey, List<TKey>, LNGCDMGCKLD)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LNGCDMGCKLD)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private (TKey key, List<TKey> path, LNGCDMGCKLD timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private ENJHCLDNEDD timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public ENJHCLDNEDD <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public MFEMJMGOOCM<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private IEnumerator<ENJHCLDNEDD> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IEnumerator<(TKey key, List<TKey> path, LNGCDMGCKLD timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, LNGCDMGCKLD) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x1F79990", Offset = "0x1F78990", VA = "0x181F79990", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LNGCDMGCKLD));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x3668010", Offset = "0x3667010", VA = "0x183668010", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1F79A80", Offset = "0x1F78A80", VA = "0x181F79A80")]
		[DebuggerHidden]
		public FCLPCJIMCNB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3668070", Offset = "0x3667070", VA = "0x183668070", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3667700", Offset = "0x3666700", VA = "0x183667700", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x36676A0", Offset = "0x36666A0", VA = "0x1836676A0")]
		private void GFMFCNEFFMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3667640", Offset = "0x3666640", VA = "0x183667640")]
		private void FIEDEKGMCFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3667FC0", Offset = "0x3666FC0", VA = "0x183667FC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3667EB0", Offset = "0x3666EB0", VA = "0x183667EB0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LNGCDMGCKLD)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3667F90", Offset = "0x3666F90", VA = "0x183667F90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Action<TKey, LNGCDMGCKLD, LPCGADPJIJD> DDMMJOMJGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Action<TKey, LNGCDMGCKLD, LPCGADPJIJD> GJBECPAEILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Action<MFEMJMGOOCM<TKey>, LPCGADPJIJD> HMICPJCJHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly LPCGADPJIJD IJDHPGKKFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly ENJHCLDNEDD BEMJPOKHLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool HBKBODDFLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int BNFMKAPACDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly Stopwatch OFNBJEINPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly int GJAPILCPOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string ABFLONMJCHD;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public ENJHCLDNEDD HCOOMCHFPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string EOEBLBKOOCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7C1250", Offset = "0x7C0250", VA = "0x1807C1250")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3ECBC00", Offset = "0x3ECAC00", VA = "0x183ECBC00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3ECBC60", Offset = "0x3ECAC60", VA = "0x183ECBC60")]
	public MFEMJMGOOCM(TKey HDCNEMOGKNB, LPCGADPJIJD IJDHPGKKFNN, [Optional] int? AAIOKGLCCNO, [Optional][CanBeNull] Stopwatch OFNBJEINPKO, [Optional] Action<TKey, LNGCDMGCKLD, LPCGADPJIJD> DDMMJOMJGFL, [Optional] Action<TKey, LNGCDMGCKLD, LPCGADPJIJD> GJBECPAEILL, [Optional] Action<MFEMJMGOOCM<TKey>, LPCGADPJIJD> HMICPJCJHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3ECB990", Offset = "0x3ECA990", VA = "0x183ECB990", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3ECBA20", Offset = "0x3ECAA20", VA = "0x183ECBA20")]
	[IteratorStateMachine(typeof(MFEMJMGOOCM<>.LKMMMMNPELG))]
	public IEnumerable<(TKey, List<TKey>, LNGCDMGCKLD)> KBOPFIBKKBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3ECBAB0", Offset = "0x3ECAAB0", VA = "0x183ECBAB0")]
	[IteratorStateMachine(typeof(MFEMJMGOOCM<>.FCLPCJIMCNB))]
	private IEnumerable<(TKey, List<TKey>, LNGCDMGCKLD)> KBOPFIBKKBI(List<TKey> MOOBDKACMAL, ENJHCLDNEDD BGNFGAIAJFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3ECBB80", Offset = "0x3ECAB80", VA = "0x183ECBB80")]
	private (long, int) LPDOEHKDOAH()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public abstract class LEIGEGKHEJL<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut GBFIGDCBOBD(MFEMJMGOOCM<TKey> HKNHNBDNOFH);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	protected LEIGEGKHEJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public abstract class DIKHJMDCBAF<TKey> : LEIGEGKHEJL<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate string FEANAAGODFD(TKey IPAJBJLLPIJ);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x50C8B90", Offset = "0x50C7B90", VA = "0x1850C8B90")]
	private static string KHAOPHPKBPB(TKey IPAJBJLLPIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x50C8AD0", Offset = "0x50C7AD0", VA = "0x1850C8AD0", Slot = "4")]
	public override string GBFIGDCBOBD(MFEMJMGOOCM<TKey> HKNHNBDNOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x50C8980", Offset = "0x50C7980", VA = "0x1850C8980")]
	public string GBFIGDCBOBD(MFEMJMGOOCM<TKey> HKNHNBDNOFH, [NotNull] FEANAAGODFD HBCFBNKJKGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string DNNAAICONEB(MFEMJMGOOCM<TKey> HKNHNBDNOFH, [NotNull] FEANAAGODFD HBCFBNKJKGG);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3986FC0", Offset = "0x3985FC0", VA = "0x183986FC0")]
	protected DIKHJMDCBAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class DEHIIEFAAJC<TKey> : LEIGEGKHEJL<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate string CFMBOHPHFKP(TKey IPAJBJLLPIJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly string IIEIDGJAPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly double EMHGMGNCNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly bool MMIMBJDFOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly int KBKPPPNILMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly ISet<string> GFOKJHBEELL;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x50B8C90", Offset = "0x50B7C90", VA = "0x1850B8C90")]
	private static string KHAOPHPKBPB(TKey IPAJBJLLPIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x50B8E30", Offset = "0x50B7E30", VA = "0x1850B8E30")]
	public DEHIIEFAAJC(string IIEIDGJAPMB = "F2", double EMHGMGNCNCH = double.MaxValue, bool MMIMBJDFOGB = false, int KBKPPPNILMP = int.MaxValue, [Optional] ISet<string> GFOKJHBEELL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x50B88B0", Offset = "0x50B78B0", VA = "0x1850B88B0", Slot = "4")]
	public override Dictionary<string, string> GBFIGDCBOBD(MFEMJMGOOCM<TKey> HKNHNBDNOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x50B8970", Offset = "0x50B7970", VA = "0x1850B8970")]
	private bool GFEPEAIJEDJ(string HPAFFPGIHEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x50B82C0", Offset = "0x50B72C0", VA = "0x1850B82C0")]
	public Dictionary<string, string> GBFIGDCBOBD(MFEMJMGOOCM<TKey> HKNHNBDNOFH, CFMBOHPHFKP HBCFBNKJKGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x50B8A50", Offset = "0x50B7A50", VA = "0x1850B8A50")]
	private string HMEBEMKFELD(StringBuilder AGBHAFNJOKB, List<TKey> CCJFEBDLLEH, CFMBOHPHFKP HBCFBNKJKGG, bool GADPHPJOGML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x50B8CD0", Offset = "0x50B7CD0", VA = "0x1850B8CD0")]
	private static void OMHICPPHPGO(StringBuilder CJDGPMHONMO, string DHLODILGPKL, bool PODADDGNDNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class LKLCKDLOMOF<TKey> : DIKHJMDCBAF<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct KBDGPKEJEEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public FEANAAGODFD keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static LKLCKDLOMOF<TKey> GDAKEGIGEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly string[] HILGCCICKDK;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3CF3AE0", Offset = "0x3CF2AE0", VA = "0x183CF3AE0")]
	private LKLCKDLOMOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3CF2A80", Offset = "0x3CF1A80", VA = "0x183CF2A80", Slot = "5")]
	protected override string DNNAAICONEB(MFEMJMGOOCM<TKey> HKNHNBDNOFH, FEANAAGODFD HBCFBNKJKGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3CF38B0", Offset = "0x3CF28B0", VA = "0x183CF38B0")]
	[CompilerGenerated]
	internal static string NNGMMCMNMJN(string ACCMPLBKBJO, TKey IPAJBJLLPIJ, KBDGPKEJEEF P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class LAPLLDBBBLP : MFEMJMGOOCM<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class ECABIEALJGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Action<LAPLLDBBBLP, LPCGADPJIJD> callback;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public ECABIEALJGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x61618B0", Offset = "0x61608B0", VA = "0x1861618B0")]
		internal void EMOJHJLJIFM(MFEMJMGOOCM<string> timer, LPCGADPJIJD log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6163830", Offset = "0x6162830", VA = "0x186163830")]
	public LAPLLDBBBLP(LPCGADPJIJD IJDHPGKKFNN, [Optional] string IDLJMMKGNMN, [Optional] int? AAIOKGLCCNO, [Optional] Stopwatch OFNBJEINPKO, [Optional] Action<string, LNGCDMGCKLD, LPCGADPJIJD> DDMMJOMJGFL, [Optional] Action<string, LNGCDMGCKLD, LPCGADPJIJD> GJBECPAEILL, [Optional] Action<LAPLLDBBBLP, LPCGADPJIJD> HMICPJCJHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6163770", Offset = "0x6162770", VA = "0x186163770")]
	private static Action<MFEMJMGOOCM<string>, LPCGADPJIJD> MAKAAOPEEEJ(Action<LAPLLDBBBLP, LPCGADPJIJD> ADABDJONAPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public abstract class JOGGFLCIKED
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private class JEBMNGLPCEE : JOGGFLCIKED
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static JOGGFLCIKED GDAKEGIGEFB
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x6162FC0", Offset = "0x6161FC0", VA = "0x186162FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float KJAPLOODLML
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x1D9D820", Offset = "0x1D9C820", VA = "0x181D9D820", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x61630C0", Offset = "0x61620C0", VA = "0x1861630C0")]
		public JEBMNGLPCEE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static JOGGFLCIKED LGAJEBIBMEA;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static JOGGFLCIKED KOOHNFGMCMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6163110", Offset = "0x6162110", VA = "0x186163110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float KJAPLOODLML
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	protected JOGGFLCIKED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class NPPCCPGECKO<T> : AOEJGKLMNAK<T> where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public override Task<T> OHJAFNLPBII
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public override BJNFJNCLHKJ<T> KHFJODAPKMA
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1F0", Offset = "0x7BC1F0", VA = "0x1807BD1F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3FAD950", Offset = "0x3FAC950", VA = "0x183FAD950")]
	public NPPCCPGECKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "10")]
	protected override void FCMPBOFGJDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class IMGHOMGNELM<T> : AOEJGKLMNAK<T> where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public override Task<T> OHJAFNLPBII
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override BJNFJNCLHKJ<T> KHFJODAPKMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1F0", Offset = "0x7BC1F0", VA = "0x1807BD1F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3961A40", Offset = "0x3960A40", VA = "0x183961A40")]
	public IMGHOMGNELM(Exception LPBJFENAMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "10")]
	protected override void FCMPBOFGJDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface IDHALJOCJBC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool CLLGOADBCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface DEHADEPDEGA<T> : IDHALJOCJBC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[NotNull]
	Task<T> OHJAFNLPBII
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	[NotNull]
	BJNFJNCLHKJ<T> KHFJODAPKMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public abstract class AOEJGKLMNAK<T> : DEHADEPDEGA<T>, IDHALJOCJBC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly CNDMELHGHNJ JBHJEOGJNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool HBKBODDFLFH;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool CLLGOADBCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xA117A0", Offset = "0xA107A0", VA = "0x180A117A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public abstract Task<T> OHJAFNLPBII
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public abstract BJNFJNCLHKJ<T> KHFJODAPKMA
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x38DE900", Offset = "0x38DD900", VA = "0x1838DE900")]
	public AOEJGKLMNAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x38DE7A0", Offset = "0x38DD7A0", VA = "0x1838DE7A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void FCMPBOFGJDM();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public abstract class ICPMMDPLJFP<TTask, T> : AOEJGKLMNAK<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class CCCHOJACODE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public CCCHOJACODE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x3100E90", Offset = "0x30FFE90", VA = "0x183100E90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x3101400", Offset = "0x3100400", VA = "0x183101400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public ICPMMDPLJFP<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public CCCHOJACODE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x4B8F940", Offset = "0x4B8E940", VA = "0x184B8F940")]
		[AsyncStateMachine(typeof(ICPMMDPLJFP<, >.CCCHOJACODE.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> LNAHHKBCGJP(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Task<T> JCGMNOGFGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	protected readonly CancellationTokenSource COPLNLJNKII;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public override Task<T> OHJAFNLPBII
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public override BJNFJNCLHKJ<T> KHFJODAPKMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1F0", Offset = "0x7BC1F0", VA = "0x1807BD1F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3920500", Offset = "0x391F500", VA = "0x183920500")]
	protected ICPMMDPLJFP(TTask JCGMNOGFGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3920170", Offset = "0x391F170", VA = "0x183920170", Slot = "10")]
	protected override void FCMPBOFGJDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T HNHGCKLPGOL(TTask NPJKPLIOPNN);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void BCPMFLCKAME();
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class CHDMDEDDLNF<T> : AOEJGKLMNAK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly ACLFJKPGHAP<Task<T>> AMNOBIGHONC;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public override Task<T> OHJAFNLPBII
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x37A4620", Offset = "0x37A3620", VA = "0x1837A4620", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public override BJNFJNCLHKJ<T> KHFJODAPKMA
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1F0", Offset = "0x7BC1F0", VA = "0x1807BD1F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x4C91BC0", Offset = "0x4C90BC0", VA = "0x184C91BC0")]
	public CHDMDEDDLNF(ACLFJKPGHAP<Task<T>> BMEFLOBPOHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x4C91BA0", Offset = "0x4C90BA0", VA = "0x184C91BA0", Slot = "10")]
	protected override void FCMPBOFGJDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class GENPLCOPPEC
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6161BA0", Offset = "0x6160BA0", VA = "0x186161BA0")]
	[NotNull]
	public static byte[] AMKKHJPLCAI(this JAABKIBFIHP KIHHNGADECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6161B30", Offset = "0x6160B30", VA = "0x186161B30")]
	[NotNull]
	public static byte[] AMKKHJPLCAI(this JAABKIBFIHP KIHHNGADECE, HashAlgorithmName HMAJGKPBPBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6161C10", Offset = "0x6160C10", VA = "0x186161C10")]
	public static bool CKPEIBMGHIL([CanBeNull] this JAABKIBFIHP KIHHNGADECE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6161DA0", Offset = "0x6160DA0", VA = "0x186161DA0")]
	public static bool CKPEIBMGHIL([CanBeNull] this JAABKIBFIHP KIHHNGADECE, [Out] string AIKAPCCDDEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6161F40", Offset = "0x6160F40", VA = "0x186161F40")]
	private static bool MIOFHGOHLMF([NotNull] JAABKIBFIHP KIHHNGADECE, [Out][CanBeNull] byte[] NGFKEBDJPPG, [Out][CanBeNull] byte[] KGBFDJEIFEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class DJDNBDLHKIB
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6161670", Offset = "0x6160670", VA = "0x186161670")]
	[NotNull]
	public static byte[] AMKKHJPLCAI(this LAKEDFNJCFE LHJCPKNKLON, HashAlgorithmName HMAJGKPBPBJ, byte[] OOLDLEMGLMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface LAKEDFNJCFE
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash NLBCJPBLAOB);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface JAABKIBFIHP : LAKEDFNJCFE
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	[CanBeNull]
	byte[] IFFJGDFJGMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	[CanBeNull]
	byte[] NIGAOMBDECM
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class DCBFKBLDEDF
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static readonly ArrayPool<byte> GKPPABDADGC;

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static bool PEDJFFPIBCM;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x2635450", Offset = "0x2634450", VA = "0x182635450")]
	public static void LFKFMJEICLJ<T>(this IncrementalHash BDNIHGLKJDF, [CanBeNull] T HDIPHGOKDCK) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x26353C0", Offset = "0x26343C0", VA = "0x1826353C0")]
	public static void JBILCMGNGIB<T>(this IncrementalHash BDNIHGLKJDF, [CanBeNull] T LHJCPKNKLON) where T : LAKEDFNJCFE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2635510", Offset = "0x2634510", VA = "0x182635510")]
	public static void PFPFKCDJBJG<T>(this IncrementalHash BDNIHGLKJDF, [CanBeNull] IList<T> JPNKFGJBOFP) where T : LAKEDFNJCFE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6161170", Offset = "0x6160170", VA = "0x186161170")]
	private static bool LLMACLEODEK([CanBeNull] LAKEDFNJCFE LHJCPKNKLON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6160BA0", Offset = "0x615FBA0", VA = "0x186160BA0")]
	public static void DOOHAFLPIAO(this IncrementalHash NLBCJPBLAOB, [CanBeNull] string FNILFGNEOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6160E30", Offset = "0x615FE30", VA = "0x186160E30")]
	public static void JIIHKIPOGNB(this IncrementalHash NLBCJPBLAOB, long BMCNPNDEJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6161200", Offset = "0x6160200", VA = "0x186161200")]
	public static void OBBIPEKKCLN(this IncrementalHash NLBCJPBLAOB, int ADPGKPALOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x61609D0", Offset = "0x615F9D0", VA = "0x1861609D0")]
	public static void CPMIOOOCNEM(this IncrementalHash NLBCJPBLAOB, short NIABANMOCAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6160D20", Offset = "0x615FD20", VA = "0x186160D20")]
	public static void HEJGGBJNIAL(this IncrementalHash NLBCJPBLAOB, byte KBLFNEENFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6161000", Offset = "0x6160000", VA = "0x186161000")]
	public static void KHFFMGGNEGI(this IncrementalHash NLBCJPBLAOB, bool NIDBFBBAPKK, bool NLDBBDAGNNM = false, bool CCBNNDNLNAN = false, bool JBGIKMELFJL = false, bool IJGOEIAMOEO = false, bool JFAPDGGPHGA = false, bool EPOIIONKNOO = false, bool DPILCBDKOLO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2634D90", Offset = "0x2633D90", VA = "0x182634D90")]
	public static void BFFEKLHMFHN<T>(this IncrementalHash NLBCJPBLAOB, T PDPILKIDIPM) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6160C00", Offset = "0x615FC00", VA = "0x186160C00")]
	public static void EKKHBFIIFEM(this IncrementalHash NLBCJPBLAOB, float MKLMNJFDGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6160CC0", Offset = "0x615FCC0", VA = "0x186160CC0")]
	public static void FPPJAOGMENK(this IncrementalHash NLBCJPBLAOB, ulong MPFHBEEIFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6161500", Offset = "0x6160500", VA = "0x186161500")]
	public static void PJGPKOLKFLK(this IncrementalHash NLBCJPBLAOB, uint DDBAMOFKBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6160C60", Offset = "0x615FC60", VA = "0x186160C60")]
	public static void FLFLFFBHHII(this IncrementalHash NLBCJPBLAOB, ushort GBCLFMKHONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x61613D0", Offset = "0x61603D0", VA = "0x1861613D0")]
	public static void OJEPBILKAHD(this IncrementalHash NLBCJPBLAOB, Vector3 MBCNAGDGKAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class KEJENJDNBDO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6163280", Offset = "0x6162280", VA = "0x186163280")]
	public KEJENJDNBDO(string DFJKCKBFLAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public abstract class PEHIEKDOIDB<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	internal class KKAKCJCHEFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public TNode AOFEPADBPDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public TNode MMPNPJILHCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public MMOEIDNAODJ MIPPFCPNLIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public List<MMOEIDNAODJ> EMEBEJLAMLO;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public KKAKCJCHEFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal struct MMOEIDNAODJ : IComparable<MMOEIDNAODJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int KMEFFDJFINH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public TClaimant DKDDDNEKLEG;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xC44CC0", Offset = "0xC43CC0", VA = "0x180C44CC0")]
		public MMOEIDNAODJ(int KMEFFDJFINH, TClaimant DKDDDNEKLEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3ED7BD0", Offset = "0x3ED6BD0", VA = "0x183ED7BD0")]
		public bool FABJOLGEPCK([In] MMOEIDNAODJ PJNBIAFGNNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3ED7C30", Offset = "0x3ED6C30", VA = "0x183ED7C30")]
		public bool OEDIBIJBJHG([In] MMOEIDNAODJ PJNBIAFGNNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3ED7BC0", Offset = "0x3ED6BC0", VA = "0x183ED7BC0", Slot = "4")]
		public int CompareTo(MMOEIDNAODJ PJNBIAFGNNN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3ED7C40", Offset = "0x3ED6C40", VA = "0x183ED7C40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum DGNOGIDDCDM
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class MDIPCKCPMLD : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public PEHIEKDOIDB<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x80FF60", Offset = "0x80EF60", VA = "0x18080FF60")]
		[DebuggerHidden]
		public MDIPCKCPMLD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3EBFE20", Offset = "0x3EBEE20", VA = "0x183EBFE20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3EBFFE0", Offset = "0x3EBEFE0", VA = "0x183EBFFE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3EBFF00", Offset = "0x3EBEF00", VA = "0x183EBFF00", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3686580", Offset = "0x3685580", VA = "0x183686580", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static readonly MFOEMOFPBGB<KKAKCJCHEFD> MBDGGLHECOD;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static readonly MFOEMOFPBGB<List<MMOEIDNAODJ>> GGNILJAFLBP;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static int GIOLBPCLIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	internal readonly Dictionary<TClaimant, TNode> BGIBABHFDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	internal readonly Dictionary<TNode, KKAKCJCHEFD> CNLJLKLIBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private DGNOGIDDCDM AHPNAMMDGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool FIBIHEBBEBM;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode CIHBJKNPHHM(TNode PENNBKHEEFF);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void EOFFKJJFLND(TNode PENNBKHEEFF, TClaimant FMKIPDNEMEG, TClaimant OHICLJACNDD);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x4140220", Offset = "0x413F220", VA = "0x184140220")]
	public PEHIEKDOIDB(DGNOGIDDCDM AHPNAMMDGCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x413F560", Offset = "0x413E560", VA = "0x18413F560")]
	public void GAEPMDELBEG(TNode PENNBKHEEFF, TNode DIMMPCLNOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x413F440", Offset = "0x413E440", VA = "0x18413F440")]
	public void FPIOMCHHIAF(TClaimant DKDDDNEKLEG, TNode ECHFEMKABEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x413EEC0", Offset = "0x413DEC0", VA = "0x18413EEC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x413F5F0", Offset = "0x413E5F0", VA = "0x18413F5F0")]
	private void GALHPLCKFHI(TClaimant DKDDDNEKLEG, TNode NEOJBAFNAKP, TNode ECHFEMKABEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x413F090", Offset = "0x413E090", VA = "0x18413F090")]
	private int EKHDAPAKBGC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x413F100", Offset = "0x413E100", VA = "0x18413F100")]
	private void EPOELKMMNBF(TClaimant DKDDDNEKLEG, TNode NGOFGFPMMGK, TNode AOOGJNGBDNO, int KMCJLCONECM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x413F910", Offset = "0x413E910", VA = "0x18413F910")]
	private void KMMNFCBLKPG(MMOEIDNAODJ FOEHCKBEBKH, KKAKCJCHEFD OKABGGPDJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x413EBE0", Offset = "0x413DBE0", VA = "0x18413EBE0")]
	private void DBAMIIPNAMI(TClaimant DKDDDNEKLEG, TNode NGOFGFPMMGK, TNode AOOGJNGBDNO, int KMCJLCONECM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x413F690", Offset = "0x413E690", VA = "0x18413F690")]
	private void GMCAJEFPLIG(MMOEIDNAODJ FOEHCKBEBKH, TNode PENNBKHEEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x413EA00", Offset = "0x413DA00", VA = "0x18413EA00")]
	private void AANIGIPBGKG(MMOEIDNAODJ FOEHCKBEBKH, KKAKCJCHEFD OKABGGPDJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x413FF30", Offset = "0x413EF30", VA = "0x18413FF30")]
	private void NJBGDOGKOKC(KKAKCJCHEFD OKABGGPDJIM, bool OMAKIIFPNEO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x413FBF0", Offset = "0x413EBF0", VA = "0x18413FBF0")]
	private void MOFHLJBFJCE(KKAKCJCHEFD OKABGGPDJIM, TNode DIMMPCLNOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x413F9A0", Offset = "0x413E9A0", VA = "0x18413F9A0")]
	[IteratorStateMachine(typeof(PEHIEKDOIDB<, >.MDIPCKCPMLD))]
	private IEnumerable<TNode> MFHIPEMKIBC(TNode NGOFGFPMMGK, TNode AOOGJNGBDNO, bool DABPMKONOJB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x413EAF0", Offset = "0x413DAF0", VA = "0x18413EAF0")]
	private KKAKCJCHEFD CBDMDNFKICI(TNode PENNBKHEEFF, TNode MMPNPJILHCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x413FA80", Offset = "0x413EA80", VA = "0x18413FA80")]
	private KKAKCJCHEFD MHJCJMBFGGL(TNode PENNBKHEEFF, TNode MMPNPJILHCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x413F7A0", Offset = "0x413E7A0", VA = "0x18413F7A0")]
	private void ILKFLHDENBK(KKAKCJCHEFD OKABGGPDJIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class GPCMMICDCNE<T> : IEnumerable<GPCMMICDCNE<T>.AKLKHCJICML>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct AKLKHCJICML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public T CFJDHAGGAJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int GCDIELAOHNA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class HFBJEGGNDJD : IEnumerator<AKLKHCJICML>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private GPCMMICDCNE<T> JJNGNJIDCFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private int GCDIELAOHNA;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x3337320", Offset = "0x3336320", VA = "0x183337320", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public AKLKHCJICML FKHNLELEDDF
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x37C79E0", Offset = "0x37C69E0", VA = "0x1837C79E0", Slot = "4")]
			get
			{
				return default(AKLKHCJICML);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x37C79A0", Offset = "0x37C69A0", VA = "0x1837C79A0")]
		public HFBJEGGNDJD(GPCMMICDCNE<T> JJNGNJIDCFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x37C78A0", Offset = "0x37C68A0", VA = "0x1837C78A0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x338A120", Offset = "0x3389120", VA = "0x18338A120", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8772A0", Offset = "0x8762A0", VA = "0x1808772A0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private struct PKDOHHPDPBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public bool OBHKMBHEEGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public T CFJDHAGGAJO;
	}

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int HFPEOGAGLBD = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly Dictionary<T, int> PKEGCDMBGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private PKDOHHPDPBF[] MCDECPAPIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int AICNIBLEHKA;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int IGBBPHBOKDB
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7FABC0", Offset = "0x7F9BC0", VA = "0x1807FABC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7FA1C0", Offset = "0x7F91C0", VA = "0x1807FA1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int BIBAPHNHGKH
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3111D10", Offset = "0x3110D10", VA = "0x183111D10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x376BCC0", Offset = "0x376ACC0", VA = "0x18376BCC0")]
	public GPCMMICDCNE(int CCPFDJOINBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x376C170", Offset = "0x376B170", VA = "0x18376C170")]
	public GPCMMICDCNE(AKLKHCJICML[] ANPJPPHLECG, bool CFCDENBBBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x376B0B0", Offset = "0x376A0B0", VA = "0x18376B0B0")]
	public int EDGLENOLPIL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x376B7C0", Offset = "0x376A7C0", VA = "0x18376B7C0")]
	private int KGNKKOAHLMN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x376B050", Offset = "0x376A050", VA = "0x18376B050", Slot = "6")]
	protected virtual uint DPBIGDHGNEN(uint NLBCJPBLAOB, T CFJDHAGGAJO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x376B720", Offset = "0x376A720", VA = "0x18376B720")]
	public bool HBMKINACGEC(T CFJDHAGGAJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x376B6B0", Offset = "0x376A6B0", VA = "0x18376B6B0")]
	public int GDNFINECJNC(T CFJDHAGGAJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x376AFE0", Offset = "0x3769FE0", VA = "0x18376AFE0")]
	public T CCNECELHLHO(int GCDIELAOHNA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x376B190", Offset = "0x376A190", VA = "0x18376B190")]
	public bool FJICIMHALFB(T CFJDHAGGAJO, bool GGEOPHGOLNM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x376B1E0", Offset = "0x376A1E0", VA = "0x18376B1E0")]
	public bool FJICIMHALFB(T CFJDHAGGAJO, int GCDIELAOHNA, bool GGEOPHGOLNM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x376BBF0", Offset = "0x376ABF0", VA = "0x18376BBF0")]
	private int MFKEEMIFDCM(int BMGBMMPKFAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x376BC40", Offset = "0x376AC40", VA = "0x18376BC40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x376BC40", Offset = "0x376AC40", VA = "0x18376BC40", Slot = "4")]
	private IEnumerator<AKLKHCJICML> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class MFOEMOFPBGB<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Stack<T> HHNFMDHKOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly List<T> AAKKDOEFBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly int GJAIPJOBNJM;

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x3ECBE10", Offset = "0x3ECAE10", VA = "0x183ECBE10")]
	public static MFOEMOFPBGB<T> CPOFHEHNMEM(int CCPFDJOINBO = 0, int GJAIPJOBNJM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x3ECC030", Offset = "0x3ECB030", VA = "0x183ECC030")]
	public static MFOEMOFPBGB<T> EKFLJPNHOEA(int CCPFDJOINBO = 0, int GJAIPJOBNJM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x3ECC800", Offset = "0x3ECB800", VA = "0x183ECC800")]
	public MFOEMOFPBGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3ECC660", Offset = "0x3ECB660", VA = "0x183ECC660")]
	public MFOEMOFPBGB(int CCPFDJOINBO, int GJAIPJOBNJM = int.MaxValue, bool ALJDBOOFFIL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3ECC110", Offset = "0x3ECB110", VA = "0x183ECC110")]
	public T IFDEMMDFBAC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3ECC590", Offset = "0x3ECB590", VA = "0x183ECC590")]
	public void PJJDMGCOONE(T CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x3ECC290", Offset = "0x3ECB290", VA = "0x183ECC290")]
	private void JEFBANFGOHG(T CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x3ECC570", Offset = "0x3ECB570", VA = "0x183ECC570")]
	private void OIKLKOLKDGF(T CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x3ECBEF0", Offset = "0x3ECAEF0", VA = "0x183ECBEF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x3ECC370", Offset = "0x3ECB370", VA = "0x183ECC370")]
	private void MJLCNAGMPFO(IEnumerable<T> MHPPDDHIHNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class IAPGGHGAMNK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private Dictionary<int, T> MBMBPCDJPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private T BHHLAEELGHC;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual T MOEECCKFNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7BC240", Offset = "0x7BB240", VA = "0x1807BC240", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3886070", Offset = "0x3885070", VA = "0x183886070")]
	public bool DEHFHPLHDND(T CFJDHAGGAJO, int KMEFFDJFINH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x38860F0", Offset = "0x38850F0", VA = "0x1838860F0")]
	public bool FPCJCHDGKKD(int KMEFFDJFINH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x3885A70", Offset = "0x3884A70", VA = "0x183885A70")]
	public T CHANNEMKPCC(int LEEEHDPOIDJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x3885F60", Offset = "0x3884F60", VA = "0x183885F60")]
	private bool CHPFKDDDCNL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3886160", Offset = "0x3885160", VA = "0x183886160")]
	public bool IJFOADKACJF(int KMEFFDJFINH, [Out] T CFJDHAGGAJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x38861B0", Offset = "0x38851B0", VA = "0x1838861B0")]
	public IAPGGHGAMNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class EIHGKDHMBOM<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	protected struct MCGICNMOODI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public T ADACBBLDADO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int GKGGLDOMHLF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	protected readonly List<MCGICNMOODI> NNECKNPBAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private T BICIMIEMAPB;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int BIBAPHNHGKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3111D10", Offset = "0x3110D10", VA = "0x183111D10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x3319AF0", Offset = "0x3318AF0", VA = "0x183319AF0")]
	public bool NNJMGGGBMOM(T CFJDHAGGAJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x3319880", Offset = "0x3318880", VA = "0x183319880")]
	public void EMJMPPLJJNE(T CFJDHAGGAJO, int KMEFFDJFINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x33199A0", Offset = "0x33189A0", VA = "0x1833199A0")]
	public bool JOBFLKKFIPF(T CFJDHAGGAJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x3319820", Offset = "0x3318820", VA = "0x183319820")]
	public void BGPDDONPEEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x3319920", Offset = "0x3318920", VA = "0x183319920")]
	public T IAIKPMNFKNK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x3319C70", Offset = "0x3318C70", VA = "0x183319C70")]
	private void PDPNFCFMBBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x3319DD0", Offset = "0x3318DD0", VA = "0x183319DD0")]
	public EIHGKDHMBOM()
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
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[SerializeField]
		[JMOFFDBDEHI(HLBGFFAONPF.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x6163C50", Offset = "0x6162C50", VA = "0x186163C50")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x6163F20", Offset = "0x6162F20", VA = "0x186163F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x6163E30", Offset = "0x6162E30", VA = "0x186163E30")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x6163BA0", Offset = "0x6162BA0", VA = "0x186163BA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x6163E70", Offset = "0x6162E70", VA = "0x186163E70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x6163D80", Offset = "0x6162D80", VA = "0x186163D80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6163B10", Offset = "0x6162B10", VA = "0x186163B10")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x42FD590", Offset = "0x42FC590", VA = "0x1842FD590", Slot = "4")]
		public virtual T BIANBKMDNFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class JEAIAJGCPCO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly Dictionary<byte, KHKECHGKFFD> AGBNKICDNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly MFOEMOFPBGB<KHKECHGKFFD> FBLPJBENLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly bool APEABNCHOFC;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public KHKECHGKFFD LECLOJJPBAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7BC250", Offset = "0x7BB250", VA = "0x1807BC250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Vector2 BMEDEPCMCKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xBC04D0", Offset = "0xBBF4D0", VA = "0x180BC04D0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xE9D5A0", Offset = "0xE9C5A0", VA = "0x180E9D5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private Vector2 NFLJGHPMEOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xEDC620", Offset = "0xEDB620", VA = "0x180EDC620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public Vector2 HBLGNOLBILK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6162820", Offset = "0x6161820", VA = "0x186162820")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7BC470", Offset = "0x7BB470", VA = "0x1807BC470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public int BOLLIHDACGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x7C5A80", Offset = "0x7C4A80", VA = "0x1807C5A80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x7C56E0", Offset = "0x7C46E0", VA = "0x1807C56E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6162B30", Offset = "0x6161B30", VA = "0x186162B30")]
	public JEAIAJGCPCO(Bounds BNIKILPIKHI, Vector2[] JHJKOGAFCIM, int DAEEMCBINOE, byte BMGBMMPKFAO, float HKGHKCEPGAG = 0f, [Optional] MFOEMOFPBGB<KHKECHGKFFD> FBLPJBENLCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x61625A0", Offset = "0x61615A0", VA = "0x1861625A0")]
	public KHKECHGKFFD IFCIODDBFEJ(byte GCDIELAOHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6162410", Offset = "0x6161410", VA = "0x186162410")]
	public void CNHHGHPLLEP(Vector3 PKDBIHBDKOO, float LMGADFJACEJ, float LCLDOJFLPNF, List<byte> ODFNIPEEPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x58E42C0", Offset = "0x58E32C0", VA = "0x1858E42C0")]
	public void JGGIMFFPJBL(KHKECHGKFFD.GEHBDPAJLHO HCPAHIFJHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6162840", Offset = "0x6161840", VA = "0x186162840")]
	public static int KAMONJMGFNM(Vector2[] JHJKOGAFCIM, int DAEEMCBINOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6162930", Offset = "0x6161930", VA = "0x186162930")]
	private KHKECHGKFFD OLDDFFEDEPM(byte GCDIELAOHNA, KHKECHGKFFD.NMHFMBABMPI ADMMFOIKNGB, KHKECHGKFFD MMPNPJILHCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6162060", Offset = "0x6161060", VA = "0x186162060")]
	private void BHIBLFNIHKN(KHKECHGKFFD MMPNPJILHCD, Vector2[] JHJKOGAFCIM, int EOLKKNLOMKG, int AICCNAIABPI, int HMONGLECLMK, int PJGHECPDFOM, float HKGHKCEPGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6162600", Offset = "0x6161600", VA = "0x186162600")]
	private void JGDLLAJBBFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x61624E0", Offset = "0x61614E0", VA = "0x1861624E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6162540", Offset = "0x6161540", VA = "0x186162540", Slot = "1")]
	~JEAIAJGCPCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class KHKECHGKFFD
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public enum NMHFMBABMPI
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum GEHBDPAJLHO
	{
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public byte NIAPEAHEHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public Vector3 NFAKLOBMPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public Vector3 DAPBPFEGNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public Vector3 GAFFLGADFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public Vector3 CHKFKAIOLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public NMHFMBABMPI GLIBHAOPBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public KHKECHGKFFD APJKJHMNMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public List<KHKECHGKFFD> IIGGHLJJDNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public bool FEJEDGCKKNB;

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6163750", Offset = "0x6162750", VA = "0x186163750")]
	public KHKECHGKFFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x61635D0", Offset = "0x61625D0", VA = "0x1861635D0")]
	public void EPJFLKIHBEG(KHKECHGKFFD ONPHKLFILKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280")]
	public void JGGIMFFPJBL(int IBPFJHAEPJC, GEHBDPAJLHO HCPAHIFJHKP, int JCACFEGOIDE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x61632E0", Offset = "0x61622E0", VA = "0x1861632E0")]
	public void CNHHGHPLLEP(List<byte> ODFNIPEEPCI, Vector3 PKDBIHBDKOO, float LMGADFJACEJ, float LCLDOJFLPNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6163720", Offset = "0x6162720", VA = "0x186163720")]
	public bool ODCKJDPPHLK(Vector3 HLCDMCNCOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x61636F0", Offset = "0x61626F0", VA = "0x1861636F0")]
	public bool GAIEOHJDJBA(Vector3 HLCDMCNCOBO, float KLCONKJOFGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6163540", Offset = "0x6162540", VA = "0x186163540")]
	public void DPGLELIALOP()
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
		public struct DNMGCDDAFKN<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private readonly List<Component> JOAHCODCDPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private readonly bool KPEFJOBHHBM;

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x3915B90", Offset = "0x3914B90", VA = "0x183915B90")]
			public DNMGCDDAFKN(List<Component> JOAHCODCDPO, bool KPEFJOBHHBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x50DFCA0", Offset = "0x50DECA0", VA = "0x1850DFCA0")]
			public ELOOCNOIHCO<T> CJGNNJFLGEE()
			{
				return default(ELOOCNOIHCO<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x50DFD10", Offset = "0x50DED10", VA = "0x1850DFD10", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x50DFD10", Offset = "0x50DED10", VA = "0x1850DFD10", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public struct ELOOCNOIHCO<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private readonly List<Component> JOAHCODCDPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private readonly bool KPEFJOBHHBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private int GCDIELAOHNA;

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public T FKHNLELEDDF
			{
				[Cpp2IlInjected.Token(Token = "0x60001EC")]
				[Cpp2IlInjected.Address(RVA = "0x3329A80", Offset = "0x3328A80", VA = "0x183329A80", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001ED")]
				[Cpp2IlInjected.Address(RVA = "0x3329A10", Offset = "0x3328A10", VA = "0x183329A10", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x3329A50", Offset = "0x3328A50", VA = "0x183329A50")]
			public ELOOCNOIHCO(List<Component> JOAHCODCDPO, bool KPEFJOBHHBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x3329940", Offset = "0x3328940", VA = "0x183329940", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x3329950", Offset = "0x3328950", VA = "0x183329950", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x3329A00", Offset = "0x3328A00", VA = "0x183329A00", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x61657A0", Offset = "0x61647A0", VA = "0x1861657A0")]
		private void DPGLELIALOP(GameObject HKFHFFDFJOO, bool GCPGMMGNKLP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x61655E0", Offset = "0x61645E0", VA = "0x1861655E0")]
		public static void DPGLELIALOP(GameObject HKFHFFDFJOO, ToolHierarchyCache AMEJCPPGMKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x2A683B0", Offset = "0x2A673B0", VA = "0x182A683B0")]
		public void IGNHEJBJFCC<T>(Action<T> DFHNKDINOMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2A68340", Offset = "0x2A67340", VA = "0x182A68340")]
		public T AFMBDCNHJFJ<T>(bool KPEFJOBHHBM = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x2A685D0", Offset = "0x2A675D0", VA = "0x182A685D0")]
		public DNMGCDDAFKN<T> MDINAEBENAL<T>(bool KPEFJOBHHBM = false) where T : class
		{
			return default(DNMGCDDAFKN<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6165290", Offset = "0x6164290", VA = "0x186165290")]
		public List<Component> CANDIGEKKEO(Type IKHOLAJCJOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6165910", Offset = "0x6164910", VA = "0x186165910", Slot = "4")]
		public bool Equals(ToolHierarchyCache GDALFMOOMGE, ToolHierarchyCache CPFDGDKGJBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6165990", Offset = "0x6164990", VA = "0x186165990", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache FGOCJODIEMI)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class AHMKPNOFJMB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private int CCPFDJOINBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int AOHHPFODLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private List<T> JOGMOPACDKH;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int BIBAPHNHGKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x37A4620", Offset = "0x37A3620", VA = "0x1837A4620")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public T GMLEKMDNCFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x37A4740", Offset = "0x37A3740", VA = "0x1837A4740")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public T OPAABIPNEAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x37A4670", Offset = "0x37A3670", VA = "0x1837A4670")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public T LKDELJLAKPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x37A4470", Offset = "0x37A3470", VA = "0x1837A4470")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x37A48B0", Offset = "0x37A38B0", VA = "0x1837A48B0")]
	public AHMKPNOFJMB(int CCPFDJOINBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x37A4220", Offset = "0x37A3220", VA = "0x1837A4220")]
	public void EMJMPPLJJNE(T KPIGDOEMLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x37A41E0", Offset = "0x37A31E0", VA = "0x1837A41E0")]
	public void BGPDDONPEEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x37A4550", Offset = "0x37A3550", VA = "0x1837A4550")]
	public void INDJEIBHOLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x37A4410", Offset = "0x37A3410", VA = "0x1837A4410")]
	public void GPJOLMKOOLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x37A4660", Offset = "0x37A3660", VA = "0x1837A4660")]
	public void NCGPBPPHNDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class INKPKBFCKAP<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private struct BIACPALLJOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int GKGGLDOMHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public T ADACBBLDADO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly Dictionary<object, BIACPALLJOO> MBMBPCDJPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly EqualityComparer<T> BFNKHALNKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private T BHHLAEELGHC;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public virtual T MOEECCKFNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x1074BF0", Offset = "0x1073BF0", VA = "0x181074BF0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x397EDA0", Offset = "0x397DDA0", VA = "0x18397EDA0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool NBOGOOLPGIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x397EE90", Offset = "0x397DE90", VA = "0x18397EE90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public object AAKGFPJDKMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7BD940", Offset = "0x7BC940", VA = "0x1807BD940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x397E170", Offset = "0x397D170", VA = "0x18397E170")]
	public bool DEHFHPLHDND(T CFJDHAGGAJO, object OGACLNNOKDA, int KMEFFDJFINH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x397E500", Offset = "0x397D500", VA = "0x18397E500")]
	public bool FPCJCHDGKKD(object OGACLNNOKDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x397E610", Offset = "0x397D610", VA = "0x18397E610")]
	public bool IJFOADKACJF(object OGACLNNOKDA, [Out] T CFJDHAGGAJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x397B120", Offset = "0x397A120", VA = "0x18397B120")]
	public void BGPDDONPEEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x397C610", Offset = "0x397B610", VA = "0x18397C610")]
	private bool CHPFKDDDCNL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x397EEE0", Offset = "0x397DEE0", VA = "0x18397EEE0")]
	public INKPKBFCKAP()
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
