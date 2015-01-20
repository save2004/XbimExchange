﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Classification references used only in this Plan of Work
/// </summary>
public interface IClassificationReference 
{
	/// <summary>
	/// The string used to sort in alphabetical order
	/// </summary>
	string Sort { get;set; }

	/// <summary>
	/// The code of the reference i.e. 1.2.4
	/// </summary>
	string ClassificationCode { get;set; }

	/// <summary>
	/// Textual description of the classifcation reference i.e. External Doors
	/// </summary>
	string ClassificationDescription { get;set; }

}
