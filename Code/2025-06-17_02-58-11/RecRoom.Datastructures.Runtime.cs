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
using Microsoft.CodeAnalysis;
using RecRoom.Attributes;
using RecRoom.Core.DataStructures;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7D0F5B0", Offset = "0x7D0DFB0", VA = "0x187D0F5B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA35A80", Offset = "0xA34480", VA = "0x180A35A80")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA35AC0", Offset = "0xA344C0", VA = "0x180A35AC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MOOKCIFOLKL : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x21EE890", Offset = "0x21ED290", VA = "0x1821EE890")]
	public MOOKCIFOLKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, ANHDCKFMHKN, JDGJGMOJJCI, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA0A570", Offset = "0xA08F70", VA = "0x180A0A570", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD0DC80", Offset = "0xD0C680", VA = "0x180D0DC80", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash IHCNKMENBKK);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xC49D80", Offset = "0xC48780", VA = "0x180C49D80")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[SerializeField]
	[ReadOnlyField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[SerializeField]
	[ReadOnlyField]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7D10780", Offset = "0x7D0F180", VA = "0x187D10780")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7D10740", Offset = "0x7D0F140", VA = "0x187D10740")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7D107C0", Offset = "0x7D0F1C0", VA = "0x187D107C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7D10970", Offset = "0x7D0F370", VA = "0x187D10970")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7D108E0", Offset = "0x7D0F2E0", VA = "0x187D108E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA66550", Offset = "0xA64F50", VA = "0x180A66550")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA66560", Offset = "0xA64F60", VA = "0x180A66560")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7D10700", Offset = "0x7D0F100", VA = "0x187D10700")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7D10850", Offset = "0x7D0F250", VA = "0x187D10850")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7D10350", Offset = "0x7D0ED50", VA = "0x187D10350")]
	public void CopyBounds(SavedExtents NDNHELJMDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7D10650", Offset = "0x7D0F050", VA = "0x187D10650")]
	public void SetLocalSpaceBounds(Bounds EEBOJOOEAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1579BF0", Offset = "0x15785F0", VA = "0x181579BF0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7D10640", Offset = "0x7D0F040", VA = "0x187D10640")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7D0FB60", Offset = "0x7D0E560", VA = "0x187D0FB60")]
	private void BNNNKIHNHJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7D10440", Offset = "0x7D0EE40", VA = "0x187D10440")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7D0FD10", Offset = "0x7D0E710", VA = "0x187D0FD10")]
	public static void CalculateLocalBoundsFor(GameObject HNGFDIJGINB, [Out] Bounds EEBOJOOEAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7D10380", Offset = "0x7D0ED80", VA = "0x187D10380")]
	private static void FKPFOGOLOEG(Bounds LJDEEJKPAEN, Color CIBCGCDEGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7D10670", Offset = "0x7D0F070", VA = "0x187D10670")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA09110", Offset = "0xA07B10", VA = "0x180A09110")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA155F0", Offset = "0xA13FF0", VA = "0x180A155F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1A267B0", Offset = "0x1A251B0", VA = "0x181A267B0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x598A6E0", Offset = "0x59890E0", VA = "0x18598A6E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "4")]
	public virtual void BAOAPBOOAMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[MOOKCIFOLKL]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x598A310", Offset = "0x5988D10", VA = "0x18598A310", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5989160", Offset = "0x5987B60", VA = "0x185989160", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x598A640", Offset = "0x5989040", VA = "0x18598A640")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class PPBEGEPOBPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public PPBEGEPOBPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5791CE0", Offset = "0x57906E0", VA = "0x185791CE0")]
		internal int GNBLLPLKLIM(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[MOOKCIFOLKL]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x46FDD60", Offset = "0x46FC760", VA = "0x1846FDD60", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x46FDDA0", Offset = "0x46FC7A0", VA = "0x1846FDDA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x46FDC80", Offset = "0x46FC680", VA = "0x1846FDC80", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey KJNEHANBOBO]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x46FDD00", Offset = "0x46FC700", VA = "0x1846FDD00", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x46FDB80", Offset = "0x46FC580", VA = "0x1846FDB80", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x46FD8A0", Offset = "0x46FC2A0", VA = "0x1846FD8A0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x46FCD90", Offset = "0x46FB790", VA = "0x1846FCD90", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x46FCC60", Offset = "0x46FB660", VA = "0x1846FCC60", Slot = "14")]
	protected virtual string GBNHHINGOMA(TKeyVal FPBJFGGMDOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x46FCC20", Offset = "0x46FB620", VA = "0x1846FCC20", Slot = "4")]
	public bool ContainsKey(TKey KJNEHANBOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x46FDA50", Offset = "0x46FC450", VA = "0x1846FDA50", Slot = "5")]
	public bool TryGetValue(TKey KJNEHANBOBO, [Out] TVal PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x46FCCF0", Offset = "0x46FB6F0", VA = "0x1846FCCF0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x46FCCF0", Offset = "0x46FB6F0", VA = "0x1846FCCF0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x46FDA90", Offset = "0x46FC490", VA = "0x1846FDA90")]
	protected EditableSerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class SerializedReferenceKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[SerializeReference]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7A0", Offset = "0xA091A0", VA = "0x180A0A7A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	protected SerializedReferenceKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class SerializedReferenceDictionary<TKey, TVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private class SerializedReferenceKeyValuePair : SerializedReferenceKeyVal<TKey, TVal>
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x465BD60", Offset = "0x465A760", VA = "0x18465BD60")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[MOOKCIFOLKL]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x598BD80", Offset = "0x598A780", VA = "0x18598BD80")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x598B6D0", Offset = "0x598A0D0", VA = "0x18598B6D0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x598AD50", Offset = "0x5989750", VA = "0x18598AD50", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class JCONDOOMIGD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct HGEHMAGBCBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public T AMCECKEAKLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float INCMCCHBPGP;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int IIPCPHLCMPO = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float GHLPPLBHACE = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly HGEHMAGBCBJ[] KLDOGKPLNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int EIBOGLMIOCB;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float DMFOMELAPJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xCA95B0", Offset = "0xCA7FB0", VA = "0x180CA95B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xCF0BC0", Offset = "0xCEF5C0", VA = "0x180CF0BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public T LDCOIDNBEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x50555D0", Offset = "0x5053FD0", VA = "0x1850555D0")]
	protected JCONDOOMIGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x50555F0", Offset = "0x5053FF0", VA = "0x1850555F0")]
	protected JCONDOOMIGD(int OPKPFANIILK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5055410", Offset = "0x5053E10", VA = "0x185055410")]
	public void PBDMKLNODMP(float FDFNAMJJMBO, T PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool IDHJIPMCIAF(float JCDBIBKMNJP, float IEBICIECCML, [Out] T PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool MFFJKBJPGNP(float JCDBIBKMNJP, float IEBICIECCML, [Out] T PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x50553B0", Offset = "0x5053DB0", VA = "0x1850553B0")]
	public void MPMJEFEEPDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LNGMGOELLFJ : JCONDOOMIGD<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7D0DFE0", Offset = "0x7D0C9E0", VA = "0x187D0DFE0", Slot = "4")]
	public override bool IDHJIPMCIAF(float JCDBIBKMNJP, float IEBICIECCML, [Out] Vector3 PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7D0E140", Offset = "0x7D0CB40", VA = "0x187D0E140", Slot = "5")]
	public override bool MFFJKBJPGNP(float JCDBIBKMNJP, float IEBICIECCML, [Out] Vector3 PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7D0E280", Offset = "0x7D0CC80", VA = "0x187D0E280")]
	public LNGMGOELLFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class DCKLHIBDCPD
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x38A1970", Offset = "0x38A0370", VA = "0x1838A1970")]
	public static PCDLKLMNBFN<T1, T2> JEBOFNEMEAN<T1, T2>(T1 EIEOJGMFGNJ, T2 FAAJFBFAJLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x38A19F0", Offset = "0x38A03F0", VA = "0x1838A19F0")]
	public static NHNLCEGNOLM<T1, T2, T3> JEBOFNEMEAN<T1, T2, T3>(T1 EIEOJGMFGNJ, T2 FAAJFBFAJLD, T3 MKALBCJNMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x54D9FE0", Offset = "0x54D89E0", VA = "0x1854D9FE0")]
	internal static int NCCKOMNELBB(int IGFOFJAJGEL, int OAHJBKKIPIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6ED75E0", Offset = "0x6ED5FE0", VA = "0x186ED75E0")]
	internal static int NCCKOMNELBB(int IGFOFJAJGEL, int OAHJBKKIPIH, int LFGGFMPDNBO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class PCDLKLMNBFN<T1, T2> : IComparable<PCDLKLMNBFN<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 GCMEANEGIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 KFGBCPIOJAF;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5757F70", Offset = "0x5756970", VA = "0x185757F70")]
	public PCDLKLMNBFN(T1 EIEOJGMFGNJ, T2 FAAJFBFAJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5756640", Offset = "0x5755040", VA = "0x185756640", Slot = "4")]
	public int CompareTo(PCDLKLMNBFN<T1, T2> NDNHELJMDCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5756AB0", Offset = "0x57554B0", VA = "0x185756AB0", Slot = "0")]
	public override bool Equals(object NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5757440", Offset = "0x5755E40", VA = "0x185757440", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x57577D0", Offset = "0x57561D0", VA = "0x1857577D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NHNLCEGNOLM<T1, T2, T3> : IComparable<NHNLCEGNOLM<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 GCMEANEGIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 KFGBCPIOJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 PBEEOFHKKNB;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x55052E0", Offset = "0x5503CE0", VA = "0x1855052E0")]
	public NHNLCEGNOLM(T1 EIEOJGMFGNJ, T2 FAAJFBFAJLD, T3 MKALBCJNMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x55049C0", Offset = "0x55033C0", VA = "0x1855049C0", Slot = "4")]
	public int CompareTo(NHNLCEGNOLM<T1, T2, T3> NDNHELJMDCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5504C20", Offset = "0x5503620", VA = "0x185504C20", Slot = "0")]
	public override bool Equals(object NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5504EF0", Offset = "0x55038F0", VA = "0x185504EF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5505130", Offset = "0x5503B30", VA = "0x185505130", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public AnimationCurve GNGAGPBCPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T HLDMHOJGCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x12D5200", Offset = "0x12D3C00", VA = "0x1812D5200")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T MBIDHALPFLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xC9A360", Offset = "0xC98D60", VA = "0x180C9A360")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T AMCECKEAKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2CF2FC0", Offset = "0x2CF19C0", VA = "0x182CF2FC0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2CF3070", Offset = "0x2CF1A70", VA = "0x182CF3070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float LMLEFBGOJLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE80", Offset = "0xA5A880", VA = "0x180A5BE80")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5C433B0", Offset = "0x5C41DB0", VA = "0x185C433B0")]
	public T IMNLDEDAFNC(float ANAFNAJGANI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5C43130", Offset = "0x5C41B30", VA = "0x185C43130")]
	public T IBOGJIMNFEK(float ANAFNAJGANI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T EMPEDCADLAK(T LCMCGCNDGLJ, T JAOCPECLJLL, float ANAFNAJGANI);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7D0CEF0", Offset = "0x7D0B8F0", VA = "0x187D0CEF0", Slot = "4")]
	protected override float EMPEDCADLAK(float LCMCGCNDGLJ, float JAOCPECLJLL, float ANAFNAJGANI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7D0CF30", Offset = "0x7D0B930", VA = "0x187D0CF30")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x187F210", Offset = "0x187DC10", VA = "0x18187F210", Slot = "4")]
	protected override Vector3 EMPEDCADLAK(Vector3 LCMCGCNDGLJ, Vector3 JAOCPECLJLL, float ANAFNAJGANI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7D11740", Offset = "0x7D10140", VA = "0x187D11740")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7D0CAD0", Offset = "0x7D0B4D0", VA = "0x187D0CAD0", Slot = "4")]
	protected override Color EMPEDCADLAK(Color LCMCGCNDGLJ, Color JAOCPECLJLL, float ANAFNAJGANI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7D0CB90", Offset = "0x7D0B590", VA = "0x187D0CB90")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class AABFGJDLGGD : FINLMOPIAGC<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7D0C8C0", Offset = "0x7D0B2C0", VA = "0x187D0C8C0")]
	public AABFGJDLGGD(int OOPBDBFKCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7D0C850", Offset = "0x7D0B250", VA = "0x187D0C850", Slot = "6")]
	protected override uint GDKMHBEGPDN(uint IHCNKMENBKK, string PCDAHJCDHHF)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class DFLPBDDHFNO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IDisposable FDCAMNOGINK;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public DFLPBDDHFNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct FILGHCPOPAN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> MAFHDENLOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int ODBEJJODCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int FJNACDLKCKA;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4B43C50", Offset = "0x4B42650", VA = "0x184B43C50")]
	private FILGHCPOPAN(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> KEIPLMBADKN, int OOKDPEDJNCC, int EKKOCKBOLHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4B41AC0", Offset = "0x4B404C0", VA = "0x184B41AC0")]
	public static FILGHCPOPAN<T> FMDOFBCLPJB()
	{
		return default(FILGHCPOPAN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4B428B0", Offset = "0x4B412B0", VA = "0x184B428B0")]
	public (int, int, Task<T>) MMACDOJBANM(int NIHHJEGJCCB, [Optional] CancellationToken JKPNCAGHEDI, double CAJJAMECEFA = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4B435B0", Offset = "0x4B41FB0", VA = "0x184B435B0")]
	public void MMDKOIEGIMF(int NIHHJEGJCCB, int EKKOCKBOLHD, [In] T MGJNMKLFKCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class FCAKNPNGGDB
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7D0CE20", Offset = "0x7D0B820", VA = "0x187D0CE20")]
	public static FILGHCPOPAN<NOHGHNIBNOG> FMDOFBCLPJB()
	{
		return default(FILGHCPOPAN<NOHGHNIBNOG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7D0CE70", Offset = "0x7D0B870", VA = "0x187D0CE70")]
	public static void MMDKOIEGIMF([In] this FILGHCPOPAN<NOHGHNIBNOG> NMEFAPBBOCD, int NIHHJEGJCCB, int EKKOCKBOLHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class OIPLMHOGNKE<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly Dictionary<TKey, TVal> OHIENIPPICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TVal, TKey> MENPNOLDHNJ;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int IMMMMMEPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4255850", Offset = "0x4254250", VA = "0x184255850", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool HDMPHDAENOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> DFDJBNMBJHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5493280", Offset = "0x5491C80", VA = "0x185493280", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> GMPKHGAGCIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x5666890", Offset = "0x5665290", VA = "0x185666890", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5666830", Offset = "0x5665230", VA = "0x185666830", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x56668F0", Offset = "0x56652F0", VA = "0x1856668F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5665E40", Offset = "0x5664840", VA = "0x185665E40")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5666090", Offset = "0x5664A90", VA = "0x185666090", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x56666B0", Offset = "0x56650B0", VA = "0x1856666B0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5665F40", Offset = "0x5664940", VA = "0x185665F40", Slot = "9")]
	public void Add(TKey KJNEHANBOBO, TVal PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5665ED0", Offset = "0x56648D0", VA = "0x185665ED0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> HMJJODPHKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x56660F0", Offset = "0x5664AF0", VA = "0x1856660F0", Slot = "8")]
	public bool ContainsKey(TKey KJNEHANBOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5666160", Offset = "0x5664B60", VA = "0x185666160", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x56665E0", Offset = "0x5664FE0", VA = "0x1856665E0", Slot = "10")]
	public bool Remove(TKey KJNEHANBOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5666630", Offset = "0x5665030", VA = "0x185666630", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5666700", Offset = "0x5665100", VA = "0x185666700", Slot = "11")]
	public bool TryGetValue(TKey KJNEHANBOBO, [Out] TVal PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5666290", Offset = "0x5664C90", VA = "0x185666290", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5666190", Offset = "0x5664B90", VA = "0x185666190", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] KLDOGKPLNJA, int KFFMGEMIMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5666200", Offset = "0x5664C00", VA = "0x185666200")]
	public bool EHEIJGNBGFA(TVal KJNEHANBOBO, [Out] TKey PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x56664C0", Offset = "0x5664EC0", VA = "0x1856664C0")]
	private void PNICMOAGBCI(TKey KJNEHANBOBO, TVal KPILPFEAJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5665F70", Offset = "0x5664970", VA = "0x185665F70")]
	private void CJFHPFMCBLK(TKey KJNEHANBOBO, TVal KPILPFEAJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x56663F0", Offset = "0x5664DF0", VA = "0x1856663F0")]
	private bool NPEPDGMNLIL(TKey KJNEHANBOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5666740", Offset = "0x5665140", VA = "0x185666740")]
	public OIPLMHOGNKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class NLLPLOLNIGD<T> : IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private NLLPLOLNIGD<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x47541F0", Offset = "0x4752BF0", VA = "0x1847541F0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x4769920", Offset = "0x4768320", VA = "0x184769920", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x476A0F0", Offset = "0x4768AF0", VA = "0x18476A0F0")]
		public Enumerator(NLLPLOLNIGD<T> NNHDOHEKGEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4768060", Offset = "0x4766A60", VA = "0x184768060", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4768B50", Offset = "0x4767550", VA = "0x184768B50", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4767B90", Offset = "0x4766590", VA = "0x184767B90")]
		private void ADNFFDLFJHE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T[] MIGOHJBNJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int OBKGKEGIECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int OFHENEEBPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int GPMAOGCPKOA;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int IMMMMMEPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x553ABF0", Offset = "0x55395F0", VA = "0x18553ABF0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5538BA0", Offset = "0x55375A0", VA = "0x185538BA0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5538AB0", Offset = "0x55374B0", VA = "0x185538AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x553AB70", Offset = "0x5539570", VA = "0x18553AB70")]
	public NLLPLOLNIGD(int OOPBDBFKCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x553A700", Offset = "0x5539100", VA = "0x18553A700")]
	public void PBDMKLNODMP(T ANAFNAJGANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5539420", Offset = "0x5537E20", VA = "0x185539420")]
	public void BBBAJHJCMNI(IEnumerable<T> GMBPOMFEMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x553A2D0", Offset = "0x5538CD0", VA = "0x18553A2D0")]
	public void MPMJEFEEPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x553A7F0", Offset = "0x55391F0", VA = "0x18553A7F0")]
	public void POIMECGCLLC(int IMCIONKBBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5538700", Offset = "0x5537100", VA = "0x185538700")]
	public void AHEPFHGKECD(T[] KLDOGKPLNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x553A1C0", Offset = "0x5538BC0", VA = "0x18553A1C0")]
	public Enumerator ICNPOCIJNJG()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x553A910", Offset = "0x5539310", VA = "0x18553A910", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x553A910", Offset = "0x5539310", VA = "0x18553A910", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5537AD0", Offset = "0x55364D0", VA = "0x185537AD0")]
	private int AAMOMEGBGGJ(int MNFHMLCLFEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x553A190", Offset = "0x5538B90", VA = "0x18553A190")]
	private int FFGIPACCAMO(int MNFHMLCLFEB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class EFONCAEBAHP<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<TResult> MHGGHHLFJAN(TRequest OHOKHLNBDDB, CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum AGBIAMCPONH
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class AOHCINIPJMM
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const float MFDFGIAMPNE = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TimeSpan LGHJPGEPMFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int HPDJMBIMILE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AGBIAMCPONH CKNMOKMHBKJ;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly AOHCINIPJMM MCHDAMDLAPK;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float PEBGBHGPNNA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x4F794C0", Offset = "0x4F77EC0", VA = "0x184F794C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan AICENDLCHNI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x4F79610", Offset = "0x4F78010", VA = "0x184F79610")]
		public AOHCINIPJMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct KDPNONLIHFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly TRequest OHOKHLNBDDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly CancellationToken JKPNCAGHEDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly TaskCompletionSource<TResult> OCECEEDLDBF;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x51AFD60", Offset = "0x51AE760", VA = "0x1851AFD60")]
		public KDPNONLIHFB(TRequest OHOKHLNBDDB, TaskCompletionSource<TResult> OCECEEDLDBF, CancellationToken JKPNCAGHEDI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct GFBMPHJDGCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public EFONCAEBAHP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4C35440", Offset = "0x4C33E40", VA = "0x184C35440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4C36040", Offset = "0x4C34A40", VA = "0x184C36040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct NBCEGLEDKOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public EFONCAEBAHP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private KDPNONLIHFB <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x54EBB90", Offset = "0x54EA590", VA = "0x1854EBB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x54EC700", Offset = "0x54EB100", VA = "0x1854EC700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CancellationTokenSource KBLDHMPEKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<KDPNONLIHFB> PNGCEAPFJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly AOHCINIPJMM FLMOPLNMBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly MHGGHHLFJAN AHEODMJJFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Task PKGJFGGHMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int NDNOKHAIDNL;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4697050", Offset = "0x4695A50", VA = "0x184697050")]
	public EFONCAEBAHP(MHGGHHLFJAN AHEODMJJFBD, [Optional] AOHCINIPJMM FLMOPLNMBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4695750", Offset = "0x4694150", VA = "0x184695750")]
	public Task<TResult> ALLOMMDDLDO(TRequest OHOKHLNBDDB, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4696E50", Offset = "0x4695850", VA = "0x184696E50")]
	private void KGLFEPOMBEL(KDPNONLIHFB CEEODJEKHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4696330", Offset = "0x4694D30", VA = "0x184696330")]
	[AsyncStateMachine(typeof(EFONCAEBAHP<, >.GFBMPHJDGCI))]
	private Task FPHLNKHBNAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4696830", Offset = "0x4695230", VA = "0x184696830")]
	private KDPNONLIHFB HDOKDOCDGDJ()
	{
		return default(KDPNONLIHFB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4696050", Offset = "0x4694A50", VA = "0x184696050")]
	[AsyncStateMachine(typeof(EFONCAEBAHP<, >.NBCEGLEDKOD))]
	private Task ELHDJBGOHCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4695E30", Offset = "0x4694830", VA = "0x184695E30")]
	private void BDMCPMKGPDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4696010", Offset = "0x4694A10", VA = "0x184696010", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface IRRUISpriteLookup
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryFindSpriteByName(string spriteName, [Out] Sprite sprite);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class BFKPKFFLFFJ<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly List<T> IBKFNAMHILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<T> JEABIGFIJAJ;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int IMMMMMEPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4255850", Offset = "0x4254250", VA = "0x184255850", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool HDMPHDAENOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5482280", Offset = "0x5480C80", VA = "0x185482280", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x610D790", Offset = "0x610C190", VA = "0x18610D790", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4BB8AB0", Offset = "0x4BB74B0", VA = "0x184BB8AB0", Slot = "11")]
	public void Add(T HMJJODPHKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x610D260", Offset = "0x610BC60", VA = "0x18610D260")]
	public bool MNDHBHLHPAG(T HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x610D580", Offset = "0x610BF80", VA = "0x18610D580", Slot = "15")]
	public bool Remove(T HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x610D040", Offset = "0x610BA40", VA = "0x18610D040", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4BFE890", Offset = "0x4BFD290", VA = "0x184BFE890", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x610CF70", Offset = "0x610B970", VA = "0x18610CF70", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x610CFD0", Offset = "0x610B9D0", VA = "0x18610CFD0", Slot = "13")]
	public bool Contains(T HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x610D010", Offset = "0x610BA10", VA = "0x18610D010", Slot = "14")]
	public void CopyTo(T[] KLDOGKPLNJA, int KFFMGEMIMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5247E40", Offset = "0x5246840", VA = "0x185247E40", Slot = "6")]
	public int IndexOf(T HMJJODPHKCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x610D190", Offset = "0x610BB90", VA = "0x18610D190", Slot = "7")]
	public void Insert(int MNFHMLCLFEB, T HMJJODPHKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x610D4A0", Offset = "0x610BEA0", VA = "0x18610D4A0", Slot = "8")]
	public void RemoveAt(int MNFHMLCLFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x610D6A0", Offset = "0x610C0A0", VA = "0x18610D6A0")]
	public BFKPKFFLFFJ()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2B642A0", Offset = "0x2B62CA0", VA = "0x182B642A0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xA62040", Offset = "0xA60A40", VA = "0x180A62040")]
		public SerializedGuid([In] Guid FNKCCICOAII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7D10B00", Offset = "0x7D0F500", VA = "0x187D10B00")]
		public static SerializedGuid GLGFBGGBLDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7D10B90", Offset = "0x7D0F590", VA = "0x187D10B90")]
		public static SerializedGuid JKBLLKGCJAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7D10C00", Offset = "0x7D0F600", VA = "0x187D10C00")]
		public bool LFELJFCAJBE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7D10CE0", Offset = "0x7D0F6E0", VA = "0x187D10CE0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7D10C60", Offset = "0x7D0F660", VA = "0x187D10C60", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7D10A30", Offset = "0x7D0F430", VA = "0x187D10A30", Slot = "7")]
		public bool Equals(SerializedGuid NDNHELJMDCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7D10A70", Offset = "0x7D0F470", VA = "0x187D10A70", Slot = "0")]
		public override bool Equals(object OJDHMKOBKLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7D10B80", Offset = "0x7D0F580", VA = "0x187D10B80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7D10A00", Offset = "0x7D0F400", VA = "0x187D10A00", Slot = "6")]
		public int CompareTo(SerializedGuid NDNHELJMDCG)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class BMGLPDHJCCH : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Type GBEAKFHOFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string EMINPBIJGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool JAHIIBJGKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool JIEFNOKBACL;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7D0C910", Offset = "0x7D0B310", VA = "0x187D0C910")]
	public BMGLPDHJCCH(Type FCFGELOMMNO, string ONEHGOICHJH, bool EBHMFHHFAFN = false, bool LPGDBHKNPIH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface GKFHEHNJJKE<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	int FJCNOCFJFGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<T> HPLAHGJGDOL(float FDFNAMJJMBO, [Optional] float? EIKGOOBIGBH);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IHCMILLNEAN(float FDFNAMJJMBO, T PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MPMJEFEEPDP();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[Obsolete("Use ITimeSeriesRollingWindow<T> instead")]
public class AGNPABFMFBF<T> : GKFHEHNJJKE<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class LAOJAOEBHIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float MPFAODOCFHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public T AMCECKEAKLL;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public LAOJAOEBHIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class MFEELIALMLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public MFEELIALMLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x547BC00", Offset = "0x547A600", VA = "0x18547BC00")]
		internal bool OANGIALEJJB(LAOJAOEBHIG sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly float EPOFFIHHCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly float AGIFPCMEJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<LAOJAOEBHIG> KHDHHLCMPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private KMHICFHJEAE<LAOJAOEBHIG> EILELFHHLKJ;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int FJCNOCFJFGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x4D876A0", Offset = "0x4D860A0", VA = "0x184D876A0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4D878B0", Offset = "0x4D862B0", VA = "0x184D878B0")]
	public AGNPABFMFBF(float MOKOBMMKIMP, float LEIMKGKAANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4D87360", Offset = "0x4D85D60", VA = "0x184D87360", Slot = "6")]
	public bool IHCMILLNEAN(float FDFNAMJJMBO, T PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4D87080", Offset = "0x4D85A80", VA = "0x184D87080", Slot = "5")]
	public IEnumerable<T> HPLAHGJGDOL(float FDFNAMJJMBO, float? EIKGOOBIGBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4D87710", Offset = "0x4D86110", VA = "0x184D87710", Slot = "7")]
	public void MPMJEFEEPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4D87770", Offset = "0x4D86170", VA = "0x184D87770")]
	private void NKJBBLHNGHE(float FDFNAMJJMBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class PJFENHGDAFF<T> : GKFHEHNJJKE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct PKCAJNEJALG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly T AMCECKEAKLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly float MPFAODOCFHI;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x51F1860", Offset = "0x51F0260", VA = "0x1851F1860")]
		public PKCAJNEJALG(T PCDAHJCDHHF, float FDFNAMJJMBO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class IMIHMJLHBAH : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public PJFENHGDAFF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float <>3__time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private float? minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public float? <>3__minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private int <count>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xF1BA30", Offset = "0xF1A430", VA = "0x180F1BA30")]
		[DebuggerHidden]
		public IMIHMJLHBAH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x4E742F0", Offset = "0x4E72CF0", VA = "0x184E742F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4E74780", Offset = "0x4E73180", VA = "0x184E74780", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4E74600", Offset = "0x4E73000", VA = "0x184E74600", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4C1FEB0", Offset = "0x4C1E8B0", VA = "0x184C1FEB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly float MOKOBMMKIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly float LEIMKGKAANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly List<PKCAJNEJALG> KHDHHLCMPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int OBKGKEGIECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int NFHMAIJGNID;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int FJCNOCFJFGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA155B0", Offset = "0xA13FB0", VA = "0x180A155B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x577EFC0", Offset = "0x577D9C0", VA = "0x18577EFC0")]
	public PJFENHGDAFF(float MOKOBMMKIMP, float LEIMKGKAANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x577E790", Offset = "0x577D190", VA = "0x18577E790", Slot = "6")]
	public bool IHCMILLNEAN(float FDFNAMJJMBO, T PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x577E600", Offset = "0x577D000", VA = "0x18577E600", Slot = "8")]
	public int GNDFLCMCIAD(float FDFNAMJJMBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x577E630", Offset = "0x577D030", VA = "0x18577E630", Slot = "5")]
	[IteratorStateMachine(typeof(PJFENHGDAFF<>.IMIHMJLHBAH))]
	public IEnumerable<T> HPLAHGJGDOL(float FDFNAMJJMBO, float? EIKGOOBIGBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x577ED80", Offset = "0x577D780", VA = "0x18577ED80", Slot = "7")]
	public void MPMJEFEEPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x577EBF0", Offset = "0x577D5F0", VA = "0x18577EBF0")]
	private void KHKEHCNMEAL(float FDFNAMJJMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x577E540", Offset = "0x577CF40", VA = "0x18577E540")]
	private PKCAJNEJALG COBHGFJNFAE()
	{
		return default(PKCAJNEJALG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class JBLIEDANKLD<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct KKJEGNMACNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly long DPEEHHDLCOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly long GHHLFKLKBOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly int DDJOEDBHMLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly int JDNENAKNNJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool ENBBBLFDBIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string ALJABDBDKEF;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x51CF140", Offset = "0x51CDB40", VA = "0x1851CF140")]
		public KKJEGNMACNO(long DPEEHHDLCOA, int DDJOEDBHMLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x51CF1B0", Offset = "0x51CDBB0", VA = "0x1851CF1B0")]
		public KKJEGNMACNO(long DPEEHHDLCOA, long GHHLFKLKBOO, int DDJOEDBHMLJ, int JDNENAKNNJG, bool ENBBBLFDBIL, string ALJABDBDKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x51CF070", Offset = "0x51CDA70", VA = "0x1851CF070")]
		public int GKIPMOMLADL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x51CF0C0", Offset = "0x51CDAC0", VA = "0x1851CF0C0")]
		public int HEFCPKPNLPA(int JGEEGJPGCBK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x51CF0E0", Offset = "0x51CDAE0", VA = "0x1851CF0E0")]
		public double NKNINGGKJKA()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x51CEFD0", Offset = "0x51CD9D0", VA = "0x1851CEFD0")]
		public KKJEGNMACNO DOFLJOMEHNB(long GHHLFKLKBOO, int JDNENAKNNJG)
		{
			return default(KKJEGNMACNO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class CKADLEMJOGG : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private struct AAEHLKNFJHA<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public CKADLEMJOGG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Func<CKADLEMJOGG, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private CKADLEMJOGG <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x4C95D60", Offset = "0x4C94760", VA = "0x184C95D60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x46BE7B0", Offset = "0x46BD1B0", VA = "0x1846BE7B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly TKey PKHCDEJLLNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly JBLIEDANKLD<TKey> JNHNJKFGOJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly COJJKFBGGKB PMPMPCJHKKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private List<CKADLEMJOGG> KLFCGGGGGOD;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string JMLLIFOHNMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x6676530", Offset = "0x6674F30", VA = "0x186676530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerable<CKADLEMJOGG> JKFFEFAGBBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x6676380", Offset = "0x6674D80", VA = "0x186676380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public KKJEGNMACNO KFJOJKDHPKN
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x6676740", Offset = "0x6675140", VA = "0x186676740")]
			[CompilerGenerated]
			get
			{
				return default(KKJEGNMACNO);
			}
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x66763B0", Offset = "0x6674DB0", VA = "0x1866763B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6676760", Offset = "0x6675160", VA = "0x186676760")]
		internal CKADLEMJOGG(JBLIEDANKLD<TKey> JNHNJKFGOJB, TKey KJNEHANBOBO, COJJKFBGGKB PMPMPCJHKKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x66763E0", Offset = "0x6674DE0", VA = "0x1866763E0")]
		public CKADLEMJOGG BMOJFHGOAGI(TKey KJNEHANBOBO, [Optional] COJJKFBGGKB? KFGGMMDIIJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3BD7770", Offset = "0x3BD6170", VA = "0x183BD7770")]
		[AsyncStateMachine(typeof(AAEHLKNFJHA<>))]
		public Task<T> NLEBKDGFNIP<T>(TKey KJNEHANBOBO, Func<CKADLEMJOGG, Task<T>> IDNDDAFIIDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6676560", Offset = "0x6674F60", VA = "0x186676560", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class LHBKIJGMJFM : IEnumerable<(TKey, List<TKey>, KKJEGNMACNO)>, IEnumerable, IEnumerator<(TKey, List<TKey>, KKJEGNMACNO)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private (TKey key, List<TKey> path, KKJEGNMACNO timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public JBLIEDANKLD<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<(TKey key, List<TKey> path, KKJEGNMACNO timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private (TKey, List<TKey>, KKJEGNMACNO) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x2B5C800", Offset = "0x2B5B200", VA = "0x182B5C800", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, KKJEGNMACNO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x52895B0", Offset = "0x5287FB0", VA = "0x1852895B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2B5C8F0", Offset = "0x2B5B2F0", VA = "0x182B5C8F0")]
		[DebuggerHidden]
		public LHBKIJGMJFM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4BCEAF0", Offset = "0x4BCD4F0", VA = "0x184BCEAF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5289120", Offset = "0x5287B20", VA = "0x185289120", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x52890D0", Offset = "0x5287AD0", VA = "0x1852890D0")]
		private void KIPLFAABBJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5289560", Offset = "0x5287F60", VA = "0x185289560", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x52894A0", Offset = "0x5287EA0", VA = "0x1852894A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, KKJEGNMACNO)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x426F590", Offset = "0x426DF90", VA = "0x18426F590", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class INDMHDCICEP : IEnumerable<(TKey, List<TKey>, KKJEGNMACNO)>, IEnumerable, IEnumerator<(TKey, List<TKey>, KKJEGNMACNO)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private (TKey key, List<TKey> path, KKJEGNMACNO timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private CKADLEMJOGG timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public CKADLEMJOGG <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public JBLIEDANKLD<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator<CKADLEMJOGG> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<(TKey key, List<TKey> path, KKJEGNMACNO timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private (TKey, List<TKey>, KKJEGNMACNO) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x2B5C800", Offset = "0x2B5B200", VA = "0x182B5C800", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, KKJEGNMACNO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x4E759B0", Offset = "0x4E743B0", VA = "0x184E759B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2B5C8F0", Offset = "0x2B5B2F0", VA = "0x182B5C8F0")]
		[DebuggerHidden]
		public INDMHDCICEP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x4E75A10", Offset = "0x4E74410", VA = "0x184E75A10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x4E75090", Offset = "0x4E73A90", VA = "0x184E75090", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x4E75030", Offset = "0x4E73A30", VA = "0x184E75030")]
		private void KIPLFAABBJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x4E757F0", Offset = "0x4E741F0", VA = "0x184E757F0")]
		private void NODCBNAELMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4E75960", Offset = "0x4E74360", VA = "0x184E75960", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x4E75850", Offset = "0x4E74250", VA = "0x184E75850", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, KKJEGNMACNO)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x4E75930", Offset = "0x4E74330", VA = "0x184E75930", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Action<TKey, KKJEGNMACNO, COJJKFBGGKB> EJAMCCEHLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Action<TKey, KKJEGNMACNO, COJJKFBGGKB> EIPGEKCJODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Action<JBLIEDANKLD<TKey>, COJJKFBGGKB> DGPEEOLPBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly CKADLEMJOGG NLEFLPOKNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool CDPHAALIFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int PNMLPMIJIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Stopwatch MCPCEFNFNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly int JEGENHAFONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private string CFKHOMPIMPI;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public CKADLEMJOGG EIEOFMIFKDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA10FC0", Offset = "0xA0F9C0", VA = "0x180A10FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[NotNull]
	public string JMLLIFOHNMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA10570", Offset = "0xA0EF70", VA = "0x180A10570")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5054E20", Offset = "0x5053820", VA = "0x185054E20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x50550F0", Offset = "0x5053AF0", VA = "0x1850550F0")]
	public JBLIEDANKLD(TKey NAJFIAMMFAD, COJJKFBGGKB PMPMPCJHKKF, [Optional] int? DDJOEDBHMLJ, [Optional][CanBeNull] Stopwatch MCPCEFNFNGK, [Optional] Action<TKey, KKJEGNMACNO, COJJKFBGGKB> EJAMCCEHLOG, [Optional] Action<TKey, KKJEGNMACNO, COJJKFBGGKB> EIPGEKCJODD, [Optional] Action<JBLIEDANKLD<TKey>, COJJKFBGGKB> DGPEEOLPBOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5054E80", Offset = "0x5053880", VA = "0x185054E80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5054F90", Offset = "0x5053990", VA = "0x185054F90")]
	[IteratorStateMachine(typeof(JBLIEDANKLD<>.LHBKIJGMJFM))]
	public IEnumerable<(TKey, List<TKey>, KKJEGNMACNO)> IEHEKACKMJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5055020", Offset = "0x5053A20", VA = "0x185055020")]
	[IteratorStateMachine(typeof(JBLIEDANKLD<>.INDMHDCICEP))]
	private IEnumerable<(TKey, List<TKey>, KKJEGNMACNO)> IEHEKACKMJJ(List<TKey> KJHMBICDBAO, CKADLEMJOGG HDFDLAFAIMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5054F10", Offset = "0x5053910", VA = "0x185054F10")]
	private (long, int) IDCAPHLAMGF()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class EFFPEJDBIOI<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut KNDMJJHCAJG(JBLIEDANKLD<TKey> JNHNJKFGOJB);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	protected EFFPEJDBIOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class AFBHAJPPBFO<TKey> : EFFPEJDBIOI<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate string IEFPDNKEODA(TKey KJNEHANBOBO);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4CA8A80", Offset = "0x4CA7480", VA = "0x184CA8A80")]
	private static string MJIJACHABPN(TKey KJNEHANBOBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4CA8890", Offset = "0x4CA7290", VA = "0x184CA8890", Slot = "4")]
	public override string KNDMJJHCAJG(JBLIEDANKLD<TKey> JNHNJKFGOJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4CA8940", Offset = "0x4CA7340", VA = "0x184CA8940")]
	public string KNDMJJHCAJG(JBLIEDANKLD<TKey> JNHNJKFGOJB, [NotNull] IEFPDNKEODA JMFPGHICHOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string CLJGPOGLPCD(JBLIEDANKLD<TKey> JNHNJKFGOJB, [NotNull] IEFPDNKEODA JMFPGHICHOD);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x467DD70", Offset = "0x467C770", VA = "0x18467DD70")]
	protected AFBHAJPPBFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class DKPCLPBHMGC<TKey> : EFFPEJDBIOI<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public delegate string IGNOFHBJJAH(TKey KJNEHANBOBO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly string OECOEGCOFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly double BKPDNNGHGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly bool NDHMMBBIJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly int OPMJNENJPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly ISet<string> FAJDECBOLOP;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6AFEDF0", Offset = "0x6AFD7F0", VA = "0x186AFEDF0")]
	private static string MJIJACHABPN(TKey KJNEHANBOBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6AFEE30", Offset = "0x6AFD830", VA = "0x186AFEE30")]
	public DKPCLPBHMGC(string OECOEGCOFMA = "F2", double BKPDNNGHGLI = double.MaxValue, bool NDHMMBBIJHC = false, int OPMJNENJPKJ = int.MaxValue, [Optional] ISet<string> FAJDECBOLOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6AFED40", Offset = "0x6AFD740", VA = "0x186AFED40", Slot = "4")]
	public override Dictionary<string, string> KNDMJJHCAJG(JBLIEDANKLD<TKey> JNHNJKFGOJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6AFE6C0", Offset = "0x6AFD0C0", VA = "0x186AFE6C0")]
	private bool IJFKEHFLHAC(string LLJEJILFKLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6AFE790", Offset = "0x6AFD190", VA = "0x186AFE790")]
	public Dictionary<string, string> KNDMJJHCAJG(JBLIEDANKLD<TKey> JNHNJKFGOJB, IGNOFHBJJAH JMFPGHICHOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6AFE350", Offset = "0x6AFCD50", VA = "0x186AFE350")]
	private string BHHKKMNKAHM(StringBuilder LMHGDBJJLGI, List<TKey> ALOLICAJPDA, IGNOFHBJJAH JMFPGHICHOD, bool CLOLBIDFLLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6AFE560", Offset = "0x6AFCF60", VA = "0x186AFE560")]
	private static void DLLNAJBKPCJ(StringBuilder FMANAEKOMEL, string BGCEFJBKDHO, bool BMGAOMHJFCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class KOKJDKGDICA<TKey> : AFBHAJPPBFO<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct ABJFDONJPAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public IEFPDNKEODA keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static KOKJDKGDICA<TKey> FDCAMNOGINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly string[] MLAMNHAALOL;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x51F12F0", Offset = "0x51EFCF0", VA = "0x1851F12F0")]
	private KOKJDKGDICA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x51F02A0", Offset = "0x51EECA0", VA = "0x1851F02A0", Slot = "5")]
	protected override string CLJGPOGLPCD(JBLIEDANKLD<TKey> JNHNJKFGOJB, IEFPDNKEODA JMFPGHICHOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x51F10D0", Offset = "0x51EFAD0", VA = "0x1851F10D0")]
	[CompilerGenerated]
	internal static string OGOLOHGHPAL(string NAPLMHBAFFK, TKey KJNEHANBOBO, ABJFDONJPAN P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class JMGAGFFEEJJ : JBLIEDANKLD<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class MKODCDNPKNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Action<JMGAGFFEEJJ, COJJKFBGGKB> callback;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public MKODCDNPKNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7D0E2C0", Offset = "0x7D0CCC0", VA = "0x187D0E2C0")]
		internal void FBGKAEHIBCJ(JBLIEDANKLD<string> timer, COJJKFBGGKB log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7D0DD30", Offset = "0x7D0C730", VA = "0x187D0DD30")]
	public JMGAGFFEEJJ(COJJKFBGGKB PMPMPCJHKKF, [Optional] string JEGOPGAILHF, [Optional] int? DDJOEDBHMLJ, [Optional] Stopwatch MCPCEFNFNGK, [Optional] Action<string, KKJEGNMACNO, COJJKFBGGKB> EJAMCCEHLOG, [Optional] Action<string, KKJEGNMACNO, COJJKFBGGKB> EIPGEKCJODD, [Optional] Action<JMGAGFFEEJJ, COJJKFBGGKB> DGPEEOLPBOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7D0DC70", Offset = "0x7D0C670", VA = "0x187D0DC70")]
	private static Action<JBLIEDANKLD<string>, COJJKFBGGKB> JHAAHMHIJML(Action<JMGAGFFEEJJ, COJJKFBGGKB> DMDJELFGCKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public abstract class LFNBIIGDOPD
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private class HNCBPIJMPHO : LFNBIIGDOPD
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static LFNBIIGDOPD FDCAMNOGINK
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x7D0D8E0", Offset = "0x7D0C2E0", VA = "0x187D0D8E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override float BMINAKCPCAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x1274EB0", Offset = "0x12738B0", VA = "0x181274EB0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7D0D9D0", Offset = "0x7D0C3D0", VA = "0x187D0D9D0")]
		public HNCBPIJMPHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static LFNBIIGDOPD IKEMGOAGEKE;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static LFNBIIGDOPD MCHDAMDLAPK
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7D0DE80", Offset = "0x7D0C880", VA = "0x187D0DE80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public abstract float BMINAKCPCAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	protected LFNBIIGDOPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface MCFGKKFEMKA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool MCFAHADANHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface ODDHNIEMFCD<T> : MCFGKKFEMKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[NotNull]
	Task<T> CBFPJBCPECJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[NotNull]
	MPBOGDMHBIL<T> PENDILLEPOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class IBALNDOBIKK
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B620", Offset = "0x3A9A020", VA = "0x183A9B620")]
	public static ODDHNIEMFCD<TResource> EKDIBEKFGGG<TResource, TId>(this DDNEPEFALOO<TId, TResource> DIAPHCLLMBP, TId KHNIMGKFPOO, [Optional] Func<TId, CancellationToken, Task<TResource>>? DAJHLFINBGA) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class OKCFFBGOJAL
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class JECBENALLHO<T> : NNJGPMOALGH<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<T?> CBFPJBCPECJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override MPBOGDMHBIL<T?> PENDILLEPOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5056240", Offset = "0x5054C40", VA = "0x185056240")]
		public JECBENALLHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "10")]
		protected override void FJBHEGLBPCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class CGHJMLHEKEI<T> : NNJGPMOALGH<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly T FBENFOKKFLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Action<T>? NBDIEELKKDN;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Task<T> CBFPJBCPECJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xA0A590", Offset = "0xA08F90", VA = "0x180A0A590", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override MPBOGDMHBIL<T> PENDILLEPOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xA0A540", Offset = "0xA08F40", VA = "0x180A0A540", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x65837F0", Offset = "0x65821F0", VA = "0x1865837F0")]
		public CGHJMLHEKEI(T IEBGOKLBDGB, Action<T>? KJODHAENABA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x6583770", Offset = "0x6582170", VA = "0x186583770", Slot = "10")]
		protected override void FJBHEGLBPCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class OMPNBNFHNDD<T> : NNJGPMOALGH<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override Task<T> CBFPJBCPECJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override MPBOGDMHBIL<T> PENDILLEPOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x5680CB0", Offset = "0x567F6B0", VA = "0x185680CB0")]
		public OMPNBNFHNDD(Exception AJLHKIHCGAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "10")]
		protected override void FJBHEGLBPCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private sealed class NJLNKPDCGFB<T> : NNJGPMOALGH<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct HHCMFMFPLKN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Task<ODDHNIEMFCD<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<ODDHNIEMFCD<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x4CF23D0", Offset = "0x4CF0DD0", VA = "0x184CF23D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x4CF28B0", Offset = "0x4CF12B0", VA = "0x184CF28B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct FODKHHEEMPB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Task<ODDHNIEMFCD<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private TaskAwaiter<ODDHNIEMFCD<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x4B5E670", Offset = "0x4B5D070", VA = "0x184B5E670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x4B5EAB0", Offset = "0x4B5D4B0", VA = "0x184B5EAB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly Task<ODDHNIEMFCD<T>> KPOHIBKONOH;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override Task<T> CBFPJBCPECJ
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override MPBOGDMHBIL<T> PENDILLEPOM
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x550FAD0", Offset = "0x550E4D0", VA = "0x18550FAD0")]
		public NJLNKPDCGFB(Task<ODDHNIEMFCD<T>> HAAEKADIBMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x550F9D0", Offset = "0x550E3D0", VA = "0x18550F9D0", Slot = "10")]
		protected override void FJBHEGLBPCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x550F570", Offset = "0x550DF70", VA = "0x18550F570")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(NJLNKPDCGFB<>.HHCMFMFPLKN))]
		internal static Task<T> BONENIICGFP(Task<ODDHNIEMFCD<T>> HAAEKADIBMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x550F8F0", Offset = "0x550E2F0", VA = "0x18550F8F0")]
		[AsyncStateMachine(typeof(NJLNKPDCGFB<>.FODKHHEEMPB))]
		[CompilerGenerated]
		internal static Task EIJLJALBBFF(Task<ODDHNIEMFCD<T>> HAAEKADIBMM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class ADMNNEDFIHN<TIn, TOut> : NNJGPMOALGH<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct CJGIHAJKHIJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x658CB10", Offset = "0x658B510", VA = "0x18658CB10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x4B51BE0", Offset = "0x4B505E0", VA = "0x184B51BE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly ODDHNIEMFCD<TIn> LGOLKPFPIGD;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override Task<TOut> CBFPJBCPECJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override MPBOGDMHBIL<TOut> PENDILLEPOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x4CA7DD0", Offset = "0x4CA67D0", VA = "0x184CA7DD0")]
		public ADMNNEDFIHN(ODDHNIEMFCD<TIn> GBBNBMNFBOO, Func<TIn, TOut> BHEIHCOGDJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x4CA7A50", Offset = "0x4CA6450", VA = "0x184CA7A50", Slot = "10")]
		protected override void FJBHEGLBPCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x4CA7AF0", Offset = "0x4CA64F0", VA = "0x184CA7AF0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(ADMNNEDFIHN<, >.CJGIHAJKHIJ))]
		internal static Task<TOut> HKFFHAADMEL(Task<TIn> HLOAFHIINCL, Func<TIn, TOut> BHEIHCOGDJC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3BFD190", Offset = "0x3BFBB90", VA = "0x183BFD190")]
	public static ODDHNIEMFCD<T> BOAAIAHJNJN<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3BFD1F0", Offset = "0x3BFBBF0", VA = "0x183BFD1F0")]
	public static ODDHNIEMFCD<T> MIPCDNBFIMH<T>(T MGJNMKLFKCJ, [Optional] Action<T>? KJODHAENABA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x30000B0", Offset = "0x2FFEAB0", VA = "0x1830000B0")]
	public static ODDHNIEMFCD<T> DLNCNCBLELM<T>(Exception AJLHKIHCGAH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x30000B0", Offset = "0x2FFEAB0", VA = "0x1830000B0")]
	public static ODDHNIEMFCD<T> HLCOBBBMCAG<T>(Task<ODDHNIEMFCD<T>> HAAEKADIBMM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3000800", Offset = "0x2FFF200", VA = "0x183000800")]
	public static ODDHNIEMFCD<TOut> OIBPIKEGOHJ<TOut, TIn>(ODDHNIEMFCD<TIn> GCKDJGKENJL, Func<TIn, TOut> BHEIHCOGDJC) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class NNJGPMOALGH<T> : ODDHNIEMFCD<T>, MCFGKKFEMKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly string DBLDOHLHEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly ONKIACMKPLC PLEDFALOCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool CDPHAALIFLC;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool MCFAHADANHE
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA979F0", Offset = "0xA963F0", VA = "0x180A979F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract Task<T> CBFPJBCPECJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public abstract MPBOGDMHBIL<T> PENDILLEPOM
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5546870", Offset = "0x5545270", VA = "0x185546870")]
	public NNJGPMOALGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x55465E0", Offset = "0x5544FE0", VA = "0x1855465E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void FJBHEGLBPCD();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public abstract class PDKHPAHJCEI<TTask, T> : NNJGPMOALGH<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class FCLHOPCAFBE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public FCLHOPCAFBE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x423E540", Offset = "0x423CF40", VA = "0x18423E540", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x423E800", Offset = "0x423D200", VA = "0x18423E800", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public PDKHPAHJCEI<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public FCLHOPCAFBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x4B340C0", Offset = "0x4B32AC0", VA = "0x184B340C0")]
		[AsyncStateMachine(typeof(PDKHPAHJCEI<, >.FCLHOPCAFBE.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> BIPCMIEMMKK(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Task<T> HAAEKADIBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	protected readonly CancellationTokenSource IFHBDAKCHCL;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override Task<T> CBFPJBCPECJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override MPBOGDMHBIL<T> PENDILLEPOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5759860", Offset = "0x5758260", VA = "0x185759860")]
	protected PDKHPAHJCEI(TTask HAAEKADIBMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5759650", Offset = "0x5758050", VA = "0x185759650", Slot = "10")]
	protected override void FJBHEGLBPCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T AFBILIDKDDK(TTask IIBJDKIFLAM);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void PBKNHAODEBA();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class OANJCHDFFCB<T> : NNJGPMOALGH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly BBBOLEBKOCP<Task<T>> CKBIPEHAOAL;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override Task<T> CBFPJBCPECJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x528B550", Offset = "0x5289F50", VA = "0x18528B550", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override MPBOGDMHBIL<T> PENDILLEPOM
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x56512F0", Offset = "0x564FCF0", VA = "0x1856512F0")]
	public OANJCHDFFCB(BBBOLEBKOCP<Task<T>> OFKMEPNNCCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x56512D0", Offset = "0x564FCD0", VA = "0x1856512D0", Slot = "10")]
	protected override void FJBHEGLBPCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class GKADAGHJAAK
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly HashAlgorithmName MIAJHHMGKBA;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly ThreadLocal<IncrementalHash> KCHOJAEKGEB;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7D0CF70", Offset = "0x7D0B970", VA = "0x187D0CF70")]
	public static int FGPBCKHHGKC(this ANHDCKFMHKN KHEHGHKAFJC, IncrementalHash IHCNKMENBKK, byte[] BENOCFHFOHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7D0D650", Offset = "0x7D0C050", VA = "0x187D0D650")]
	public static bool HEAAOIEJPOK([CanBeNull] this ANHDCKFMHKN KHEHGHKAFJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7D0D340", Offset = "0x7D0BD40", VA = "0x187D0D340")]
	public static bool HEAAOIEJPOK([CanBeNull] this ANHDCKFMHKN KHEHGHKAFJC, [Out] string OLIGKIPGKGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7D0D000", Offset = "0x7D0BA00", VA = "0x187D0D000")]
	public static bool HEAAOIEJPOK([CanBeNull] this ANHDCKFMHKN KHEHGHKAFJC, IncrementalHash IHCNKMENBKK, byte[] BENOCFHFOHM, [Out] string OLIGKIPGKGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7D0D6B0", Offset = "0x7D0C0B0", VA = "0x187D0D6B0")]
	private static bool OIBIHPDCJMK(byte[] LBDKBGPMGPD, Span<byte> MIJBOGLONEG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class CKILFGDEKEC
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7D0C980", Offset = "0x7D0B380", VA = "0x187D0C980")]
	public static int NHNLFAFGDEA(HashAlgorithmName PBAGOEGEFHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3856F40", Offset = "0x3855940", VA = "0x183856F40")]
	public static int FGPBCKHHGKC<T>(this T EAOOEPMFPFA, byte[] NIENCOEGIDN, IncrementalHash IHCNKMENBKK, byte[] FLILHONLOPJ) where T : JDGJGMOJJCI
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface JDGJGMOJJCI
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash IHCNKMENBKK);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface ANHDCKFMHKN : JDGJGMOJJCI
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[CanBeNull]
	byte[] MCMNMDMOKHN
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[CanBeNull]
	byte[] BGOPFANMGGC
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class MMJFGKELFJH
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static bool INPEPIDFPGM;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly ArrayPool<byte> HHKKKHIMEOI;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ArrayPool<char> KCLGHGLOIPE;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly Encoding GEFGFODJHMM;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ThreadLocal<Encoder> CFJKCLKNAJN;

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3B59E00", Offset = "0x3B58800", VA = "0x183B59E00")]
	public static void HOHDEMLHNAL<T>(this IncrementalHash JOMNGJAKIHF, [CanBeNull] T FDMBFEDKLFL) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3B59D70", Offset = "0x3B58770", VA = "0x183B59D70")]
	public static void GMLKHAJGDLD<T>(this IncrementalHash JOMNGJAKIHF, [CanBeNull] T EAOOEPMFPFA) where T : JDGJGMOJJCI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3B58BF0", Offset = "0x3B575F0", VA = "0x183B58BF0")]
	public static void CCICOLHDMJE<T>(this IncrementalHash JOMNGJAKIHF, [CanBeNull] IList<T> EACKBLPNINB) where T : JDGJGMOJJCI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7D0E8C0", Offset = "0x7D0D2C0", VA = "0x187D0E8C0")]
	private static bool HOHDMCAFOKD([CanBeNull] JDGJGMOJJCI EAOOEPMFPFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7D0E950", Offset = "0x7D0D350", VA = "0x187D0E950")]
	public static void IBJIJIHLJCK(this IncrementalHash IHCNKMENBKK, string? INELIFOAIDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7D0E520", Offset = "0x7D0CF20", VA = "0x187D0E520")]
	public static void COANJBGDODB(this IncrementalHash IHCNKMENBKK, long CFMPNFAHDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7D0E350", Offset = "0x7D0CD50", VA = "0x187D0E350")]
	public static void CKEEAILDIKA(this IncrementalHash IHCNKMENBKK, int FPHCFBPNBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7D0EE80", Offset = "0x7D0D880", VA = "0x187D0EE80")]
	public static void KLMJCGLDABA(this IncrementalHash IHCNKMENBKK, short KIHMLFGMKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7D0F0B0", Offset = "0x7D0DAB0", VA = "0x187D0F0B0")]
	public static void MDGGAPAHOEA(this IncrementalHash IHCNKMENBKK, byte PPEABMJOBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7D0E750", Offset = "0x7D0D150", VA = "0x187D0E750")]
	public static void GINMCLJJNNJ(this IncrementalHash IHCNKMENBKK, bool BCOAOFGEHDN, bool KHAFOFKBOEN = false, bool LEEECLNCMOD = false, bool IKCNPLKNMLB = false, bool MJBBAHCKPIA = false, bool LLJEBIHHPFF = false, bool OBFOHMIIPKK = false, bool NMDDFBMFHBL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3B59110", Offset = "0x3B57B10", VA = "0x183B59110")]
	public static void EJLJOLOPDBK<T>(this IncrementalHash IHCNKMENBKK, T MIMNBICPMMO) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7D0F220", Offset = "0x7D0DC20", VA = "0x187D0F220")]
	public static void OIHLKENJLCH(this IncrementalHash IHCNKMENBKK, float FCHOGCJPKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7D0F1C0", Offset = "0x7D0DBC0", VA = "0x187D0F1C0")]
	public static void OAPBFCHMBJP(this IncrementalHash IHCNKMENBKK, ulong OOGHJFDPELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7D0F050", Offset = "0x7D0DA50", VA = "0x187D0F050")]
	public static void LMMOAOJBOGN(this IncrementalHash IHCNKMENBKK, uint DAFLBIFEPDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7D0E6F0", Offset = "0x7D0D0F0", VA = "0x187D0E6F0")]
	public static void DDAPCGCELIL(this IncrementalHash IHCNKMENBKK, ushort PKKBHEDMBOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7D0ED50", Offset = "0x7D0D750", VA = "0x187D0ED50")]
	public static void JMOIHDGEAPF(this IncrementalHash IHCNKMENBKK, Vector3 BKDGEINOGLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class HLAMACJMJJI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7D0D880", Offset = "0x7D0C280", VA = "0x187D0D880")]
	public HLAMACJMJJI(string IJOJGNJMCGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class KNLFKNEOKLC
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void EFLFEOILLEP(ushort GPFJAGOPFIA, ushort LIGLAMMOCLB, ushort ODIJBJOHNNL, ushort KAOJPMJDNNM);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void DENPKINEIKE(ushort LEOBJDMPEIH, ushort AEDPOLCDJGO);

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate void CNINPJLHLLD();

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const ushort NOIIOBIOGMP = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	protected KNLFKNEOKLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class CJGKACIFMLB<T> : KNLFKNEOKLC where T : CJGKACIFMLB<T>.NJGBKJLAGGA
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public interface NJGBKJLAGGA
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		DENPKINEIKE DNBBBFNNGAI
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		DENPKINEIKE PHGEKNEOBDF
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		CNINPJLHLLD MGFNDIBCDIP
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<uint, T> CBODDGBGCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private CNINPJLHLLD BEHNPCDOEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private CNINPJLHLLD PILMJLNBLMG;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool JJABBNPMAEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA62AE0", Offset = "0xA614E0", VA = "0x180A62AE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA129F0", Offset = "0xA113F0", VA = "0x180A129F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public ushort ALPONDOGCJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x1127040", Offset = "0x1125A40", VA = "0x181127040")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x1126EE0", Offset = "0x11258E0", VA = "0x181126EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public ushort LLEEDHGCOLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x658D030", Offset = "0x658BA30", VA = "0x18658D030")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x658D7B0", Offset = "0x658C1B0", VA = "0x18658D7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ushort LLCHAHEMKAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xE5DBA0", Offset = "0xE5C5A0", VA = "0x180E5DBA0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xE5DCB0", Offset = "0xE5C6B0", VA = "0x180E5DCB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public ushort JHKBEKACBGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x658CF90", Offset = "0x658B990", VA = "0x18658CF90")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x658D0B0", Offset = "0x658BAB0", VA = "0x18658D0B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected bool GOHABMEDCHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1126A70", Offset = "0x1125470", VA = "0x181126A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected bool OEAHGGBKJEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xF53120", Offset = "0xF51B20", VA = "0x180F53120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event EFLFEOILLEP GHAOPMPFOGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x658CEE0", Offset = "0x658B8E0", VA = "0x18658CEE0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x658D9F0", Offset = "0x658C3F0", VA = "0x18658D9F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x658CE50", Offset = "0x658B850", VA = "0x18658CE50")]
	private T AHJKIPBAAEN(ushort EDDOOIIFIDK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x658CFA0", Offset = "0x658B9A0", VA = "0x18658CFA0")]
	private T GMENBKJGHDC(ushort EDDOOIIFIDK, ushort LMHBLLMEICI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x658DBF0", Offset = "0x658C5F0", VA = "0x18658DBF0")]
	protected T PGMHEBGOFCK(uint HGLMHJLIMOC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x658DC40", Offset = "0x658C640", VA = "0x18658DC40")]
	protected CJGKACIFMLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x658DBD0", Offset = "0x658C5D0", VA = "0x18658DBD0")]
	public void NHIJFEHEHDF(ushort CPDGBBIEKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x658DB80", Offset = "0x658C580", VA = "0x18658DB80")]
	public void NHIJFEHEHDF(ushort CPDGBBIEKJI, ushort HEALEEDCMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x658DAC0", Offset = "0x658C4C0", VA = "0x18658DAC0", Slot = "4")]
	protected virtual void NHIJFEHEHDF(uint FBDGMNMHBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x658D0D0", Offset = "0x658BAD0", VA = "0x18658D0D0")]
	protected void JJGPIFLKEMD(uint FBDGMNMHBLG, uint PPNFENHMPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x658D040", Offset = "0x658BA40", VA = "0x18658D040")]
	protected void HCIKPPMEAGK(ushort EDDOOIIFIDK, ushort LMHBLLMEICI, T LOPOEJHIPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x658DA90", Offset = "0x658C490", VA = "0x18658DA90")]
	private void MMIJOHIPILN(uint HGLMHJLIMOC, T LOPOEJHIPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x658D7C0", Offset = "0x658C1C0", VA = "0x18658D7C0")]
	protected void MBICLGLHJEO(float HMAHKNFCDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x658CF80", Offset = "0x658B980", VA = "0x18658CF80")]
	protected uint DODHPLACFFL(ushort EDDOOIIFIDK, ushort LMHBLLMEICI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x658DC30", Offset = "0x658C630", VA = "0x18658DC30")]
	protected ushort PPFMLBMNLDE(uint EBGEHHINJOG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x658D0C0", Offset = "0x658BAC0", VA = "0x18658D0C0")]
	protected ushort IKBDBGGAJCD(uint EBGEHHINJOG)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class JENFKDKHKCC : CJGKACIFMLB<JENFKDKHKCC.BLFKKCFIOAB>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class BLFKKCFIOAB : NJGBKJLAGGA
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public DENPKINEIKE DNBBBFNNGAI
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7A0", Offset = "0xA091A0", VA = "0x180A0A7A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public DENPKINEIKE PHGEKNEOBDF
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public CNINPJLHLLD MGFNDIBCDIP
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xA0A570", Offset = "0xA08F70", VA = "0x180A0A570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public BLFKKCFIOAB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7D0DA70", Offset = "0x7D0C470", VA = "0x187D0DA70")]
	public void HBDCJGEMDEG(ushort NPNDNMPJLEC, DENPKINEIKE NKDEDGEFHND, DENPKINEIKE KNCGOFKBFBG, CNINPJLHLLD OLDIEEFKHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7D0DB50", Offset = "0x7D0C550", VA = "0x187D0DB50")]
	public void HBDCJGEMDEG(ushort EDDOOIIFIDK, ushort LMHBLLMEICI, DENPKINEIKE NKDEDGEFHND, DENPKINEIKE KNCGOFKBFBG, CNINPJLHLLD OLDIEEFKHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7D0DA20", Offset = "0x7D0C420", VA = "0x187D0DA20")]
	public void FPILOHDMIEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x7D0DC30", Offset = "0x7D0C630", VA = "0x187D0DC30")]
	protected JENFKDKHKCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class NJMEEIICCAM : JENFKDKHKCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool ALGNNAPDEJK;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool ANNFNILDKLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xCA7120", Offset = "0xCA5B20", VA = "0x180CA7120")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xD9EDB0", Offset = "0xD9D7B0", VA = "0x180D9EDB0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7D0F550", Offset = "0x7D0DF50", VA = "0x187D0F550")]
	public void DBILOAODCDE(ushort DKIMMHGDNHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7D0F4F0", Offset = "0x7D0DEF0", VA = "0x187D0F4F0")]
	public void DBILOAODCDE(ushort DKIMMHGDNHI, ushort LFJHJJKPIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7D0DC30", Offset = "0x7D0C630", VA = "0x187D0DC30")]
	public NJMEEIICCAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class NAFOBECMIHG<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal class HKMLFONBLDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TNode NMEFAPBBOCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TNode EAGGHBKHKHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public OBPKCLCGACC BBAFJLLBENK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public List<OBPKCLCGACC> JKKDGGIBGCN;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public HKMLFONBLDN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal struct OBPKCLCGACC : IComparable<OBPKCLCGACC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int JILFIKIPHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TClaimant IIBMBIELOPH;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x17A0610", Offset = "0x179F010", VA = "0x1817A0610")]
		public OBPKCLCGACC(int JILFIKIPHBK, TClaimant IIBMBIELOPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x56541A0", Offset = "0x5652BA0", VA = "0x1856541A0")]
		public bool AKBCGMPHKBL([In] OBPKCLCGACC NDNHELJMDCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x5654210", Offset = "0x5652C10", VA = "0x185654210")]
		public bool FGNEAJIDMCP([In] OBPKCLCGACC NDNHELJMDCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5654200", Offset = "0x5652C00", VA = "0x185654200", Slot = "4")]
		public int CompareTo(OBPKCLCGACC NDNHELJMDCG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x5654220", Offset = "0x5652C20", VA = "0x185654220", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum FFINIHBDOGA
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class GFGIFLLCEFF : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public NAFOBECMIHG<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xF1BA30", Offset = "0xF1A430", VA = "0x180F1BA30")]
		[DebuggerHidden]
		public GFGIFLLCEFF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x4C3DDC0", Offset = "0x4C3C7C0", VA = "0x184C3DDC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x4C3DF80", Offset = "0x4C3C980", VA = "0x184C3DF80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x4C3DEA0", Offset = "0x4C3C8A0", VA = "0x184C3DEA0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x425E460", Offset = "0x425CE60", VA = "0x18425E460", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly KMHICFHJEAE<HKMLFONBLDN> OPELKGJLKNA;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly KMHICFHJEAE<List<OBPKCLCGACC>> HFFFKOPGFCG;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static int DECJLGANKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	internal readonly Dictionary<TClaimant, TNode> LADPJPBPEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	internal readonly Dictionary<TNode, HKMLFONBLDN> OAJOLBNLGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private FFINIHBDOGA KMALIDMGEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool KJMPONALMPD;

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode IGONPOBPOPB(TNode DGGBJNBEMBF);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void FGOBJLHKEPB(TNode DGGBJNBEMBF, TClaimant GPJBDMHAFOL, TClaimant OEGGBNKIPPJ);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x54EA460", Offset = "0x54E8E60", VA = "0x1854EA460")]
	public NAFOBECMIHG(FFINIHBDOGA KMALIDMGEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x54E9D80", Offset = "0x54E8780", VA = "0x1854E9D80")]
	public void KDMABGIGBJI(TNode DGGBJNBEMBF, TNode FEIPCFECKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x54EA050", Offset = "0x54E8A50", VA = "0x1854EA050")]
	public void MIJPCLGFDBK(TClaimant IIBMBIELOPH, TNode FHPINHKNFFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x54E9230", Offset = "0x54E7C30", VA = "0x1854E9230", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x54E98A0", Offset = "0x54E82A0", VA = "0x1854E98A0")]
	private void HIPKNDFNFLH(TClaimant IIBMBIELOPH, TNode IKJFGNAGAMA, TNode FHPINHKNFFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x54E9720", Offset = "0x54E8120", VA = "0x1854E9720")]
	private int GCMLOBLPCLC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x54E9940", Offset = "0x54E8340", VA = "0x1854E9940")]
	private void IMDLNKMNAKB(TClaimant IIBMBIELOPH, TNode MIKFEGFKGCC, TNode AHFPKINDEMG, int BNFKKDPHNNF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x54EA170", Offset = "0x54E8B70", VA = "0x1854EA170")]
	private void OFDDAKJPDDP(OBPKCLCGACC IHDHEPCJOLD, HKMLFONBLDN FENDIEDGFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x54E8F70", Offset = "0x54E7970", VA = "0x1854E8F70")]
	private void CFBKOPKBKBO(TClaimant IIBMBIELOPH, TNode MIKFEGFKGCC, TNode AHFPKINDEMG, int BNFKKDPHNNF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x54E9790", Offset = "0x54E8190", VA = "0x1854E9790")]
	private void GIKKENCDLHF(OBPKCLCGACC IHDHEPCJOLD, TNode DGGBJNBEMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x54E8E90", Offset = "0x54E7890", VA = "0x1854E8E90")]
	private void AHMFEILNIND(OBPKCLCGACC IHDHEPCJOLD, HKMLFONBLDN FENDIEDGFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x54E9C60", Offset = "0x54E8660", VA = "0x1854E9C60")]
	private void IONJAEBFDAH(HKMLFONBLDN FENDIEDGFFH, bool ENBPAEANJAF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x54E93D0", Offset = "0x54E7DD0", VA = "0x1854E93D0")]
	private void FNPCNMPEIFO(HKMLFONBLDN FENDIEDGFFH, TNode FEIPCFECKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x54EA1F0", Offset = "0x54E8BF0", VA = "0x1854EA1F0")]
	[IteratorStateMachine(typeof(NAFOBECMIHG<, >.GFGIFLLCEFF))]
	private IEnumerable<TNode> OFFHNEIDIOD(TNode MIKFEGFKGCC, TNode AHFPKINDEMG, bool NMDJMCDEIGA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x54E9E10", Offset = "0x54E8810", VA = "0x1854E9E10")]
	private HKMLFONBLDN LFGANDHIBGA(TNode DGGBJNBEMBF, TNode EAGGHBKHKHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x54E8D40", Offset = "0x54E7740", VA = "0x1854E8D40")]
	private HKMLFONBLDN ACBGGENKPOJ(TNode DGGBJNBEMBF, TNode EAGGHBKHKHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x54E9EF0", Offset = "0x54E88F0", VA = "0x1854E9EF0")]
	private void LKEOOKLELAH(HKMLFONBLDN FENDIEDGFFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class FINLMOPIAGC<T> : IEnumerable<FINLMOPIAGC<T>.LGNMDAGAPMG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public struct LGNMDAGAPMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public T PCDAHJCDHHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int MNFHMLCLFEB;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class FDBEOILBPBO : IEnumerator<LGNMDAGAPMG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private FINLMOPIAGC<T> ICFOMKCGHDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int MNFHMLCLFEB;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x46FE290", Offset = "0x46FCC90", VA = "0x1846FE290", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public LGNMDAGAPMG NBBAKIJBGKK
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x4B34310", Offset = "0x4B32D10", VA = "0x184B34310", Slot = "4")]
			get
			{
				return default(LGNMDAGAPMG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x4B342D0", Offset = "0x4B32CD0", VA = "0x184B342D0")]
		public FDBEOILBPBO(FINLMOPIAGC<T> ICFOMKCGHDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x4B341D0", Offset = "0x4B32BD0", VA = "0x184B341D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x4764AE0", Offset = "0x47634E0", VA = "0x184764AE0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x11DFC50", Offset = "0x11DE650", VA = "0x1811DFC50", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private struct PCCKIOMJNIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public bool AODPHPEBFHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public T PCDAHJCDHHF;
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const int CIODBIBFJNK = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Dictionary<T, int> DGLOEDPJPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private PCCKIOMJNIN[] PGOBANNLAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int GEKMJFCIMCK;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int NCFEPCECBNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA6EB80", Offset = "0xA6D580", VA = "0x180A6EB80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xF69880", Offset = "0xF68280", VA = "0x180F69880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int IMMMMMEPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x4255850", Offset = "0x4254250", VA = "0x184255850")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x4B44D00", Offset = "0x4B43700", VA = "0x184B44D00")]
	public FINLMOPIAGC(int OOPBDBFKCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x4B44950", Offset = "0x4B43350", VA = "0x184B44950")]
	public FINLMOPIAGC(LGNMDAGAPMG[] CHLPEGOEJGG, bool CIOBPAPANKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x4B447C0", Offset = "0x4B431C0", VA = "0x184B447C0")]
	public int MPHEHEEDNNK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x4B43E70", Offset = "0x4B42870", VA = "0x184B43E70")]
	private int AFAANCOLOBM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x4B44290", Offset = "0x4B42C90", VA = "0x184B44290", Slot = "6")]
	protected virtual uint GDKMHBEGPDN(uint IHCNKMENBKK, T PCDAHJCDHHF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x4B44880", Offset = "0x4B43280", VA = "0x184B44880")]
	public bool ONLIFFPIAIK(T PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4B44120", Offset = "0x4B42B20", VA = "0x184B44120")]
	public int DJAFGAAPNAI(T PCDAHJCDHHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x4B440B0", Offset = "0x4B42AB0", VA = "0x184B440B0")]
	public T BACOOPOJLAH(int MNFHMLCLFEB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x4B44770", Offset = "0x4B43170", VA = "0x184B44770")]
	public bool MNDHBHLHPAG(T PCDAHJCDHHF, bool PKBGNGOCEGN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x4B44320", Offset = "0x4B42D20", VA = "0x184B44320")]
	public bool MNDHBHLHPAG(T PCDAHJCDHHF, int MNFHMLCLFEB, bool PKBGNGOCEGN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x4B44240", Offset = "0x4B42C40", VA = "0x184B44240")]
	private int EDPCILBJDEM(int OBKGKEGIECO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x4B448D0", Offset = "0x4B432D0", VA = "0x184B448D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x4B448D0", Offset = "0x4B432D0", VA = "0x184B448D0", Slot = "4")]
	private IEnumerator<LGNMDAGAPMG> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class KMHICFHJEAE<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly Stack<T> EDCLKKJAJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<T> MAMIPDHOEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly int BKKGEFKLGMA;

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x51DB760", Offset = "0x51DA160", VA = "0x1851DB760")]
	public static KMHICFHJEAE<T> EAKABCIHGIA(int OOPBDBFKCBI = 0, int BKKGEFKLGMA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x51DB840", Offset = "0x51DA240", VA = "0x1851DB840")]
	public static KMHICFHJEAE<T> EIDELBKHJPE(int OOPBDBFKCBI = 0, int BKKGEFKLGMA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x51DBB90", Offset = "0x51DA590", VA = "0x1851DBB90")]
	public KMHICFHJEAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x51DBBC0", Offset = "0x51DA5C0", VA = "0x1851DBBC0")]
	public KMHICFHJEAE(int OOPBDBFKCBI, int BKKGEFKLGMA = int.MaxValue, bool DCDGLKAMIDP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x51DBA10", Offset = "0x51DA410", VA = "0x1851DBA10")]
	public T LPOPHENMMHM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x51DB550", Offset = "0x51D9F50", VA = "0x1851DB550")]
	public void DKAGEAADPDL(T PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x51DB940", Offset = "0x51DA340", VA = "0x1851DB940")]
	private void LIMILJEABFP(T PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x51DB920", Offset = "0x51DA320", VA = "0x1851DB920")]
	private void JBAAPEHFHAP(T PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x51DB620", Offset = "0x51DA020", VA = "0x1851DB620", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x51DB2F0", Offset = "0x51D9CF0", VA = "0x1851DB2F0")]
	private void COOKFKIFBMP(IEnumerable<T> OKEIIBNBBOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class FCCEFLAKENP<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Dictionary<int, T> FHONBPKKLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private T BLFHCGBHOEL;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public virtual T EPCJBLJMCCM
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x4B31C20", Offset = "0x4B30620", VA = "0x184B31C20")]
	public bool GOOFDNOKNFF(T PCDAHJCDHHF, int JILFIKIPHBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x4B31C90", Offset = "0x4B30690", VA = "0x184B31C90")]
	public bool JLGGFHOHDHO(int JILFIKIPHBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x4B31CF0", Offset = "0x4B306F0", VA = "0x184B31CF0")]
	public T OLCPDIFCCPI(int GPBAAPKHJMJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x4B31A30", Offset = "0x4B30430", VA = "0x184B31A30")]
	private bool FIFIFOIPDKD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x4B319F0", Offset = "0x4B303F0", VA = "0x184B319F0")]
	public bool EHEIJGNBGFA(int JILFIKIPHBK, [Out] T PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x4B320D0", Offset = "0x4B30AD0", VA = "0x184B320D0")]
	public FCCEFLAKENP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class DGBEAOOKIOK<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	protected struct MAMLIBOJFKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T AMCECKEAKLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int NGNDNJMMICE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	protected readonly List<MAMLIBOJFKA> MIGOHJBNJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private T GKGOKGFKEHG;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int IMMMMMEPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x4255850", Offset = "0x4254250", VA = "0x184255850")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6AEDFE0", Offset = "0x6AEC9E0", VA = "0x186AEDFE0")]
	public bool PFLPBNAMPLH(T PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6AEDDE0", Offset = "0x6AEC7E0", VA = "0x186AEDDE0")]
	public void PBDMKLNODMP(T PCDAHJCDHHF, int JILFIKIPHBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6AED600", Offset = "0x6AEC000", VA = "0x186AED600")]
	public bool DAAFLACHELB(T PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x6AEDCE0", Offset = "0x6AEC6E0", VA = "0x186AEDCE0")]
	public void MPMJEFEEPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x6AEDC50", Offset = "0x6AEC650", VA = "0x186AEDC50")]
	public T FNGIBJPCBHE()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6AEDA50", Offset = "0x6AEC450", VA = "0x186AEDA50")]
	protected void DCICNLDNBAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6AEE220", Offset = "0x6AECC20", VA = "0x186AEE220")]
	public DGBEAOOKIOK()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[EMFMMKKCPNF(MEAOHOOOBOD.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x7D0F760", Offset = "0x7D0E160", VA = "0x187D0F760")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x7D0FA30", Offset = "0x7D0E430", VA = "0x187D0FA30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x7D0F940", Offset = "0x7D0E340", VA = "0x187D0F940")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x7D0F6B0", Offset = "0x7D0E0B0", VA = "0x187D0F6B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x7D0F980", Offset = "0x7D0E380", VA = "0x187D0F980")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x7D0F890", Offset = "0x7D0E290", VA = "0x187D0F890")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x7D0F630", Offset = "0x7D0E030", VA = "0x187D0F630")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x59535B0", Offset = "0x5951FB0", VA = "0x1859535B0", Slot = "4")]
		public virtual T EAFBJMOOBPH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface MCEMJEFBHJL
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	ToolHierarchyCache CPHONAKKAOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public struct MDHDCMBKICO<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			private readonly List<Component> IBKFNAMHILN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private readonly bool HPNEOLEAIKL;

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x1919890", Offset = "0x1918290", VA = "0x181919890")]
			public MDHDCMBKICO(List<Component> IBKFNAMHILN, bool HPNEOLEAIKL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x5477E00", Offset = "0x5476800", VA = "0x185477E00")]
			public PCOCMKFCOLD<T> ICNPOCIJNJG()
			{
				return default(PCOCMKFCOLD<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x5477E60", Offset = "0x5476860", VA = "0x185477E60", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x5477E60", Offset = "0x5476860", VA = "0x185477E60", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public struct PCOCMKFCOLD<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private readonly List<Component> IBKFNAMHILN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			private readonly bool HPNEOLEAIKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private int MNFHMLCLFEB;

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public T NBBAKIJBGKK
			{
				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x5758870", Offset = "0x5757270", VA = "0x185758870", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000249")]
				[Cpp2IlInjected.Address(RVA = "0x5758800", Offset = "0x5757200", VA = "0x185758800", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x5758840", Offset = "0x5757240", VA = "0x185758840")]
			public PCOCMKFCOLD(List<Component> IBKFNAMHILN, bool HPNEOLEAIKL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x5758740", Offset = "0x5757140", VA = "0x185758740", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x5758750", Offset = "0x5757150", VA = "0x185758750", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x4750530", Offset = "0x474EF30", VA = "0x184750530", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x7D11420", Offset = "0x7D0FE20", VA = "0x187D11420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7D10D10", Offset = "0x7D0F710", VA = "0x187D10D10")]
		private void DBILOAODCDE(GameObject MDCCLJKNLLP, bool BOOINJJDCOC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7D10E80", Offset = "0x7D0F880", VA = "0x187D10E80")]
		public static void DBILOAODCDE(GameObject MDCCLJKNLLP, ToolHierarchyCache DIAPHCLLMBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x7D11000", Offset = "0x7D0FA00", VA = "0x187D11000")]
		public void MKPJAGMNGLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3DF6560", Offset = "0x3DF4F60", VA = "0x183DF6560")]
		public void DKAHNEGIDBD<T>(Action<T> KPGBPPBMJJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3DF64F0", Offset = "0x3DF4EF0", VA = "0x183DF64F0")]
		public T AGCOLOGOCJJ<T>(bool HPNEOLEAIKL = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3DF6780", Offset = "0x3DF5180", VA = "0x183DF6780")]
		public MDHDCMBKICO<T> MPKDBBDEFME<T>(bool HPNEOLEAIKL = false) where T : class
		{
			return default(MDHDCMBKICO<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x7D11010", Offset = "0x7D0FA10", VA = "0x187D11010")]
		public List<Component> PLCFKNBGLHH(Type HHCAOFMCNLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7D10F10", Offset = "0x7D0F910", VA = "0x187D10F10", Slot = "4")]
		public bool Equals(ToolHierarchyCache CBPCNABIALH, ToolHierarchyCache CBOHEKOGGHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7D10F90", Offset = "0x7D0F990", VA = "0x187D10F90", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache OJDHMKOBKLD)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class PMCEMBLCMMP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private int OOPBDBFKCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int BNGHKLILEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<T> NBOIKFLACJA;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int IMMMMMEPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x528B550", Offset = "0x5289F50", VA = "0x18528B550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public T HMMJEOMFOEB
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x578D9C0", Offset = "0x578C3C0", VA = "0x18578D9C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public T IPABAAGAFKO
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x578D620", Offset = "0x578C020", VA = "0x18578D620")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public T BCFNAKNFGML
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x578D890", Offset = "0x578C290", VA = "0x18578D890")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x578DCC0", Offset = "0x578C6C0", VA = "0x18578DCC0")]
	public PMCEMBLCMMP(int OOPBDBFKCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x578DAE0", Offset = "0x578C4E0", VA = "0x18578DAE0")]
	public void PBDMKLNODMP(T LGBELDFDKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x578DAA0", Offset = "0x578C4A0", VA = "0x18578DAA0")]
	public void MPMJEFEEPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x578D700", Offset = "0x578C100", VA = "0x18578D700")]
	public void FADKDMBDMDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x578D5D0", Offset = "0x578BFD0", VA = "0x18578D5D0")]
	public void AFLNDPDHEAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x578DA90", Offset = "0x578C490", VA = "0x18578DA90")]
	public void MJCJFOMKEMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x578D7C0", Offset = "0x578C1C0", VA = "0x18578D7C0")]
	public List<T> HNNLBDEOCGI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class KJJOAJGFHIL<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private struct JOMPIKAAOGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public int NGNDNJMMICE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public T AMCECKEAKLL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly Dictionary<object, JOMPIKAAOGG> FHONBPKKLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly EqualityComparer<T> LOJPPCHOGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private T BLFHCGBHOEL;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public virtual T EPCJBLJMCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xDC95B0", Offset = "0xDC7FB0", VA = "0x180DC95B0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x51C6060", Offset = "0x51C4A60", VA = "0x1851C6060", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool EHCPOOFICLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x51C60B0", Offset = "0x51C4AB0", VA = "0x1851C60B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public object EJFPOIEFPNF
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xA10FC0", Offset = "0xA0F9C0", VA = "0x180A10FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA14650", Offset = "0xA13050", VA = "0x180A14650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x51C8740", Offset = "0x51C7140", VA = "0x1851C8740")]
	public bool GOOFDNOKNFF(T PCDAHJCDHHF, object BECBHDDLOHA, int JILFIKIPHBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x51C88B0", Offset = "0x51C72B0", VA = "0x1851C88B0")]
	public bool JLGGFHOHDHO(object BECBHDDLOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x51C60F0", Offset = "0x51C4AF0", VA = "0x1851C60F0")]
	public bool EHEIJGNBGFA(object BECBHDDLOHA, [Out] T PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x51C8930", Offset = "0x51C7330", VA = "0x1851C8930")]
	public void MPMJEFEEPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x51C6BD0", Offset = "0x51C55D0", VA = "0x1851C6BD0")]
	private bool FIFIFOIPDKD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x51C8970", Offset = "0x51C7370", VA = "0x1851C8970")]
	public KJJOAJGFHIL()
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
