import React, { useState } from "react";

export default function ResumeAnalyzer() {
  const [file, setFile] = useState(null);

  const handleFileChange = (e) => {
    setFile(e.target.files[0]);
  };

  const handleAnalyze = () => {
    if (!file) {
      alert("Please select a file first.");
      return;
    }
    console.log("Analyzing file:", file.name);
  };

  return (
    <div className="min-h-screen flex items-center justify-center bg-gradient-to-br from-black via-gray-800 to-black text-white">
      <div className="border border-white rounded-xl p-10 w-[500px] text-center bg-gradient-to-b from-gray-800 to-gray-900 shadow-2xl">
        <h1 className="text-4xl font-handwritten mb-10 text-transparent bg-clip-text bg-gradient-to-r from-purple-400 via-blue-500 to-red-500">
          Resume Analyzer
        </h1>
        <div className="mb-6">
          <label className="mr-4">Upload your resume</label>
          <input
            type="file"
            onChange={handleFileChange}
            className="border border-white px-4 py-2 rounded cursor-pointer text-white"
          />
        </div>
        <button
          onClick={handleAnalyze}
          className="mt-4 border border-white px-6 py-2 rounded hover:bg-white hover:text-black transition bg-gradient-to-r from-purple-500 to-blue-500 text-white hover:cursor-pointer"
        >
          Analyze
        </button>
      </div>
    </div>
  );
}